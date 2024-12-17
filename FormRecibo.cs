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
using Google.Protobuf.Collections;

namespace ProyectoFinal_EDRM_ProgramacionII
{
    public partial class FormRecibo : Form
    {
        private string name = "";
        private int subtotal = 0;
        private double total = 0;
        public FormRecibo()
        {
            InitializeComponent();
        }
        public FormRecibo(string nombre)
        {
            InitializeComponent();
            name= nombre;
            MostrarCompra();
            

        }
        public void MostrarCompra()
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
            
            subtotal += (Convert.ToInt32(producto["Precio"]))*Convert.ToInt32(cantidad);
            string nombre = Convert.ToString(producto["Nombre"]);
            string precio = Convert.ToString(producto["Precio"]);

            

            this.richTextBox1.AppendText(cantidad + " --------------- " + nombre + " xxxxxxxxxxxxxxxxx" + "   $" + precio +"\n");

            
            total = subtotal + (subtotal * 0.06);
            LblSubtotal.Text= subtotal.ToString();
            label7.Text = total.ToString();





















            // Agregar controles al panel



            // Agregar el panel al FlowLayoutPanel

        }

        private void FormRecibo_Load(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToLongDateString();
            string hora = DateTime.Now.ToShortTimeString();
            label2.Text = fecha;
            label3.Text = hora;
            LbLShowName.Text = name;
            
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            Random aleatorio = new Random();
            PDF1 archivo = new PDF1 ();
            int numero = aleatorio.Next(10000000, 100000000);
            archivo.NombrePdf = numero.ToString();
            archivo.logo = picLogo.Image;
            ProcesarPDF2 PDF = new ProcesarPDF2();
            PDF.crearPdf(archivo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
