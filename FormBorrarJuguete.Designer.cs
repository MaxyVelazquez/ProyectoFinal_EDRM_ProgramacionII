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
            this.lContinuar = new System.Windows.Forms.Label();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lNombre = new System.Windows.Forms.Label();
            this.lId = new System.Windows.Forms.Label();
            this.lDescripcion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lContinuar
            // 
            this.lContinuar.Location = new System.Drawing.Point(372, 210);
            this.lContinuar.Name = "lContinuar";
            this.lContinuar.Size = new System.Drawing.Size(208, 76);
            this.lContinuar.TabIndex = 0;
            this.lContinuar.Text = "¿Esta seguro de que quiere continuar?";
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(305, 267);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(134, 63);
            this.btnContinuar.TabIndex = 1;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(532, 267);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(134, 63);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(465, 41);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(0, 13);
            this.lNombre.TabIndex = 3;
            // 
            // lId
            // 
            this.lId.AutoSize = true;
            this.lId.Location = new System.Drawing.Point(465, 81);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(0, 13);
            this.lId.TabIndex = 4;
            // 
            // lDescripcion
            // 
            this.lDescripcion.AutoSize = true;
            this.lDescripcion.Location = new System.Drawing.Point(465, 138);
            this.lDescripcion.Name = "lDescripcion";
            this.lDescripcion.Size = new System.Drawing.Size(0, 13);
            this.lDescripcion.TabIndex = 5;
            // 
            // FormBorrarJuguete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 481);
            this.Controls.Add(this.lDescripcion);
            this.Controls.Add(this.lId);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.lContinuar);
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
    }
}