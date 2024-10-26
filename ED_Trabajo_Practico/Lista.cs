using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_Trabajo_Practico
{
    internal class Lista
    {
        public Nodo? primero { get; set; }
        public Nodo? ultimo { get; set; }
        int contador = 0;
        public Lista()
        {
            primero = null;
            ultimo = null;
        }

        public void crear(Nodo nodo)
        {
            if (nodo != null)
            {
                if (primero == null && ultimo == null)
                {
                    primero = nodo;
                    ultimo = nodo;
                }
                else
                {
                    insertar(nodo);
                }
            }
            else
            {
                MessageBox.Show("Error en la carga del cliente.\nRevise la información por favor.", "Error", MessageBoxButtons.OK);
            }
        }
        public void insertar(Nodo nodo)
        {
            if (primero != null && ultimo != null)
            {
                if (nodo.turno < primero.turno)
                {
                    nodo.siguiente = primero;
                    primero = nodo;
                }
                if (nodo.turno > ultimo.turno)
                {
                    ultimo.siguiente = nodo;
                    ultimo = nodo;
                }
                if (nodo.turno > primero.turno && nodo.turno < primero.turno)
                {
                    Nodo? anterior = null;
                    Nodo? auxiliar = primero;
                    while (nodo.turno > auxiliar.turno)
                    {
                        anterior = auxiliar;
                        auxiliar = auxiliar.siguiente;
                    }
                    anterior.siguiente = nodo;
                    nodo.siguiente = auxiliar;
                }
            }
            else
            {
                crear(nodo);
            }
        }

        public List<Nodo> listar()
        {
            List<Nodo> nodos = new List<Nodo>();
            Nodo aux = primero;
            while (aux != null)
            {
                nodos.Add(aux);
                aux = aux.siguiente;
            }

            return nodos;
        }
        public bool ExisteNodo(int dni)
        {            
            Nodo aux = primero;
            while (aux != null)
            {
                if (aux.dni == dni)
                {
                    return true;
                }
                aux = aux.siguiente;
            }
            return false;
        }
        public Nodo EliminarDeCaja()
        {
            Nodo aux = primero;
            Nodo anterior = null;

            Nodo nodoQueSeDevuelve = null;

            if (aux != null)
            {
                
                if(contador == 0)
                {
                    nodoQueSeDevuelve = primero;
                    primero = primero.siguiente;
                    contador++;
                    return nodoQueSeDevuelve;
                }
                else
                {
                    while (contador < 4 && aux != null)
                    {
                        if(aux.esCliente)
                        {
                            nodoQueSeDevuelve = aux;
                            contador = 0;

                            if(aux == primero)
                            {
                                aux = aux.siguiente;
                            }
                            else if (aux != null && anterior != null)
                            {
                                anterior.siguiente = aux.siguiente;

                                if (aux.siguiente == null) ultimo = anterior;
                            }

                            return nodoQueSeDevuelve;

                        }
                        else
                        {
                            anterior = aux;
                            aux = aux.siguiente;
                            contador++;
                        }
                    }
                    contador = 0;
                    return nodoQueSeDevuelve = primero;
                }
            }
            return nodoQueSeDevuelve;
        }
        public Nodo EliminarDeAtencionPersonal()
        {
            Nodo nodoQueSeDevuelve = null;

            Nodo aux = primero;
            Nodo anterior = null;
            if (aux != null)
            {
                if (contador == 0)
                {
                    nodoQueSeDevuelve = primero;
                    primero = primero.siguiente;
                    contador++;
                    return nodoQueSeDevuelve;
                }
                else
                {                    
                    while ((contador == 1) && (aux != null))
                    {
                        if (aux.esCliente)
                        {
                            break;
                        }

                        anterior = aux;
                        aux = aux.siguiente;
                    }

                    if((aux != null) && (aux.esCliente))
                    {
                        if(aux == primero)
                        {
                            nodoQueSeDevuelve = primero;
                            primero = primero.siguiente;
                        }
                        else if((aux.siguiente == null) && (anterior != null))
                        {
                            nodoQueSeDevuelve = aux;
                            ultimo = anterior;
                            anterior.siguiente = null;
                        }
                        else
                        {
                            nodoQueSeDevuelve = aux;
                            anterior.siguiente = aux.siguiente;
                        }
                        contador = 0;
                        return nodoQueSeDevuelve;
                    }

                    nodoQueSeDevuelve = primero;

                    if (primero == ultimo)
                    {
                        ultimo = null;    
                    }
                    primero = primero.siguiente;
                    
                    return nodoQueSeDevuelve;
                }
            }
            return nodoQueSeDevuelve;
        }
        private int ContarMaxLista()
        {
            int max = 0;
            Nodo aux = primero;
            while (aux != null)
            {
                max++;
                aux = aux.siguiente;
            }
            
            return max;
        }
    }
}
