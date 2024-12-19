using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoFinal_EDRM_ProgramacionII
{
    public partial class FormJugueteNuevo : Form
    {
        private string nombre;
        public FormJugueteNuevo()
        {
            InitializeComponent();
        }
        public FormJugueteNuevo(string nombre)
        {
            this.nombre=nombre;
            InitializeComponent();
            this.FormsJugueteNuevo_txtNombre.Text = nombre;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtName.Text;
            int id = Convert.ToInt32(txtId.Text);
            float precio = float.Parse(txtPrecio.Text);
            int existencia = Convert.ToInt32(txtExistencia.Text);
            string descripcion = txtDescripcion.Text;
            string imagen = txtImagen.Text;
            int promocion = Convert.ToInt32(txtPromocion.Text);

            try
            {
                BDJuguetes baseDatos = new BDJuguetes();

                string query = "INSERT INTO juguetes (Nombre, Id, Precio, Existencia, Promocion, imagen, descripcion) " +
                               "VALUES (@nombre, @id, @precio, @existencia, @promocion, @imagen, @descripcion);";

                MySqlCommand cmd = new MySqlCommand(query, baseDatos.GetConnection());
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@precio", precio);
                cmd.Parameters.AddWithValue("@existencia", existencia);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@imagen", imagen);
                cmd.Parameters.AddWithValue("@promocion", promocion);
                cmd.ExecuteNonQuery();
                baseDatos.GetConnection().Close();

                MessageBox.Show("Producto agregado exitosamente");

                txtName.Clear();
                txtPrecio.Clear();
                txtExistencia.Clear();
                txtDescripcion.Clear();
                txtImagen.Clear();
                txtPromocion.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el producto: " + ex.Message);
            }

            this.Close();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormJugueteNuevo_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.FormNuevo_lblfecha.Text=DateTime.Now.ToShortDateString();
            this.FormNuevo_lblhora.Text=DateTime.Now.ToShortTimeString();
        }
    }
}
