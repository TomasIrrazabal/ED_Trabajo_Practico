using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_Trabajo_Practico
{
    internal class Cola
    {
        Nodo primero { get; set; }
        int turno;
        public Cola()
        {
            primero = null;  
            turno = 0;
        }
        public void Ingresar(Nodo nodo)
        {
            if(primero == null) //crea la cola
            {
                nodo.turno = ++turno;
                primero = nodo;
            }
            else
            {
                Nodo aux = primero;
                while(aux.siguiente != null)
                {
                    aux = aux.siguiente;
                }
                turno++;
                nodo.turno = turno;
                aux.siguiente = nodo;   
            }
        }

        public Nodo eliminar()
        {
            Nodo aux = null;
            if(primero != null)
            {
                aux = primero;
                primero = primero.siguiente;
            }
            return aux;
        }

        public List<Nodo> listar()
        {
            List<Nodo> list = new List<Nodo>();
            Nodo aux = primero;
            while(aux != null )
            {
                list.Add(aux);
                aux = aux.siguiente;
            }
            return list;
        }
        public int buscarTurno()
        {
            //turno = 1;
            Nodo aux = primero;

            if (aux == null) return turno;
            do
            {
                if(aux != null) turno = aux.turno;

                aux = aux.siguiente;
                
            } while( aux != null ); 

            return turno;
        }
        public bool existeNodo(int dni)
        {
            {
                Nodo aux = primero;
                if (aux == null) return false;
                do
                {
                    if (aux.dni == dni)
                    {
                        return true;
                    }
                    aux = aux.siguiente;
                } while (aux != null);

                return false;
            }
        }
    }
}
