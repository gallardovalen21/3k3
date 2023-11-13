using G1_PPA1_E1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1_PPA1_E1.Iterator
{
    public class IteradorPregunta : Iterador
    {
        List<string> respuestasDeEncuestaCliente;
        private int posicionActual;
        List<Pregunta> arrayPreguntas;


        public IteradorPregunta(List<string> respuestasDeEncuestaCliente, List<Pregunta> preguntas)
        {
            this.respuestasDeEncuestaCliente = respuestasDeEncuestaCliente;
            this.arrayPreguntas = preguntas;
        }

        public override bool HaTerminado()
        {
            if (posicionActual == respuestasDeEncuestaCliente.Count) return true;
            else return false;
        }

     
        public override Object Actual()
        {
                return arrayPreguntas[posicionActual];
                  }

        public override void Siguiente()
        {
            posicionActual++;
        }
        public override void primero() { posicionActual = 0; }



    }
}

