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
    public partial class FormsInicio : Form
    {
        public FormsInicio()
        {
            InitializeComponent();
        }

        private void FormsInicioUser_buttonProductos_Click(object sender, EventArgs e)
        {
            FormsProductos prod=new FormsProductos();
            this.Hide();
            prod.ShowDialog();
        }

        private void FormsInicioUsuario_buttonAcerca_Click(object sender, EventArgs e)
        {
            FormsCreditos aux=new FormsCreditos();
            this.Hide(); 
            aux.ShowDialog();
        }

        private void FormsInicioUsuario_buttonPromociones_Click(object sender, EventArgs e)
        {
            FormProductosPromociones prodPromo = new FormProductosPromociones();
            this.Hide();
            prodPromo.ShowDialog();
        }

        private void bttCerrarSesion_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
