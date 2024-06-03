using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto2_prograIII.HashTable.LinkedListHash
{
    public class clsNodoLKHash
    {

        public Object dato { get; set; }
        public clsNodoLKHash siguiente { get; set; }

        public clsNodoLKHash(Object dato)
        {
            this.dato = dato;
            this.siguiente = null;
        }

    }
}
