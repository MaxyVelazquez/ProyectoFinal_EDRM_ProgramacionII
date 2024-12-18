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
        private string nombre;
        private string contraseña;
        public FormsInicio()
        {
            InitializeComponent();
        }
        public FormsInicio(string nombre, string contraseña)
        {
            this.nombre = nombre;
            this.contraseña = contraseña;
            InitializeComponent();
            this.FormsInicio_txtNombre.Text = nombre;
        }

        private void FormsInicioUser_buttonProductos_Click(object sender, EventArgs e)
        {
            FormsProductos prod = new FormsProductos(nombre);
            this.Hide();
            prod.ShowDialog();
            this.Show();
        }

        private void FormsInicioUsuario_buttonAcerca_Click(object sender, EventArgs e)
        {
            FormCreditosRegresar aux = new FormCreditosRegresar();
            this.Hide(); 
            aux.ShowDialog();
            this.Show();
        }

        private void FormsInicioUsuario_buttonPromociones_Click(object sender, EventArgs e)
        {
            FormProductosPromociones prodPromo = new FormProductosPromociones(nombre);
            this.Hide();
            prodPromo.ShowDialog();
            this.Show();
        }

        private void bttCerrarSesion_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormsInicio_Load(object sender, EventArgs e)
        {

        }

        private void FormsInicio_buttonCuenta_Click(object sender, EventArgs e)
        {
            FormsMiCuenta cuenta = new FormsMiCuenta(nombre, contraseña);
            this.Hide();
            cuenta.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCarrito carrito=new FormCarrito(nombre);
            this.Hide();
            carrito.ShowDialog();
            this.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.FormInicio_lblfecha.Text = DateTime.Now.ToShortDateString();
            this.FormInico_lblhora.Text = DateTime.Now.ToShortTimeString();
        }

        private void FormInico_lblhora_Click(object sender, EventArgs e)
        {

        }
    }
}
