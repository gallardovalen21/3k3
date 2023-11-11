using G1_PPA1_E1.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1_PPA1_E1.Entidades
{
    public class RespuestaPosible
    {
        //Atributos
        private string descripcion;
        private string valor;

        //Constructor
        public RespuestaPosible (string descripcion, string valor)
        {
            this.descripcion = descripcion;
            this.valor = valor;
        }
        //Metodos
        public string getDescripcion()
        {
            return descripcion;
        }

        public void setDescripcion(string value)
        {
            descripcion = value;
        }
        public void setValor(string value)
        {
            valor = value;
        }
                public string getValor()
        {
            return valor;
        }

}
}



