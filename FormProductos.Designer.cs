namespace ProyectoFinal_EDRM_ProgramacionII
{
    partial class FormsProductos
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bttRecargar = new System.Windows.Forms.Button();
            this.bttCerrarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 105);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1208, 528);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // bttRecargar
            // 
            this.bttRecargar.BackColor = System.Drawing.Color.Transparent;
            this.bttRecargar.FlatAppearance.BorderSize = 0;
            this.bttRecargar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bttRecargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bttRecargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttRecargar.Location = new System.Drawing.Point(135, 47);
            this.bttRecargar.Margin = new System.Windows.Forms.Padding(2);
            this.bttRecargar.Name = "bttRecargar";
            this.bttRecargar.Size = new System.Drawing.Size(51, 54);
            this.bttRecargar.TabIndex = 1;
            this.bttRecargar.UseVisualStyleBackColor = false;
            this.bttRecargar.Click += new System.EventHandler(this.bttRecargar_Click);
            // 
            // bttCerrarSesion
            // 
            this.bttCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.bttCerrarSesion.FlatAppearance.BorderSize = 0;
            this.bttCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bttCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bttCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttCerrarSesion.Location = new System.Drawing.Point(1121, 47);
            this.bttCerrarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.bttCerrarSesion.Name = "bttCerrarSesion";
            this.bttCerrarSesion.Size = new System.Drawing.Size(56, 54);
            this.bttCerrarSesion.TabIndex = 2;
            this.bttCerrarSesion.UseVisualStyleBackColor = false;
            this.bttCerrarSesion.Click += new System.EventHandler(this.bttCerrarSesion_Click);
            // 
            // FormsProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal_EDRM_ProgramacionII.Properties.Resources._3;
            this.ClientSize = new System.Drawing.Size(1224, 641);
            this.Controls.Add(this.bttCerrarSesion);
            this.Controls.Add(this.bttRecargar);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FormsProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProductos";
            this.Load += new System.EventHandler(this.FormsProductos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bttRecargar;
        private System.Windows.Forms.Button bttCerrarSesion;
    }
}