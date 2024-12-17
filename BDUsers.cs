using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_EDRM_ProgramacionII
{
    public class BDUsers
    {
        private MySqlConnection conexion;
        
        //INICIAR LA BASE DE DATOS
        public BDUsers()
        {
            this.Connect();
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
        //MÉTODO Log In
        public bool LogIn(string user, string password)
        {
            List<Usuarios> usuarios = new List<Usuarios>();
            Usuarios item;
            string usr;
            string pwd;
            int id;
            string name;
            int monto;
            bool log = false;
            bool findUser = false;
            try
            {
                string ptr = "SELECT * FROM usuarios";
                MySqlCommand comando = new MySqlCommand(ptr, this.conexion);
                MySqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    usr = Convert.ToString(leer["User"]);
                    pwd = Convert.ToString(leer["Contraseña"]);
                    id = Convert.ToInt32(leer["Id"]);
                    name = Convert.ToString(leer["Nombre"]);
                    monto = Convert.ToInt32(leer["Monto"]);

                    item = new Usuarios(usr, pwd, id, name, monto);
                    usuarios.Add(item);
                }
                leer.Close();
                usuarios.ForEach(x =>
                {
                    if (x.Usr == user && x.Pwd == password)
                    {
                        log = true;
                        findUser = true;
                    }
                    else if (x.Usr == user && x.Pwd != password)
                    {
                        findUser = true;
                        MessageBox.Show("La constraseña es incorrecta. Intente de nuevo");
                    }
                });
                if (!findUser)
                {
                    MessageBox.Show("El usuario no se ha encontrado. Verifique los datos");
                }
            }
            catch (Exception ex)
            {
              MessageBox.Show("Error al acceder a los datos");
              this.Disconnect();
            }
            return log;
        }
        public Usuarios Consultar(string toy)
        {
            Usuarios obj = null;
            string usr;
            string pwd;
            int id;
            string name;
            int monto;
            try
            {
                string ptr = "SELECT * FROM usuarios User  = @toy ";
                MySqlCommand comando = new MySqlCommand(ptr, this.conexion);
                comando.Parameters.AddWithValue("@toy", toy);
                MySqlDataReader leer = comando.ExecuteReader();
                while(leer.Read())
                {
                    usr = Convert.ToString(leer["User"]);
                    pwd = Convert.ToString(leer["Contraseña"]);
                    id = Convert.ToInt32(leer["id"]);
                    name = Convert.ToString(leer["Nombre"]);
                    monto = Convert.ToInt32(leer["monto"]);

                    obj = new Usuarios(usr, pwd, id, name, monto);
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
        public void Actualizar(string usr, string pwd, int id, string name, int monto)
        {
            try
            {
                string ptr = "UPDATE usuarios SET User=" + "'" + usr + "'" + ",Contraseña=" + "'" + pwd + "'" + ",id=" + "'" + id + "'" + ",Nombre=" + "'" + name + "'" + ",monto=" + "'" + monto + "where id=" + id + ";";
                MySqlCommand comando = new MySqlCommand(ptr, conexion);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con los datos");
                this.Disconnect();
            }
        }
    }
}

