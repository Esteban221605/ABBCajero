using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero
{
    class Sucursal
    {
        public int codigo = 0;
        public string nombre,direccion, telefono, ciudad;
        public Sucursal NodoIzquierdo, NodoDerecho;

        public void EscribirSucursales(Sucursal nuevo)
        {

            string fileName = "Sucursales.txt";
            StreamWriter writer = File.AppendText(fileName.Trim());
            writer.WriteLine("{0}&{1}&{2}&{3}&{4}",nuevo.codigo, nuevo.nombre,nuevo.direccion, nuevo.telefono, nuevo.ciudad);
            writer.Close();

        }
    }
}
