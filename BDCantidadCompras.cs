using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ProyectoFinal_EDRM_ProgramacionII
{
    public class BDCantidadCompras
    {
        private MySqlConnection conexion;

        public BDCantidadCompras()
        {
            this.Connect();
        }

        public MySqlConnection GetConnection()
        {
            if (conexion.State != System.Data.ConnectionState.Open)
            {
                Connect();
            }
            return conexion;
        }

        //MÉTODOS CONNECT Y DISCONNECT
        public void Connect()
        {
            string connect = "Server=localhost; Database=rincon_tesoros; User=root; Password=; SslMode=none;";
            try
            {
                conexion = new MySqlConnection(connect);
                conexion.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error al conectar con la base de datos {e.Message}");
            }
        }
        public void Disconnect()
        {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }

        public int obtenerCantidad()
        {
            int cantidad = 0;

            try
            {
                string query = "SELECT Compras FROM cantidadcompras LIMIT 1";
                MySqlCommand comando = new MySqlCommand(query, this.GetConnection());
                object resultado = comando.ExecuteScalar();

                if (resultado != null)
                {
                    cantidad = Convert.ToInt32(resultado);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener la cantidad: {ex.Message}");
            }

            return cantidad;
        }

        public void sumarCantidad(int cantidadAgregar)
        {
            try
            {
                int cantidadActual = obtenerCantidad();

                int nuevaCantidad = cantidadActual + cantidadAgregar;

                string query = "UPDATE cantidadCompras SET Compras = @nuevaCantidad LIMIT 1";
                MySqlCommand comando = new MySqlCommand(query, this.GetConnection());
                comando.Parameters.AddWithValue("@nuevaCantidad", nuevaCantidad);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al sumar la cantidad: {ex.Message}");
            }
        }
    }
}