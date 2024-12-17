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
    public partial class FormPrincipalAdmin : Form
    {
        public FormPrincipalAdmin()
        {
            InitializeComponent();
        }

        private void bttAgregarProducto_Click(object sender, EventArgs e)
        {
            FormJugueteNuevo formJugueteNuevo = new FormJugueteNuevo();
            formJugueteNuevo.ShowDialog();
        }

        private void bttListado_Click(object sender, EventArgs e)
        {
            FormListadoMayor formListadoMayor = new FormListadoMayor();
            formListadoMayor.ShowDialog();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttEliminarProduvto_Click(object sender, EventArgs e)
        {
            FormIdBorrar formIdBorrar = new FormIdBorrar();
            formIdBorrar.ShowDialog();
        }

        private void bttVerGrafica_Click(object sender, EventArgs e)
        {
            Grafica grafica = new Grafica();
            this.Hide();
            grafica.ShowDialog();
            this.Show();
        }

        private void bttMonto_Click(object sender, EventArgs e)
        {
            FormVentas formVentas = new FormVentas();
            this.Hide();
            formVentas.ShowDialog();
            this.Show();

        }
    }
}
