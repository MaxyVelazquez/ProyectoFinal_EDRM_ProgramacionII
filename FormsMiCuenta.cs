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
    public partial class FormsMiCuenta : Form
    {
        private string nombre;
        private string contraseña;
        public FormsMiCuenta()
        {
            InitializeComponent();
        }
        public FormsMiCuenta(string nombre, string contraseña)
        {
            this.nombre= nombre;
            this.contraseña = contraseña;
            InitializeComponent();
            this.FormsMiCuenta_txtNombre.Text= nombre;
            this.FormsMiCuenta_txtContraseña.Text = contraseña;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FormsMiCuenta_buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormsMiCuenta_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.FormCuenta_lblfecha.Text = DateTime.Now.ToShortDateString();
            this.FormCuenta_lblhora.Text = DateTime.Now.ToShortTimeString();
        }
    }
}
