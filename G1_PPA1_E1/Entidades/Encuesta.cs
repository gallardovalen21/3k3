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
      
        public List<string> armarEncuesta(List<string> respuestas)
        {
            List<string> descrpPregResp = new List<string> { };


            foreach (Pregunta preg in pregunta)
            {
                foreach (string resp in respuestas)
                {
                    if (preg.esTuRespuestaAsociada(resp))
                    {
                        descrpPregResp.Add(preg.getStrPregunta());
                    }
                }
            }

            return descrpPregResp;

        }
    }
}
