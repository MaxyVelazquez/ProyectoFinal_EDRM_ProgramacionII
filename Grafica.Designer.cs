namespace ProyectoFinal_EDRM_ProgramacionII
{
    partial class Grafica
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Grafica_BtnCerrar = new System.Windows.Forms.Button();
            this.FormsGrafica_txtNombre = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(238, 94);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(703, 387);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Grafica_BtnCerrar
            // 
            this.Grafica_BtnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.Grafica_BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Grafica_BtnCerrar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.Grafica_BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Grafica_BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Grafica_BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Grafica_BtnCerrar.Location = new System.Drawing.Point(1128, 56);
            this.Grafica_BtnCerrar.Name = "Grafica_BtnCerrar";
            this.Grafica_BtnCerrar.Size = new System.Drawing.Size(47, 44);
            this.Grafica_BtnCerrar.TabIndex = 1;
            this.Grafica_BtnCerrar.UseVisualStyleBackColor = false;
            this.Grafica_BtnCerrar.Click += new System.EventHandler(this.Grafica_BtnCerrar_Click);
            // 
            // FormsGrafica_txtNombre
            // 
            this.FormsGrafica_txtNombre.BackColor = System.Drawing.SystemColors.Menu;
            this.FormsGrafica_txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FormsGrafica_txtNombre.Enabled = false;
            this.FormsGrafica_txtNombre.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormsGrafica_txtNombre.Location = new System.Drawing.Point(996, 63);
            this.FormsGrafica_txtNombre.Name = "FormsGrafica_txtNombre";
            this.FormsGrafica_txtNombre.Size = new System.Drawing.Size(126, 29);
            this.FormsGrafica_txtNombre.TabIndex = 11;
            this.FormsGrafica_txtNombre.Text = "";
            // 
            // Grafica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = global::ProyectoFinal_EDRM_ProgramacionII.Properties.Resources.Over_Grafica;
            this.ClientSize = new System.Drawing.Size(1224, 641);
            this.Controls.Add(this.FormsGrafica_txtNombre);
            this.Controls.Add(this.Grafica_BtnCerrar);
            this.Controls.Add(this.chart1);
            this.Name = "Grafica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafica";
            this.Load += new System.EventHandler(this.Grafica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button Grafica_BtnCerrar;
        private System.Windows.Forms.RichTextBox FormsGrafica_txtNombre;
    }
}