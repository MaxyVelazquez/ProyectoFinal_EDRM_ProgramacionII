using MySql.Data.MySqlClient;
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
    public partial class FormsCreditos : Form
    {
        public FormsCreditos()
        {
            InitializeComponent();
        }

        private void FormsCreditos_Load(object sender, EventArgs e)
        {

        }

        private void buttonFormsCreditos_Iniciar_Click(object sender, EventArgs e)
        {
            FormsLogIn logIn = new FormsLogIn();
            this.Hide();
            logIn.ShowDialog();
            this.Show();
        }
    }
}
