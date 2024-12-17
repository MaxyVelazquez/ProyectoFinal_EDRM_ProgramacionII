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
        public PagoConTarjeta()
        {
            InitializeComponent();
        }

        private void FormPagar_BtnRecibo_Click(object sender, EventArgs e)
        {
            
            string Nombre=FormTarjeta_Nombre.Text;
            FormRecibo recibo = new FormRecibo(Nombre);
            this.Hide();
            recibo.ShowDialog();

            BDJuguetes toy = new BDJuguetes();
            Juguetes actualizar=new Juguetes();
            foreach (KeyValuePair<int, int> item in ValoresCompras.carritoCompras)
            {
                
                actualizar=toy.Consultar(item.Key);
                toy.Actualizar(actualizar.Nombre, actualizar.Id, actualizar.Precio, (actualizar.Existencia - item.Value), actualizar.Promocion, actualizar.Imagen);
                
                
            }
            ValoresCompras.carritoCompras.Clear();



        }
    }
}
