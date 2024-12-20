﻿using System;
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
        private string nombre;
        List<Juguetes> lista;
        int cantidad = 0;
        public PagoConTarjeta()
        {
            InitializeComponent();
        }
        public PagoConTarjeta(string nombre)
        {
            this.nombre=nombre;
            InitializeComponent();
            this.FormsPago_txtNombre.Text = nombre;
        }

        private void FormPagar_BtnRecibo_Click(object sender, EventArgs e)
        {
            
            string Nombre=FormTarjeta_Nombre.Text;
            FormRecibo recibo = new FormRecibo(Nombre);
            this.Hide();
            recibo.ShowDialog();

            

            BDJuguetes toy = new BDJuguetes();
            Juguetes actualizar=new Juguetes();
            Usuarios usuarios = new Usuarios();
            BDUsers adminUsr = new BDUsers();
            usuarios = adminUsr.Consultar(nombre);
            foreach (KeyValuePair<int, int> item in ValoresCompras.carritoCompras)
            {
                actualizar = toy.Consultar(item.Key);
                toy.Actualizar(actualizar.Nombre, actualizar.Id, actualizar.Precio, (actualizar.Existencia - item.Value), actualizar.Promocion, actualizar.Imagen, actualizar.Descripcion);
                adminUsr.Actualizar(usuarios.Usr, usuarios.Pwd, usuarios.Id, usuarios.Name, (item.Value * Convert.ToSingle(actualizar.Precio)));
            }
            BDCantidadCompras obj = new BDCantidadCompras();
            obj.sumarCantidad(1);
            ValoresCompras.carritoCompras.Clear();



        }

        private void FormsPago_txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void PagoConTarjeta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.FormTarj_lblfecha.Text = DateTime.Now.ToShortDateString();
            this.FormTarj_lblhora.Text = DateTime.Now.ToShortTimeString();
        }
    }
}
