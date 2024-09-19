using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_Trabajo_Practico
{
    internal class Lista
    {
        public Nodo? primero {  get; set; }
        public Nodo? ultimo { get; set; }
        public Lista()
        {
            primero = null;
            ultimo = null;
        }

        public void crear(Nodo nodo)
        {
            if(primero == null && ultimo == null)
            {
                primero = nodo;
                ultimo = nodo;
            }
            else
            {
                insertar(nodo);
            }
        }
        public void insertar(Nodo nodo)
        {
            if(primero != null && ultimo != null)
            {
                if(nodo.turno <  primero.turno)
                {
                    nodo.siguiente = primero;
                    primero = nodo;
                }
                if(nodo.turno > ultimo.turno)
                {
                    ultimo.siguiente = nodo;
                    ultimo = nodo;
                }
                if(nodo.turno > primero.turno && nodo.turno < primero.turno)
                {
                    Nodo? anterior = null;
                    Nodo? auxiliar = primero;
                    while(nodo.turno > auxiliar.turno)
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
        public Nodo buscar()
        {
            Nodo aux = primero;
            while (aux != null)
            {
                if (aux.esCliente)
                {
                    break;
                }
                aux = aux.siguiente;
            }
            return aux;
        }
        public Nodo eliminar(Nodo nodo)
        {
            Nodo aux = primero;
            Nodo anterior = null;
            while (aux != null)
            {
                if(nodo == aux)
                {
                    //fixme
                    anterior.siguiente = aux.siguiente;
                    break;
                }
                anterior = aux;
                aux = aux.siguiente;
            }
            return aux;
        }
    }
}
