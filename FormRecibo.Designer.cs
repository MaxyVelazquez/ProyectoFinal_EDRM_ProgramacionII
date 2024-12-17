namespace ProyectoFinal_EDRM_ProgramacionII
{
    partial class FormRecibo
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
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LbLShowName = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LblSubtotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPDF = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = global::ProyectoFinal_EDRM_ProgramacionII.Properties.Resources.LogoFInal;
            this.picLogo.Location = new System.Drawing.Point(-4, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(326, 76);
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(650, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(952, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // LbLShowName
            // 
            this.LbLShowName.AutoSize = true;
            this.LbLShowName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLShowName.Location = new System.Drawing.Point(124, 100);
            this.LbLShowName.Name = "LbLShowName";
            this.LbLShowName.Size = new System.Drawing.Size(45, 20);
            this.LbLShowName.TabIndex = 7;
            this.LbLShowName.Text = "label4";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox1.Location = new System.Drawing.Point(365, 155);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(418, 215);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(684, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Subtotal->";
            // 
            // LblSubtotal
            // 
            this.LblSubtotal.AutoSize = true;
            this.LblSubtotal.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubtotal.Location = new System.Drawing.Point(745, 388);
            this.LblSubtotal.Name = "LblSubtotal";
            this.LblSubtotal.Size = new System.Drawing.Size(68, 18);
            this.LblSubtotal.TabIndex = 10;
            this.LblSubtotal.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(684, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Impuesto del 6% (IVA)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(684, 454);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total->";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(748, 454);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "label7";
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPDF.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.Location = new System.Drawing.Point(365, 388);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(165, 54);
            this.btnPDF.TabIndex = 14;
            this.btnPDF.Text = "Generar Comprobante";
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1108, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal_EDRM_ProgramacionII.Properties.Resources.Recibo;
            this.ClientSize = new System.Drawing.Size(1224, 641);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblSubtotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.LbLShowName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picLogo);
            this.Name = "FormRecibo";
            this.Text = "FormRecibo";
            this.Load += new System.EventHandler(this.FormRecibo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LbLShowName;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblSubtotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button button1;
    }
}