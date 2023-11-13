using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1_PPA1_E1
{
    public abstract class Iterador
    {
        public abstract void primero();
        public abstract void Siguiente();
        public abstract bool HaTerminado();
        public abstract Object Actual();

    }
}
