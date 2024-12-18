using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf.security;

namespace ProyectoFinal_EDRM_ProgramacionII
{
    public partial class FormPrincipalAdmin : Form
    {
        private string nombre;
        public FormPrincipalAdmin()
        {
            InitializeComponent();
        }
        public FormPrincipalAdmin(string nombre)
        {
            this.nombre = nombre;
            InitializeComponent();
            this.FormsAdmin_txtNombre.Text = nombre;
        }
        private void bttAgregarProducto_Click(object sender, EventArgs e)
        {
            FormJugueteNuevo formJugueteNuevo = new FormJugueteNuevo(nombre);
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
            Grafica grafica = new Grafica(nombre);
            this.Hide();
            grafica.ShowDialog();
            this.Show();
        }

        private void bttMonto_Click(object sender, EventArgs e)
        {
            FormVentas formVentas = new FormVentas(nombre);
            this.Hide();
            formVentas.ShowDialog();
            this.Show();

        }

        private void FormPrincipalAdmin_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.FormAdmin_lblfecha.Text=DateTime.Now.ToShortDateString();
            this.FormAdmin_lblhora.Text = DateTime.Now.ToShortTimeString();
        }
    }
}
