using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Cajero
{
    public partial class Loguin : Form
    {
        public Loguin()
        {
            InitializeComponent();
        }
        bool validar = false;
       
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "CONTRASEÑA")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "CONTRASEÑA";
                txtpass.ForeColor = Color.DimGray;
            }
        }

        private void txtUser_Enter_1(object sender, EventArgs e)
        {

            if (txtUser.Text == "USUARIO")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;
            }
        }

        private void txtUser_Leave_1(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "USUARIO";
                txtUser.ForeColor = Color.DimGray;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void Loguin_Load(object sender, EventArgs e)
        {

        }


       

        public void btnLoguin_Click(object sender, EventArgs e)
        {
            if (txtpass.Text != "" && txtUser.Text != "")
            {
                Admini();
                Usuario();
                
            }
            else
            {
                MessageBox.Show("porfavor llenar los campos correctamente");
            }

            
           
        }

       

        public void Usuario()
        {
            string rutaArchivo = ("Cuentas.txt");
            string busquedauser = txtUser.Text;
            string busquedPass = txtpass.Text;

            foreach (string item in File.ReadAllLines(rutaArchivo, System.Text.Encoding.Default))
            {
                string[] datos = item.Split('&');
                string.Format(datos[0], datos[1], datos[2], datos[3], datos[4], datos[5], datos[6], datos[7], datos[8]);
                if (datos[0].Equals(busquedauser) && datos[7].Equals(busquedPass))
                {
                    Usuario u = new Usuario();
                    u.Show();
                    validar = true;
                    string fileName = "ModLoguin.txt";
                    StreamWriter writer = File.CreateText(fileName.TrimStart());
                    writer.WriteLine("{0}&{1}&{2}&{3}&{4}&{5}&{6}&{7}&{8}", datos[0],datos[1],datos[2],datos[3],datos[4],datos[5],datos[6],datos[7],datos[8]);
                    writer.Close();
                }
                
            }
            if (validar == false)
            {
                MessageBox.Show("El usuario o la cuenta no es valido");
            }

        }

        public void Admini()
        {

            string rutaArchivo = ("loguin.txt");
            string busquedauser = txtUser.Text;
            string busquedPass = txtpass.Text;

            foreach (string item in File.ReadAllLines(rutaArchivo, System.Text.Encoding.Default))
            {
                string[] datos = item.Split('&');
                string.Format(datos[0], datos[1], datos[2], datos[3], datos[4], datos[5], datos[6], datos[7], datos[8]);
                if (datos[2].Equals(busquedauser) && datos[0].Equals(busquedPass))
                {
                    Admin admin = new Admin();
                    admin.Show();
                    btnLoguin.BackColor = Color.FromArgb(12, 61, 92);
                
                }
            }
        }
    }
}