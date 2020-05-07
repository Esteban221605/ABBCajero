using System;

namespace Cajero
{
    class ArbolBB
    {
      
        private int fila = 0;



        private int i = 0;//valor de intentacion,servira para desplegar de forma mas sencilla el arbol

       
        public void InsertarPersona(Persona nuevo, Persona primeraPersona)
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
        public void InsertarSucursal(Sucursal nuevo, Sucursal primeraSucursal)
        {
            Sucursal anterior = null, actual;

            Console.WriteLine("En el else: " + nuevo.codigo);
            actual = primeraSucursal;
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
        public void InsertarSaldoActual(Persona nuevo, Persona primeraPersona)
        {
            Persona anterior = null, actual;

            Console.WriteLine("En el else: " + nuevo.saldo);
            actual = primeraPersona;
            while (actual != null)
            {
                anterior = actual;
                if (actual.saldo > nuevo.saldo)
                    actual = actual.NodoIzquierdo;
                else
                    actual = actual.NodoDerecho;
            }
            if (anterior.saldo > nuevo.saldo)
                anterior.NodoIzquierdo = nuevo;

            else
                anterior.NodoDerecho = nuevo;
        }
        public void InsertarClienteSucursal(Persona nuevo, Persona primeraPersona)
        {
            Persona anterior = null, actual;

            Console.WriteLine("En el else: " + nuevo.sucursal);
            actual = primeraPersona;
            while (actual != null)
            {
                anterior = actual;
                if (actual.sucursal > nuevo.sucursal)
                    actual = actual.NodoIzquierdo;
                else
                    actual = actual.NodoDerecho;
            }
            if (anterior.sucursal > nuevo.sucursal)
                anterior.NodoIzquierdo = nuevo;

            else
                anterior.NodoDerecho = nuevo;
        }

        public void RecorrerClientesPorSucursal(Persona Raiz, ListarClientesPorSucursalcs formListarSuc)
        {
            if (Raiz != null)
            {
                RecorrerClientesPorSucursal(Raiz.NodoIzquierdo, formListarSuc);
               formListarSuc.dataGridViewListarCuenta.Rows.Add();

               formListarSuc.dataGridViewListarCuenta.Rows[fila].Cells["Codigo"].Value = Raiz.codigo;
               formListarSuc.dataGridViewListarCuenta.Rows[fila].Cells["Nombre"].Value = Raiz.nombre;
               formListarSuc.dataGridViewListarCuenta.Rows[fila].Cells["Apellido"].Value = Raiz.apellido;
               formListarSuc.dataGridViewListarCuenta.Rows[fila].Cells["Direccion"].Value = Raiz.direccion;
               formListarSuc.dataGridViewListarCuenta.Rows[fila].Cells["Telefono"].Value = Raiz.telefono;
               formListarSuc.dataGridViewListarCuenta.Rows[fila].Cells["Ciudad"].Value = Raiz.ciudad;
               formListarSuc.dataGridViewListarCuenta.Rows[fila].Cells["codsucursal"].Value = Raiz.sucursal;
               formListarSuc.dataGridViewListarCuenta.Rows[fila].Cells["Cuenta"].Value = Raiz.numeroCuenta;
               formListarSuc.dataGridViewListarCuenta.Rows[fila].Cells["Saldo"].Value = Raiz.saldo;

                fila++;

                RecorrerClientesPorSucursal(Raiz.NodoDerecho, formListarSuc);
            }
        }

        public void RecorrerClienteSaldo(Persona Raiz, ListarClienteConSaldoActual formListarSal)
        {
            if (Raiz != null)
            {
                RecorrerClienteSaldo(Raiz.NodoIzquierdo, formListarSal);
                formListarSal.dataGridViewListarCuenta.Rows.Add();

                formListarSal.dataGridViewListarCuenta.Rows[fila].Cells["Codigo"].Value = Raiz.codigo;
                formListarSal.dataGridViewListarCuenta.Rows[fila].Cells["Nombre"].Value = Raiz.nombre;
                formListarSal.dataGridViewListarCuenta.Rows[fila].Cells["Apellido"].Value = Raiz.apellido;
                formListarSal.dataGridViewListarCuenta.Rows[fila].Cells["Direccion"].Value = Raiz.direccion;
                formListarSal.dataGridViewListarCuenta.Rows[fila].Cells["Telefono"].Value = Raiz.telefono;
                formListarSal.dataGridViewListarCuenta.Rows[fila].Cells["Ciudad"].Value = Raiz.ciudad;
                formListarSal.dataGridViewListarCuenta.Rows[fila].Cells["codsucursal"].Value = Raiz.sucursal;
                formListarSal.dataGridViewListarCuenta.Rows[fila].Cells["Cuenta"].Value = Raiz.numeroCuenta;
                formListarSal.dataGridViewListarCuenta.Rows[fila].Cells["Saldo"].Value = Raiz.saldo;

                fila++;

                RecorrerClienteSaldo(Raiz.NodoDerecho, formListarSal);
            }
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

        public void Recorrersucursal(Sucursal Raiz, AddSucursal formSucucrsal)
        {
            if (Raiz != null)
            {
                Recorrersucursal(Raiz.NodoIzquierdo, formSucucrsal);
                formSucucrsal.dataGridViewAddSucursal.Rows.Add();

                formSucucrsal.dataGridViewAddSucursal.Rows[fila].Cells["codigo"].Value   = Raiz.codigo;
                formSucucrsal.dataGridViewAddSucursal.Rows[fila].Cells["nombre"].Value    = Raiz.nombre;
                formSucucrsal.dataGridViewAddSucursal.Rows[fila].Cells["direccion"].Value = Raiz.direccion;
                formSucucrsal.dataGridViewAddSucursal.Rows[fila].Cells["telefono"].Value  = Raiz.telefono;
                formSucucrsal.dataGridViewAddSucursal.Rows[fila].Cells["ciudad"].Value    = Raiz.ciudad;

                fila++;

                Recorrersucursal(Raiz.NodoDerecho, formSucucrsal);
            }
        }


       
    }
}
