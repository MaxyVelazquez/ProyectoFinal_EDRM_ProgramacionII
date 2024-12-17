namespace ProyectoFinal_EDRM_ProgramacionII
{
    partial class FormProductosPromociones
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
            this.FormPromo_btnCarrito = new System.Windows.Forms.Button();
            this.FormsPromociones_txtNombre = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 118);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1208, 471);
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
            this.bttRecargar.Location = new System.Drawing.Point(137, 52);
            this.bttRecargar.Margin = new System.Windows.Forms.Padding(2);
            this.bttRecargar.Name = "bttRecargar";
            this.bttRecargar.Size = new System.Drawing.Size(48, 50);
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
            this.bttCerrarSesion.Location = new System.Drawing.Point(1122, 52);
            this.bttCerrarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.bttCerrarSesion.Name = "bttCerrarSesion";
            this.bttCerrarSesion.Size = new System.Drawing.Size(51, 50);
            this.bttCerrarSesion.TabIndex = 2;
            this.bttCerrarSesion.UseVisualStyleBackColor = false;
            this.bttCerrarSesion.Click += new System.EventHandler(this.bttCerrarSesion_Click);
            // 
            // FormPromo_btnCarrito
            // 
            this.FormPromo_btnCarrito.BackColor = System.Drawing.Color.Transparent;
            this.FormPromo_btnCarrito.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.FormPromo_btnCarrito.FlatAppearance.BorderSize = 0;
            this.FormPromo_btnCarrito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.FormPromo_btnCarrito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.FormPromo_btnCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormPromo_btnCarrito.Location = new System.Drawing.Point(1056, 52);
            this.FormPromo_btnCarrito.Name = "FormPromo_btnCarrito";
            this.FormPromo_btnCarrito.Size = new System.Drawing.Size(61, 50);
            this.FormPromo_btnCarrito.TabIndex = 3;
            this.FormPromo_btnCarrito.UseVisualStyleBackColor = false;
            this.FormPromo_btnCarrito.Click += new System.EventHandler(this.FormPromo_btnCarrito_Click);
            // 
            // FormsPromociones_txtNombre
            // 
            this.FormsPromociones_txtNombre.BackColor = System.Drawing.SystemColors.Menu;
            this.FormsPromociones_txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FormsPromociones_txtNombre.Enabled = false;
            this.FormsPromociones_txtNombre.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormsPromociones_txtNombre.Location = new System.Drawing.Point(869, 62);
            this.FormsPromociones_txtNombre.Name = "FormsPromociones_txtNombre";
            this.FormsPromociones_txtNombre.Size = new System.Drawing.Size(126, 29);
            this.FormsPromociones_txtNombre.TabIndex = 9;
            this.FormsPromociones_txtNombre.Text = "";
            this.FormsPromociones_txtNombre.TextChanged += new System.EventHandler(this.FormsPromociones_txtNombre_TextChanged);
            // 
            // FormProductosPromociones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal_EDRM_ProgramacionII.Properties.Resources.Over_Promociones;
            this.ClientSize = new System.Drawing.Size(1224, 641);
            this.Controls.Add(this.FormsPromociones_txtNombre);
            this.Controls.Add(this.FormPromo_btnCarrito);
            this.Controls.Add(this.bttCerrarSesion);
            this.Controls.Add(this.bttRecargar);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormProductosPromociones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProductosPromociones";
            this.Load += new System.EventHandler(this.FormProductosPromociones_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bttRecargar;
        private System.Windows.Forms.Button bttCerrarSesion;
        private System.Windows.Forms.Button FormPromo_btnCarrito;
        private System.Windows.Forms.RichTextBox FormsPromociones_txtNombre;
    }
}