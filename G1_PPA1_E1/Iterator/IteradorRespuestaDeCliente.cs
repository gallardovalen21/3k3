using G1_PPA1_E1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1_PPA1_E1.Iterator
{
    internal class IteradorRespuestaDeCliente : Iterador
    {
        List<RespuestaDeCliente> respuestas;
        private int posicionActual;


        public IteradorRespuestaDeCliente(List<RespuestaDeCliente> Respuestas)
        {
            this.respuestas = Respuestas;
        }

        public override bool HaTerminado()
        {
            if (posicionActual == respuestas.Count) return true;
            else return false;
        }

        public override Object Actual()
        {
            return respuestas[posicionActual];
        }


        public override void Siguiente()
        {
            posicionActual++;
        }
        public override void primero() { posicionActual = 0; }


    }
}
