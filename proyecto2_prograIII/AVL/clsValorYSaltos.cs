using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto2_prograIII.AVL
{
    public class clsValorYSaltos
    {

        public Object obj { get; set; }
        public int saltos { get; set; }

        public clsValorYSaltos() { }

        public clsValorYSaltos(Object obj, int saltos)
        {

            this.obj = obj;
            this.saltos = saltos;

        }

    }
}
