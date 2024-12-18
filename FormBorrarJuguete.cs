using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using Org.BouncyCastle.Asn1.Ocsp;

namespace ProyectoFinal_EDRM_ProgramacionII
{
    public partial class FormBorrarJuguete : Form
    {
        private int idElim;
        public FormBorrarJuguete(int idEliminar)
        {
            InitializeComponent();
            idElim = idEliminar;
            CargarDatosProducto(idElim);
        }

        private void FormBorrarJuguete_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarDatosProducto(int id)
        {
            BDJuguetes baseDatos = new BDJuguetes();
            Juguetes producto = baseDatos.Consultar(id);

            if (producto != null)
            {
                lNombre.Text = producto.Nombre;
                lId.Text = producto.Id.ToString();
                lDescripcion.Text = producto.Descripcion;
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
                this.Close();
            }
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            BDJuguetes baseDatos = new BDJuguetes();
            baseDatos.Bajas(idElim);
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.FormBorrar_lblhora.Text=DateTime.Now.ToShortTimeString();
            this.FormBorrar_lblfecha.Text=DateTime.Now.ToShortDateString();
        }
    }
}
