using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto2_prograIII.AVL
{
    public class clsNodoAVL:clsNodo
    {

        public int fe;
        public clsNodoAVL(Object valor) : base(valor)
        {
            fe = 0;
        }

        public clsNodoAVL(Object valor, clsNodoAVL ramaIzdo, clsNodoAVL ramaDcho) : base(ramaIzdo, valor, ramaDcho)
        {
            fe = 0;
        }

    }
}
