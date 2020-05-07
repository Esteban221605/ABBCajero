using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Cajero
{
    public partial class Retirar : Form
    {
        public Retirar()
        {
            InitializeComponent();
        }
        bool validacion = false;
        Consignar retirar = new Consignar();

        private void txtNumeroCuenta_Enter(object sender, EventArgs e)
        {
            if (txtNumeroCuenta.Text == "NÙMERO DE CUENTA")
            {
                txtNumeroCuenta.Text = "";
                txtNumeroCuenta.ForeColor = Color.LightGray;
            }
        }

        private void txtNumeroCuenta_Leave(object sender, EventArgs e)
        {

            if (txtNumeroCuenta.Text == "")
            {
                txtNumeroCuenta.Text = "NÙMERO DE CUENTA";
                txtNumeroCuenta.ForeColor = Color.DimGray;
            }
        }

        private void txtMontoARetirar_Enter(object sender, EventArgs e)
        {
            if (txtMontoARetirar.Text == "MONTO A RETIRAR")
            {
                txtMontoARetirar.Text = "";
                txtMontoARetirar.ForeColor = Color.LightGray;
            }
        }


        private void txtMontoARetirar_Leave(object sender, EventArgs e)
        {
            if (txtMontoARetirar.Text == "")
            {
                txtMontoARetirar.Text = "MONTO A RETIRAR";
                txtMontoARetirar.ForeColor = Color.DimGray;
            }
        }


        private void butnContinuar_Click(object sender, EventArgs e)
        {
            RestarRetiro();
            if (validacion == true)
            {
                retirar.ModifiCuentas();
                retirar.EliminarModCuentas();

                foreach (Control oControls in this.panel2.Controls)
                {
                    if (oControls is TextBox)
                    {
                        oControls.Text = ""; // Eliminar el texto del TextBox
                    }
                }
                MessageBox.Show("Retiro exitoso");
            }

            if (txtNumeroCuenta.Text == "")
            {
                txtNumeroCuenta.Text = "NÙMERO DE CUENTA";
                txtNumeroCuenta.ForeColor = Color.DimGray;
            }
            if (txtMontoARetirar.Text == "")
            {
                txtMontoARetirar.Text = "MONTO A RETIRAR";
                txtMontoARetirar.ForeColor = Color.DimGray;
            }
        }

        public void RestarRetiro()
        {
            string rutaArchivo = ("Cuentas.txt");
            string valorBusqueda = txtNumeroCuenta.Text; //Argumento de búsqueda
            foreach (string item in File.ReadAllLines(rutaArchivo, Encoding.Default))
            {
                string[] datos = item.Split('&');
                string.Format(datos[0], datos[1], datos[2], datos[3], datos[4], datos[5], datos[6], datos[7], datos[8]);

                Persona nuevo = new Persona();
                nuevo.codigo = int.Parse(datos[0]);
                nuevo.nombre = datos[1];
                nuevo.apellido = datos[2];
                nuevo.direccion = datos[3];
                nuevo.telefono = datos[4];
                nuevo.ciudad = datos[5];
                nuevo.sucursal = int.Parse(datos[6]);
                nuevo.numeroCuenta = datos[7];
                nuevo.saldo = int.Parse(datos[8]);
                if (datos[7].Equals(txtNumeroCuenta.Text))
                {
                    if (int.Parse(txtMontoARetirar.Text) > 10000 && int.Parse(txtMontoARetirar.Text) < int.Parse(datos[8]))
                    {
                        nuevo.saldo = int.Parse(datos[8]) - int.Parse(txtMontoARetirar.Text);
                        validacion = true;
                    }
                    
                }

                if (validacion == true)
                {
                    string fileName = "ModCuenta.txt";
                    StreamWriter writer = File.AppendText(fileName.TrimStart());
                    writer.WriteLine("{0}&{1}&{2}&{3}&{4}&{5}&{6}&{7}&{8}", nuevo.codigo, nuevo.nombre, nuevo.apellido, nuevo.direccion, nuevo.telefono, nuevo.ciudad, nuevo.sucursal, nuevo.numeroCuenta, nuevo.saldo);
                    writer.Close();
                }

            }
            if (validacion == false)
            {
                MessageBox.Show("Verifica tu numero de cuenta y que el monto sea mayores a 10.000");
            }


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            foreach (Control oControls in this.panel2.Controls)
            {
                if (oControls is TextBox)
                {
                    oControls.Text = ""; // Eliminar el texto del TextBox
                }
            }
            if (txtNumeroCuenta.Text == "")
            {
                txtNumeroCuenta.Text = "NÙMERO DE CUENTA";
                txtNumeroCuenta.ForeColor = Color.DimGray;
            }
            if (txtMontoARetirar.Text == "")
            {
                txtMontoARetirar.Text = "MONTO A RETIRAR";
                txtMontoARetirar.ForeColor = Color.DimGray;
            }
        }

        private void txtMontoARetirar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtNumeroCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }
    }
}
