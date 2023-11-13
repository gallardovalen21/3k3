using G1_PPA1_E1.Iterator;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using Chunk = iTextSharp.text.Chunk;

namespace G1_PPA1_E1.Entidades
{
    public class GestorConsulta : IAgregado
    {
        //Atributos
        public List<Llamada> llamadas;
        public List<Encuesta> encuestas;
        private PantallaConsulta pantalla;

        private DateTime fechaInicioPeriodo;
        private DateTime fechaFinPeriodo;


        //
        public List<Llamada> llamadasEncontradas = new List<Llamada>();
        public List<string> arrayPreguntas;
        public Llamada llamadaSeleccionada;
        //
        public bool esEncuesta;

        public String nombreClienteSeleccionado;
        public String duracionLlamadaSelec;
        public String estadoActualLlamadaSelec;
        public List<string> RespuestasDeEncuestaCliente;
        public Encuesta EncuestaAsociada;

        public string descripcionEncuesta;



        //Constructor
        public GestorConsulta(List<Llamada> llamadas, List<Encuesta> encuestas)
        {
            this.llamadas = llamadas;
            this.encuestas = encuestas;
        }

        //Metodos
        public void setPantalla(PantallaConsulta value)  // Relaciona al gestor con la pantalla
        {
            this.pantalla = value;
        }
        public void ConsultarEncuesta()
        {
            pantalla.solicitarPeriodo();
        }
        public void tomarFechaInicioPeriodo(DateTime fechaInicio)
        {
            fechaInicioPeriodo = fechaInicio;
        }
        public void tomarFechaFinPeriodo(DateTime fechaFin)
        {
            fechaFinPeriodo = fechaFin;
        }


        public void buscarLlamadas()
        {
            llamadasEncontradas.Clear();
            esEncuesta = false;
            Iterador iteradorLlamadas = CrearIterador();
            iteradorLlamadas.primero();

            while (iteradorLlamadas.HaTerminado() == false)
            {
                //aca
                Llamada llamada = (Llamada)iteradorLlamadas.Actual();

                if (llamada != null)
                {
                    llamadasEncontradas.Add(llamada);
                }
                iteradorLlamadas.Siguiente();
            }
            pantalla.solicitarSeleccionLlamada(llamadasEncontradas);
        }


        public void tomarSeleccionLlamada(Llamada llamadaSeleccion)
        {
            buscarDatosLlamadaSeleccionada(llamadaSeleccion);

        }

        public void buscarDatosLlamadaSeleccionada(Llamada llamada)
        {
            nombreClienteSeleccionado = llamada.getNombreClienteDeLlamada();
            duracionLlamadaSelec = llamada.getDuracion();
            estadoActualLlamadaSelec = llamada.DeterminarUltimoEstado;
            RespuestasDeEncuestaCliente = llamada.getDescripcionRespuestaDeEncuesta();
            EncuestaAsociada = BuscarEncuestaAsociada();
            arrayPreguntas = EncuestaAsociada.GetPreguntasEncuesta();
            descripcionEncuesta = EncuestaAsociada.getDescripcionEncuesta();
            mostrarEncuesta();
        }

        public void mostrarEncuesta()
        {
            pantalla.solicitarMetodoImpresion(nombreClienteSeleccionado, duracionLlamadaSelec, estadoActualLlamadaSelec, descripcionEncuesta, RespuestasDeEncuestaCliente, arrayPreguntas);
        }


        public Encuesta BuscarEncuestaAsociada()
        {
            esEncuesta = true;
            Iterador iteradorEncuesta = CrearIterador();
            iteradorEncuesta.primero();

            while (iteradorEncuesta.HaTerminado() == false)
            {
                Encuesta encuesta = (Encuesta)iteradorEncuesta.Actual();
                string loco= encuesta.getDescripcionEncuesta();
                if (encuesta.EsEncuestaLlamada(RespuestasDeEncuestaCliente))
                {
                    return encuesta;
                }
                else { 
                iteradorEncuesta.Siguiente();
                }
            }
            return null;
        }

        public void tomarSeleccionImpresion(int valorImpresion)
        {
            if (valorImpresion == 1)
            {
                imprimir();
            }
            else if (valorImpresion == 2)
            {
                generarCSV();
            }

        }

        public void imprimir()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos PDF (.pdf)|.pdf";
            saveFileDialog.Title = "Guardar archivo PDF";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string destinoArchivo = saveFileDialog.FileName;

                // Crear el documento PDF
                Document document = new Document();
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(destinoArchivo, FileMode.Create));
                document.Open();

                // Escribir los datos de la llamada
                document.Add(new Paragraph("Nombre Cliente: " + nombreClienteSeleccionado));
                document.Add(new Paragraph("Duración de la llamada: " + duracionLlamadaSelec + " segundos"));
                document.Add(new Paragraph("Estado de la llamada: " + estadoActualLlamadaSelec));
                document.Add(Chunk.NEWLINE);

                // Escribir la marca de separación
                document.Add(new Paragraph("--------------"));
                document.Add(Chunk.NEWLINE);

                // Escribir los datos de la pregunta-respuesta
                document.Add(new Paragraph("Descripción de la encuesta: " + descripcionEncuesta));
                document.Add(new Paragraph("Preguntas:"));
                for (int i = 0; i < RespuestasDeEncuestaCliente.Count; i++)
                {
                    document.Add(new Paragraph("Pregunta " + (i + 1) + ": " + arrayPreguntas[i]));
                    document.Add(new Paragraph("Respuesta " + (i + 1) + ": " + RespuestasDeEncuestaCliente[i]));
                }

                // Cerrar el documento PDF
                document.Close();
            }

            MessageBox.Show("Archivo PDF creado exitosamente.");
        }

        public void generarCSV()
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos CSV (.csv)|.csv";
            saveFileDialog.Title = "Guardar archivo CSV";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string destinoArchivo = saveFileDialog.FileName;


                using (StreamWriter writer = new StreamWriter(destinoArchivo))
                {
                    // Escribir los datos en cada línea del CSV
                    writer.WriteLine("Nombre Cliente: " + nombreClienteSeleccionado);
                    writer.WriteLine("Duracion de la llamada: " + duracionLlamadaSelec + " segundos");
                    writer.WriteLine("Estado de la llamada: " + estadoActualLlamadaSelec);
                    writer.WriteLine();

                    // Escribir la marca de separación
                    writer.WriteLine("--------------");
                    writer.WriteLine("Descripcion de la encuesta: " + descripcionEncuesta);
                    writer.WriteLine();

                    // Escribir los datos de la pregunta-respuesta
                    writer.WriteLine("Preguntas:");
                    for (int i = 0; i < RespuestasDeEncuestaCliente.Count; i++)
                    {
                        writer.WriteLine("Pregunta " + (i + 1) + ": " + arrayPreguntas[i]);
                        writer.WriteLine("Respuesta " + (i + 1) + ": " + RespuestasDeEncuestaCliente[i]);
                        writer.WriteLine("--------------");
                    }
                }
            }

            MessageBox.Show("Archivo CSV creado exitosamente.");
        }
        public void finCU()
        {

        }
      
        public override Iterador CrearIterador()
        {
            if (esEncuesta)
            {
                return new IteradorEncuesta(RespuestasDeEncuestaCliente, encuestas);
            }
            else
            {
                return new IteradorLlamadas(llamadas, fechaInicioPeriodo, fechaFinPeriodo);
            }
        }
    }
}

