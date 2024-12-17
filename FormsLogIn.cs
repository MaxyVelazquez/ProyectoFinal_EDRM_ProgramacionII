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
            
             if(obj.LogIn(nombre, contraseña))
            {
                if (nombre == "Admin" && contraseña == "RinconTesoros1234")
                {
                    FormPrincipalAdmin Iniciar = new FormPrincipalAdmin(nombre);
                    MessageBox.Show($"Bienvenido {nombre}");
                    this.Hide();
                    Iniciar.ShowDialog();
                    FormsLogIn_txtNombre.Clear();
                    FormsLogIn_txtContraseña.Clear();
                    this.Show();
                }
                else
                {
                    FormsInicio iniciar = new FormsInicio(nombre, contraseña);
                    MessageBox.Show($"Bienvenido {nombre}");
                    this.Hide();
                    iniciar.ShowDialog();
                    FormsLogIn_txtNombre.Clear();
                    FormsLogIn_txtContraseña.Clear();
                    this.Show();
                }
                


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
            string nombre;
            string contraseña;
            BDUsers obj= new BDUsers();
            nombre = Convert.ToString("Guest");
            contraseña = Convert.ToString("0");
            FormsInicio iniciar = new FormsInicio(nombre, contraseña);
            MessageBox.Show($"Gracias por acceder al sistema");
            this.Hide();
            iniciar.ShowDialog();
            FormsLogIn_txtNombre.Clear();
            FormsLogIn_txtContraseña.Clear();
            this.Show();
        }

        private void bttSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormsLogIn_txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormsLogIn_txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
