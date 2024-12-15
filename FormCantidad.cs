using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_EDRM_ProgramacionII
{
    public partial class FormCantidad : Form
    {
        public int Cant { get; set; }
        private string name;
        private int exis;
        public FormCantidad(string name, int existencias)
        {
            InitializeComponent();
            this.name = name;
            this.exis = existencias;

            Label lblNombre = new Label
            {
                Text = "¿Cuantos " + name + " Desea adquirir?",
                Location = new Point(90, 70),
                AutoSize = true,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };

            panelCant.Controls.Add(lblNombre);
        }

        private void panelCant_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxCantidad_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void bttContinuar_Click(object sender, EventArgs e)
        {
            Cant = Convert.ToInt32(this.textBoxCantidad.Text);
            if (Cant <= exis)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show($"Lo sentimos, solo contamos con {exis} existencias");
            }
        }

        private void bttCancelar_Click(object sender, EventArgs e)
        {
            Cant = 0;
            this.Close();
        }
    }
}
