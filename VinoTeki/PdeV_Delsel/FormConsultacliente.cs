﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PdeV_Delsel
{
    public partial class FormConsultacliente : Form
    {
        public FormConsultacliente()
        {
            InitializeComponent();
        }
        Class_ClienteTB C = new Class_ClienteTB();

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            C.IdCliente1 = int.Parse(lbl_idcliente.Text);
            C.Nombre1 = txt_nombre.Text;
            C.RFC1 = txt_rfc.Text;
            C.Direccion1 = txt_direccion.Text;
            C.Telefono1 = txt_telefono.Text;
            C.Email1 = txt_email.Text;
            C.Razonsocial1 = txt_email.Text;
            Class_BasedeDatos.ActualisarC(C);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            C.IdCliente1 = int.Parse(lbl_idcliente.Text);
            Class_BasedeDatos.EliminarC(C);
        }

        private void FormConsultacliente_Load(object sender, EventArgs e)
        {
            LlenarCombo c = new LlenarCombo();
            c.ItemLlenarC(comboBox_consultaC);

            comboBox_consultaC.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_consultaC.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void comboBox_consultaC_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cadena = "Select * from Table_Cliente where Nombre = '" + comboBox_consultaC.Text + "' ";
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
                txt_rasonsocial.Text = leer["Razonsocial"].ToString();
                lbl_idcliente.Text = leer["IdCliente"].ToString();
            }
            else
            {
                txt_nombre.Text = "";
                txt_rfc.Text = "";
                txt_direccion.Text = "";
                txt_telefono.Text = "";
                txt_email.Text = "";
                txt_rasonsocial.Text = "";
            }
            cnn.Close();
        }
    }
}
