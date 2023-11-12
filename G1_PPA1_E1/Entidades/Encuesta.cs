using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace G1_PPA1_E1.Entidades
{
    public class Encuesta
    {
        //Atributos
        private string descripcion;
        private List<Pregunta> pregunta;
        // private DateTime fechaFinVigencia;

        //Constructor
        public Encuesta(string descripcion, List<Pregunta> pregunta)
        {
            this.descripcion = descripcion;
            this.pregunta = pregunta;
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



        //esta es mia
        public bool EsEncuestaLlamada(List<string> respuestasDeEncuestaCliente)

        {
            List<Pregunta> arrayPreguntas = this.pregunta;
            int contador = 0;

            foreach (Pregunta pregunta in arrayPreguntas)
            {
                if (pregunta.EsEncuestaLlamada(respuestasDeEncuestaCliente))
                {
                    contador++;
                }
                else
                {
                    return false;
                }
            }

            if (respuestasDeEncuestaCliente.Count == contador)
            {
                return true;
            }

            return false;
        }

    }
}
