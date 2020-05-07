namespace Cajero
{
    partial class CrearCuentasBancarias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearCuentasBancarias));
            this.dataGridViewListarCuenta = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codsucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelarCreacion = new System.Windows.Forms.Button();
            this.btnListarCuentas = new System.Windows.Forms.Button();
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FechaIni = new System.Windows.Forms.Label();
            this.txtsaldoInicial = new System.Windows.Forms.TextBox();
            this.txtIDcliente = new System.Windows.Forms.TextBox();
            this.txtCodSucursal = new System.Windows.Forms.TextBox();
            this.txtCrearCuenta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListarCuenta)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewListarCuenta
            // 
            this.dataGridViewListarCuenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dataGridViewListarCuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListarCuenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Apellido,
            this.Direccion,
            this.Telefono,
            this.Ciudad,
            this.Codsucursal,
            this.Cuenta,
            this.saldo});
            this.dataGridViewListarCuenta.Location = new System.Drawing.Point(42, 32);
            this.dataGridViewListarCuenta.Name = "dataGridViewListarCuenta";
            this.dataGridViewListarCuenta.Size = new System.Drawing.Size(942, 297);
            this.dataGridViewListarCuenta.TabIndex = 23;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "ID_Cliente";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direcciòn";
            this.Direccion.Name = "Direccion";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // Ciudad
            // 
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.Name = "Ciudad";
            // 
            // Codsucursal
            // 
            this.Codsucursal.HeaderText = "Cod_Sucursal";
            this.Codsucursal.Name = "Codsucursal";
            // 
            // Cuenta
            // 
            this.Cuenta.HeaderText = "Cuenta";
            this.Cuenta.Name = "Cuenta";
            // 
            // saldo
            // 
            this.saldo.HeaderText = "Saldo";
            this.saldo.Name = "saldo";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.dataGridViewListarCuenta);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1056, 446);
            this.panel2.TabIndex = 27;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.SeaGreen;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 248);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 16);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.btnCancelarCreacion);
            this.panel1.Controls.Add(this.btnListarCuentas);
            this.panel1.Controls.Add(this.btnCrearCuenta);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.FechaIni);
            this.panel1.Controls.Add(this.txtsaldoInicial);
            this.panel1.Controls.Add(this.txtIDcliente);
            this.panel1.Controls.Add(this.txtCodSucursal);
            this.panel1.Controls.Add(this.txtCrearCuenta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(0, 446);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 98);
            this.panel1.TabIndex = 26;
            // 
            // btnCancelarCreacion
            // 
            this.btnCancelarCreacion.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCancelarCreacion.FlatAppearance.BorderSize = 0;
            this.btnCancelarCreacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnCancelarCreacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnCancelarCreacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCreacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCreacion.ForeColor = System.Drawing.Color.LightGray;
            this.btnCancelarCreacion.Location = new System.Drawing.Point(682, 9);
            this.btnCancelarCreacion.Name = "btnCancelarCreacion";
            this.btnCancelarCreacion.Size = new System.Drawing.Size(144, 39);
            this.btnCancelarCreacion.TabIndex = 23;
            this.btnCancelarCreacion.Text = "CANCELAR";
            this.btnCancelarCreacion.UseVisualStyleBackColor = false;
            this.btnCancelarCreacion.Click += new System.EventHandler(this.btnCancelarCreacion_Click);
            // 
            // btnListarCuentas
            // 
            this.btnListarCuentas.BackColor = System.Drawing.Color.SeaGreen;
            this.btnListarCuentas.FlatAppearance.BorderSize = 0;
            this.btnListarCuentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnListarCuentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnListarCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarCuentas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarCuentas.ForeColor = System.Drawing.Color.LightGray;
            this.btnListarCuentas.Location = new System.Drawing.Point(532, 52);
            this.btnListarCuentas.Name = "btnListarCuentas";
            this.btnListarCuentas.Size = new System.Drawing.Size(144, 39);
            this.btnListarCuentas.TabIndex = 22;
            this.btnListarCuentas.Text = "LISTAR";
            this.btnListarCuentas.UseVisualStyleBackColor = false;
            this.btnListarCuentas.Click += new System.EventHandler(this.btnListarCuentas_Click);
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCrearCuenta.FlatAppearance.BorderSize = 0;
            this.btnCrearCuenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnCrearCuenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnCrearCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearCuenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCuenta.ForeColor = System.Drawing.Color.LightGray;
            this.btnCrearCuenta.Location = new System.Drawing.Point(532, 9);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(144, 39);
            this.btnCrearCuenta.TabIndex = 21;
            this.btnCrearCuenta.Text = "CREAR";
            this.btnCrearCuenta.UseVisualStyleBackColor = false;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID Cleinte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cuenta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(275, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cod_Sucursal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(275, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Saldo Inicial";
            // 
            // FechaIni
            // 
            this.FechaIni.AutoSize = true;
            this.FechaIni.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaIni.ForeColor = System.Drawing.Color.LightGray;
            this.FechaIni.Location = new System.Drawing.Point(931, 9);
            this.FechaIni.Name = "FechaIni";
            this.FechaIni.Size = new System.Drawing.Size(81, 21);
            this.FechaIni.TabIndex = 10;
            this.FechaIni.Text = "Fecha Ini";
            // 
            // txtsaldoInicial
            // 
            this.txtsaldoInicial.Location = new System.Drawing.Point(396, 52);
            this.txtsaldoInicial.Name = "txtsaldoInicial";
            this.txtsaldoInicial.Size = new System.Drawing.Size(115, 27);
            this.txtsaldoInicial.TabIndex = 15;
            this.txtsaldoInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsaldoInicial_KeyPress);
            // 
            // txtIDcliente
            // 
            this.txtIDcliente.Location = new System.Drawing.Point(133, 12);
            this.txtIDcliente.Name = "txtIDcliente";
            this.txtIDcliente.Size = new System.Drawing.Size(115, 27);
            this.txtIDcliente.TabIndex = 12;
            this.txtIDcliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDcliente_KeyPress);
            // 
            // txtCodSucursal
            // 
            this.txtCodSucursal.Location = new System.Drawing.Point(396, 12);
            this.txtCodSucursal.Name = "txtCodSucursal";
            this.txtCodSucursal.Size = new System.Drawing.Size(115, 27);
            this.txtCodSucursal.TabIndex = 14;
            this.txtCodSucursal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodSucursal_KeyPress);
            // 
            // txtCrearCuenta
            // 
            this.txtCrearCuenta.Location = new System.Drawing.Point(133, 55);
            this.txtCrearCuenta.Name = "txtCrearCuenta";
            this.txtCrearCuenta.Size = new System.Drawing.Size(115, 27);
            this.txtCrearCuenta.TabIndex = 13;
            this.txtCrearCuenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCrearCuenta_KeyPress);
            // 
            // CrearCuentasBancarias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 544);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrearCuentasBancarias";
            this.Text = "CrearCuentasBancarias";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListarCuenta)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label FechaIni;
        private System.Windows.Forms.TextBox txtsaldoInicial;
        private System.Windows.Forms.TextBox txtIDcliente;
        private System.Windows.Forms.TextBox txtCodSucursal;
        private System.Windows.Forms.TextBox txtCrearCuenta;
        private System.Windows.Forms.Button btnCancelarCreacion;
        private System.Windows.Forms.Button btnListarCuentas;
        private System.Windows.Forms.Button btnCrearCuenta;
        public System.Windows.Forms.DataGridView dataGridViewListarCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codsucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}