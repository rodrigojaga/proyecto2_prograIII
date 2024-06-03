using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto2_prograIII.AVL
{
    public class clsLogical
    {

        Boolean v;
        public clsLogical(Boolean f)
        {
            v = f;
        }
        public void setLogical(Boolean f)
        {
            v = f;
        }
        public Boolean booleanValue()
        {
            return v;
        }

    }
}
