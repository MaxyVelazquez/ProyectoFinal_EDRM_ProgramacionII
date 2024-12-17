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
    public partial class FormIdBorrar : Form
    {
        public FormIdBorrar()
        {
            InitializeComponent();
        }

        private void FormIdBorrar_Load(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            int idEliminar = Convert.ToInt32(txtIdBorrar.Text);
            FormBorrarJuguete formBorrarJuguete = new FormBorrarJuguete(idEliminar);
            this.Close();
            formBorrarJuguete.ShowDialog();

        }
    }
}
