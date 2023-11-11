using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1_PPA1_E1.Entidades
{
    public class Estado
    {
        //Atributos
        private string nombre;

        //Constructor
        public Estado(string nombre) 
        {
            this.nombre = nombre;
        }

        //Metodos
        public string getNombre()
        {
            return nombre;
        }
    }
}
