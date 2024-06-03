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

            return intValor % intTamanoTabla;

        }


        public void insertar(long clave, Object valor)
        {
            long num = fncHashMod(clave);
            //clsClaveYValor m = new clsClaveYValor(num, valor);
            clsNodoLKHash nd = new clsNodoLKHash(valor);
            if (Tabla[num] == null)
            {
                Tabla[num] = new clsListaEnlazadaHash();
            }
            Tabla[num].AgregarFinal(nd);
        }


        public clsNodoLKHash buscar(long clave, Object valor)
        {
            long num = fncHashMod((long)clave);
            clsNodoLKHash temp = Tabla[num].buscar(valor);
            if (temp != null)
                return temp;

            return null;
        }

        public string eliminar(long clave, Object valor)
        {
            long num = fncHashMod((long)clave);
            string temp = Tabla[num].Eliminar(valor);
            if (!string.IsNullOrEmpty(temp))
                return temp;

            return null;
        }
        //                      Clave long(apellido)    Nombre busqueda     Nuevo atleta que cambia al viejo
        public string modificar(long clave, Object valor, Object nuevo)
        {
            long num = fncHashMod((long)clave);
            string temp = Tabla[num].Modificar(valor, nuevo);
            if (!string.IsNullOrEmpty(temp))
                return temp;

            return null;
        }

    }
}
