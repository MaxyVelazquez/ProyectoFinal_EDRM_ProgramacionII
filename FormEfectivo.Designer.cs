namespace ProyectoFinal_EDRM_ProgramacionII
{
    partial class FormEfectivo
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
            this.LabelName = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.picBBVA = new System.Windows.Forms.PictureBox();
            this.picSantander = new System.Windows.Forms.PictureBox();
            this.picOxxo = new System.Windows.Forms.PictureBox();
            this.picQR = new System.Windows.Forms.PictureBox();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.btnGenerarRecibo = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.Regresar = new System.Windows.Forms.Button();
            this.FormsInicio_txtNombre = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBBVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSantander)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOxxo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.BackColor = System.Drawing.Color.Transparent;
            this.LabelName.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.Location = new System.Drawing.Point(398, 86);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(76, 21);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "label1";
            this.LabelName.Click += new System.EventHandler(this.LabelName_Click);
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.BackColor = System.Drawing.Color.Transparent;
            this.labelFecha.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(631, 86);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(76, 21);
            this.labelFecha.TabIndex = 1;
            this.labelFecha.Text = "label1";
            this.labelFecha.Click += new System.EventHandler(this.labelFecha_Click);
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.BackColor = System.Drawing.Color.Transparent;
            this.labelHora.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.Location = new System.Drawing.Point(874, 86);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(76, 21);
            this.labelHora.TabIndex = 2;
            this.labelHora.Text = "label1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.LightGray;
            this.richTextBox1.Location = new System.Drawing.Point(563, 120);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(445, 202);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // picBBVA
            // 
            this.picBBVA.Image = global::ProyectoFinal_EDRM_ProgramacionII.Properties.Resources.BBVA_Final;
            this.picBBVA.Location = new System.Drawing.Point(480, 319);
            this.picBBVA.Name = "picBBVA";
            this.picBBVA.Size = new System.Drawing.Size(61, 30);
            this.picBBVA.TabIndex = 4;
            this.picBBVA.TabStop = false;
            // 
            // picSantander
            // 
            this.picSantander.Image = global::ProyectoFinal_EDRM_ProgramacionII.Properties.Resources.Santander;
            this.picSantander.Location = new System.Drawing.Point(480, 278);
            this.picSantander.Name = "picSantander";
            this.picSantander.Size = new System.Drawing.Size(65, 26);
            this.picSantander.TabIndex = 5;
            this.picSantander.TabStop = false;
            this.picSantander.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // picOxxo
            // 
            this.picOxxo.Image = global::ProyectoFinal_EDRM_ProgramacionII.Properties.Resources.OXXOFinal;
            this.picOxxo.Location = new System.Drawing.Point(470, 220);
            this.picOxxo.Name = "picOxxo";
            this.picOxxo.Size = new System.Drawing.Size(71, 29);
            this.picOxxo.TabIndex = 6;
            this.picOxxo.TabStop = false;
            // 
            // picQR
            // 
            this.picQR.Image = global::ProyectoFinal_EDRM_ProgramacionII.Properties.Resources.QR;
            this.picQR.Location = new System.Drawing.Point(465, 424);
            this.picQR.Name = "picQR";
            this.picQR.Size = new System.Drawing.Size(143, 132);
            this.picQR.TabIndex = 7;
            this.picQR.TabStop = false;
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.AutoSize = true;
            this.labelSubtotal.BackColor = System.Drawing.Color.Transparent;
            this.labelSubtotal.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtotal.Location = new System.Drawing.Point(896, 441);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(68, 18);
            this.labelSubtotal.TabIndex = 8;
            this.labelSubtotal.Text = "label1";
            this.labelSubtotal.Click += new System.EventHandler(this.labelSubtotal_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelTotal.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(875, 497);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(68, 18);
            this.labelTotal.TabIndex = 9;
            this.labelTotal.Text = "label1";
            // 
            // btnGenerarRecibo
            // 
            this.btnGenerarRecibo.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerarRecibo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarRecibo.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.btnGenerarRecibo.FlatAppearance.BorderSize = 0;
            this.btnGenerarRecibo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGenerarRecibo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGenerarRecibo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarRecibo.Location = new System.Drawing.Point(563, 342);
            this.btnGenerarRecibo.Name = "btnGenerarRecibo";
            this.btnGenerarRecibo.Size = new System.Drawing.Size(131, 34);
            this.btnGenerarRecibo.TabIndex = 10;
            this.btnGenerarRecibo.UseVisualStyleBackColor = false;
            this.btnGenerarRecibo.Click += new System.EventHandler(this.btnGenerarRecibo_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::ProyectoFinal_EDRM_ProgramacionII.Properties.Resources.LogoFInal;
            this.picLogo.Location = new System.Drawing.Point(-3, -2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(345, 76);
            this.picLogo.TabIndex = 11;
            this.picLogo.TabStop = false;
            // 
            // Regresar
            // 
            this.Regresar.BackColor = System.Drawing.Color.Transparent;
            this.Regresar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.Regresar.FlatAppearance.BorderSize = 0;
            this.Regresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Regresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Regresar.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regresar.Location = new System.Drawing.Point(1120, 55);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(58, 43);
            this.Regresar.TabIndex = 12;
            this.Regresar.UseVisualStyleBackColor = false;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // FormsInicio_txtNombre
            // 
            this.FormsInicio_txtNombre.BackColor = System.Drawing.SystemColors.Menu;
            this.FormsInicio_txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FormsInicio_txtNombre.Enabled = false;
            this.FormsInicio_txtNombre.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormsInicio_txtNombre.Location = new System.Drawing.Point(196, 84);
            this.FormsInicio_txtNombre.Name = "FormsInicio_txtNombre";
            this.FormsInicio_txtNombre.Size = new System.Drawing.Size(146, 21);
            this.FormsInicio_txtNombre.TabIndex = 13;
            this.FormsInicio_txtNombre.Text = "";
            this.FormsInicio_txtNombre.TextChanged += new System.EventHandler(this.FormsInicio_txtNombre_TextChanged);
            // 
            // FormEfectivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal_EDRM_ProgramacionII.Properties.Resources.Over_Efectivo;
            this.ClientSize = new System.Drawing.Size(1224, 641);
            this.Controls.Add(this.FormsInicio_txtNombre);
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnGenerarRecibo);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelSubtotal);
            this.Controls.Add(this.picQR);
            this.Controls.Add(this.picOxxo);
            this.Controls.Add(this.picSantander);
            this.Controls.Add(this.picBBVA);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.LabelName);
            this.Name = "FormEfectivo";
            this.Text = "FormEfectivo";
            this.Load += new System.EventHandler(this.FormEfectivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBBVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSantander)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOxxo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox picBBVA;
        private System.Windows.Forms.PictureBox picSantander;
        private System.Windows.Forms.PictureBox picOxxo;
        private System.Windows.Forms.PictureBox picQR;
        private System.Windows.Forms.Label labelSubtotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button btnGenerarRecibo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button Regresar;
        private System.Windows.Forms.RichTextBox FormsInicio_txtNombre;
    }
}