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

namespace ProyectoFinal_EDRM_ProgramacionII
{
    public partial class FormListadoMayor : Form
    {
        public FormListadoMayor()
        {
            InitializeComponent();
            CargarProductos();
        }

        private void flowListado_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CargarProductos()
        {
            BDJuguetes baseDatos = new BDJuguetes();
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM juguetes ORDER BY existencia ASC", baseDatos.GetConnection());
                DataTable productos = new DataTable();
                adapter.Fill(productos);
                baseDatos.Disconnect();

                // Crear controles dinámicamente
                foreach (DataRow producto in productos.Rows)
                {
                    AgregarProducto(producto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message);
            }
        }

        public void AgregarProducto(DataRow producto)
        {
            // Crear un panel para el producto
            Panel panelProducto = new Panel
            {
                Size = new Size(270, 440),
                Margin = new Padding(10)
            };

            // PictureBox para la imagen
            PictureBox pictureBox = new PictureBox
            {
                Size = new Size(250, 250),
                Location = new Point(10, 10),
                SizeMode = PictureBoxSizeMode.Zoom
            };

            string rutaImagen = Path.Combine(Application.StartupPath, @"..\..\imagenesJuguetes", producto["imagen"].ToString());

            if (System.IO.File.Exists(rutaImagen))
            {
                pictureBox.Image = Image.FromFile(rutaImagen);
            }

            // Labels para nombre, precio y descripción
            Label lblNombre = new Label
            {
                Text = producto["nombre"].ToString(),
                Location = new Point(10, 260),
                AutoSize = true,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };

            int projo = Convert.ToInt32(producto["Precio"]) + 400;


            Label lblPrecio1 = new Label
            {
                Text = "Precio: $" + producto["precio"].ToString(),
                Location = new Point(10, 290),
                AutoSize = true
            };

            Label lblPrecio2 = new Label
            {
                Text = projo.ToString(),
                Location = new Point(80, 290),
                Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Strikeout),
                ForeColor = Color.Red,
                AutoSize = true
            };


            Label lblPrecio3 = new Label
            {
                Text = "Precio: $" + producto["precio"].ToString(),
                Location = new Point(10, 290),
                AutoSize = true
            };

            Label lblExistencias = new Label
            {
                Text = "Existencia: " + producto["Existencia"].ToString(),
                Location = new Point(10, 310),
                AutoSize = true,

            };

            Label lblDescripcion = new Label
            {
                Text = producto["descripcion"].ToString(),
                Location = new Point(10, 330),
                AutoSize = false,
                Size = new Size(270, 50),
                Font = new Font("Microsoft Sans Serif", 7, FontStyle.Regular),
                TextAlign = ContentAlignment.TopLeft  // Alinear el texto a la izquierda y hacia arriba
            };

            // Crear el botón "Agregar al carrito"
            Button btnActializarProdcuto = new Button
            {
                Text = "Actualizar Producto",
                Location = new Point(10, 380),
                Size = new Size(250, 40),  // Modificar tamaño
                BackColor = Color.Coral,   // Color de fondo
                ForeColor = Color.White,   // Color del texto
                Font = new Font("Arial", 10, FontStyle.Bold), // Modificar la fuente
                FlatStyle = FlatStyle.Flat, // Estilo plano sin bordes
            };

            // Asignar el evento de clic del botón
            btnActializarProdcuto.Click += (sender, e) =>
            {
                int id = Convert.ToInt32(producto["Id"]);
                string nombre = producto["Nombre"].ToString();
                float precio = float.Parse(producto["Precio"].ToString());
                int existencia = Convert.ToInt32(producto["Existencia"]);
                string descripcion = producto["descripcion"].ToString();
                string imagen=producto["imagen"].ToString();
                int promocion = Convert.ToInt32(producto["Promocion"]);

                FormJuguete formActualizar = new FormJuguete(nombre, id, precio, existencia, promocion, imagen, descripcion);

                // Mostrar el formulario
                formActualizar.ShowDialog();
                flowListado.Controls.Clear();
                CargarProductos();

            };

            // Agregar controles al panel
            panelProducto.Controls.Add(pictureBox);
            panelProducto.Controls.Add(lblNombre);
            panelProducto.Controls.Add(lblDescripcion);
            panelProducto.Controls.Add(btnActializarProdcuto);
            panelProducto.Controls.Add(lblExistencias);


            if (Convert.ToInt32(producto["Promocion"]) == 1)
            {
                panelProducto.Controls.Add(lblPrecio1);
                panelProducto.Controls.Add(lblPrecio2);
            }
            else
            {
                panelProducto.Controls.Add(lblPrecio3);
            }

            // Agregar el panel al FlowLayoutPanel
            flowListado.Controls.Add(panelProducto);
        }
    }
}
