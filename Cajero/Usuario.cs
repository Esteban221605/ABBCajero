using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Cajero
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnCerarr_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Abrirformulario<Miform>() where Miform : Form, new()
        {
            Form formulario;
            formulario = panelFormularios.Controls.OfType<Miform>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new Miform();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            else
            {
                formulario.BringToFront();
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Form1"] == null)
                btnConsignar.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Form2"] == null)
                btnRetirar.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Form3"] == null)
                btnTransferrir.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Form3"] == null)
                btnEstadofactura.BackColor = Color.FromArgb(4, 41, 68);
        }

        private void btnConsignar_Click(object sender, EventArgs e)
        {
            Abrirformulario<Consignar>();
            btnConsignar.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            Abrirformulario<Retirar>();
            btnRetirar.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void btnTransferrir_Click(object sender, EventArgs e)
        {
            Abrirformulario<Transferencia>();
            btnTransferrir.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void btnEstadofactura_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura();
            Abrirformulario<Factura>();
            btnEstadofactura.BackColor = Color.FromArgb(12, 61, 92);
            factura.Registro();
        }

    }
}

