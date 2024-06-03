using proyecto2_prograIII.HashTable.LinkedListHash;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto2_prograIII.HashTable
{
    public class clsTablaHash
    {

        private long intTamanoTabla;

        clsListaEnlazadaHash[] Tabla = null;

        public clsTablaHash(long tamanoTabla)
        {

            this.intTamanoTabla = tamanoTabla;
            Tabla = new clsListaEnlazadaHash[intTamanoTabla];



        }

        public long fncHashMod(long intValor)
        {

            return (intValor/17) % intTamanoTabla;

        }


        public void insertar(long clave, Object valor)
        {
            //InterfaceCompHash v = (InterfaceCompHash)valor;
            //long clave = v.convertirASCII();
            long num = fncHashMod(clave);
            //clsClaveYValor m = new clsClaveYValor(num, valor);
            clsNodoLKHash nd = new clsNodoLKHash(valor);
            if (Tabla[num] == null)
            {
                Tabla[num] = new clsListaEnlazadaHash();
            }
            Tabla[num].AgregarFinal(nd);
        }


        public clsNodoLKHash buscar(Object valor)
        {
            InterfaceCompHash v = (InterfaceCompHash)valor;
            long clave = v.convertirASCII();
            long num = fncHashMod((long)clave);
            clsNodoLKHash temp = Tabla[num].buscar(valor);
            if (temp != null)
                return temp;

            return null;
        }

        public string eliminar(Object valor)
        {
            InterfaceCompHash v = (InterfaceCompHash)valor;
            long clave = v.convertirASCII();
            long num = fncHashMod((long)clave);
            string temp = Tabla[num].Eliminar(valor);
            if (!string.IsNullOrEmpty(temp))
                return temp;

            return null;
        }
        //                      Clave long(apellido)    Nombre busqueda     Nuevo atleta que cambia al viejo
        public string modificar(Object valor, Object nuevo)
        {
            InterfaceCompHash v = (InterfaceCompHash)valor;
            long clave = v.convertirASCII();

            long num = fncHashMod((long)clave);
            string temp = Tabla[num].Modificar(valor, nuevo);
            if (!string.IsNullOrEmpty(temp))
                return temp;

            return null;
        }

        public string leerTodo()
        {
            StringBuilder sb = new StringBuilder();
            int i = 0;
            while(i < intTamanoTabla)
            {
                if (Tabla[i] != null)
                    sb.Append(Tabla[i].ImprimirLista());

                i++;
            }
            return sb.ToString();
        }

    }
}
