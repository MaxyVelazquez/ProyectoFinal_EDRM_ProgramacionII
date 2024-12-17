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
using static iTextSharp.awt.geom.Point2D;


namespace ProyectoFinal_EDRM_ProgramacionII
{
    public partial class FormJuguete : Form
    {
        private int productoId;
        public FormJuguete(string nombre, int id, float precio, int existencia, int promocion, string imagen, string descripcion)
        {
            InitializeComponent();

            productoId = id;
            txtNombre.Text = nombre;
            txtPrecio.Text = precio.ToString();
            txtExistencia.Text = existencia.ToString();
            txtDescripcion.Text = descripcion;
            txtImagen.Text = imagen;
            txtPromocion.Text = promocion.ToString();
        }

        private void FormJuguete_Load(object sender, EventArgs e)
        {

        }

        private void bttActualizarRegistro_Click(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text;
            float precio = float.Parse(txtPrecio.Text);
            int existencia = Convert.ToInt32(txtExistencia.Text);
            string descripcion = txtDescripcion.Text;
            string imagen = txtImagen.Text;
            int promocion = Convert.ToInt32(txtPromocion.Text);

            try
            {
                BDJuguetes baseDatos = new BDJuguetes();
                string query = "UPDATE juguetes SET Nombre = @nombre, Precio = @precio, Existencia = @existencia, Promocion = @promocion, imagen = @imagen, descripcion = @descripcion WHERE Id = @id";

                MySqlCommand cmd = new MySqlCommand(query, baseDatos.GetConnection());
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@precio", precio);
                cmd.Parameters.AddWithValue("@existencia", existencia);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@imagen", imagen);
                cmd.Parameters.AddWithValue("@promocion", promocion);
                cmd.Parameters.AddWithValue("@id", productoId);
                cmd.ExecuteNonQuery();
                baseDatos.GetConnection().Close();

                MessageBox.Show("Producto Actualizado");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el producto: " + ex.Message);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
