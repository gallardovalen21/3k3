using G1_PPA1_E1.Entidades;
using G1_PPA1_E1.Pantallas;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace G1_PPA1_E1
{
    class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuMock());
        }

        public static List<Llamada> crearLlamadas()
        {
            List<Llamada> llamadas = init.crearListaLlamadas();
            return llamadas;

        }
        public static GestorConsulta setGestor()
        {
            GestorConsulta gestor = new GestorConsulta(crearLlamadas(), crearListaDeEncuestas());
            return gestor;
        }

        public static List<Encuesta> crearListaDeEncuestas()
        {
            List<Encuesta> listaEncuestas = init.crearListaEncuestas();
            return listaEncuestas;
        }
    }
}
