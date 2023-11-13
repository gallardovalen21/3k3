using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G1_PPA1_E1.Entidades
{

    public class Pregunta
    {
        private string strPregunta;
        private List<RespuestaPosible> respuestas;

        public Pregunta(string strPregunta, List<RespuestaPosible> respuestas)
        {
            this.strPregunta = strPregunta;
            this.respuestas = respuestas;
        }
        public string getStrPregunta()
        {
            return strPregunta;
        }

        public void setStrPregunta(string value)
        {
            strPregunta = value;
        }

        public List<RespuestaPosible> getRespuestas()
        {
            return respuestas;
        }

        public void setRespuestas(List<RespuestaPosible> value)
        {
            respuestas = value;
        }

        public bool EsEncuestaLlamada(List<string> respuestasDeEncuestaCliente)
        {
            foreach (RespuestaPosible respuesta in this.respuestas)
            {
                string descripcion = respuesta.getDescripcion();
                if (respuestasDeEncuestaCliente.Contains(descripcion))
                {    return true;  }            }

            return false;
        }



    }
}
