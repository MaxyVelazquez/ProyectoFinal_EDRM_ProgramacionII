using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoFinal_EDRM_ProgramacionII
{
    public partial class FormsAdminEditar : Form
    {
        List<Juguetes> data;
        public FormsAdminEditar()
        {
            InitializeComponent();
        }

        private void FormsAdminEditar_Load(object sender, EventArgs e)
        {
            

        }

        private void FormsAdminEditar_buttonRegresar_Click(object sender, EventArgs e)
        {
            FormsLogIn regreso = new FormsLogIn();
            this.Hide();
            regreso.ShowDialog();
        }

        private void FormsAdminEditar_buttonActualizar_Click(object sender, EventArgs e)
        {
            string nombre;
            int id;
            double precio;
            int existencia;
            int promocion;
            string imagen;

            nombre = Convert.ToString(this.FormsAdminEditar_txtNombre.Text);
            id=Convert.ToInt32(this.FormsAdminEditar_txtId.Text);
            precio=Convert.ToDouble(this.FormsAdminEditar_txtPrecio.Text);
            existencia=Convert.ToInt32(this.FormsAdminEditar_txtExistencia.Text);
            if (this.FormsAdminEditar_txtPromocion.Text == "0")
            {
                promocion= 0;
            }
            else
            {
                promocion = 1;
            }
            
            imagen=Convert.ToString(this.FormsAdminEditar_txtImagen.Text);


            BDJuguetes aux=new BDJuguetes();
            aux.Actualizar(nombre, id, precio, existencia, promocion, imagen);
        }

        private void FromAdmin_BtnActualizar_Click(object sender, EventArgs e)
        {
            

            
        }

        private void FormAdmin_BtnVerGrafica_Click(object sender, EventArgs e)
        {
            Grafica ver = new Grafica();
            this.Hide();
            ver.ShowDialog();
        }
    }
}
