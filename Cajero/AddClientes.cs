using System;
using System.IO;
using System.Windows.Forms;

namespace Cajero
{
    public partial class AddClientes : Form
    {
        public AddClientes()
        {
            InitializeComponent();
        }
        ArbolBB arbol = new ArbolBB();
        Persona RaizPersona = null;
       
        

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            if (txtCodigocliente.Text == "" || txtNombreCliente.Text == "" || txtApellidoCliente.Text == "" || txtDireccionCliente.Text == "" || txtTelefonoCliente.Text == "" || txtCiudadCliente.Text == "")
                MessageBox.Show("hay campos sin llenar!", "Error");

            else
            {
                ArbolBB anterior = null, actual;
                Persona nuevo = new Persona();

                nuevo.codigo = int.Parse(txtCodigocliente.Text);
                nuevo.nombre = txtNombreCliente.Text;
                nuevo.apellido = txtApellidoCliente.Text;
                nuevo.direccion = txtDireccionCliente.Text;
                nuevo.telefono = txtTelefonoCliente.Text;
                nuevo.ciudad = txtCiudadCliente.Text;
                nuevo.EscribirClientes(nuevo);
            }
        }

        private void btnListarCliente_Click(object sender, EventArgs e)
        {
           

            StreamReader Arch = new StreamReader("Clientes.txt");
            int fila = 0;
            while (Arch.EndOfStream == false)
            {
                Persona persona = new Persona();
                string[] Vect = Arch.ReadLine().Split('&');
                persona.codigo = int.Parse(Vect[0]);
                persona.nombre = Vect[1];
                persona.apellido = Vect[2];
                persona.telefono = Vect[4];
                persona.direccion = Vect[3];
                persona.ciudad = Vect[5];

                if (RaizPersona == null)
                {
                    RaizPersona = persona;
                }
                else
                {
                    arbol.InsertarPersona(persona, RaizPersona);
                }
               
                fila++;
            }

            Arch.Close();

            arbol.RecorrerPersona(RaizPersona, this);
            
        }

        private void dataGridViewAddClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }

        private void btnCancelarCliente_Click(object sender, EventArgs e)
        {
            foreach (Control oControls in this.panel1.Controls)
            {
                if (oControls is TextBox)
                {
                    oControls.Text = ""; // Eliminar el texto del TextBox
                }
            }


        }


        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigocliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void btnListarCliente_Enter(object sender, EventArgs e)
        {
           
           
        }
    }
}
