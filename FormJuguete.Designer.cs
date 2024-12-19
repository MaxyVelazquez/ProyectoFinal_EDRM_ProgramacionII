namespace ProyectoFinal_EDRM_ProgramacionII
{
    partial class FormJuguete
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.txtPromocion = new System.Windows.Forms.TextBox();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.bttActualizarRegistro = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.FormJuguete_lblfecha = new System.Windows.Forms.Label();
            this.FormJuguete_lblhora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Location = new System.Drawing.Point(479, 90);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(268, 37);
            this.txtNombre.TabIndex = 0;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.Menu;
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Location = new System.Drawing.Point(479, 150);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(268, 37);
            this.txtId.TabIndex = 1;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecio.Location = new System.Drawing.Point(498, 210);
            this.txtPrecio.Multiline = true;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(249, 37);
            this.txtPrecio.TabIndex = 2;
            // 
            // txtExistencia
            // 
            this.txtExistencia.BackColor = System.Drawing.SystemColors.Menu;
            this.txtExistencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExistencia.Location = new System.Drawing.Point(479, 270);
            this.txtExistencia.Multiline = true;
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(268, 37);
            this.txtExistencia.TabIndex = 3;
            // 
            // txtPromocion
            // 
            this.txtPromocion.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPromocion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPromocion.Location = new System.Drawing.Point(479, 329);
            this.txtPromocion.Multiline = true;
            this.txtPromocion.Name = "txtPromocion";
            this.txtPromocion.Size = new System.Drawing.Size(268, 37);
            this.txtPromocion.TabIndex = 4;
            // 
            // txtImagen
            // 
            this.txtImagen.BackColor = System.Drawing.SystemColors.Menu;
            this.txtImagen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImagen.Location = new System.Drawing.Point(479, 390);
            this.txtImagen.Multiline = true;
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(268, 37);
            this.txtImagen.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Location = new System.Drawing.Point(479, 453);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(268, 103);
            this.txtDescripcion.TabIndex = 6;
            // 
            // bttActualizarRegistro
            // 
            this.bttActualizarRegistro.BackColor = System.Drawing.Color.Transparent;
            this.bttActualizarRegistro.FlatAppearance.BorderSize = 0;
            this.bttActualizarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttActualizarRegistro.Location = new System.Drawing.Point(520, 581);
            this.bttActualizarRegistro.Name = "bttActualizarRegistro";
            this.bttActualizarRegistro.Size = new System.Drawing.Size(192, 33);
            this.bttActualizarRegistro.TabIndex = 7;
            this.bttActualizarRegistro.UseVisualStyleBackColor = false;
            this.bttActualizarRegistro.Click += new System.EventHandler(this.bttActualizarRegistro_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Location = new System.Drawing.Point(1110, 47);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 50);
            this.btnRegresar.TabIndex = 8;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // FormJuguete_lblfecha
            // 
            this.FormJuguete_lblfecha.AutoSize = true;
            this.FormJuguete_lblfecha.BackColor = System.Drawing.Color.Transparent;
            this.FormJuguete_lblfecha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormJuguete_lblfecha.Location = new System.Drawing.Point(65, 73);
            this.FormJuguete_lblfecha.Name = "FormJuguete_lblfecha";
            this.FormJuguete_lblfecha.Size = new System.Drawing.Size(0, 15);
            this.FormJuguete_lblfecha.TabIndex = 9;
            // 
            // FormJuguete_lblhora
            // 
            this.FormJuguete_lblhora.AutoSize = true;
            this.FormJuguete_lblhora.BackColor = System.Drawing.Color.Transparent;
            this.FormJuguete_lblhora.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormJuguete_lblhora.Location = new System.Drawing.Point(65, 136);
            this.FormJuguete_lblhora.Name = "FormJuguete_lblhora";
            this.FormJuguete_lblhora.Size = new System.Drawing.Size(0, 15);
            this.FormJuguete_lblhora.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormJuguete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = global::ProyectoFinal_EDRM_ProgramacionII.Properties.Resources.Editar;
            this.ClientSize = new System.Drawing.Size(1224, 641);
            this.Controls.Add(this.FormJuguete_lblhora);
            this.Controls.Add(this.FormJuguete_lblfecha);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.bttActualizarRegistro);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.txtPromocion);
            this.Controls.Add(this.txtExistencia);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtNombre);
            this.Name = "FormJuguete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormJuguete";
            this.Load += new System.EventHandler(this.FormJuguete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.TextBox txtPromocion;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button bttActualizarRegistro;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label FormJuguete_lblfecha;
        private System.Windows.Forms.Label FormJuguete_lblhora;
        private System.Windows.Forms.Timer timer1;
    }
}