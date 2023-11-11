using G1_PPA1_E1.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace G1_PPA1_E1
{
    public partial class PantallaConsulta : Form
    {
        private GestorConsulta gestor = null;

        public PantallaConsulta(GestorConsulta gestor)
        {
            this.gestor = gestor;
            gestor.setPantalla(this);
            opcionConsultarEncuesta(gestor);
            //InitializeComponent();
        }

        public void opcionConsultarEncuesta(GestorConsulta gestor)
        {
            habilitarPantalla(gestor);

        }
        public void habilitarPantalla(GestorConsulta gestor)
        {
            InitializeComponent();
            lblFechaInicio.Visible = true;
            lblFechaFin.Visible = true;
            dtpFechaFin.Visible = true;
            dtpFechaInicio.Visible = true;
            btnBuscarLlamadas.Visible = true;
            btnCancelar.Visible = true;
            gridLlamadas.Visible = false;

            gestor.nuevaConsulta();

        }
        public void solicitarPeriodo()
        {
            dtpFechaInicio.Enabled = true;
            dtpFechaFin.Enabled = true;

        }
        public void tomarFechaInicioPeriodo(DateTime fechaInicio)
        {
            gestor.tomarFechaInicioPeriodo(fechaInicio);
        }
        public void tomarFechaFinPeriodo(DateTime fechaFin)
        {
            gestor.tomarFechaFinPeriodo(fechaFin);
        }

        public void solicitarSeleccionLlamada(List<Llamada> llamadasEncontradas)
        {
            gridLlamadas.Rows.Clear();

            if (llamadasEncontradas.Count > 0)
            {
                gridLlamadas.Visible = true;


                // Crea una nueva fila y asigna los valores correspondientes a las columnas
                foreach (Llamada llamada in llamadasEncontradas)
                {
                    DataGridViewRow fila = new DataGridViewRow();
                    fila.CreateCells(gridLlamadas);
                    fila.Cells[0].Value = llamada.getFechaLlamada(); // Columna "Fecha Llamada"

                    // Agrega la fila a gridLlamadas
                    gridLlamadas.Rows.Add(fila);
                }
            }
            else
            {
                MessageBox.Show("No se encontraron llamadas.");
            }

        }
        public void tomarSeleccionLlamada(DateTime llamadaSeleccionada)
        {
            gestor.tomarSeleccionLlamada(llamadaSeleccionada);
        }

        public void solicitarMetodoImpresion(string nombreClienteSeleccionado,string duracionLlamadaSelec,string estadoActualLlamadaSelec,
            string descripcionEncuesta,List<string> descripcionesRtas,List<string> encuestaArmada)
        {
            // Muestra los datos de la llamada y habilita la selección
            btnGenerarCSV.Enabled = true;
            btnImprimir.Enabled = true;
            btnGenerarCSV.Visible = true;
            btnImprimir.Visible = true;
            panelLlamada.Visible = true;

            txtCliente.Text = nombreClienteSeleccionado;
            txtDuracion.Text = duracionLlamadaSelec;
            txtEstado.Text = estadoActualLlamadaSelec;
            txtEncuesta.Text = descripcionEncuesta.ToString();

            // Mostrar datos en el grid

            gridRespuestas.Rows.Clear();

            int cantFilas = Math.Max( encuestaArmada.Count, descripcionesRtas.Count);

            for (int i = 0; i < cantFilas; i++)
            {
                string item1 = (i < encuestaArmada.Count) ? encuestaArmada[i] : string.Empty;
                string item2 = (i < descripcionesRtas.Count) ? descripcionesRtas[i] : string.Empty;

                gridRespuestas.Rows.Add(item1, item2);
            }

        }
        public void tomarSeleccionImpresion(int valorImpresion)
        {
            gestor.tomarSeleccionImpresion(valorImpresion);
        }

        // metodos de los elementos de la interfaz
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpFechaInicio.Value;

            tomarFechaInicioPeriodo(fechaInicio);
        }

        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaFin = dtpFechaFin.Value;

            tomarFechaFinPeriodo(fechaFin);
        }

        private void btnBuscarLlamadas_Click(object sender, EventArgs e)
        {
            gestor.buscarLlamadas();
        }

        private void gridLlamadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // Obtener la fila actualmente seleccionada
                DataGridViewRow filaSeleccionada = gridLlamadas.Rows[e.RowIndex];

                // Obtener el valor de la celda "Fecha Llamada" como objeto
                object valorCelda = filaSeleccionada.Cells["Fecha_Llamada"].Value;

                // Verificar si el valor de la celda no es nulo y es de tipo DateTime
                if (valorCelda != null && valorCelda is DateTime)
                {
                    // Convertir el valor de la celda a DateTime
                    DateTime llamadaSeleccionada = (DateTime)valorCelda;
                    gestor.tomarSeleccionLlamada(llamadaSeleccionada);
                }
            }

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            tomarSeleccionImpresion(1);
        }

        private void btnGenerarCSV_Click(object sender, EventArgs e)
        {
            tomarSeleccionImpresion(2);
        }

        private void PantallaConsulta_Load(object sender, EventArgs e)
        {

        }
    }
}
