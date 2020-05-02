using System;
using System.Windows.Forms;

namespace Cajero
{
    class ArbolBB
    {
        private CNodo raiz;//nodo raiz
        private CNodo trabajo;
        private int fila = 0;



        private int i = 0;//valor de intentacion,servira para desplegar de forma mas sencilla el arbol

        public ArbolBB()
        {
            raiz = null;
        }

        internal CNodo Raiz { get => raiz; set => raiz = value; }//propiedad para raiz, servira para obtener la raiz o cambiarla en cualquier momento

        //insertar
        //el primer parametro es el dato que deseamos insertar y el segundo es el nodo en el cual nosotros queremos que se lleve acabo la insercion.       
        //insertar es un metodo recursivo.
        public void Insertar(Persona nuevo, Persona primeraPersona)
        {
            Persona anterior = null, actual;

            Console.WriteLine("En el else: " + nuevo.codigo);
            actual = primeraPersona;
            while (actual != null)
            {
                anterior = actual;
                if (actual.codigo > nuevo.codigo)
                    actual = actual.NodoIzquierdo;
                else
                    actual = actual.NodoDerecho;
            }
            if (anterior.codigo > nuevo.codigo)
                anterior.NodoIzquierdo = nuevo;

            else
                anterior.NodoDerecho = nuevo;
        }
      
        public void RecorrerPersona(Persona Raiz, AddClientes formPersona)
        {
            if (Raiz != null)
            {
                RecorrerPersona(Raiz.NodoIzquierdo, formPersona);
                formPersona.dataGridViewAddClientes.Rows.Add();

                formPersona.dataGridViewAddClientes.Rows[fila].Cells["codigo"].Value    = Raiz.codigo;
                formPersona.dataGridViewAddClientes.Rows[fila].Cells["nombre"].Value    = Raiz.nombre;
                formPersona.dataGridViewAddClientes.Rows[fila].Cells["Apellido"].Value  = Raiz.apellido;
                formPersona.dataGridViewAddClientes.Rows[fila].Cells["direccion"].Value = Raiz.direccion;
                formPersona.dataGridViewAddClientes.Rows[fila].Cells["telefono"].Value  = Raiz.telefono;
                formPersona.dataGridViewAddClientes.Rows[fila].Cells["ciudad"].Value    = Raiz.ciudad;

                fila++;

                RecorrerPersona(Raiz.NodoDerecho, formPersona);
            }
        }
        public void TransversaOrdenada(CNodo pNodo)//transversa Inorder
                                                   //como parametro el nodo sobre el cual queremos sacar la transversa Inorder de ese arbol
        {
            if (pNodo == null)//caso base
                return;

            //si tengo izquierda,proceso a la izquierda
            if (pNodo.Izq != null)
            {
                i++;
                TransversaOrdenada(pNodo.Izq);//llamada recursiva a quien sea que tengamos en la izquierda
                i--;
            }

            Console.WriteLine("{0}, ", pNodo.Dato);//nos procesamos 

            //si tengo derecha,proceso a la derecha
            if (pNodo.Der != null)//si tenemos a alguien en la derecha
            {
                i++;
                TransversaOrdenada(pNodo.Der);//hacemos transversa ordenada de quien tengamos nosotros en la derecha
                i--;
                //Con esto se va a recorrer el arbol con una transversa inorder y nos van a aparecer los datos que nosotros tenemos ordenados de menor a mayor     
            }
        }

        //inorder comienza 
        public int EncuentraMinimo(CNodo pNodo)//pasamos como parametro el nodo que del arbol deseamos encontrar el minimo 
        {
            if (pNodo == null)
                return 0;

            trabajo = pNodo;
            int minimo = trabajo.Dato;

            while (trabajo.Izq != null)
            {
                trabajo = trabajo.Izq;//muevo trabajo hacia la izquierda,nos permitira en cada vuelta del ciclo mover mi referencia de trabajo entre nodo y nodo que se encuentra a la izquierda
                minimo = trabajo.Dato;//actualizo minimo, con cada movimiento se actualiza, hasta que llegue aquel que ya no tenga mas izquierdas y con eso garantizamos que sea el mas pequeño del arbol
                //minimo quedaria con el valor mas pequeño del arbol
            }
            return minimo;
        }
        public CNodo EncuentraNodoMinimo(CNodo pNodo)// el nodo que va a ser usado como raiz para encontrar el minimo de su arbol 
                                                     //regreso un nodo
        {
            if (pNodo == null)
                return null;

            trabajo = pNodo;
            int minimo = trabajo.Dato;

            while (trabajo.Izq != null)//recorro cada uno de los elementos hacia la izquierda
            {
                trabajo = trabajo.Izq;
                minimo = trabajo.Dato;
            }
            return trabajo;//trabajo va a quedar apuntando al nodo mas a la izquierda despues del ciclo
            //con eso ya tenemos la referencia al nodo que tiene el valor mas pequeño del arbol
        }

        public int EncuentraMaximo(CNodo pNodo)
        {
            if (pNodo == null)
                return 0;

            trabajo = pNodo;
            int maximo = trabajo.Dato;

            while (trabajo.Der != null)
            {
                trabajo = trabajo.Der;//trabajamos en el lado derecho , cuando llegamos a un nodo derecho que ya no tiene mas, sabemos que hemos llegado al nodo mas derecho posible.
                maximo = trabajo.Dato;
            }
            return maximo;//regresamos el maximo 
        }

    }
}
