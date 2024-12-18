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
using System.IO;

namespace ProyectoFinal_EDRM_ProgramacionII
{
    public partial class FormProductosPromociones : Form
    {
        private string nombre;
        public FormProductosPromociones()
        {
            InitializeComponent();
            CargarProductos();
        }
        public FormProductosPromociones(string nombre)
        {
            this.nombre = nombre;
            InitializeComponent();
            CargarProductos();
            this.FormsPromociones_txtNombre.Text = nombre;

        }
        private void FormsProductosPromociones_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CargarProductos()
        {
            BDJuguetes baseDatos = new BDJuguetes();
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM juguetes ORDER BY Id ASC", baseDatos.GetConnection());
                DataTable productos = new DataTable();
                adapter.Fill(productos);
                baseDatos.Disconnect();

                // Crear controles dinámicamente
                foreach (DataRow producto in productos.Rows)
                {
                    if (Convert.ToInt32(producto["promocion"]) == 1)
                    {
                        AgregarProducto(producto);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message);
            }
        }

            private void AgregarProducto(DataRow producto)
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
                AutoSize = false,

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
            Button btnAgregarCarrito = new Button
            {
                Text = "Agregar al Carrito",
                Location = new Point(10, 380),
                Size = new Size(250, 40),  // Modificar tamaño
                BackColor = Color.Coral,   // Color de fondo
                ForeColor = Color.White,   // Color del texto
                Font = new Font("Arial", 10, FontStyle.Bold), // Modificar la fuente
                FlatStyle = FlatStyle.Flat, // Estilo plano sin bordes
            };

            // Asignar el evento de clic del botón
            btnAgregarCarrito.Click += (sender, e) =>
            {
                BDJuguetes baseDatos = new BDJuguetes();

                int cantidadProductos = baseDatos.ContarProductos();
                if (cantidadProductos < 6)
                {
                    MessageBox.Show("No se puede agregar el producto, ya que hay 6 o menos productos en la base de datos.");
                    return;
                }
                FormCantidad formCantidad = new FormCantidad(producto["Nombre"].ToString(), Convert.ToInt32(producto["Existencia"]));
                formCantidad.ShowDialog();
                if (formCantidad.Cant != 0)
                {
                    if (ValoresCompras.carritoCompras.ContainsKey(Convert.ToInt32(producto["id"])))
                    {
                        ValoresCompras.carritoCompras[Convert.ToInt32(producto["id"])] += formCantidad.Cant;
                    }
                    else
                    {
                        ValoresCompras.carritoCompras[Convert.ToInt32(producto["id"])] = 1;
                        ValoresCompras.carritoCompras[Convert.ToInt32(producto["id"])] += formCantidad.Cant - 1;
                    }
                }

            };

            // Agregar controles al panel
            panelProducto.Controls.Add(pictureBox);
            panelProducto.Controls.Add(lblNombre);
            panelProducto.Controls.Add(lblDescripcion);
            panelProducto.Controls.Add(btnAgregarCarrito);
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
            flowLayoutPanel1.Controls.Add(panelProducto);
        }

        private void bttRecargar_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            CargarProductos();
        }

        private void bttCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormProductosPromociones_Load(object sender, EventArgs e)
        {

        }

        private void FormsPromociones_buttonCarrito_Click(object sender, EventArgs e)
        {
            FormCarrito carro = new FormCarrito(nombre);
            this.Hide();
            carro.ShowDialog();
            this.Show();
        }
    }
}
