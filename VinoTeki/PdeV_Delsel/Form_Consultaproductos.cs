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
    public partial class Form_Consultaproductos : Form
    {
        public Form_Consultaproductos()
        {
            InitializeComponent();
        }

        Class_ProductoTB P = new Class_ProductoTB();

        #region Diseño para los combo box, que muestre info y al momento de escribir se borre
        private void txt_producto_Enter(object sender, EventArgs e)
        {
            /* if (txt_producto.Text == "PRODUCTO")
            {
                txt_producto.Text = "";
                txt_producto.ForeColor = Color.White;
            } */
        }

        private void txt_producto_Leave(object sender, EventArgs e)
        {
            /* if (txt_producto.Text == "")
            {
                txt_producto.Text = "PRODUCTO";
                txt_producto.ForeColor = Color.SeaGreen;
            } */
        }

        private void txt_tipo_Enter(object sender, EventArgs e)
        {
            /* if (txt_tipo.Text == "TIPO")
            {
                txt_tipo.Text = "";
                txt_tipo.ForeColor = Color.White;
            } */
        }

        private void txt_tipo_Leave(object sender, EventArgs e)
        {
            /*if (txt_tipo.Text == "")
            {
                txt_tipo.Text = "TIPO";
                txt_tipo.ForeColor = Color.SeaGreen;
            }*/
        }

        private void txt_marca_Enter(object sender, EventArgs e)
        {
            /* if (txt_marca.Text == "MARCA")
            {
                txt_marca.Text = "";
                txt_marca.ForeColor = Color.White;
            } */
        }

        private void txt_marca_Leave(object sender, EventArgs e)
        {
            /* if (txt_marca.Text == "")
            {
                txt_marca.Text = "MARCA";
                txt_marca.ForeColor = Color.SeaGreen;
            }*/
        }

        private void txt_modelo_Enter(object sender, EventArgs e)
        {
            /*if (txt_modelo.Text == "MODELO")
            {
                txt_modelo.Text = "";
                txt_modelo.ForeColor = Color.White;
            }*/
        }

        private void txt_modelo_Leave(object sender, EventArgs e)
        {
            /*if (txt_modelo.Text == "")
            {
                txt_modelo.Text = "MODELO";
                txt_modelo.ForeColor = Color.SeaGreen;
            }*/
        }

        private void txt_descrip_Enter(object sender, EventArgs e)
        {
            /*if (txt_descrip.Text == "DESCRIPCION")
            {
                txt_descrip.Text = "";
                txt_descrip.ForeColor = Color.White;
            }*/
        }

        private void txt_descrip_Leave(object sender, EventArgs e)
        {
            /*if (txt_descrip.Text == "")
            {
                txt_descrip.Text = "DESCRIPCION";
                txt_descrip.ForeColor = Color.SeaGreen;
            }*/
        }

        private void txt_cantidad_Enter(object sender, EventArgs e)
        {
            /*if (txt_cantidad.Text == "CANTIDAD")
            {
                txt_cantidad.Text = "";
                txt_cantidad.ForeColor = Color.White;
            }*/
        }

        private void txt_cantidad_Leave(object sender, EventArgs e)
        {
            /*if (txt_cantidad.Text == "")
            {
                txt_cantidad.Text = "CANTIDAD";
                txt_cantidad.ForeColor = Color.SeaGreen;
            }*/
        }

        private void txt_costo_Enter(object sender, EventArgs e)
        {
            /*if (txt_costo.Text == "COSTO")
            {
                txt_costo.Text = "";
                txt_costo.ForeColor = Color.White;
            }*/
        }

        private void txt_costo_Leave(object sender, EventArgs e)
        {
            /*if (txt_costo.Text == "")
            {
                txt_costo.Text = "COSTO";
                txt_costo.ForeColor = Color.SeaGreen;
            }*/
        }

        private void txt_precio_Enter(object sender, EventArgs e)
        {
            /*if (txt_precio.Text == "PRECIO")
            {
                txt_precio.Text = "";
                txt_precio.ForeColor = Color.White;
            }*/
        }

        private void txt_precio_Leave(object sender, EventArgs e)
        {
            /*if (txt_precio.Text == "")
            {
                txt_precio.Text = "PRECIO";
                txt_precio.ForeColor = Color.SeaGreen;
            } */
        }
        #endregion


        #region editar
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            P.IdProducto1 = int.Parse(lbl_idproducto.Text);
            P.Producto1 = txt_producto.Text;
            P.Tipo1 = txt_tipo.Text;
            P.Marca1 = txt_marca.Text;
            P.Modelo1 = txt_modelo.Text;
            P.Descripcion1 = txt_descrip.Text;
            P.Cantidad1 = int.Parse(txt_cantidad.Text);
            P.Costo1 = int.Parse(txt_costo.Text);
            P.Precio1 = int.Parse(txt_precio.Text);
            Class_BasedeDatos.ActualisarP(P);
            //comboBox_consultaP.Refresh();

            txt_producto.Text = "";
            txt_tipo.Text = "";
            txt_marca.Text = "";
            txt_modelo.Text = "";
            txt_descrip.Text = "";
            txt_cantidad.Text = "";
            txt_costo.Text = "";
            txt_precio.Text = "";
            comboBox_consultaP.Text = "";

            //Actualizar combobox producto
            LlenarCombo p = new LlenarCombo();
            p.ItemLlenarP(comboBox_consultaP );

        }

        #endregion

        #region eliminar

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            P.IdProducto1 = int.Parse(lbl_idproducto.Text);
            Class_BasedeDatos.EliminarP(P);
            lbl_idproducto.Text = "#";
            txt_producto.Text = "";
            txt_tipo.Text = "";
            txt_marca.Text = "";
            txt_modelo.Text = "";
            txt_descrip.Text = "";
            txt_cantidad.Text = "";
            txt_costo.Text = "";
            txt_precio.Text = "";
            
            comboBox_consultaP.Text = "";

            //Actualizar combobox producto
            LlenarCombo p = new LlenarCombo();
            p.ItemLlenarP(comboBox_consultaP);

        }

        #endregion


        private void Form_Consultaproductos_Load(object sender, EventArgs e)
        {
            LlenarCombo p = new LlenarCombo();
            p.ItemLlenarP(comboBox_consultaP);
            
            comboBox_consultaP.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_consultaP.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        #region consulta 

        private void comboBox_consultaP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cadena = "Select * from Table_Producto where Producto = '" + comboBox_consultaP.Text + "' ";
            OleDbConnection cnn = new OleDbConnection("Provider=sqloledb;Data Source=LENOY97;Initial Catalog=ProyectoPdeVDelsel;Integrated Security=SSPI");
            OleDbCommand comando = new OleDbCommand(cadena, cnn);
            cnn.Open();

            OleDbDataReader leer = comando.ExecuteReader();
            if (leer.Read() == true)
            {
                txt_producto.Text = leer["Producto"].ToString();
                txt_tipo.Text = leer["Tipo"].ToString();
                txt_marca.Text = leer["Marca"].ToString();
                txt_modelo.Text = leer["Modelo"].ToString();
                txt_descrip.Text = leer["Descripcion"].ToString();
                txt_cantidad.Text = leer["Cantidad"].ToString();
                txt_costo.Text = leer["Costo"].ToString();
                txt_precio.Text = leer["Precio"].ToString();
                lbl_idproducto.Text = leer["IdProducto"].ToString();
            }
            else
            {
                txt_producto.Text = "";
                txt_tipo.Text = "";
                txt_marca.Text = "";
                txt_modelo.Text = "";
                txt_descrip.Text = "";
                txt_cantidad.Text = "";
                txt_costo.Text = "";
                txt_precio.Text = "";
            }
            cnn.Close();
        }

        #endregion

        #region validaciones

        private void txt_producto_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_producto.Text))
            {
                errorP.SetError(txt_producto, "Completa el campo para continuar");
                txt_producto.Focus();
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txt_tipo_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tipo.Text))
            {
                errorP.SetError(txt_tipo, "Completa el campo para continuar");
                txt_tipo.Focus();
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txt_marca_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_marca.Text))
            {
                errorP.SetError(txt_marca, "Completa el campo para continuar");
                txt_marca.Focus();
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txt_modelo_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_modelo.Text))
            {
                errorP.SetError(txt_modelo, "Completa el campo para continuar");
                txt_modelo.Focus();
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txt_descrip_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_descrip.Text))
            {
                errorP.SetError(txt_descrip, "Completa el campo para continuar");
                txt_descrip.Focus();
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txt_cantidad_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_cantidad.Text))
            {
                errorP.SetError(txt_cantidad, "Completa el campo para continuar");
                txt_cantidad.Focus();
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txt_costo_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_costo.Text))
            {
                errorP.SetError(txt_costo, "Completa el campo para continuar");
                txt_costo.Focus();
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txt_precio_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_precio.Text))
            {
                errorP.SetError(txt_precio, "Completa el campo para continuar");
                txt_precio.Focus();
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txt_tipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                errorP.SetError(txt_tipo, "Solo se permiten letras");
                txt_tipo.Focus();
                e.Handled = true;
                return;
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txt_marca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                errorP.SetError(txt_marca, "Solo se permiten letras");
                txt_marca.Focus();
                e.Handled = true;
                return;
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txt_descrip_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            //{
            //    errorP.SetError(txt_descrip, "Solo se permiten letras");
            //    txt_descrip.Focus();
            //    e.Handled = true;
            //    return;
            //}
            //else
            //{
            //    errorP.Clear();
            //}
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                errorP.SetError(txt_cantidad, "Caracteres y Letras están prohibidos, solo se permite números, gracias :D");
                txt_cantidad.Focus();


                e.Handled = true;
                return;
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txt_costo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                errorP.SetError(txt_costo, "Caracteres y Letras están prohibidos, solo se permite números, gracias :D");
                txt_costo.Focus();


                e.Handled = true;
                return;
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                errorP.SetError(txt_precio, "Caracteres y Letras están prohibidos, solo se permite números, gracias :D");
                txt_precio.Focus();


                e.Handled = true;
                return;
            }
            else
            {
                errorP.Clear();
            }
        }

        #endregion
    }
}
