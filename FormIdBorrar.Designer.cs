namespace ProyectoFinal_EDRM_ProgramacionII
{
    partial class FormIdBorrar
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdBorrar = new System.Windows.Forms.TextBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el Id del producto a eliminar";
            // 
            // txtIdBorrar
            // 
            this.txtIdBorrar.Location = new System.Drawing.Point(120, 61);
            this.txtIdBorrar.Name = "txtIdBorrar";
            this.txtIdBorrar.Size = new System.Drawing.Size(100, 20);
            this.txtIdBorrar.TabIndex = 1;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(67, 104);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(223, 95);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = "Continuar";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // FormIdBorrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 255);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.txtIdBorrar);
            this.Controls.Add(this.label1);
            this.Name = "FormIdBorrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormIdBorrar";
            this.Load += new System.EventHandler(this.FormIdBorrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdBorrar;
        private System.Windows.Forms.Button btnSiguiente;
    }
}