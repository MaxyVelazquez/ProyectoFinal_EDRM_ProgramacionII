using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_EDRM_ProgramacionII
{
    public class BDJuguetes
    {
        private MySqlConnection conexion;
        
        public BDJuguetes()
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
            catch(Exception e)
            {
                MessageBox.Show($"Error al conectar con la base de datos {e.Message}");
            }
        }
        public void Disconnect()
        {
            if(conexion!=null && conexion.State==System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }

        public List <Juguetes> Buscar()
        {
            List<Juguetes> datos = new List<Juguetes>();
            Juguetes obj;
            string nombre;
            int id;
            double precio;
            int existencia;
            int promocion;
            string imagen;
            string descripcion;

            try
            {
                string ptr = "SELECT * FROM juguetes";
                MySqlCommand comando = new MySqlCommand(ptr, this.conexion);
                MySqlDataReader leer = comando.ExecuteReader();

                while(leer.Read())
                {
                    nombre = Convert.ToString(leer["Nombre"]);
                    id = Convert.ToInt32(leer["Id"]);
                    precio = Convert.ToDouble(leer["Precio"]);
                    existencia = Convert.ToInt32(leer["Existencia"]);
                    promocion = Convert.ToInt32(leer["Promocion"]);
                    imagen = Convert.ToString(leer["imagen"]);
                    descripcion = Convert.ToString(leer["descripcion"].ToString());

                    obj = new Juguetes(nombre, id, precio, existencia, promocion, imagen, descripcion);
                    datos.Add(obj);
                }
                leer.Close();
                datos.ForEach((p) =>
                {
                    //MessageBox.Show(p.Id+","+p.Producto+","+p.Imagen+","+p.Precio);
                });
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al leer los datos");
                this.Disconnect();
            }
            return datos;
        }
        public void Altas(string Name, int ID, double Price, bool exist, bool Promo, string image)
        {
            string ptr = "";
            try
            {
                ptr = "INSERT INTO juguetes (Nombre,Id,Precio,Existencia, Promocion, imagen) VALUES ("
                    + "'" + Name + "'"
                    + "'" + ID + "'"
                    + "'" + Price + "'"
                    + "'" + exist + "'"
                    + "'" + Promo + "'"
                    + "'" + image + "'";
                MySqlCommand comando = new MySqlCommand(ptr, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro agregado exitosamente");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al insertar los datos");
                this.Disconnect();
            }
        }

        public Juguetes Consultar(int toy)
        {
            Juguetes obj = null;
            string nombre;
            int id;
            double precio;
            int existencia;
            int promocion;
            string imagen;
            string descripcion;
            try
            {
                string ptr = "SELECT * FROM juguetes where id=" + toy + ";";
                MySqlCommand comando = new MySqlCommand(ptr, this.conexion);
                MySqlDataReader leer = comando.ExecuteReader();
                while(leer.Read())
                {
                    nombre = Convert.ToString(leer["Nombre"]);
                    id = Convert.ToInt32(leer["Id"]);
                    precio = Convert.ToDouble(leer["Precio"]);
                    existencia = Convert.ToInt32(leer["Existencia"]);
                    promocion = Convert.ToInt32(leer["Promocion"]);
                    imagen = Convert.ToString(leer["imagen"]);
                    descripcion = Convert.ToString(leer["descripcion"]);

                    obj = new Juguetes(nombre, id, precio, existencia, promocion, imagen, descripcion);
                }
                leer.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al acceder a los datos");
                this.Disconnect();
            }
            return obj;
        }
        public void Bajas(int toy)
        {
            string ptr = "";
            try
            {
                ptr = "DELETE FROM juguetes WHERE id=" + toy + ";";
                MySqlCommand comando = new MySqlCommand(ptr, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Has Eliminado el objeto con exito");

                //AQUI HACE FALTA AGREGAR CUANDO EL ADMIN QUIERA DAR DE BAJA UN ELEMENTO
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al acceder a los datos");
                this.Disconnect();
            }
        }

        public int ContarProductos()
        {
            int count = 0;
            try
            {
                string query = "SELECT COUNT(*) FROM juguetes";
                MySqlCommand comando = new MySqlCommand(query, this.conexion);
                count = Convert.ToInt32(comando.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al contar productos: " + ex.Message);
            }
            return count;
        }
        public void Actualizar(string nombre, int id, double precio, int existencia, int promocion, string imagen, string descripcion)
        {
            try
            {
                string ptr = "UPDATE juguetes SET Nombre='" + nombre + "', Id='" + id + "', Precio='" + precio + "', Existencia='" + existencia + "', Promocion='" + promocion + "', imagen='" + imagen + "', descripcion='"+descripcion + "' WHERE Id='" + id + "';";

                MySqlCommand comando = new MySqlCommand(ptr, conexion);
                
                comando.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al conectar con los datos"+ex.Message);
                this.Disconnect();
            }
        }
    }
}
