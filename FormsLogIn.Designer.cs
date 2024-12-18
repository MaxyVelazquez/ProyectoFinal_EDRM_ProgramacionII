namespace ProyectoFinal_EDRM_ProgramacionII
{
    partial class FormsLogIn
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
            this.components = new System.ComponentModel.Container();
            this.FormsLogIn_txtNombre = new System.Windows.Forms.RichTextBox();
            this.FormsLogIn_txtContraseña = new System.Windows.Forms.RichTextBox();
            this.FormsLogIn_IniciarSesion = new System.Windows.Forms.Button();
            this.bttInvitado = new System.Windows.Forms.Button();
            this.bttSalir = new System.Windows.Forms.Button();
            this.FormLog_lblfecha = new System.Windows.Forms.Label();
            this.FormLog_lblhora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // FormsLogIn_txtNombre
            // 
            this.FormsLogIn_txtNombre.BackColor = System.Drawing.SystemColors.Menu;
            this.FormsLogIn_txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FormsLogIn_txtNombre.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormsLogIn_txtNombre.Location = new System.Drawing.Point(447, 332);
            this.FormsLogIn_txtNombre.Name = "FormsLogIn_txtNombre";
            this.FormsLogIn_txtNombre.ShowSelectionMargin = true;
            this.FormsLogIn_txtNombre.Size = new System.Drawing.Size(361, 32);
            this.FormsLogIn_txtNombre.TabIndex = 0;
            this.FormsLogIn_txtNombre.TabStop = false;
            this.FormsLogIn_txtNombre.Text = "";
            this.FormsLogIn_txtNombre.TextChanged += new System.EventHandler(this.FormsLogIn_txtNombre_TextChanged);
            // 
            // FormsLogIn_txtContraseña
            // 
            this.FormsLogIn_txtContraseña.BackColor = System.Drawing.SystemColors.Menu;
            this.FormsLogIn_txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FormsLogIn_txtContraseña.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormsLogIn_txtContraseña.Location = new System.Drawing.Point(447, 420);
            this.FormsLogIn_txtContraseña.Name = "FormsLogIn_txtContraseña";
            this.FormsLogIn_txtContraseña.ShowSelectionMargin = true;
            this.FormsLogIn_txtContraseña.Size = new System.Drawing.Size(373, 31);
            this.FormsLogIn_txtContraseña.TabIndex = 1;
            this.FormsLogIn_txtContraseña.TabStop = false;
            this.FormsLogIn_txtContraseña.Text = "";
            this.FormsLogIn_txtContraseña.TextChanged += new System.EventHandler(this.FormsLogIn_txtContraseña_TextChanged);
            // 
            // FormsLogIn_IniciarSesion
            // 
            this.FormsLogIn_IniciarSesion.BackColor = System.Drawing.Color.Transparent;
            this.FormsLogIn_IniciarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FormsLogIn_IniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormsLogIn_IniciarSesion.FlatAppearance.BorderSize = 0;
            this.FormsLogIn_IniciarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.FormsLogIn_IniciarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.FormsLogIn_IniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormsLogIn_IniciarSesion.Location = new System.Drawing.Point(430, 476);
            this.FormsLogIn_IniciarSesion.Name = "FormsLogIn_IniciarSesion";
            this.FormsLogIn_IniciarSesion.Size = new System.Drawing.Size(195, 33);
            this.FormsLogIn_IniciarSesion.TabIndex = 2;
            this.FormsLogIn_IniciarSesion.UseVisualStyleBackColor = false;
            this.FormsLogIn_IniciarSesion.Click += new System.EventHandler(this.FormsLogIn_IniciarSesion_Click);
            // 
            // bttInvitado
            // 
            this.bttInvitado.BackColor = System.Drawing.Color.Transparent;
            this.bttInvitado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttInvitado.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.bttInvitado.FlatAppearance.BorderSize = 0;
            this.bttInvitado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bttInvitado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bttInvitado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttInvitado.Location = new System.Drawing.Point(640, 476);
            this.bttInvitado.Margin = new System.Windows.Forms.Padding(2);
            this.bttInvitado.Name = "bttInvitado";
            this.bttInvitado.Size = new System.Drawing.Size(193, 33);
            this.bttInvitado.TabIndex = 3;
            this.bttInvitado.UseVisualStyleBackColor = false;
            this.bttInvitado.Click += new System.EventHandler(this.bttInvitado_Click);
            // 
            // bttSalir
            // 
            this.bttSalir.BackColor = System.Drawing.Color.Transparent;
            this.bttSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttSalir.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.bttSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bttSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bttSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttSalir.Location = new System.Drawing.Point(1126, 55);
            this.bttSalir.Margin = new System.Windows.Forms.Padding(2);
            this.bttSalir.Name = "bttSalir";
            this.bttSalir.Size = new System.Drawing.Size(50, 41);
            this.bttSalir.TabIndex = 4;
            this.bttSalir.UseVisualStyleBackColor = false;
            this.bttSalir.Click += new System.EventHandler(this.bttSalir_Click);
            // 
            // FormLog_lblfecha
            // 
            this.FormLog_lblfecha.AutoSize = true;
            this.FormLog_lblfecha.BackColor = System.Drawing.Color.Transparent;
            this.FormLog_lblfecha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormLog_lblfecha.Location = new System.Drawing.Point(742, 83);
            this.FormLog_lblfecha.Name = "FormLog_lblfecha";
            this.FormLog_lblfecha.Size = new System.Drawing.Size(0, 15);
            this.FormLog_lblfecha.TabIndex = 5;
            // 
            // FormLog_lblhora
            // 
            this.FormLog_lblhora.AutoSize = true;
            this.FormLog_lblhora.BackColor = System.Drawing.Color.Transparent;
            this.FormLog_lblhora.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormLog_lblhora.Location = new System.Drawing.Point(916, 83);
            this.FormLog_lblhora.Name = "FormLog_lblhora";
            this.FormLog_lblhora.Size = new System.Drawing.Size(0, 15);
            this.FormLog_lblhora.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormsLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = global::ProyectoFinal_EDRM_ProgramacionII.Properties.Resources.Over_LogIn1;
            this.ClientSize = new System.Drawing.Size(1224, 641);
            this.Controls.Add(this.FormLog_lblhora);
            this.Controls.Add(this.FormLog_lblfecha);
            this.Controls.Add(this.bttSalir);
            this.Controls.Add(this.bttInvitado);
            this.Controls.Add(this.FormsLogIn_IniciarSesion);
            this.Controls.Add(this.FormsLogIn_txtContraseña);
            this.Controls.Add(this.FormsLogIn_txtNombre);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name = "FormsLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormsLogIn";
            this.Load += new System.EventHandler(this.FormsLogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox FormsLogIn_txtNombre;
        private System.Windows.Forms.RichTextBox FormsLogIn_txtContraseña;
        private System.Windows.Forms.Button FormsLogIn_IniciarSesion;
        private System.Windows.Forms.Button bttInvitado;
        private System.Windows.Forms.Button bttSalir;
        private System.Windows.Forms.Label FormLog_lblfecha;
        private System.Windows.Forms.Label FormLog_lblhora;
        private System.Windows.Forms.Timer timer1;
    }
}