using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Cajero
{
    public partial class Transferencia : Form
    {
        public Transferencia()
        {
            InitializeComponent();
        }
        Consignar transferencia = new Consignar();
        bool validacion = false;
        bool validacion2 = false;

        private void txtCuentaOrigen_Enter(object sender, EventArgs e)
        {

            if (txtCuentaOrigen.Text == "CUENTA DE ORIGEN")
            {
                txtCuentaOrigen.Text = "";
                txtCuentaOrigen.ForeColor = Color.LightGray;
            }
        }

        private void txtCuentaOrigen_Leave(object sender, EventArgs e)
        {
            if (txtCuentaOrigen.Text == "")
            {
                txtCuentaOrigen.Text = "CUENTA DE ORIGEN";
                txtCuentaOrigen.ForeColor = Color.DimGray;
            }
        }

        private void txtCuentaDestino_Enter(object sender, EventArgs e)
        {
            if (txtCuentaDestino.Text == "CUENTA A TRASNFERIR")
            {
                txtCuentaDestino.Text = "";
                txtCuentaDestino.ForeColor = Color.LightGray;
            }
        }

        private void txtCuentaDestino_Leave(object sender, EventArgs e)
        {
            if (txtCuentaDestino.Text == "")
            {
                txtCuentaDestino.Text = "CUENTA A TRASNFERIR";
                txtCuentaDestino.ForeColor = Color.DimGray;
            }
        }

        private void txtMontoAtrasferir_Enter(object sender, EventArgs e)
        {

            if (txtMontoAtrasferir.Text == "MONTO A TRANSFERIR")
            {
                txtMontoAtrasferir.Text = "";
                txtMontoAtrasferir.ForeColor = Color.LightGray;
            }
        }

        private void txtMontoAtrasferir_Leave(object sender, EventArgs e)
        {
            if (txtMontoAtrasferir.Text == "")
            {
                txtMontoAtrasferir.Text = "MONTO A TRANSFERIR";
                txtMontoAtrasferir.ForeColor = Color.DimGray;
            }
        }

        private void btnContinua_Click(object sender, EventArgs e)
        {
            if (txtMontoAtrasferir.Text == "" || txtCuentaOrigen.Text == "" || txtCuentaDestino.Text == "")
            { MessageBox.Show("hay campos sin llenar!", "Error"); }
            else if (txtCuentaOrigen.Text == txtCuentaDestino.Text)
            { MessageBox.Show("Las cuentas no pueden ser las mismas"); }
            else
            {
                Transferir();
                if (validacion == true && validacion2 == true)
                {
                    transferencia.ModifiCuentas();
                    transferencia.EliminarModCuentas();

                    foreach (Control oControls in this.panel2.Controls)
                    {
                        if (oControls is TextBox)
                        {
                            oControls.Text = ""; // Eliminar el texto del TextBox
                        }
                    }


                    if (txtCuentaOrigen.Text == "")
                    {
                        txtCuentaOrigen.Text = "CUENTA DE ORIGEN";
                        txtCuentaOrigen.ForeColor = Color.DimGray;
                    }

                    if (txtMontoAtrasferir.Text == "")
                    {
                        txtMontoAtrasferir.Text = "MONTO A TRANSFERIR";
                        txtMontoAtrasferir.ForeColor = Color.DimGray;
                    }
                    if (txtCuentaDestino.Text == "")
                    {
                        txtCuentaDestino.Text = "CUENTA A TRASNFERIR";
                        txtCuentaDestino.ForeColor = Color.DimGray;
                    }
                }

            }
        }

        public void Transferir()
        {
            string rutaArchivo1 = ("Cuentas.txt");
            string busquedaOrigen = txtCuentaOrigen.Text;

            string rutaArchivo2 = ("Cuentas.txt");
            String busquedaDestino = txtCuentaDestino.Text;

            foreach (string item in File.ReadAllLines(rutaArchivo1, Encoding.Default))
            {
                string[] datos = item.Split('&');
                string.Format(datos[0], datos[1], datos[2], datos[3], datos[4], datos[5], datos[6], datos[7], datos[8]);

                foreach (string item2 in File.ReadAllLines(rutaArchivo2, Encoding.Default))
                {
                    string[] datos2 = item2.Split('&');
                    string.Format(datos2[0], datos2[1], datos2[2], datos2[3], datos2[4], datos2[5], datos2[6], datos2[7], datos2[8]);

                    if (datos[7].Equals(busquedaOrigen) && datos2[7].Equals(busquedaDestino))
                    {

                        Persona nuevo = new Persona();
                        nuevo.codigo = int.Parse(datos[0]);
                        nuevo.nombre = datos[1];
                        nuevo.apellido = datos[2];
                        nuevo.direccion = datos[3];
                        nuevo.telefono = datos[4];
                        nuevo.ciudad = datos[5];
                        nuevo.sucursal = int.Parse(datos[6]);
                        nuevo.numeroCuenta = datos[7];
                        if (datos[7].Equals(busquedaOrigen))
                        {
                            if (int.Parse(txtMontoAtrasferir.Text) < int.Parse(datos[8]) && int.Parse(txtMontoAtrasferir.Text) > 10000)
                            {
                                nuevo.saldo = int.Parse(datos[8]) - int.Parse(txtMontoAtrasferir.Text);
                                validacion = true;
                            }

                        }
                        if (validacion == false)
                        {
                            MessageBox.Show("No tienes fondos suficientes");
                        }
                        //2daVerificacion.
                        Persona nuevo2 = new Persona();
                        nuevo2.codigo = int.Parse(datos2[0]);
                        nuevo2.nombre = datos2[1];
                        nuevo2.apellido = datos2[2];
                        nuevo2.direccion = datos2[3];
                        nuevo2.telefono = datos2[4];
                        nuevo2.ciudad = datos2[5];
                        nuevo2.sucursal = int.Parse(datos2[6]);
                        nuevo2.numeroCuenta = datos2[7];
                        if (datos2[7].Equals(busquedaDestino))
                        {
                            nuevo2.saldo = int.Parse(datos2[8]) + int.Parse(txtMontoAtrasferir.Text);
                            validacion2 = true;
                        }

                        if (validacion == true && validacion2 == true)
                        {
                            string fileName = "ModCuenta.txt";
                            StreamWriter writer = File.AppendText(fileName.TrimStart());
                            writer.WriteLine("{0}&{1}&{2}&{3}&{4}&{5}&{6}&{7}&{8}", nuevo.codigo, nuevo.nombre, nuevo.apellido, nuevo.direccion, nuevo.telefono, nuevo.ciudad, nuevo.sucursal, nuevo.numeroCuenta, nuevo.saldo);
                            writer.Close();

                            string fileName2 = "ModCuenta.txt";
                            StreamWriter writer2 = File.AppendText(fileName2.TrimStart());
                            writer2.WriteLine("{0}&{1}&{2}&{3}&{4}&{5}&{6}&{7}&{8}", nuevo2.codigo, nuevo2.nombre, nuevo2.apellido, nuevo2.direccion, nuevo2.telefono, nuevo2.ciudad, nuevo2.sucursal, nuevo2.numeroCuenta, nuevo2.saldo);
                            writer2.Close();
                        }
                        if (validacion == false || validacion2 == false)
                        {
                            MessageBox.Show("Revisa los datos y verifica que el monto sea mayor de 10.000");
                        }

                    }
                    

                }


            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control oControls in this.panel2.Controls)
            {
                if (oControls is TextBox)
                {
                    oControls.Text = ""; // Eliminar el texto del TextBox
                }
            }

            if (txtCuentaOrigen.Text == "")
            {
                txtCuentaOrigen.Text = "CUENTA DE ORIGEN";
                txtCuentaOrigen.ForeColor = Color.DimGray;
            }

            if (txtMontoAtrasferir.Text == "")
            {
                txtMontoAtrasferir.Text = "MONTO A TRANSFERIR";
                txtMontoAtrasferir.ForeColor = Color.DimGray;
            }
            if (txtCuentaDestino.Text == "")
            {
                txtCuentaDestino.Text = "CUENTA A TRASNFERIR";
                txtCuentaDestino.ForeColor = Color.DimGray;
            }
        }

        private void txtCuentaOrigen_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }
    }
}
