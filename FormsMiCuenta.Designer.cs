namespace ProyectoFinal_EDRM_ProgramacionII
{
    partial class FormsMiCuenta
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
            this.FormsMiCuenta_txtNombre = new System.Windows.Forms.RichTextBox();
            this.FormsMiCuenta_buttonRegresar = new System.Windows.Forms.Button();
            this.FormsMiCuenta_txtContraseña = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // FormsMiCuenta_txtNombre
            // 
            this.FormsMiCuenta_txtNombre.BackColor = System.Drawing.SystemColors.Menu;
            this.FormsMiCuenta_txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FormsMiCuenta_txtNombre.Enabled = false;
            this.FormsMiCuenta_txtNombre.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormsMiCuenta_txtNombre.Location = new System.Drawing.Point(443, 237);
            this.FormsMiCuenta_txtNombre.Name = "FormsMiCuenta_txtNombre";
            this.FormsMiCuenta_txtNombre.Size = new System.Drawing.Size(356, 45);
            this.FormsMiCuenta_txtNombre.TabIndex = 0;
            this.FormsMiCuenta_txtNombre.Text = "";
            this.FormsMiCuenta_txtNombre.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // FormsMiCuenta_buttonRegresar
            // 
            this.FormsMiCuenta_buttonRegresar.BackColor = System.Drawing.Color.Transparent;
            this.FormsMiCuenta_buttonRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormsMiCuenta_buttonRegresar.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuBar;
            this.FormsMiCuenta_buttonRegresar.FlatAppearance.BorderSize = 0;
            this.FormsMiCuenta_buttonRegresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.FormsMiCuenta_buttonRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.FormsMiCuenta_buttonRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormsMiCuenta_buttonRegresar.Location = new System.Drawing.Point(1125, 55);
            this.FormsMiCuenta_buttonRegresar.Name = "FormsMiCuenta_buttonRegresar";
            this.FormsMiCuenta_buttonRegresar.Size = new System.Drawing.Size(54, 42);
            this.FormsMiCuenta_buttonRegresar.TabIndex = 1;
            this.FormsMiCuenta_buttonRegresar.UseVisualStyleBackColor = false;
            this.FormsMiCuenta_buttonRegresar.Click += new System.EventHandler(this.FormsMiCuenta_buttonRegresar_Click);
            // 
            // FormsMiCuenta_txtContraseña
            // 
            this.FormsMiCuenta_txtContraseña.BackColor = System.Drawing.SystemColors.Menu;
            this.FormsMiCuenta_txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FormsMiCuenta_txtContraseña.Enabled = false;
            this.FormsMiCuenta_txtContraseña.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormsMiCuenta_txtContraseña.Location = new System.Drawing.Point(443, 323);
            this.FormsMiCuenta_txtContraseña.Name = "FormsMiCuenta_txtContraseña";
            this.FormsMiCuenta_txtContraseña.Size = new System.Drawing.Size(356, 45);
            this.FormsMiCuenta_txtContraseña.TabIndex = 2;
            this.FormsMiCuenta_txtContraseña.Text = "";
            // 
            // FormsMiCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal_EDRM_ProgramacionII.Properties.Resources.Over_MiCuenta;
            this.ClientSize = new System.Drawing.Size(1224, 641);
            this.Controls.Add(this.FormsMiCuenta_txtContraseña);
            this.Controls.Add(this.FormsMiCuenta_buttonRegresar);
            this.Controls.Add(this.FormsMiCuenta_txtNombre);
            this.Name = "FormsMiCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormsMiCuenta";
            this.Load += new System.EventHandler(this.FormsMiCuenta_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox FormsMiCuenta_txtNombre;
        private System.Windows.Forms.Button FormsMiCuenta_buttonRegresar;
        private System.Windows.Forms.RichTextBox FormsMiCuenta_txtContraseña;
    }
}