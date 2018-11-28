using System;
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

        #region editar
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            C.IdCliente1 = int.Parse(lbl_idcliente.Text);
            C.Nombre1 = txt_nombre.Text;
            C.RFC1 = txt_rfc.Text;
            C.Direccion1 = txt_direccion.Text;
            C.Telefono1 = txt_telefono.Text;
            C.Email1 = txt_email.Text;
            C.Razonsocial1 = txt_rasonsocial.Text;
            Class_BasedeDatos.ActualisarC(C);

            txt_nombre.Text = "";
            txt_rfc.Text = "";
            txt_direccion.Text = "";
            txt_telefono.Text = "";
            txt_email.Text = "";
            txt_rasonsocial.Text = "";
            lbl_idcliente.Text = "#";
            comboBox_consultaC.Text = "";

            //Actualizar combobox cliente
            LlenarCombo c = new LlenarCombo();
            c.ItemLlenarC(comboBox_consultaC);
        }
        #endregion

        #region eliminar
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            C.IdCliente1 = int.Parse(lbl_idcliente.Text);
            Class_BasedeDatos.EliminarC(C);

            txt_nombre.Text = "";
            txt_rfc.Text = "";
            txt_direccion.Text = "";
            txt_telefono.Text = "";
            txt_email.Text = "";
            txt_rasonsocial.Text = "";
            lbl_idcliente.Text = "#";
            comboBox_consultaC.Text = "";

            //Actualizar combobox cliente
            LlenarCombo c = new LlenarCombo();
            c.ItemLlenarC(comboBox_consultaC);
        }
        #endregion

        private void FormConsultacliente_Load(object sender, EventArgs e)
        {
            LlenarCombo c = new LlenarCombo();
            c.ItemLlenarC(comboBox_consultaC);

            comboBox_consultaC.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_consultaC.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void comboBox_consultaC_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region busqueda de combobox y selecion
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
            #endregion
        }

        #region validaciones

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            //{
            //    errorP.SetError(txt_nombre, "Solo se permiten letras");
            //    txt_nombre.Focus();
            //    e.Handled = true;
            //    return;
            //}
            //else
            //{
            //    errorP.Clear();
            //}
        }

        private void txt_rasonsocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                errorP.SetError(txt_rasonsocial, "Solo se permiten letras");
                txt_rasonsocial.Focus();
                e.Handled = true;
                return;
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                errorP.SetError(txt_telefono, "Caracteres y Letras están prohibidos, solo se permite números, gracias :D");
                txt_telefono.Focus();


                e.Handled = true;
                return;
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txt_nombre_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nombre.Text))
            {
                errorP.SetError(txt_nombre, "Completa el campo para continuar");
                txt_nombre.Focus();
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txt_rfc_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_rfc.Text))
            {
                errorP.SetError(txt_rfc, "Completa el campo para continuar");
                txt_rfc.Focus();
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txt_direccion_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_direccion.Text))
            {
                errorP.SetError(txt_direccion, "Completa el campo para continuar");
                txt_direccion.Focus();
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txt_telefono_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_telefono.Text))
            {
                errorP.SetError(txt_telefono, "Completa el campo para continuar");
                txt_telefono.Focus();
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txt_email_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_email.Text))
            {
                errorP.SetError(txt_email, "Completa el campo para continuar");
                txt_email.Focus();
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txt_rasonsocial_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_rasonsocial.Text))
            {
                errorP.SetError(txt_rasonsocial, "Completa el campo para continuar");
                txt_rasonsocial.Focus();
            }
            else
            {
                errorP.Clear();
            }
        }

        #endregion
    }
}
