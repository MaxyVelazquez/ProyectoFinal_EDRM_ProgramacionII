namespace ProyectoFinal_EDRM_ProgramacionII
{
    partial class FormCarrito
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
            this.PanelCarrito = new System.Windows.Forms.FlowLayoutPanel();
            this.FormCarro_BtnRegresar = new System.Windows.Forms.Button();
            this.FormCarrito_PagoTarjeta = new System.Windows.Forms.Button();
            this.FormCarro_Efectivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PanelCarrito
            // 
            this.PanelCarrito.AutoScroll = true;
            this.PanelCarrito.Location = new System.Drawing.Point(8, 208);
            this.PanelCarrito.Margin = new System.Windows.Forms.Padding(2);
            this.PanelCarrito.Name = "PanelCarrito";
            this.PanelCarrito.Size = new System.Drawing.Size(1208, 277);
            this.PanelCarrito.TabIndex = 1;
            // 
            // FormCarro_BtnRegresar
            // 
            this.FormCarro_BtnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.FormCarro_BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormCarro_BtnRegresar.Location = new System.Drawing.Point(976, 31);
            this.FormCarro_BtnRegresar.Name = "FormCarro_BtnRegresar";
            this.FormCarro_BtnRegresar.Size = new System.Drawing.Size(146, 23);
            this.FormCarro_BtnRegresar.TabIndex = 2;
            this.FormCarro_BtnRegresar.UseVisualStyleBackColor = false;
            this.FormCarro_BtnRegresar.Click += new System.EventHandler(this.FormCarro_BtnRegresar_Click);
            // 
            // FormCarrito_PagoTarjeta
            // 
            this.FormCarrito_PagoTarjeta.BackColor = System.Drawing.Color.Transparent;
            this.FormCarrito_PagoTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormCarrito_PagoTarjeta.Location = new System.Drawing.Point(115, 539);
            this.FormCarrito_PagoTarjeta.Name = "FormCarrito_PagoTarjeta";
            this.FormCarrito_PagoTarjeta.Size = new System.Drawing.Size(338, 54);
            this.FormCarrito_PagoTarjeta.TabIndex = 3;
            this.FormCarrito_PagoTarjeta.UseVisualStyleBackColor = false;
            this.FormCarrito_PagoTarjeta.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormCarro_Efectivo
            // 
            this.FormCarro_Efectivo.BackColor = System.Drawing.Color.Transparent;
            this.FormCarro_Efectivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormCarro_Efectivo.Location = new System.Drawing.Point(766, 539);
            this.FormCarro_Efectivo.Name = "FormCarro_Efectivo";
            this.FormCarro_Efectivo.Size = new System.Drawing.Size(330, 52);
            this.FormCarro_Efectivo.TabIndex = 4;
            this.FormCarro_Efectivo.UseVisualStyleBackColor = false;
            this.FormCarro_Efectivo.Click += new System.EventHandler(this.FormCarro_Efectivo_Click);
            // 
            // FormCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal_EDRM_ProgramacionII.Properties.Resources.Over_Carrito;
            this.ClientSize = new System.Drawing.Size(1224, 641);
            this.Controls.Add(this.FormCarro_Efectivo);
            this.Controls.Add(this.FormCarrito_PagoTarjeta);
            this.Controls.Add(this.FormCarro_BtnRegresar);
            this.Controls.Add(this.PanelCarrito);
            this.Name = "FormCarrito";
            this.Text = "FormCarrito";
            this.Load += new System.EventHandler(this.FormCarrito_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PanelCarrito;
        private System.Windows.Forms.Button FormCarro_BtnRegresar;
        private System.Windows.Forms.Button FormCarrito_PagoTarjeta;
        private System.Windows.Forms.Button FormCarro_Efectivo;
    }
}