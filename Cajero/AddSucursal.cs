using System;
using System.IO;
using System.Windows.Forms;

namespace Cajero
{
    public partial class AddSucursal : Form
    {
        public AddSucursal()
        {
            InitializeComponent();
        }

        ArbolBB arbol = new ArbolBB();
        Sucursal RaizSucursal = null;

        private void btnCrearSucursal_Click_1(object sender, EventArgs e)
        {
            if (txtcodigoSucursual.Text == "" || txtNomSucursal.Text == "" || txtDireccion_Suc.Text == "" || txtTelefono_suc.Text == "" || txtCiudad_suc.Text == "")
                MessageBox.Show("hay campos sin llenar!", "Error");
            else
            {
                ArbolBB anterior = null, actual;
                Sucursal nuevo = new Sucursal();

                nuevo.codigo = int.Parse(txtcodigoSucursual.Text);
                nuevo.nombre = txtNomSucursal.Text;
                nuevo.direccion = txtDireccion_Suc.Text;
                nuevo.telefono = txtTelefono_suc.Text;
                nuevo.ciudad = txtCiudad_suc.Text;
                nuevo.EscribirSucursales(nuevo);
            }
        }

        private void btnListarSucursal_Click(object sender, EventArgs e)
        {

            StreamReader Arch = new StreamReader("Sucursales.txt");
            int fila = 0;
            while (Arch.EndOfStream == false)
            {
                Sucursal sucursal = new Sucursal();
                string[] Vect = Arch.ReadLine().Split('&');
                sucursal.codigo = int.Parse(Vect[0]);
                sucursal.nombre = Vect[1];
                sucursal.telefono = Vect[2];
                sucursal.direccion = Vect[3];
                sucursal.ciudad = Vect[4];

                if (RaizSucursal == null)
                {
                    RaizSucursal = sucursal;
                }
                else
                {
                    arbol.InsertarSucursal(sucursal, RaizSucursal);
                }

                fila++;
            }
            Arch.Close();

            arbol.Recorrersucursal(RaizSucursal, this);
        }

        private void dataGridViewAddSucursal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancelarSucursal_Click(object sender, EventArgs e)
        {
            foreach (Control oControls in this.panel1.Controls)
            {
                if (oControls is TextBox)
                {
                    oControls.Text = ""; // Eliminar el texto del TextBox
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtcodigoSucursual_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }
    }
}
