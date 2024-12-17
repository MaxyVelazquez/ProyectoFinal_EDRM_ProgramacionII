using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_EDRM_ProgramacionII
{
    public class Juguetes
    {
        private string nombre;
        private int id;
        private double precio;
        private int existencia;
        private int promocion;
        private string imagen;
        private string descripcion;

        public Juguetes(string nombre, int id, double precio, int existencia, int promocion, string imagen, string descripcion)
        {
            this.nombre = nombre;
            this.id = id;
            this.precio = precio;
            this.existencia = existencia;
            this.promocion = promocion;
            this.imagen = imagen;
            this.descripcion = descripcion;
        }
        public Juguetes()
        {
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Existencia { get => existencia; set => existencia = value; }
        public int Promocion { get => promocion; set => promocion = value; }
        public string Imagen { get => imagen; set => imagen = value; }
        public string Descrpcion { get => descripcion; set =>  descripcion = value; }
    }
}
