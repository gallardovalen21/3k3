using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace G1_PPA1_E1.Entidades
{
           public class CambioDeEstado
        {
            private DateTime fechaHoraInicio;
            private Estado estado;
            public CambioDeEstado( DateTime fechaHoraInicio, Estado estado)
            {
                this.fechaHoraInicio = fechaHoraInicio;
                this.estado = estado;
            }

            public DateTime getFechaHoraInicio()
            {
                return fechaHoraInicio;
            }

            public void setFechaHoraInicio(DateTime valor)
            {
                fechaHoraInicio = valor;
            }

            public Estado getEstado()
            {
                return estado;
            }
            public string GetNombreEstado()
            {
                return estado.getNombre();
            }


            public void setEstado(Estado valor)
            {
                estado = valor;
            }
        /*

       public bool esUltimoEstado(CambioDeEstado cambioAComparar)
       {
           if (cambioAComparar.fechaHoraInicio < this.fechaHoraInicio)
           {
               return true;
           }
           else
           {
               return false;
           }
       }*/


    }
}

