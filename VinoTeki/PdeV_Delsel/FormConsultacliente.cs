using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
