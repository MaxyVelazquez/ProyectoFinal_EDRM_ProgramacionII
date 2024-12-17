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
            this.FormsCarrito_txtNombre = new System.Windows.Forms.RichTextBox();
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
            this.FormCarro_BtnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormCarro_BtnRegresar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.FormCarro_BtnRegresar.FlatAppearance.BorderSize = 0;
            this.FormCarro_BtnRegresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.FormCarro_BtnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.FormCarro_BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormCarro_BtnRegresar.Location = new System.Drawing.Point(1128, 59);
            this.FormCarro_BtnRegresar.Name = "FormCarro_BtnRegresar";
            this.FormCarro_BtnRegresar.Size = new System.Drawing.Size(46, 34);
            this.FormCarro_BtnRegresar.TabIndex = 2;
            this.FormCarro_BtnRegresar.UseVisualStyleBackColor = false;
            this.FormCarro_BtnRegresar.Click += new System.EventHandler(this.FormCarro_BtnRegresar_Click);
            // 
            // FormCarrito_PagoTarjeta
            // 
            this.FormCarrito_PagoTarjeta.BackColor = System.Drawing.Color.Transparent;
            this.FormCarrito_PagoTarjeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormCarrito_PagoTarjeta.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.FormCarrito_PagoTarjeta.FlatAppearance.BorderSize = 0;
            this.FormCarrito_PagoTarjeta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.FormCarrito_PagoTarjeta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.FormCarrito_PagoTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormCarrito_PagoTarjeta.Location = new System.Drawing.Point(312, 552);
            this.FormCarrito_PagoTarjeta.Name = "FormCarrito_PagoTarjeta";
            this.FormCarrito_PagoTarjeta.Size = new System.Drawing.Size(303, 39);
            this.FormCarrito_PagoTarjeta.TabIndex = 3;
            this.FormCarrito_PagoTarjeta.UseVisualStyleBackColor = false;
            this.FormCarrito_PagoTarjeta.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormCarro_Efectivo
            // 
            this.FormCarro_Efectivo.BackColor = System.Drawing.Color.Transparent;
            this.FormCarro_Efectivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormCarro_Efectivo.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.FormCarro_Efectivo.FlatAppearance.BorderSize = 0;
            this.FormCarro_Efectivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.FormCarro_Efectivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.FormCarro_Efectivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormCarro_Efectivo.Location = new System.Drawing.Point(641, 552);
            this.FormCarro_Efectivo.Name = "FormCarro_Efectivo";
            this.FormCarro_Efectivo.Size = new System.Drawing.Size(276, 39);
            this.FormCarro_Efectivo.TabIndex = 4;
            this.FormCarro_Efectivo.UseVisualStyleBackColor = false;
            this.FormCarro_Efectivo.Click += new System.EventHandler(this.FormCarro_Efectivo_Click);
            // 
            // FormsCarrito_txtNombre
            // 
            this.FormsCarrito_txtNombre.BackColor = System.Drawing.SystemColors.Menu;
            this.FormsCarrito_txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FormsCarrito_txtNombre.Enabled = false;
            this.FormsCarrito_txtNombre.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormsCarrito_txtNombre.Location = new System.Drawing.Point(1002, 58);
            this.FormsCarrito_txtNombre.Name = "FormsCarrito_txtNombre";
            this.FormsCarrito_txtNombre.Size = new System.Drawing.Size(120, 35);
            this.FormsCarrito_txtNombre.TabIndex = 10;
            this.FormsCarrito_txtNombre.Text = "";
            // 
            // FormCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal_EDRM_ProgramacionII.Properties.Resources.Over_Carrito1;
            this.ClientSize = new System.Drawing.Size(1224, 641);
            this.Controls.Add(this.FormsCarrito_txtNombre);
            this.Controls.Add(this.FormCarro_Efectivo);
            this.Controls.Add(this.FormCarrito_PagoTarjeta);
            this.Controls.Add(this.FormCarro_BtnRegresar);
            this.Controls.Add(this.PanelCarrito);
            this.Name = "FormCarrito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCarrito";
            this.Load += new System.EventHandler(this.FormCarrito_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PanelCarrito;
        private System.Windows.Forms.Button FormCarro_BtnRegresar;
        private System.Windows.Forms.Button FormCarrito_PagoTarjeta;
        private System.Windows.Forms.Button FormCarro_Efectivo;
        private System.Windows.Forms.RichTextBox FormsCarrito_txtNombre;
    }
}