using System;
using System.IO;
using System.Windows.Forms;

namespace Cajero
{
    public partial class ListarClientesPorSucursalcs : Form
    {
        public ListarClientesPorSucursalcs()
        {
            InitializeComponent();
        }
        ArbolBB arbol = new ArbolBB();
        Persona RaizCuenta = null;
        private void btnListarCliente_Click(object sender, EventArgs e)
        {
            StreamReader Arch = new StreamReader("Cuentas.txt");
            int fila = 0;
            while (Arch.EndOfStream == false)
            {
                Persona ListarCuentas = new Persona();
                
                string[] Vect = Arch.ReadLine().Split('&');
                ListarCuentas.codigo = int.Parse(Vect[0]);
                ListarCuentas.nombre = Vect[1];
                ListarCuentas.apellido = Vect[2];
                ListarCuentas.direccion = Vect[3];
                ListarCuentas.telefono = Vect[4];
                ListarCuentas.ciudad = Vect[5];
                ListarCuentas.sucursal = Int32.Parse(Vect[6]);
                ListarCuentas.numeroCuenta = Vect[7];
                ListarCuentas.saldo = int.Parse(Vect[8]);

                if (RaizCuenta == null)
                {
                    RaizCuenta = ListarCuentas;
                }
                else
                {
                    arbol.InsertarClienteSucursal(ListarCuentas, RaizCuenta);
                }

                fila++;
            }
            Arch.Close();

            arbol.RecorrerClientesPorSucursal(RaizCuenta, this);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
