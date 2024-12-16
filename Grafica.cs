using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoFinal_EDRM_ProgramacionII
{
    public partial class Grafica : Form
    {
        List<Juguetes> data;
        public Grafica()
        {
            InitializeComponent();
        }

        private void Grafica_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            BDJuguetes lista = new BDJuguetes();
            data = lista.Buscar();
            chart1.Titles.Add("Existencia");
            data.ForEach(p =>
            {
                if (p.Existencia != 0)
                {
                    Series series = chart1.Series.Add(p.Nombre);
                    series.Points.Add(p.Existencia);
                }

            });
        }

        private void Grafica_BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
