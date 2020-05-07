using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cajero
{
    public partial class Consignar : Form
    {
        public Consignar()
        {
            InitializeComponent();
        }
        bool validacion = false;

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtNumcuenta.Text == "NÙMERO DE CUENTA")
            {
                txtNumcuenta.Text = "";
                txtNumcuenta.ForeColor = Color.LightGray;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtNumcuenta.Text == "")
            {
                txtNumcuenta.Text = "NÙMERO DE CUENTA";
                txtNumcuenta.ForeColor = Color.DimGray;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtMontoConsignar.Text == "MONTO A CONSIGNAR")
            {
                txtMontoConsignar.Text = "";
                txtMontoConsignar.ForeColor = Color.LightGray;
            }

        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtMontoConsignar.Text == "")
            {
                txtMontoConsignar.Text = "MONTO A CONSIGNAR";
                txtMontoConsignar.ForeColor = Color.DimGray;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtMontoConsignar.Text == "" || txtNumcuenta.Text == "")
                MessageBox.Show("hay campos sin llenar!", "Error");

            SumarConsignacion();
            if (validacion==true)
            {
                ModifiCuentas();
                EliminarModCuentas();
                foreach (Control oControls in this.panel1.Controls)
                {
                    if (oControls is TextBox)
                    {
                        oControls.Text = ""; // Eliminar el texto del TextBox
                    }
                }
                MessageBox.Show("Consignacion exitosa");

            }
            if (txtMontoConsignar.Text == "")
            {
                txtMontoConsignar.Text = "MONTO A CONSIGNAR";
                txtMontoConsignar.ForeColor = Color.DimGray;
            }
            if (txtNumcuenta.Text == "")
            {
                txtNumcuenta.Text = "NÙMERO DE CUENTA";
                txtNumcuenta.ForeColor = Color.DimGray;
            }

        }


        public void SumarConsignacion()
        {
            string rutaArchivo = ("Cuentas.txt");
            string valorBusqueda = txtNumcuenta.Text; //Argumento de búsqueda
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
                if (datos[7].Equals(txtNumcuenta.Text) && int.Parse(txtMontoConsignar.Text)>10000)
                {
                    nuevo.saldo = int.Parse(datos[8]) + int.Parse(txtMontoConsignar.Text);
                    validacion = true;
                }
                if (validacion==true)
                {
                    string fileName = "ModCuenta.txt";
                    StreamWriter writer = File.AppendText(fileName.TrimStart());
                    writer.WriteLine("{0}&{1}&{2}&{3}&{4}&{5}&{6}&{7}&{8}", nuevo.codigo, nuevo.nombre, nuevo.apellido, nuevo.direccion, nuevo.telefono, nuevo.ciudad, nuevo.sucursal, nuevo.numeroCuenta, nuevo.saldo);
                    writer.Close();
                }
                
            }
            if (validacion == false)
            {
                MessageBox.Show("El numero de cuenta no existe o el valor ingresado es menor de 10.000");
            }
        }

        public void ModifiCuentas()
        {
            LimpiarCuentas();
            string ModificarCuenta = ("ModCuenta.txt");
            foreach (string item in File.ReadAllLines(ModificarCuenta, Encoding.Default))
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
                string fileName = "Cuentas.txt";
                StreamWriter writer = File.AppendText(fileName.TrimStart());
                writer.WriteLine("{0}&{1}&{2}&{3}&{4}&{5}&{6}&{7}&{8}", nuevo.codigo, nuevo.nombre, nuevo.apellido, nuevo.direccion, nuevo.telefono, nuevo.ciudad, nuevo.sucursal, nuevo.numeroCuenta, nuevo.saldo);
                writer.Close();
            }

        }

        public void EliminarModCuentas()
        {
            Persona nuevo = new Persona();
            string fileName = "ModCuenta.txt";
            StreamWriter writer = File.CreateText(fileName.TrimStart());
            writer.WriteLine("", nuevo.codigoBlanco, nuevo.nombre, nuevo.apellido, nuevo.direccion, nuevo.telefono, nuevo.ciudad, nuevo.sucursalBlaco, nuevo.numeroCuenta, nuevo.saldoBalco);
            writer.Close();
            RemoverLineaBlaca("ModCuenta.txt", "ModCuenta.txt");
        }

        public void LimpiarCuentas()
        {
            Persona nuevo = new Persona();
   
            string fileName = "Cuentas.txt";
            StreamWriter writer = File.CreateText(fileName.TrimStart());
            writer.WriteLine("", nuevo.codigoBlanco, nuevo.nombre, nuevo.apellido, nuevo.direccion, nuevo.telefono, nuevo.ciudad, nuevo.sucursalBlaco, nuevo.numeroCuenta, nuevo.saldoBalco);
            writer.Close();
            RemoverLineaBlaca("Cuentas.txt","Cuentas.txt");
        }

       public static void RemoverLineaBlaca(string strSourcePath, string strDestinePath)
        {
            //Lee todas las lineas del fichero
            string[] strAllLines = File.ReadAllLines(strSourcePath);
            //Selecciona las lineas que no sean null o blancas
            string[] strWritedLines = strAllLines.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
            //Guarda las nuevas lineas en el nuevo fichero
            File.WriteAllLines(strDestinePath, strWritedLines);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            foreach (Control oControls in this.panel1.Controls)
            {
                if (oControls is TextBox)
                {
                    oControls.Text = ""; // Eliminar el texto del TextBox
                }
            }
            if (txtNumcuenta.Text == "")
            {
                txtNumcuenta.Text = "NÙMERO DE CUENTA";
                txtNumcuenta.ForeColor = Color.DimGray;
            }
            if (txtMontoConsignar.Text == "")
            {
                txtMontoConsignar.Text = "MONTO A CONSIGNAR";
                txtMontoConsignar.ForeColor = Color.DimGray;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMontoConsignar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtNumcuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }
    }
}
