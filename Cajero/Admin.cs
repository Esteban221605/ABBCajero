using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cajero
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }
        #region funcinalidades del formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelContainer.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
        //Metodo para abrir formulario
        private void Abrirformulario<Miform>() where Miform : Form, new() {
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
        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Form1"] == null)
                btnAddCliente.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Form2"] == null)
                btnAddSucursal.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Form3"] == null)
                btnCrearCuentasBancarias.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Form4"] == null)
                btnLisClienteSaldoActual.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Form3"] == null)
               btnLisCliPorSucursal.BackColor = Color.FromArgb(4, 41, 68);
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            Abrirformulario<AddClientes>();
            btnAddCliente.BackColor = Color.FromArgb(12,61,92);
        }

        private void btnAddSucursal_Click(object sender, EventArgs e)
        {
            Abrirformulario<AddSucursal>();
            btnAddSucursal.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void btnCrearCuentasBancarias_Click(object sender, EventArgs e)
        {
            Abrirformulario<CrearCuentasBancarias>();
            btnCrearCuentasBancarias.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void btnLisCliPorSucursal_Click(object sender, EventArgs e)
        {
            Abrirformulario<ListarClientesPorSucursalcs>();
            btnLisCliPorSucursal.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void btnLisClienteSaldoActual_Click(object sender, EventArgs e)
        {
            Abrirformulario<ListarClienteConSaldoActual>();
            btnLisClienteSaldoActual.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            
        }
    }
}
