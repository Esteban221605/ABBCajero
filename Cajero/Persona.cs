﻿using System.IO;

namespace Cajero
{
    class Persona
    {
        public int codigo, saldo, sucursal;
        public string nombre, apellido, direccion, telefono, ciudad,numeroCuenta, codigoBlanco,saldoBalco,sucursalBlaco;
        public Persona NodoIzquierdo, NodoDerecho;
        
        public void EscribirClientes(Persona nuevo)
        {

            string fileName = "Clientes.txt";
            StreamWriter writer = File.AppendText(fileName.Trim());
            writer.WriteLine("{0}&{1}&{2}&{3}&{4}&{5}", nuevo.codigo, nuevo.nombre, nuevo.apellido, nuevo.direccion, nuevo.telefono, nuevo.ciudad);
            writer.Close();

        }



    }
}

