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
            this.FormsPromociones_txtNombre = new System.Windows.Forms.RichTextBox();
            this.FormsPromociones_buttonCarrito = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
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
            this.bttCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // FormsPromociones_txtNombre
            // 
            this.FormsPromociones_txtNombre.BackColor = System.Drawing.SystemColors.Menu;
            this.FormsPromociones_txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FormsPromociones_txtNombre.Enabled = false;
            this.FormsPromociones_txtNombre.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormsPromociones_txtNombre.Location = new System.Drawing.Point(950, 67);
            this.FormsPromociones_txtNombre.Name = "FormsPromociones_txtNombre";
            this.FormsPromociones_txtNombre.Size = new System.Drawing.Size(120, 35);
            this.FormsPromociones_txtNombre.TabIndex = 9;
            this.FormsPromociones_txtNombre.Text = "";
            // 
            // FormsPromociones_buttonCarrito
            // 
            this.FormsPromociones_buttonCarrito.BackColor = System.Drawing.Color.Transparent;
            this.FormsPromociones_buttonCarrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormsPromociones_buttonCarrito.FlatAppearance.BorderSize = 0;
            this.FormsPromociones_buttonCarrito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.FormsPromociones_buttonCarrito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.FormsPromociones_buttonCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormsPromociones_buttonCarrito.Location = new System.Drawing.Point(1065, 52);
            this.FormsPromociones_buttonCarrito.Margin = new System.Windows.Forms.Padding(2);
            this.FormsPromociones_buttonCarrito.Name = "FormsPromociones_buttonCarrito";
            this.FormsPromociones_buttonCarrito.Size = new System.Drawing.Size(41, 38);
            this.FormsPromociones_buttonCarrito.TabIndex = 10;
            this.FormsPromociones_buttonCarrito.UseVisualStyleBackColor = false;
            this.FormsPromociones_buttonCarrito.Click += new System.EventHandler(this.FormsPromociones_buttonCarrito_Click);
            // 
            // FormProductosPromociones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal_EDRM_ProgramacionII.Properties.Resources.OverlaysProductosPromo;
            this.ClientSize = new System.Drawing.Size(1224, 641);
            this.Controls.Add(this.FormsPromociones_buttonCarrito);
            this.Controls.Add(this.FormsPromociones_txtNombre);
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
        private System.Windows.Forms.RichTextBox FormsPromociones_txtNombre;
        private System.Windows.Forms.Button FormsPromociones_buttonCarrito;
    }
}