using G1_PPA1_E1.Iterator;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace G1_PPA1_E1.Entidades
{
    public class Encuesta : IAgregado
    {
        //Atributos
        private string descripcion;
        private List<Pregunta> pregunta;
        private List<string> respuestasDeEncuestaCliente;


        // private DateTime fechaFinVigencia;
        public override Iterador CrearIterador()
        {
            return new IteradorPregunta(respuestasDeEncuestaCliente, this.pregunta);
        }

        //Constructor
        public Encuesta(string descripcion, List<Pregunta> pregunta)
        {
            this.descripcion = descripcion;
            this.pregunta = pregunta;
        }
        public string getPregunta()
        {
            return pregunta[0].getStrPregunta();
        }

        //Metodos
        public string getDescripcionEncuesta()
        {
            return descripcion;
        }

        public List<string> GetPreguntasEncuesta()
        {
            List<string> arrayDescripcionesPregunta = new List<string>();

            foreach (Pregunta pregunta in pregunta)
            {
                arrayDescripcionesPregunta.Add(pregunta.getStrPregunta());
            }

            return arrayDescripcionesPregunta;
        }

        public bool EsEncuestaLlamada(List<string> respuestasDeEncuestaClientes)

        {
            respuestasDeEncuestaCliente = respuestasDeEncuestaClientes;
            int contador = 0;
            Iterador iteradorPreguntas = CrearIterador();
            iteradorPreguntas.primero();
            

            while (iteradorPreguntas.HaTerminado() == false)
            {
                Pregunta pregunta1 = (Pregunta)iteradorPreguntas.Actual();

                if (pregunta1.EsEncuestaLlamada(respuestasDeEncuestaClientes))
                {
                    contador++;
                    iteradorPreguntas.Siguiente();
                }
                else { break; }
                
            }
            return respuestasDeEncuestaClientes.Count == contador;
        }

              
    }
}
