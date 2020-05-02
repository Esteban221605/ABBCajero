using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero
{
    class CNodo
    {

        
        private int dato;

        private CNodo izq;//variable de referencia de tipo CNodo para la parte izquierda
        private CNodo der;//variable de referencia de tipo CNodo para la parte derecha

        //propiedades para dato,derecha e izquierda
        public int Dato { get => dato; set => dato = value; }
        internal CNodo Izq { get => izq; set => izq = value; }
        internal CNodo Der { get => der; set => der = value; }
        public CNodo()//constructor del nodo
        {
            dato = 0;//inicializo el dato con cero
            izq = null;//defino nulo a la izquierda, nodo recien creado.
            der = null;//defino nulo a la derecha, nodo recien creado.
        }
    }
}
