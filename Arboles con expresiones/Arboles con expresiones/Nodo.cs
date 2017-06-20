using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles_con_expresiones
{
    class Nodo
    {
        public string nodo { get; set; } 
        public Nodo siguiente { get; set; }
        public Nodo anterior { get; set; }
        public Nodo hd { get; set; }
        public Nodo hi { get; set; }


        public Nodo(string nodo)
        {
            this.nodo = nodo;
            siguiente = null;
            anterior = null;
            hd = null;
            hi = null;
        }

        public override string ToString()
        {
            return nodo.ToString();
        }
    }
}
