﻿using System;
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
        public FormVentas()
        {
            InitializeComponent();
            imprimirDatos();
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {

        }

        public void imprimirDatos()
        {
            BDUsers baseUsuarios = new BDUsers();
            BDCantidadCompras bDCantidadCompras = new BDCantidadCompras();
            Usuarios aux1 = baseUsuarios.Consultar(300388);
            Usuarios aux2 = baseUsuarios.Consultar(301026);
            Usuarios aux3 = baseUsuarios.Consultar(301246);
            Usuarios aux4 = baseUsuarios.Consultar(300435);
            Usuarios aux5 = baseUsuarios.Consultar(999);

            int montoTotal = (aux1.Monto + aux2.Monto + aux3.Monto + aux4.Monto + aux5.Monto);

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
    }
}