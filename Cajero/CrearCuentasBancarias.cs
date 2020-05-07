using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Cajero
{
    public partial class CrearCuentasBancarias : Form
    {
        public CrearCuentasBancarias()
        {
            InitializeComponent();
        }

        Persona nuevo = new Persona();

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            if (txtIDcliente.Text == "" || txtCodSucursal.Text == "" || txtCrearCuenta.Text == "" || txtsaldoInicial.Text == "")
                MessageBox.Show("hay campos sin llenar!", "Error");

            string leerCliente = ("Clientes.txt");
            string buscarId = txtIDcliente.Text; //Argumento de búsqueda


            foreach (string item in File.ReadAllLines(leerCliente, Encoding.Default))
            {
                if (item.Contains(buscarId))
                {
                    string[] datosCuenta = item.Split('&');

                    string.Format(datosCuenta[0], datosCuenta[1], datosCuenta[2], datosCuenta[3], datosCuenta[4], datosCuenta[5]);
                    if (datosCuenta[0].Equals(buscarId))
                    {
                        string leerSucursal = ("Sucursales.txt");
                        string bucarSucursal = txtCodSucursal.Text; //Argumento de búsqueda
                        foreach (string item2 in File.ReadAllLines(leerSucursal, Encoding.Default))
                        {
                            if (item2.Contains(bucarSucursal))
                            {
                                string[] datosCuentaSuc = item2.Split('&');
                                string.Format(datosCuentaSuc[0]);
                                if (datosCuentaSuc[0].Equals(bucarSucursal))
                                {
                                    Persona nuevo = new Persona();
                                    nuevo.codigo = int.Parse(datosCuenta[0]);
                                    nuevo.nombre = datosCuenta[1];
                                    nuevo.apellido = datosCuenta[2];
                                    nuevo.direccion = datosCuenta[3];
                                    nuevo.telefono = datosCuenta[4];
                                    nuevo.ciudad = datosCuenta[5];
                                    nuevo.sucursal = int.Parse(datosCuentaSuc[0]);
                                    nuevo.numeroCuenta = txtCrearCuenta.Text;
                                    nuevo.saldo = int.Parse(txtsaldoInicial.Text);

                                    string fileName = "Cuentas.txt";
                                    StreamWriter writer = File.AppendText(fileName.Trim());
                                    writer.WriteLine("{0}&{1}&{2}&{3}&{4}&{5}&{6}&{7}&{8}", nuevo.codigo, nuevo.nombre, nuevo.apellido, nuevo.direccion, nuevo.telefono, nuevo.ciudad, nuevo.sucursal, nuevo.numeroCuenta, nuevo.saldo);
                                    writer.Close();
                                }
                            }


                        }

                    }
                    else
                    {
                        MessageBox.Show("Hay datos que no coinciden vuelve a intentarlo");
                    }



                }

            }

        }

        private void btnListarCuentas_Click(object sender, EventArgs e)
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
                ListarCuentas.sucursal = int.Parse(Vect[6]);
                ListarCuentas.numeroCuenta = Vect[7];
                ListarCuentas.saldo = int.Parse(Vect[8]);

                dataGridViewListarCuenta.Rows.Add();
                dataGridViewListarCuenta.Rows[fila].Cells["Codigo"].Value = ListarCuentas.codigo;
                dataGridViewListarCuenta.Rows[fila].Cells["Nombre"].Value = ListarCuentas.nombre;
                dataGridViewListarCuenta.Rows[fila].Cells["Apellido"].Value = ListarCuentas.apellido;
                dataGridViewListarCuenta.Rows[fila].Cells["Direccion"].Value = ListarCuentas.direccion;
                dataGridViewListarCuenta.Rows[fila].Cells["Telefono"].Value = ListarCuentas.telefono;
                dataGridViewListarCuenta.Rows[fila].Cells["Ciudad"].Value = ListarCuentas.ciudad;
                dataGridViewListarCuenta.Rows[fila].Cells["codsucursal"].Value = ListarCuentas.sucursal;
                dataGridViewListarCuenta.Rows[fila].Cells["Cuenta"].Value = ListarCuentas.numeroCuenta;
                dataGridViewListarCuenta.Rows[fila].Cells["Saldo"].Value = ListarCuentas.saldo;


                fila++;

            }
            Arch.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelarCreacion_Click(object sender, EventArgs e)
        {
            foreach (Control oControls in this.panel1.Controls)
            {
                if (oControls is TextBox)
                {
                    oControls.Text = ""; // Eliminar el texto del TextBox
                }
            }
        }

        private void txtIDcliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtCodSucursal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtCrearCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtsaldoInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }
    }
}
