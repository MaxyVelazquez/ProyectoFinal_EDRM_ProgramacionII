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
    public partial class FormVentas : Form
    {
        private string nombre;
        public FormVentas()
        {
            InitializeComponent();
            imprimirDatos();
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {

        }
        public FormVentas(string nombre)
        {
            this.nombre = nombre;
            InitializeComponent();
            imprimirDatos();
            this.FormsVentas_txtNombre.Text = nombre;
        }
        public void imprimirDatos()
        {
            BDUsers baseUsuarios = new BDUsers();
            BDCantidadCompras bDCantidadCompras = new BDCantidadCompras();
            Usuarios aux1 = baseUsuarios.Consultar("ReyPicazo");
            Usuarios aux2 = baseUsuarios.Consultar("MaxyVelazquez");
            Usuarios aux3 = baseUsuarios.Consultar("EmilioAvila");
            Usuarios aux4 = baseUsuarios.Consultar("DiegoDelgado");
            Usuarios aux5 = baseUsuarios.Consultar("Guest");

            float montoTotal = (aux1.Monto + aux2.Monto + aux3.Monto + aux4.Monto + aux5.Monto);

            lblUsuario1.Text = aux1.Usr;
            lblUsuario2.Text = aux2.Usr;
            lblUsuario3.Text = aux3.Usr;
            lblUsuario4.Text = aux4.Usr;
            lblUsuario5.Text = aux5.Usr;

            lblMonto1.Text = Convert.ToString(aux1.Monto);
            lblMonto2.Text = Convert.ToString(aux2.Monto);
            lblMonto3.Text = Convert.ToString(aux3.Monto);
            lblMonto4.Text = Convert.ToString(aux4.Monto);
            lblMonto5.Text = Convert.ToString(aux5.Monto);
            lblMontoTotal.Text = Convert.ToString(montoTotal);
            lblVentasFin.Text = Convert.ToString(bDCantidadCompras.obtenerCantidad());

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.FormVenta_lblfecha.Text = DateTime.Now.ToShortDateString();
            this.FormVentas_lblhora.Text = DateTime.Now.ToShortTimeString();
        }

        private void FormVentas_lblhora_Click(object sender, EventArgs e)
        {

        }
    }
}
