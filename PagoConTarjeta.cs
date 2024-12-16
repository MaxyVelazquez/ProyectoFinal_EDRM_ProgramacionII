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
    public partial class PagoConTarjeta : Form
    {
        public PagoConTarjeta()
        {
            InitializeComponent();
        }

        private void FormPagar_BtnRecibo_Click(object sender, EventArgs e)
        {
            
            string Nombre=FormTarjeta_Nombre.Text;
            FormRecibo recibo = new FormRecibo(Nombre);
            this.Hide();
            recibo.ShowDialog();
            


        }
    }
}
