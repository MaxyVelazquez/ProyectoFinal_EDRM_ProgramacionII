﻿using System;
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
    public partial class FormCarrito : Form
    {
        public FormCarrito()
        {
            InitializeComponent();
            CargarCarrito();
        }

        public void CargarCarrito()
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
                            cantidad=item.Value.ToString();
                            
                            exists= true;
                            break;
                        }
                    }
                    if (exists)
                    {
                        AgregarProductoCarro(producto,cantidad);
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

            Label lblCantidad = new Label
            {
                
                Text = "Cantidad:" + cantidad,
                Location = new Point(10, 310),
                AutoSize = false,

            };

            Button btnEliminarCarrito = new Button
            {
                Text = "Eliminar del Carrito",
                Location = new Point(10, 380),
                Size = new Size(250, 40),  // Modificar tamaño
                BackColor = Color.Coral,   // Color de fondo
                ForeColor = Color.White,   // Color del texto
                Font = new Font("Arial", 10, FontStyle.Bold), // Modificar la fuente
                FlatStyle = FlatStyle.Flat, // Estilo plano sin bordes
            };

            // Asignar el evento de clic del botón
            btnEliminarCarrito.Click += (sender, e) =>
            {
                if (ValoresCompras.carritoCompras.Remove(Convert.ToInt32(producto["Id"])))
                {
                    MessageBox.Show(Convert.ToString(producto["Nombre"]) + "Se ha eliminado del carrito");
                    PanelCarrito.Controls.Clear();
                    CargarCarrito();
                }

            };







            // Agregar controles al panel
            panelProducto.Controls.Add(pictureBox);
            panelProducto.Controls.Add(lblNombre);
            panelProducto.Controls.Add(lblCantidad);
            panelProducto.Controls.Add(btnEliminarCarrito);


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
            PanelCarrito.Controls.Add(panelProducto);
        }


        private void FormCarrito_Load(object sender, EventArgs e)
        {

        }

        private void FormCarro_BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PagoConTarjeta enviar = new PagoConTarjeta();
            this.Hide();
            enviar.ShowDialog();
            
        }

        private void FormCarro_Efectivo_Click(object sender, EventArgs e)
        {
            FormEfectivo enviar = new FormEfectivo();
            this.Hide();
            enviar.ShowDialog();
        }
    }
}
