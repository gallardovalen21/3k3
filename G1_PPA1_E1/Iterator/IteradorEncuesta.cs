using G1_PPA1_E1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1_PPA1_E1.Iterator
{
    public class IteradorEncuesta : Iterador
    {
        List<string> respuestasDeEncuestaCliente;
        private int posicionActual;
        private List<Encuesta> encuestas;

        public IteradorEncuesta(List<string> respuestasDeEncuestaCliente, List<Encuesta> encuestas)
        {
            this.respuestasDeEncuestaCliente = respuestasDeEncuestaCliente;
            this.encuestas = encuestas;
        }

        public override bool HaTerminado()
        {
            if (posicionActual == encuestas.Count) return true;
            else return false;
        }

        public override Object Actual()
        {
                return encuestas[posicionActual];
            }
        

        public override void Siguiente()
        {
            posicionActual++;
        }
        public override void primero() { posicionActual = 0; }


    
}
}
