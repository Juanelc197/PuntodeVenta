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
    public partial class Form_Altacliente : Form
    {
        public Form_Altacliente()
        {
            InitializeComponent();
        }

        Class_ClienteTB C = new Class_ClienteTB();

        #region diseño para los combobox para que muestre info cuando esta vasio
        private void txt_nombre_Enter(object sender, EventArgs e)
        {
            //if (txt_nombre.Text == "NOMBRE")
            //{
            //    txt_nombre.Text = "";
            //    txt_nombre.ForeColor = Color.White;
            //}
        }

        private void txt_nombre_Leave(object sender, EventArgs e)
        {
            //if (txt_nombre.Text == "")
            //{
            //    txt_nombre.Text = "NOMBRE";
            //    txt_nombre.ForeColor = Color.SeaGreen;
            //}
        }

        private void txt_rfc_Enter(object sender, EventArgs e)
        {
            //if (txt_rfc.Text == "RFC")
            //{
            //    txt_rfc.Text = "";
            //    txt_rfc.ForeColor = Color.White;
            //}
        }

        private void txt_rfc_Leave(object sender, EventArgs e)
        {
            //if (txt_rfc.Text == "")
            //{
            //    txt_rfc.Text = "RFC";
            //    txt_rfc.ForeColor = Color.SeaGreen;
            //}
        }

        private void txt_direccion_Enter(object sender, EventArgs e)
        {
            //if (txt_direccion.Text == "DIRECCION")
            //{
            //    txt_direccion.Text = "";
            //    txt_direccion.ForeColor = Color.White;
            //}
        }

        private void txt_direccion_Leave(object sender, EventArgs e)
        {
            //if (txt_direccion.Text == "")
            //{
            //    txt_direccion.Text = "DIRECCION";
            //    txt_direccion.ForeColor = Color.SeaGreen;
            //}
        }

        private void txt_telefono_Enter(object sender, EventArgs e)
        {
            //if (txt_telefono.Text == "TELEFONO")
            //{
            //    txt_telefono.Text = "";
            //    txt_telefono.ForeColor = Color.White;
            //}
        }

        private void txt_telefono_Leave(object sender, EventArgs e)
        {
            //if (txt_telefono.Text == "")
            //{
            //    txt_telefono.Text = "TELEFONO";
            //    txt_telefono.ForeColor = Color.SeaGreen;
            //}
        }

        private void txt_email_Enter(object sender, EventArgs e)
        {
            //if (txt_email.Text == "E-MAIL")
            //{
            //    txt_email.Text = "";
            //    txt_email.ForeColor = Color.White;
            //}
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            //if (txt_email.Text == "")
            //{
            //    txt_email.Text = "E-MAIL";
            //    txt_email.ForeColor = Color.SeaGreen;
            //}
        }
        

        private void txt_razonsocial_Enter(object sender, EventArgs e)
        {
            //if (txt_razonsocial.Text == "RAZON SOCIAL")
            //{
            //    txt_razonsocial.Text = "";
            //    txt_razonsocial.ForeColor = Color.White;
            //}
        }

        private void txt_razonsocial_Leave(object sender, EventArgs e)
        {
            //if (txt_razonsocial.Text == "")
            //{
            //    txt_razonsocial.Text = "RAZON SOCIAL";
            //    txt_razonsocial.ForeColor = Color.SeaGreen;
            //}
        }
        #endregion

        
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            C.Nombre1 = txt_nombre.Text;
            C.RFC1 = txt_rfc.Text;
            C.Direccion1 = txt_direccion.Text;
            C.Telefono1 = txt_telefono.Text;
            C.Email1 = txt_email.Text;
            C.Razonsocial1 = txt_razonsocial.Text;
            Class_BasedeDatos.GuardarC(C);
            //lbl_mostrarExito.Visible = true;
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

        private void txt_razonsocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                errorP.SetError(txt_razonsocial, "Solo se permiten letras");
                txt_razonsocial.Focus();
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

        private void txt_razonsocial_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_razonsocial.Text))
            {
                errorP.SetError(txt_razonsocial, "Completa el campo para continuar");
                txt_razonsocial.Focus();
            }
            else
            {
                errorP.Clear();
            }
        }

        #endregion
    }
}
