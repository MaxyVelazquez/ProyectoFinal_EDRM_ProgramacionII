namespace ProyectoFinal_EDRM_ProgramacionII
{
    partial class FormCantidad
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
            this.panelCant = new System.Windows.Forms.Panel();
            this.bttCancelar = new System.Windows.Forms.Button();
            this.bttContinuar = new System.Windows.Forms.Button();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.panelCant.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCant
            // 
            this.panelCant.Controls.Add(this.bttCancelar);
            this.panelCant.Controls.Add(this.bttContinuar);
            this.panelCant.Controls.Add(this.textBoxCantidad);
            this.panelCant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCant.Location = new System.Drawing.Point(0, 0);
            this.panelCant.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelCant.Name = "panelCant";
            this.panelCant.Size = new System.Drawing.Size(437, 268);
            this.panelCant.TabIndex = 0;
            this.panelCant.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCant_Paint);
            // 
            // bttCancelar
            // 
            this.bttCancelar.Location = new System.Drawing.Point(228, 155);
            this.bttCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttCancelar.Name = "bttCancelar";
            this.bttCancelar.Size = new System.Drawing.Size(107, 58);
            this.bttCancelar.TabIndex = 2;
            this.bttCancelar.Text = "Cancelar";
            this.bttCancelar.UseVisualStyleBackColor = true;
            this.bttCancelar.Click += new System.EventHandler(this.bttCancelar_Click);
            // 
            // bttContinuar
            // 
            this.bttContinuar.Location = new System.Drawing.Point(97, 155);
            this.bttContinuar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttContinuar.Name = "bttContinuar";
            this.bttContinuar.Size = new System.Drawing.Size(107, 58);
            this.bttContinuar.TabIndex = 1;
            this.bttContinuar.Text = "Continuar";
            this.bttContinuar.UseVisualStyleBackColor = true;
            this.bttContinuar.Click += new System.EventHandler(this.bttContinuar_Click);
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCantidad.Location = new System.Drawing.Point(97, 101);
            this.textBoxCantidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCantidad.Multiline = true;
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(239, 34);
            this.textBoxCantidad.TabIndex = 0;
            this.textBoxCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCantidad.TextChanged += new System.EventHandler(this.textBoxCantidad_TextChanged_1);
            // 
            // FormCantidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 268);
            this.Controls.Add(this.panelCant);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormCantidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCantidad";
            this.panelCant.ResumeLayout(false);
            this.panelCant.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCant;
        private System.Windows.Forms.Button bttCancelar;
        private System.Windows.Forms.Button bttContinuar;
        private System.Windows.Forms.TextBox textBoxCantidad;
    }
}