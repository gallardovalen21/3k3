using G1_PPA1_E1.Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1_PPA1_E1.Iterator
{
    public class IteradorLlamadas : Iterador
    {
        private List<Llamada> llamadas;
        private int posicionActual;
        private DateTime fechaInicioPeriodo;
        private DateTime fechaFinPeriodo;

        public IteradorLlamadas( List<Llamada> llamadas, DateTime fechaInicioPeriodo, DateTime fechaFinPeriodo)
        {
            this.llamadas = llamadas;
            this.fechaInicioPeriodo = fechaInicioPeriodo;
            this.fechaFinPeriodo = fechaFinPeriodo;
        }

    

        public override bool HaTerminado()
        {      
            if (posicionActual== llamadas.Count) return true;
            else return false;
        }

        public override Object Actual()
        {
            if(llamadas[posicionActual].esDePeriodo(fechaInicioPeriodo, fechaFinPeriodo)
                && llamadas[posicionActual].TieneRespuestaDeCliente()) { return llamadas[posicionActual];
            }
            else
            {  return null;  }
        }

        public override void Siguiente()
        {
            posicionActual++;
        }
        public override void primero() { posicionActual = 0; }

       
    }
}
