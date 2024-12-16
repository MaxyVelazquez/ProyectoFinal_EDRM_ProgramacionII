namespace ProyectoFinal_EDRM_ProgramacionII
{
    partial class FormsCreditos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonFormsCreditos_Iniciar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFormsCreditos_Iniciar
            // 
            this.buttonFormsCreditos_Iniciar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFormsCreditos_Iniciar.BackColor = System.Drawing.Color.Transparent;
            this.buttonFormsCreditos_Iniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFormsCreditos_Iniciar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.buttonFormsCreditos_Iniciar.FlatAppearance.BorderSize = 0;
            this.buttonFormsCreditos_Iniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonFormsCreditos_Iniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonFormsCreditos_Iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFormsCreditos_Iniciar.Location = new System.Drawing.Point(375, 552);
            this.buttonFormsCreditos_Iniciar.Name = "buttonFormsCreditos_Iniciar";
            this.buttonFormsCreditos_Iniciar.Size = new System.Drawing.Size(239, 43);
            this.buttonFormsCreditos_Iniciar.TabIndex = 0;
            this.buttonFormsCreditos_Iniciar.UseVisualStyleBackColor = false;
            this.buttonFormsCreditos_Iniciar.Click += new System.EventHandler(this.buttonFormsCreditos_Iniciar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(629, 552);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 43);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormsCreditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::ProyectoFinal_EDRM_ProgramacionII.Properties.Resources.Over_Creditos1;
            this.ClientSize = new System.Drawing.Size(1224, 641);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonFormsCreditos_Iniciar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormsCreditos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormsCreditos";
            this.Load += new System.EventHandler(this.FormsCreditos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFormsCreditos_Iniciar;
        private System.Windows.Forms.Button button1;
    }
}

