using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto2_prograIII.HashTable.LinkedListHash
{
    public class clsListaEnlazadaHash
    {
        private clsNodoLKHash inicio;

        public void AgregarInicio(Object obj)
        {

            clsNodoLKHash agregar = new clsNodoLKHash(obj);

            if (inicio == null)
            {

                inicio = agregar;

            }
            else
            {
                clsNodoLKHash aux = inicio;
                inicio = agregar;
                inicio.siguiente = aux;
            }

        }

        public void AgregarFinal(Object obj)
        {

            clsNodoLKHash agregar = new clsNodoLKHash(obj);

            if (inicio == null)
            {
                inicio = agregar;
            }
            else
            {
                clsNodoLKHash actual = inicio;
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
            clsNodoLKHash actual = inicio;
            
            if(inicio == null)
            {
                return "";
            }

            while (actual != null)
            {
                //sb.Append(actual.dato.ToString());
                //sb.Append(" ");                
                if(actual.dato is clsNodoLKHash)
                {
                    sb.Append(((InterfaceCompHash)((clsNodoLKHash)actual.dato).dato).ToString());
                }
                else
                {
                    sb.Append(((InterfaceCompHash)actual.dato).ToString());
                }

                actual = actual.siguiente;
            }
            return sb.ToString();
        }

        public clsNodoLKHash buscar(Object buscado)
        {

            InterfaceCompHash dato;
            bool encontrado = false;
            clsNodoLKHash primero = inicio;
            dato = (InterfaceCompHash)buscado;

            while (!encontrado && primero != null)
            {

                if ((primero.dato is clsNodoLKHash))
                {
                    if (dato.igualQueHash(primero.dato))

                        encontrado = true;
                    else
                    {
                        primero = primero.siguiente;
                    }
                }
                else
                {
                    if (dato.igualQueEliminarHash(primero.dato))

                        encontrado = true;
                    else
                    {
                        primero = primero.siguiente;
                    }
                }


            }
            return primero;
        }
        //                      Nombre buscado  Nuevo atleta
        public string Modificar(Object buscado, Object nuevoValor)//aca va un atleta
        {
            if (inicio == null)
            {
                return "Lista Vacia"; // Lista vacía
            }

            
            if (
                ((InterfaceCompHash)((clsNodoLKHash)inicio.dato).dato).igualQueEliminarHash(buscado)
                )
            {
                // Almacena el dato antiguo
                Object datoAntiguo = inicio.dato;
                // Actualiza el dato del nodo
                inicio.dato = nuevoValor;
                return "Nodo Modificado"; 
            }
            else
            {
                clsNodoLKHash actual = inicio;
                clsNodoLKHash anterior = null;
                while (actual != null //&& 
                                      //!((InterfaceComp)((clsNodoLK)actual.dato).dato).igualQueEliminar(buscado)
                    )
                {

                    if (actual.dato is clsNodoLKHash)
                    {
                        if (!((InterfaceCompHash)((clsNodoLKHash)actual.dato).dato).igualQueEliminarHash(buscado))
                        {
                            anterior = actual;
                            actual = actual.siguiente;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        if (!((InterfaceCompHash)(actual.dato)).igualQueEliminarHash(buscado))
                        {
                            anterior = actual;
                            actual = actual.siguiente;
                        }
                        else
                        {
                            break;
                        }
                    }

                    //anterior = actual;
                    //actual = actual.siguiente;
                }

                if (actual != null)
                {
                    // Nodo encontrado
                    Object datoAntiguo = actual.dato; // Almacena el dato antiguo
                    actual.dato = nuevoValor; // Actualiza el dato del nodo
                    return "Nodo Modificado exitosamente "; // Solo ganancias
                }
                else
                {
                    return "Nodo no encontrado"; // Nodo no encontrado
                }
            }
        }


        public string Eliminar(Object buscado)
        {
            if (inicio == null)
            {
                return "Lista Vacia"; // Lista vacía
            }

            if (!(inicio.dato is clsNodoLKHash))
            {
                if (
                ((InterfaceCompHash)inicio.dato).igualQueEliminarHash(buscado)
                )
                {

                    clsNodoLKHash temp = inicio;
                    inicio = inicio.siguiente;
                    temp.siguiente = null;
                    temp.dato = null;
                    temp = null;
                    return "Nodo Eliminado: ";
                }
                else
                {
                    clsNodoLKHash actual = inicio;
                    clsNodoLKHash anterior = null;
                    while (actual != null && !((InterfaceCompHash)actual.dato).igualQueEliminarHash(buscado))
                    {
                        anterior = actual;
                        actual = actual.siguiente;
                    }

                    if (actual != null)
                    {

                        anterior.siguiente = actual.siguiente;
                        actual.siguiente = null;
                        actual.dato = null;
                        actual = null;
                        return "Nodo Eliminado: ";
                    }
                    else
                    {
                        return "Nodo no encontrado";
                    }
                }
            }

            if (
                ((InterfaceCompHash)((clsNodoLKHash)inicio.dato).dato).igualQueEliminarHash(buscado)
                )
            {

                Object datoEliminado = inicio.dato;
                clsNodoLKHash temp = inicio;
                inicio = inicio.siguiente;
                temp.siguiente = null;
                temp.dato = null;
                temp = null;
                return "Nodo Eliminado: " + buscado.ToString();
            }
            else
            {
                clsNodoLKHash actual = inicio;
                clsNodoLKHash anterior = null;
                while (actual != null //&& !((InterfaceComp)actual.dato).igualQueEliminar(buscado)
                                      )
                {

                    if (actual.dato is clsNodoLKHash)
                    {
                        if (!((InterfaceCompHash)((clsNodoLKHash)actual.dato).dato).igualQueEliminarHash(buscado))
                        {
                            anterior = actual;
                            actual = actual.siguiente;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        if (!((InterfaceCompHash)actual.dato).igualQueEliminarHash(buscado))
                        {
                            anterior = actual;
                            actual = actual.siguiente;
                        }
                        else
                        {
                            break;
                        }
                    }


                }

                if (actual != null)
                {

                    Object datoEliminado = actual.dato;
                    anterior.siguiente = actual.siguiente;
                    actual.siguiente = null;
                    actual.dato = null;
                    actual = null;
                    return "Nodo Eliminado: " + datoEliminado.ToString();
                }
                else
                {
                    return "Nodo no encontrado";
                }
            }



        }
    }
}
