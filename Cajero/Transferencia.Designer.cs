namespace Cajero
{
    partial class Transferencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transferencia));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnContinua = new System.Windows.Forms.Button();
            this.txtMontoAtrasferir = new System.Windows.Forms.TextBox();
            this.txtCuentaDestino = new System.Windows.Forms.TextBox();
            this.txtCuentaOrigen = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnContinua);
            this.panel2.Controls.Add(this.txtMontoAtrasferir);
            this.panel2.Controls.Add(this.txtCuentaDestino);
            this.panel2.Controls.Add(this.txtCuentaOrigen);
            this.panel2.Controls.Add(this.shapeContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(806, 570);
            this.panel2.TabIndex = 29;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.SeaGreen;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 299);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 16);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaGreen;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.LightGray;
            this.button2.Location = new System.Drawing.Point(428, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 39);
            this.button2.TabIndex = 20;
            this.button2.Text = "CANCELAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnContinua
            // 
            this.btnContinua.BackColor = System.Drawing.Color.SeaGreen;
            this.btnContinua.FlatAppearance.BorderSize = 0;
            this.btnContinua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnContinua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnContinua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinua.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinua.ForeColor = System.Drawing.Color.LightGray;
            this.btnContinua.Location = new System.Drawing.Point(247, 347);
            this.btnContinua.Name = "btnContinua";
            this.btnContinua.Size = new System.Drawing.Size(144, 39);
            this.btnContinua.TabIndex = 19;
            this.btnContinua.Text = "CONTINUAR";
            this.btnContinua.UseVisualStyleBackColor = false;
            this.btnContinua.Click += new System.EventHandler(this.btnContinua_Click);
            // 
            // txtMontoAtrasferir
            // 
            this.txtMontoAtrasferir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtMontoAtrasferir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMontoAtrasferir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoAtrasferir.ForeColor = System.Drawing.Color.DimGray;
            this.txtMontoAtrasferir.Location = new System.Drawing.Point(203, 224);
            this.txtMontoAtrasferir.Name = "txtMontoAtrasferir";
            this.txtMontoAtrasferir.Size = new System.Drawing.Size(401, 20);
            this.txtMontoAtrasferir.TabIndex = 5;
            this.txtMontoAtrasferir.Text = "MONTO A TRANSFERIR";
            this.txtMontoAtrasferir.Enter += new System.EventHandler(this.txtMontoAtrasferir_Enter);
            this.txtMontoAtrasferir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuentaOrigen_KeyPress);
            this.txtMontoAtrasferir.Leave += new System.EventHandler(this.txtMontoAtrasferir_Leave);
            // 
            // txtCuentaDestino
            // 
            this.txtCuentaDestino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtCuentaDestino.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCuentaDestino.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuentaDestino.ForeColor = System.Drawing.Color.DimGray;
            this.txtCuentaDestino.Location = new System.Drawing.Point(200, 167);
            this.txtCuentaDestino.Name = "txtCuentaDestino";
            this.txtCuentaDestino.Size = new System.Drawing.Size(401, 20);
            this.txtCuentaDestino.TabIndex = 4;
            this.txtCuentaDestino.Text = "CUENTA A TRASNFERIR";
            this.txtCuentaDestino.Enter += new System.EventHandler(this.txtCuentaDestino_Enter);
            this.txtCuentaDestino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuentaOrigen_KeyPress);
            this.txtCuentaDestino.Leave += new System.EventHandler(this.txtCuentaDestino_Leave);
            // 
            // txtCuentaOrigen
            // 
            this.txtCuentaOrigen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtCuentaOrigen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCuentaOrigen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuentaOrigen.ForeColor = System.Drawing.Color.DimGray;
            this.txtCuentaOrigen.Location = new System.Drawing.Point(203, 114);
            this.txtCuentaOrigen.Name = "txtCuentaOrigen";
            this.txtCuentaOrigen.Size = new System.Drawing.Size(401, 20);
            this.txtCuentaOrigen.TabIndex = 2;
            this.txtCuentaOrigen.Text = "CUENTA DE ORIGEN";
            this.txtCuentaOrigen.Enter += new System.EventHandler(this.txtCuentaOrigen_Enter);
            this.txtCuentaOrigen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuentaOrigen_KeyPress);
            this.txtCuentaOrigen.Leave += new System.EventHandler(this.txtCuentaOrigen_Leave);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(806, 570);
            this.shapeContainer1.TabIndex = 3;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 199;
            this.lineShape3.X2 = 599;
            this.lineShape3.Y1 = 143;
            this.lineShape3.Y2 = 143;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 203;
            this.lineShape2.X2 = 603;
            this.lineShape2.Y1 = 253;
            this.lineShape2.Y2 = 253;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 200;
            this.lineShape1.X2 = 600;
            this.lineShape1.Y1 = 195;
            this.lineShape1.Y2 = 195;
            // 
            // Transferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 570);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Transferencia";
            this.Opacity = 0.9D;
            this.Text = "Transferencia";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCuentaOrigen;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox txtMontoAtrasferir;
        private System.Windows.Forms.TextBox txtCuentaDestino;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Button btnContinua;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}