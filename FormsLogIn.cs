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
    public partial class FormsLogIn : Form
    {
        public FormsLogIn()
        {
            InitializeComponent();
        }

        private void FormsLogIn_IniciarSesion_Click(object sender, EventArgs e)
        {
            string nombre;
            string contraseña;

            BDUsers obj=new BDUsers();

            nombre = Convert.ToString(this.FormsLogIn_txtNombre.Text);
            contraseña=Convert.ToString(this.FormsLogIn_txtContraseña.Text);
            if(nombre=="Admin" && contraseña=="RinconTesoros1234")
            {
                FormsAdminEditar editar= new FormsAdminEditar();
                MessageBox.Show($"Bienvenido {nombre}");
                this.Hide();
                editar.ShowDialog();
                this.Show();
            }
            else if(obj.LogIn(nombre, contraseña))
            {
                FormsInicio iniciar= new FormsInicio(nombre, contraseña);
                MessageBox.Show($"Bienvenido {nombre}");
                this.Hide();
                iniciar.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("No fue posible encontrar este usuario, Vuelve a intentarlo");
            }
        }
        private void FormsLogIn_Load(object sender, EventArgs e)
        {

        }

        private void bttInvitado_Click(object sender, EventArgs e)
        {
            FormsInicio iniciar = new FormsInicio();
            MessageBox.Show($"Gracias por acceder al sistema");
            this.Hide();
            iniciar.ShowDialog();
            this.Show();
        }

        private void bttSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormsLogIn_txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormsLogIn_txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
