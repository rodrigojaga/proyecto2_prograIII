using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto2_prograIII.LinkedList
{

    public class clsListaEnlazada
    {
        private clsNodoLK inicio;

        public void AgregarInicio(Object obj)
        {

            clsNodoLK agregar = new clsNodoLK(obj);

            if (inicio == null)
            {

                inicio = agregar;

            }
            else
            {
                clsNodoLK aux = inicio;
                inicio = agregar;
                inicio.siguiente = aux;
            }                

        }

        public void AgregarFinal(Object obj)
        {

            clsNodoLK agregar = new clsNodoLK(obj);

            if (inicio == null)
            {
                inicio = agregar;
            }
            else
            {
                clsNodoLK actual = inicio;
                while (actual.siguiente != null)
                {
                    actual = actual.siguiente;
                }
                actual.siguiente = agregar;
            }
        }

        public string ImprimirLista()
        {
            StringBuilder sb = new StringBuilder();
            clsNodoLK actual = inicio;
            while (actual != null)
            {
                sb.Append(actual.dato.ToString());
                //sb.Append(" ");
                actual = actual.siguiente;
            }
            return sb.ToString();
        }

        public clsNodoLK buscar(Object buscado)
        {

            InterfaceComp dato;
            bool encontrado = false;
            clsNodoLK primero = inicio;
            dato = (InterfaceComp)buscado;

            while (!encontrado && primero != null)
            {
                if (dato.igualQue(primero.dato))
                    
                    encontrado = true;
                else
                {
                    primero = primero.siguiente;
                }
            }
            return primero;
        }

        public string Modificar(Object buscado, Object nuevoValor)
        {

            clsNodoLK nodo = buscar(buscado);
            if (nodo != null)
            {
                nodo.dato = nuevoValor;
                return "Actualizado";
            }
            else
            {
                return "Nodo no encontrado";
            }

            
        }

        public string Eliminar(Object buscado)
        {
            if (inicio == null) return "Lista Vacia"; // Lista vacía

            if (((InterfaceComp)inicio.dato).igualQue(buscado))
            {
                // El nodo a eliminar es el primero
                inicio = inicio.siguiente;

            }
            else
            {
                clsNodoLK actual = inicio;
                clsNodoLK anterior = null;
                while (actual != null && !((InterfaceComp)actual.dato).igualQue(buscado))
                {
                    anterior = actual;
                    actual = actual.siguiente;
                }

                if (actual != null)
                {
                    anterior.siguiente = actual.siguiente;
                    actual.dato = null;
                    actual.siguiente = null;
                    actual = null;
                    return "Nodo Eliminado";
                }
                else
                {                    
                    return "Nodo no encontrado";
                }


            }
            return "";
        }



    }
}
