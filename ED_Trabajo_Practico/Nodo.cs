using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_Trabajo_Practico
{
    public class Nodo
    {
        public int turno { get; set; } 
        public int dni { get; set; }
        public bool esCliente { get; set; }
        public Nodo? siguiente { get; set; }
        public Nodo()
        {
            turno = 0;
            dni = 0;
            esCliente = false;
            siguiente = null;
        }
        public void limpiarNodo()
        {
            turno = 0;
            dni = 0;
            esCliente = false;
            siguiente = null;
            
        }
    }
}
