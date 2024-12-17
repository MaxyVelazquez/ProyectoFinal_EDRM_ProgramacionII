namespace ProyectoFinal_EDRM_ProgramacionII
{
    partial class FormListadoMayor
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
            this.flowListado = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowListado
            // 
            this.flowListado.AutoScroll = true;
            this.flowListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowListado.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowListado.Location = new System.Drawing.Point(0, 0);
            this.flowListado.Name = "flowListado";
            this.flowListado.Size = new System.Drawing.Size(713, 480);
            this.flowListado.TabIndex = 0;
            this.flowListado.Paint += new System.Windows.Forms.PaintEventHandler(this.flowListado_Paint);
            // 
            // FormListadoMayor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 480);
            this.Controls.Add(this.flowListado);
            this.Name = "FormListadoMayor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormListadoMayor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowListado;
    }
}