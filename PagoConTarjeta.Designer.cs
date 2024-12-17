namespace ProyectoFinal_EDRM_ProgramacionII
{
    partial class PagoConTarjeta
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
            this.FormTarjeta_Nombre = new System.Windows.Forms.TextBox();
            this.FormTarjeta_txtClave = new System.Windows.Forms.TextBox();
            this.FormTarjeta_txtCVV = new System.Windows.Forms.TextBox();
            this.FormPagar_BtnRecibo = new System.Windows.Forms.Button();
            this.FormsPago_txtNombre = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // FormTarjeta_Nombre
            // 
            this.FormTarjeta_Nombre.BackColor = System.Drawing.SystemColors.Menu;
            this.FormTarjeta_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FormTarjeta_Nombre.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTarjeta_Nombre.Location = new System.Drawing.Point(448, 327);
            this.FormTarjeta_Nombre.Multiline = true;
            this.FormTarjeta_Nombre.Name = "FormTarjeta_Nombre";
            this.FormTarjeta_Nombre.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.FormTarjeta_Nombre.Size = new System.Drawing.Size(337, 36);
            this.FormTarjeta_Nombre.TabIndex = 0;
            // 
            // FormTarjeta_txtClave
            // 
            this.FormTarjeta_txtClave.BackColor = System.Drawing.SystemColors.Menu;
            this.FormTarjeta_txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FormTarjeta_txtClave.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTarjeta_txtClave.Location = new System.Drawing.Point(448, 413);
            this.FormTarjeta_txtClave.Multiline = true;
            this.FormTarjeta_txtClave.Name = "FormTarjeta_txtClave";
            this.FormTarjeta_txtClave.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.FormTarjeta_txtClave.Size = new System.Drawing.Size(337, 36);
            this.FormTarjeta_txtClave.TabIndex = 1;
            // 
            // FormTarjeta_txtCVV
            // 
            this.FormTarjeta_txtCVV.BackColor = System.Drawing.SystemColors.Menu;
            this.FormTarjeta_txtCVV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FormTarjeta_txtCVV.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTarjeta_txtCVV.Location = new System.Drawing.Point(448, 495);
            this.FormTarjeta_txtCVV.Multiline = true;
            this.FormTarjeta_txtCVV.Name = "FormTarjeta_txtCVV";
            this.FormTarjeta_txtCVV.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.FormTarjeta_txtCVV.Size = new System.Drawing.Size(337, 36);
            this.FormTarjeta_txtCVV.TabIndex = 2;
            // 
            // FormPagar_BtnRecibo
            // 
            this.FormPagar_BtnRecibo.BackColor = System.Drawing.Color.Transparent;
            this.FormPagar_BtnRecibo.FlatAppearance.BorderSize = 0;
            this.FormPagar_BtnRecibo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.FormPagar_BtnRecibo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.FormPagar_BtnRecibo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormPagar_BtnRecibo.Location = new System.Drawing.Point(492, 575);
            this.FormPagar_BtnRecibo.Name = "FormPagar_BtnRecibo";
            this.FormPagar_BtnRecibo.Size = new System.Drawing.Size(246, 38);
            this.FormPagar_BtnRecibo.TabIndex = 3;
            this.FormPagar_BtnRecibo.UseVisualStyleBackColor = false;
            this.FormPagar_BtnRecibo.Click += new System.EventHandler(this.FormPagar_BtnRecibo_Click);
            // 
            // FormsPago_txtNombre
            // 
            this.FormsPago_txtNombre.BackColor = System.Drawing.SystemColors.Menu;
            this.FormsPago_txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FormsPago_txtNombre.Enabled = false;
            this.FormsPago_txtNombre.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormsPago_txtNombre.Location = new System.Drawing.Point(949, 68);
            this.FormsPago_txtNombre.Name = "FormsPago_txtNombre";
            this.FormsPago_txtNombre.Size = new System.Drawing.Size(120, 35);
            this.FormsPago_txtNombre.TabIndex = 12;
            this.FormsPago_txtNombre.Text = "";
            this.FormsPago_txtNombre.TextChanged += new System.EventHandler(this.FormsPago_txtNombre_TextChanged);
            // 
            // PagoConTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal_EDRM_ProgramacionII.Properties.Resources.OverlaysPlagoFin;
            this.ClientSize = new System.Drawing.Size(1224, 641);
            this.Controls.Add(this.FormsPago_txtNombre);
            this.Controls.Add(this.FormPagar_BtnRecibo);
            this.Controls.Add(this.FormTarjeta_txtCVV);
            this.Controls.Add(this.FormTarjeta_txtClave);
            this.Controls.Add(this.FormTarjeta_Nombre);
            this.Name = "PagoConTarjeta";
            this.Text = "PagoConTarjeta";
            this.Load += new System.EventHandler(this.PagoConTarjeta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FormTarjeta_Nombre;
        private System.Windows.Forms.TextBox FormTarjeta_txtClave;
        private System.Windows.Forms.TextBox FormTarjeta_txtCVV;
        private System.Windows.Forms.Button FormPagar_BtnRecibo;
        private System.Windows.Forms.RichTextBox FormsPago_txtNombre;
    }
}