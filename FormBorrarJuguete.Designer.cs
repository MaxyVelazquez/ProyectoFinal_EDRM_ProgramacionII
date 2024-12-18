namespace ProyectoFinal_EDRM_ProgramacionII
{
    partial class FormBorrarJuguete
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
            this.lContinuar = new System.Windows.Forms.Label();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lNombre = new System.Windows.Forms.Label();
            this.lId = new System.Windows.Forms.Label();
            this.lDescripcion = new System.Windows.Forms.Label();
            this.FormBorrar_lblfecha = new System.Windows.Forms.Label();
            this.FormBorrar_lblhora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lContinuar
            // 
            this.lContinuar.BackColor = System.Drawing.Color.Transparent;
            this.lContinuar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lContinuar.Location = new System.Drawing.Point(526, 484);
            this.lContinuar.Name = "lContinuar";
            this.lContinuar.Size = new System.Drawing.Size(288, 28);
            this.lContinuar.TabIndex = 0;
            this.lContinuar.Text = "¿Esta seguro de que quiere continuar?";
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.Transparent;
            this.btnContinuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinuar.FlatAppearance.BorderSize = 0;
            this.btnContinuar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnContinuar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.Location = new System.Drawing.Point(499, 503);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(152, 45);
            this.btnContinuar.TabIndex = 1;
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(690, 503);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(158, 45);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(663, 195);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(0, 13);
            this.lNombre.TabIndex = 3;
            // 
            // lId
            // 
            this.lId.AutoSize = true;
            this.lId.Location = new System.Drawing.Point(663, 265);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(0, 13);
            this.lId.TabIndex = 4;
            this.lId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lDescripcion
            // 
            this.lDescripcion.AutoSize = true;
            this.lDescripcion.Location = new System.Drawing.Point(663, 354);
            this.lDescripcion.Name = "lDescripcion";
            this.lDescripcion.Size = new System.Drawing.Size(0, 13);
            this.lDescripcion.TabIndex = 5;
            this.lDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormBorrar_lblfecha
            // 
            this.FormBorrar_lblfecha.AutoSize = true;
            this.FormBorrar_lblfecha.BackColor = System.Drawing.Color.Transparent;
            this.FormBorrar_lblfecha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorrar_lblfecha.Location = new System.Drawing.Point(50, 82);
            this.FormBorrar_lblfecha.Name = "FormBorrar_lblfecha";
            this.FormBorrar_lblfecha.Size = new System.Drawing.Size(0, 15);
            this.FormBorrar_lblfecha.TabIndex = 6;
            // 
            // FormBorrar_lblhora
            // 
            this.FormBorrar_lblhora.AutoSize = true;
            this.FormBorrar_lblhora.BackColor = System.Drawing.Color.Transparent;
            this.FormBorrar_lblhora.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorrar_lblhora.Location = new System.Drawing.Point(50, 133);
            this.FormBorrar_lblhora.Name = "FormBorrar_lblhora";
            this.FormBorrar_lblhora.Size = new System.Drawing.Size(0, 15);
            this.FormBorrar_lblhora.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormBorrarJuguete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal_EDRM_ProgramacionII.Properties.Resources.Over_Borrar;
            this.ClientSize = new System.Drawing.Size(1224, 641);
            this.Controls.Add(this.FormBorrar_lblhora);
            this.Controls.Add(this.FormBorrar_lblfecha);
            this.Controls.Add(this.lDescripcion);
            this.Controls.Add(this.lId);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.lContinuar);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "FormBorrarJuguete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBorrarJuguete";
            this.Load += new System.EventHandler(this.FormBorrarJuguete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lContinuar;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lId;
        private System.Windows.Forms.Label lDescripcion;
        private System.Windows.Forms.Label FormBorrar_lblfecha;
        private System.Windows.Forms.Label FormBorrar_lblhora;
        private System.Windows.Forms.Timer timer1;
    }
}