﻿namespace ProyectoFinal_EDRM_ProgramacionII
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Grafica_BtnCerrar = new System.Windows.Forms.Button();
            this.FormsGrafica_txtNombre = new System.Windows.Forms.RichTextBox();
            this.FormGrafica_lblfecha = new System.Windows.Forms.Label();
            this.FormGrafica_lblhora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
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
            this.FormsGrafica_txtNombre.Location = new System.Drawing.Point(1002, 56);
            this.FormsGrafica_txtNombre.Name = "FormsGrafica_txtNombre";
            this.FormsGrafica_txtNombre.Size = new System.Drawing.Size(120, 35);
            this.FormsGrafica_txtNombre.TabIndex = 11;
            this.FormsGrafica_txtNombre.Text = "";
            // 
            // FormGrafica_lblfecha
            // 
            this.FormGrafica_lblfecha.AutoSize = true;
            this.FormGrafica_lblfecha.BackColor = System.Drawing.Color.Transparent;
            this.FormGrafica_lblfecha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormGrafica_lblfecha.Location = new System.Drawing.Point(49, 85);
            this.FormGrafica_lblfecha.Name = "FormGrafica_lblfecha";
            this.FormGrafica_lblfecha.Size = new System.Drawing.Size(0, 15);
            this.FormGrafica_lblfecha.TabIndex = 12;
            // 
            // FormGrafica_lblhora
            // 
            this.FormGrafica_lblhora.AutoSize = true;
            this.FormGrafica_lblhora.BackColor = System.Drawing.Color.Transparent;
            this.FormGrafica_lblhora.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormGrafica_lblhora.Location = new System.Drawing.Point(49, 147);
            this.FormGrafica_lblhora.Name = "FormGrafica_lblhora";
            this.FormGrafica_lblhora.Size = new System.Drawing.Size(0, 15);
            this.FormGrafica_lblhora.TabIndex = 13;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Grafica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = global::ProyectoFinal_EDRM_ProgramacionII.Properties.Resources.OverlaysGraficaFin;
            this.ClientSize = new System.Drawing.Size(1224, 641);
            this.Controls.Add(this.FormGrafica_lblhora);
            this.Controls.Add(this.FormGrafica_lblfecha);
            this.Controls.Add(this.FormsGrafica_txtNombre);
            this.Controls.Add(this.Grafica_BtnCerrar);
            this.Controls.Add(this.chart1);
            this.Name = "Grafica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafica";
            this.Load += new System.EventHandler(this.Grafica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button Grafica_BtnCerrar;
        private System.Windows.Forms.RichTextBox FormsGrafica_txtNombre;
        private System.Windows.Forms.Label FormGrafica_lblfecha;
        private System.Windows.Forms.Label FormGrafica_lblhora;
        private System.Windows.Forms.Timer timer1;
    }
}