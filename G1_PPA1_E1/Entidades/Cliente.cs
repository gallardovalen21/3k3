using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1_PPA1_E1.Entidades
{

    public class Cliente
    {
        //Atributos
        private string dni;
        private string nombreCompleto;
        private string nroCelular;

        //Constructor
        public Cliente(string dni, string nombreCompleto, string nroCelular)
        {
            this.dni = dni;
            this.nombreCompleto = nombreCompleto;
            this.nroCelular = nroCelular;
        }

        //Metodos
        public string getNombre()
        {
            return nombreCompleto;
        }
        public string getDni()
        {
            return dni;
        }

        public void setDni(string value)
        {
            dni = value;
        }

        public string getNombreCompleto()
        {
            return nombreCompleto;
        }

        public void setNombreCompleto(string value)
        {
            nombreCompleto = value;
        }

        public string getNroCelular()
        {
            return nroCelular;
        }

        public void setNroCelular(string value)
        {
            nroCelular = value;
        }



    }
}
