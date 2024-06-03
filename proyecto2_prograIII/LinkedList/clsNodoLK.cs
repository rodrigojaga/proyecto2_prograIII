using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto2_prograIII.LinkedList
{
    public class clsNodoLK
    {

        public Object dato { get; set; }
        public clsNodoLK siguiente { get; set; }

        public clsNodoLK(Object dato)
        {
            this.dato = dato;
            this.siguiente = null;
        }


    }
}
