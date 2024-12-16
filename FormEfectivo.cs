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
    public partial class FormEfectivo : Form
    {
        private int subtotal = 0;
        double total = 0; 
        public FormEfectivo()
        {
            InitializeComponent();
            MostrarComprar();
        }

        public void MostrarComprar()
        {
            BDJuguetes baseDatos = new BDJuguetes();
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM juguetes", baseDatos.GetConnection());
                DataTable productos = new DataTable();
                adapter.Fill(productos);
                baseDatos.Disconnect();

                // Crear controles dinámicamente
                foreach (DataRow producto in productos.Rows)
                {
                    string cantidad = "";
                    bool exists = false;
                    foreach (KeyValuePair<int, int> item in ValoresCompras.carritoCompras)
                    {
                        if (item.Key == Convert.ToInt32(producto["Id"]))
                        {
                            cantidad = item.Value.ToString();

                            exists = true;
                            break;
                        }
                    }
                    if (exists)
                    {
                        AgregarProductoCarro(producto, cantidad);
                    }
                    exists = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message);
            }
        }
        private void AgregarProductoCarro(DataRow producto, String cantidad)
        {

            subtotal += (Convert.ToInt32(producto["Precio"])) * Convert.ToInt32(cantidad);
            string nombre = Convert.ToString(producto["Nombre"]);
            string precio = Convert.ToString(producto["Precio"]);



            this.richTextBox1.AppendText(cantidad + " --------------- " + nombre + " xxxxxxxxxxxxxxxxx" + "   $" + precio + "\n");


            total = subtotal + (subtotal * 0.06);
            labelSubtotal.Text = subtotal.ToString();
            labelTotal.Text = total.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void FormEfectivo_Load(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToLongDateString();
            string hora = DateTime.Now.ToShortTimeString();
            labelFecha.Text = fecha;
            labelHora.Text = hora;
        }

        private void btnGenerarRecibo_Click(object sender, EventArgs e)
        {
            Random aleatorio = new Random();
            PDF1 archivo = new PDF1();
            int numero = aleatorio.Next(10000000, 100000000);
            archivo.NombrePdf = numero.ToString();
            archivo.logo = picLogo.Image;
            archivo.qr = picQR.Image;
            archivo.oxxo = picOxxo.Image;
            archivo.bbva = picBBVA.Image;
            archivo.santander = picSantander.Image;
            ProcesarPDF PDF = new ProcesarPDF();
            BDJuguetes lista = new BDJuguetes();
            List<Juguetes> listila = lista.Buscar();
            PDF.crearPdf(archivo, listila);
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
