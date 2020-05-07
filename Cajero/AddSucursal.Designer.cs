namespace Cajero
{
    partial class AddSucursal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSucursal));
            this.dataGridViewAddSucursal = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelarSucursal = new System.Windows.Forms.Button();
            this.btnListarSucursal = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCrearSucursal = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCiudad_suc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefono_suc = new System.Windows.Forms.TextBox();
            this.txtDireccion_Suc = new System.Windows.Forms.TextBox();
            this.txtcodigoSucursual = new System.Windows.Forms.TextBox();
            this.txtNomSucursal = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddSucursal)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAddSucursal
            // 
            this.dataGridViewAddSucursal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dataGridViewAddSucursal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddSucursal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre,
            this.direccion,
            this.telefono,
            this.ciudad});
            this.dataGridViewAddSucursal.Location = new System.Drawing.Point(114, 12);
            this.dataGridViewAddSucursal.Name = "dataGridViewAddSucursal";
            this.dataGridViewAddSucursal.Size = new System.Drawing.Size(544, 485);
            this.dataGridViewAddSucursal.TabIndex = 23;
            this.dataGridViewAddSucursal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAddSucursal_CellContentClick);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo_Suc";
            this.codigo.Name = "codigo";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre_Suc";
            this.nombre.Name = "nombre";
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Direcciòn_Suc";
            this.direccion.Name = "direccion";
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Telefono_Suc";
            this.telefono.Name = "telefono";
            // 
            // ciudad
            // 
            this.ciudad.HeaderText = "Ciudad_Suc";
            this.ciudad.Name = "ciudad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Codigo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnCancelarSucursal);
            this.panel1.Controls.Add(this.btnListarSucursal);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnCrearSucursal);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtCiudad_suc);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtTelefono_suc);
            this.panel1.Controls.Add(this.txtDireccion_Suc);
            this.panel1.Controls.Add(this.txtcodigoSucursual);
            this.panel1.Controls.Add(this.txtNomSucursal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(739, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 544);
            this.panel1.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nom_Suc";
            // 
            // btnCancelarSucursal
            // 
            this.btnCancelarSucursal.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCancelarSucursal.FlatAppearance.BorderSize = 0;
            this.btnCancelarSucursal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnCancelarSucursal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnCancelarSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarSucursal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarSucursal.ForeColor = System.Drawing.Color.LightGray;
            this.btnCancelarSucursal.Location = new System.Drawing.Point(79, 448);
            this.btnCancelarSucursal.Name = "btnCancelarSucursal";
            this.btnCancelarSucursal.Size = new System.Drawing.Size(144, 39);
            this.btnCancelarSucursal.TabIndex = 20;
            this.btnCancelarSucursal.Text = "CANCELAR";
            this.btnCancelarSucursal.UseVisualStyleBackColor = false;
            this.btnCancelarSucursal.Click += new System.EventHandler(this.btnCancelarSucursal_Click);
            // 
            // btnListarSucursal
            // 
            this.btnListarSucursal.BackColor = System.Drawing.Color.SeaGreen;
            this.btnListarSucursal.FlatAppearance.BorderSize = 0;
            this.btnListarSucursal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnListarSucursal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnListarSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarSucursal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarSucursal.ForeColor = System.Drawing.Color.LightGray;
            this.btnListarSucursal.Location = new System.Drawing.Point(79, 375);
            this.btnListarSucursal.Name = "btnListarSucursal";
            this.btnListarSucursal.Size = new System.Drawing.Size(144, 39);
            this.btnListarSucursal.TabIndex = 19;
            this.btnListarSucursal.Text = "LISTAR";
            this.btnListarSucursal.UseVisualStyleBackColor = false;
            this.btnListarSucursal.Click += new System.EventHandler(this.btnListarSucursal_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Direcciòn";
            // 
            // btnCrearSucursal
            // 
            this.btnCrearSucursal.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCrearSucursal.FlatAppearance.BorderSize = 0;
            this.btnCrearSucursal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnCrearSucursal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnCrearSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearSucursal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearSucursal.ForeColor = System.Drawing.Color.LightGray;
            this.btnCrearSucursal.Location = new System.Drawing.Point(79, 300);
            this.btnCrearSucursal.Name = "btnCrearSucursal";
            this.btnCrearSucursal.Size = new System.Drawing.Size(144, 39);
            this.btnCrearSucursal.TabIndex = 18;
            this.btnCrearSucursal.Text = "CREAR";
            this.btnCrearSucursal.UseVisualStyleBackColor = false;
            this.btnCrearSucursal.Click += new System.EventHandler(this.btnCrearSucursal_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(12, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefono";
            // 
            // txtCiudad_suc
            // 
            this.txtCiudad_suc.Location = new System.Drawing.Point(108, 239);
            this.txtCiudad_suc.Name = "txtCiudad_suc";
            this.txtCiudad_suc.Size = new System.Drawing.Size(115, 27);
            this.txtCiudad_suc.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(12, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ciudad";
            // 
            // txtTelefono_suc
            // 
            this.txtTelefono_suc.Location = new System.Drawing.Point(108, 180);
            this.txtTelefono_suc.Name = "txtTelefono_suc";
            this.txtTelefono_suc.Size = new System.Drawing.Size(115, 27);
            this.txtTelefono_suc.TabIndex = 16;
            // 
            // txtDireccion_Suc
            // 
            this.txtDireccion_Suc.Location = new System.Drawing.Point(108, 123);
            this.txtDireccion_Suc.Name = "txtDireccion_Suc";
            this.txtDireccion_Suc.Size = new System.Drawing.Size(115, 27);
            this.txtDireccion_Suc.TabIndex = 15;
            // 
            // txtcodigoSucursual
            // 
            this.txtcodigoSucursual.Location = new System.Drawing.Point(108, 12);
            this.txtcodigoSucursual.Name = "txtcodigoSucursual";
            this.txtcodigoSucursual.Size = new System.Drawing.Size(115, 27);
            this.txtcodigoSucursual.TabIndex = 12;
            this.txtcodigoSucursual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigoSucursual_KeyPress);
            // 
            // txtNomSucursal
            // 
            this.txtNomSucursal.Location = new System.Drawing.Point(108, 67);
            this.txtNomSucursal.Name = "txtNomSucursal";
            this.txtNomSucursal.Size = new System.Drawing.Size(115, 27);
            this.txtNomSucursal.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.dataGridViewAddSucursal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(739, 544);
            this.panel2.TabIndex = 25;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.SeaGreen;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 154);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 16);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // AddSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 544);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddSucursal";
            this.Text = "AddSucursal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddSucursal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelarSucursal;
        private System.Windows.Forms.Button btnListarSucursal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCrearSucursal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCiudad_suc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefono_suc;
        private System.Windows.Forms.TextBox txtDireccion_Suc;
        private System.Windows.Forms.TextBox txtcodigoSucursual;
        private System.Windows.Forms.TextBox txtNomSucursal;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView dataGridViewAddSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudad;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}