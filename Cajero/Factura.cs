using System;
using System.IO;
using System.Windows.Forms;

namespace Cajero
{
    public partial class Factura : Form
    {


        public Factura()
        {
            InitializeComponent();

        }
        Loguin loguin = new Loguin();

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        public void Registro()
        {
         
            string rutaArchivo = ("ModLoguin.txt");

            foreach (string item in File.ReadAllLines(rutaArchivo, System.Text.Encoding.Default))
            {
                string[] datos = item.Split('&');
                string.Format(datos[0], datos[1], datos[2], datos[3], datos[4], datos[5], datos[6], datos[7], datos[8]);

                string ActualizarInfo = ("Cuentas.txt");
                string buscandor = datos[0];
                foreach (string item2 in File.ReadAllLines(ActualizarInfo, System.Text.Encoding.Default))
                {
                    string[] datos2 = item2.Split('&');
                    string.Format(datos2[0], datos2[1], datos2[2], datos2[3], datos2[4], datos2[5], datos2[6], datos2[7], datos2[8]);

                    if (buscandor.Equals(datos2[0]))
                    {

                        label1.Text = datos2[6];
                        label2.Text = datos2[1];
                        label6.Text = datos2[2];
                        label3.Text = datos2[7];
                        label4.Text = datos2[8];
                    }
                }
            }

        }


        private void horaFecha_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Registro();
        }
    }
}

