using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.Collections;

namespace ProyectoFinal_EDRM_ProgramacionII
{
    public partial class PagoConTarjeta : Form
    {
        List<Juguetes> lista;
        int cantidad = 0;
        private string nombre;
        public PagoConTarjeta()
        {
            InitializeComponent();
        }
        public PagoConTarjeta(string nombre)
        {
            this.nombre = nombre;
            InitializeComponent();
            this.FormsPagoTarjeta_txtNombre.Text = nombre;
        }

        private void FormPagar_BtnRecibo_Click(object sender, EventArgs e)
        {
            
            string Nombre=FormTarjeta_Nombre.Text;
            string clave = FormTarjeta_txtClave.Text;
            string CVV = FormTarjeta_txtCVV.Text;
            if(clave.Length!= 18 || CVV.Length != 3)
            {
                MessageBox.Show("Los datos introducidos son incorrectos");
            }
            if(clave.Length == 18 || CVV.Length == 3)
            {
                FormRecibo recibo = new FormRecibo(Nombre);
                this.Hide();
                recibo.ShowDialog();

                BDJuguetes toy = new BDJuguetes();
                Juguetes actualizar = new Juguetes();
                foreach (KeyValuePair<int, int> item in ValoresCompras.carritoCompras)
                {
                    BDUsers obj=new BDUsers();
                    
                    actualizar = toy.Consultar(item.Key);
                    toy.Actualizar(actualizar.Nombre, actualizar.Id, actualizar.Precio, (actualizar.Existencia - item.Value), actualizar.Promocion, actualizar.Imagen);


                }
                ValoresCompras.carritoCompras.Clear();
            }
        }

        private void PagoConTarjeta_Load(object sender, EventArgs e)
        {

        }

        private void bttSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
