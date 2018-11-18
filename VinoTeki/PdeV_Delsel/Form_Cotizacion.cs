﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PdeV_Delsel
{
    public partial class Form_Cotizacion : Form
    {
        public Form_Cotizacion()
        {
            InitializeComponent();
        }
        Class_ClienteTB C = new Class_ClienteTB();

        Class_ProductoTB P = new Class_ProductoTB();

        #region codigo de botnes de movimiento
        private void btn_inicio_Click(object sender, EventArgs e)
        {
            Form_menu form_Menu = new Form_menu();
            this.Close();
            form_Menu.Show();
        }

       private void btn_cerrar_Click(object sender, EventArgs e)
        {
            //this.Close();
        } 

        private void btn_minimisar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_restaurar.Visible = false;
            btn_maximisar.Visible = true;
        }

        private void btn_maximisar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_maximisar.Visible = false;
            btn_restaurar.Visible = true;
        }

        #endregion

        #region codigo para hacer que un Form sin borde se mueva con el mouse
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        

        private void panel_barraT_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void tableLayoutPanel_contenedorTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form_Cotizacion_Load(object sender, EventArgs e)
        {
            LlenarCombo c = new LlenarCombo();
            c.ItemLlenarC(comboBox_cliente);

            comboBox_cliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_cliente.AutoCompleteSource = AutoCompleteSource.ListItems;

            LlenarCombo p = new LlenarCombo();
            p.ItemLlenarP(comboBox_productos);

            comboBox_productos.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_productos.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void comboBox_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region busqueda de combobox y selecion cliente
            string cadena = "Select * from Table_Cliente where Nombre = '" + comboBox_cliente.Text + "' ";
            OleDbConnection cnn = new OleDbConnection("Provider=sqloledb;Data Source=LENOY97;Initial Catalog=ProyectoPdeVDelsel;Integrated Security=SSPI");
            OleDbCommand comando = new OleDbCommand(cadena, cnn);
            cnn.Open();

            OleDbDataReader leer = comando.ExecuteReader();
            if (leer.Read() == true)
            {
                txt_nombre.Text = leer["Nombre"].ToString();
                txt_rfc.Text = leer["RFC"].ToString();
                txt_direccion.Text = leer["Direccion"].ToString();
                txt_telefono.Text = leer["Telefono"].ToString();
                txt_email.Text = leer["Email"].ToString();
                txt_razonsocial.Text = leer["Razonsocial"].ToString();
                //lbl_idcliente.Text = leer["IdCliente"].ToString();
            }
            else
            {
                txt_nombre.Text = "";
                txt_rfc.Text = "";
                txt_direccion.Text = "";
                txt_telefono.Text = "";
                txt_email.Text = "";
                txt_razonsocial.Text = "";
            }
            cnn.Close();
            #endregion
        }

        private void comboBox_productos_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region busqueda de combobox y seleccion producto
            string cadena = "Select * from Table_Producto where Producto = '" + comboBox_productos.Text + "' ";
            OleDbConnection cnn = new OleDbConnection("Provider=sqloledb;Data Source=LENOY97;Initial Catalog=ProyectoPdeVDelsel;Integrated Security=SSPI");
            OleDbCommand comando = new OleDbCommand(cadena, cnn);
            cnn.Open();

            OleDbDataReader leer = comando.ExecuteReader();
            if (leer.Read() == true)
            {
                //txt_producto.Text = leer["Producto"].ToString();
                //txt_tipo.Text = leer["Tipo"].ToString();
                //txt_marca.Text = leer["Marca"].ToString();
                //txt_modelo.Text = leer["Modelo"].ToString();
                //txt_descrip.Text = leer["Descripcion"].ToString();
                txt_cantidad.Text = leer["Cantidad"].ToString();
                //txt_costo.Text = leer["Costo"].ToString();
                txt_precioU.Text = leer["Precio"].ToString();
                //lbl_idproducto.Text = leer["IdProducto"].ToString();
            }
            else
            {
                //txt_producto.Text = "";
                //txt_tipo.Text = "";
                //txt_marca.Text = "";
                //txt_modelo.Text = "";
                //txt_descrip.Text = "";
                txt_cantidad.Text = "";
                //txt_costo.Text = "";
                txt_precioU.Text = "";
            }
            cnn.Close();
            #endregion
        }
    }
}
