using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_EDRM_ProgramacionII
{
    public class Usuarios
    {
        private string usr;
        private string pwd;
        private int id;
        private string name;
        private int monto;

        public Usuarios(string usr, string pwd, int id, string name, int monto)
        {
            this.usr = usr;
            this.pwd = pwd;
            this.id = id;
            this.name = name;
            this.monto = monto;
        }
        public Usuarios()
        {
            this.usr = usr;
            this.pwd = pwd;
            this.id = id;
            this.name = name;
            this.monto = monto;
        }

        public string Usr { get => usr; set => usr = value; }
        public string Pwd { get => pwd; set => pwd = value; }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Monto { get => monto; set => monto = value; }
    }
}
