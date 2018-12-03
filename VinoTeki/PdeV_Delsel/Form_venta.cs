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
    public partial class Form_venta : Form
    {
        public Form_venta()
        {
            InitializeComponent();
            comboBox_FormaPago.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_FormaPago.Items.Add("Efectivo");
            comboBox_FormaPago.Items.Add("Tarjeta de credito");
        }
        Class_ProductoTB P = new Class_ProductoTB();

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
                lbl_conCant.Text = leer["IdProducto"].ToString();
                //txt_costo.Text = leer["Costo"].ToString();
                lbl_preciosolo.Text = leer["Precio"].ToString();
                //lbl_precioP.Text = leer["Precio"].ToString();
                //lbl_idP.Text = leer["IdProducto"].ToString();
            }
            else
            {
                //txt_producto.Text = "";
                //txt_tipo.Text = "";
                //txt_marca.Text = "";
                //txt_modelo.Text = "";
                //txt_descrip.Text = "";
                //txt_cantidad.Text = "";
                //txt_costo.Text = "";
                lbl_preciosolo.Text = "";
                //lbl_precioP.Text = "";
                //lbl_idP.Text = "#";
                lbl_conCant.Text = "...";
            }
            cnn.Close();
            #endregion 

        }

        private void Form_venta_Load(object sender, EventArgs e)
        {
            LlenarCombo p = new LlenarCombo();
            p.ItemLlenarP(comboBox_productos);

            comboBox_productos.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_productos.AutoCompleteSource = AutoCompleteSource.ListItems;

            LlenarCombo coti = new LlenarCombo();
            coti.ItemLlenarCotizacion(comboBox_clienteCot);

            comboBox_clienteCot.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_clienteCot.AutoCompleteSource = AutoCompleteSource.ListItems;

            /* DateTime hoy = DateTime.Now;


             lbl_fechita.Text = hoy.ToString("dd/MM/yy");
             hoy = Convert.ToDateTime(lbl_fechita.Text); */

            //DateTime mifecha = dateTimePicker_fecha.Value.Date;
            
        }

        private void comboBox_clienteCot_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region busqueda de combobox y seleccion producto
            string cadena = "Select * from Table_Cotizacion where FolioCot = '" + comboBox_clienteCot.Text + "' ";
            OleDbConnection cnn = new OleDbConnection("Provider=sqloledb;Data Source=LENOY97;Initial Catalog=ProyectoPdeVDelsel;Integrated Security=SSPI");
            OleDbCommand comando = new OleDbCommand(cadena, cnn);
            cnn.Open();

            OleDbDataReader leer = comando.ExecuteReader();
            if (leer.Read() == true)
            {
                txt_nombre.Text = leer["Nombre"].ToString();
                txt_rfc.Text = leer["RFC"].ToString();
                txt_razonsocial.Text = leer["RazonSocial"].ToString();
                txt_direccion.Text = leer["Direccion"].ToString();
                txt_email.Text = leer["Email"].ToString();
                txt_telefono.Text = leer["Telefono"].ToString();
                comboBox_productos.Text = leer["Producto"].ToString();
                txt_cantidad.Text = leer["Cantidad"].ToString();
                txt_subtotal.Text = leer["Subtotal"].ToString();
                txt_total.Text = leer["Total"].ToString();
                lbl_numerodeventa.Text = leer["FolioCot"].ToString();
                lbl_Ultimacotizacion.Text = leer["IDCliente"].ToString();
            }
            else
            {
                txt_nombre.Text = "";
                txt_rfc.Text = "";
                txt_razonsocial.Text = "";
                txt_direccion.Text = "";
                txt_email.Text = "";
                txt_telefono.Text = "";
                comboBox_productos.Text = "";
                txt_cantidad.Text = "";
                txt_subtotal.Text = "$";
                txt_total.Text = "$";
                lbl_numerodeventa.Text = "#";
                lbl_Ultimacotizacion.Text = "#";
            }
            cnn.Close();
            #endregion 

            #region llenar el comobobox
            try
            {
                OleDbCommand coma = new OleDbCommand();
                OleDbConnection cone = new OleDbConnection("Provider=sqloledb;Data Source=LENOY97;Initial Catalog=ProyectoPdeVDelsel;Integrated Security=SSPI");
                cone.Open();
                coma.Connection = cone;
                string query = "select Producto, Cantidad, Precio, CostoTo from Table_VentasTemporales where IDCliente=" + lbl_Ultimacotizacion.Text;
                //com.Connection = cnn;
                coma.CommandText = query;

                //com.ExecuteNonQuery();
                //MessageBox.Show("Venta realizada");
                //lbl_mostrarExito.Visible = true;
                OleDbDataAdapter da = new OleDbDataAdapter(coma);
                DataTable dt = new DataTable();
               
                da.Fill(dt);
                dataGridView_verdatos.DataSource = dt;
                coma.Clone();
                cone.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hay problemas " + ex);
                //lbl_ventabad.Visible = true;
            }
            #endregion

            #region suma datagrid
            double subtotal = 0;
            double iva = 0;

            foreach (DataGridViewRow row in dataGridView_verdatos.Rows)
            {
                //subtotal += Convert.ToDouble(row.Cells["Column4"].Value);
                subtotal += Convert.ToDouble(row.Cells["CostoTo"].Value);
            }
            txt_subtotal.Text = Convert.ToString(subtotal);


            if (checkBox_iva.Checked == true)
            {
                iva += Convert.ToDouble(subtotal * 0.16);
                txt_total.Text = Convert.ToString(iva + subtotal);
            }
            else
            {
                txt_total.Text = Convert.ToString(subtotal);
            }
            #endregion
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            

            #region codigo para realisar una suma en columnas y agregar iva
            //double subtotal = 0;
            //double iva = 0;

            /*foreach (DataGridViewRow row in dataGridView_verdatos.Rows)
            {
                subtotal += Convert.ToDouble(row.Cells["Precio"].Value);
            }
            txt_subtotal.Text = Convert.ToString(subtotal); */

            //double suma, precio, can, sub;
            //string prodo;
            //int idcli;
            //idcli = int.Parse(lbl_numerodeventa.Text);
            //prodo = comboBox_productos.Text;
            ////int can;
            //can = double.Parse(txt_cantidad.Text);
            //precio = double.Parse(lbl_preciosolo.Text);

            //suma = can * precio;
            //txt_subtotal.Text = Convert.ToString(suma);
            //sub = double.Parse(txt_subtotal.Text);
            ////dataGridView_verdatos.Rows.Add(comboBox_productos.Text, txt_cantidad.Text, lbl_preciosolo.Text, txt_subtotal.Text);
            //dataGridView_verdatos.Rows.Add(prodo, can, precio, sub);

            //foreach (DataGridViewRow row in dataGridView_verdatos.Rows)
            //{
            //    subtotal += Convert.ToDouble(row.Cells["Column4"].Value); 
            //    //subtotal += Convert.ToDouble(row.Cells["CostoTo"].Value);
            //}
            //txt_subtotal.Text = Convert.ToString(subtotal);


            //if (checkBox_iva.Checked == true)
            //{
            //    iva += Convert.ToDouble(subtotal * 0.16);
            //    txt_total.Text = Convert.ToString(iva + subtotal);
            //}
            //else
            //{
            //    txt_total.Text = Convert.ToString(subtotal);
            //}
            #endregion


        }

        private void checkBox_iva_CheckedChanged(object sender, EventArgs e)
        {
            #region para hacer el iva
            if (checkBox_iva.Checked == false)
            {
                double subtotal = Convert.ToDouble(txt_subtotal.Text);
                lbl_iva.Text = "0";
                txt_total.Text = Convert.ToString(subtotal);
            }
            else if (txt_subtotal.Text != "")
            {
                double subtotal = Convert.ToDouble(txt_subtotal.Text);
                double iva = 0;
                lbl_iva.Text = "16%";
                iva += Convert.ToDouble(subtotal * 0.16);
                txt_total.Text = Convert.ToString(iva + subtotal);
            }
            else
            {
                lbl_iva.Text = "16%";
            }
            #endregion

        }

        private void txt_total_TextChanged(object sender, EventArgs e)
        {
            Convercion c = new Convercion();
            lbl_letras.Text = c.enletras(txt_total.Text).ToLower();
        }

        private void btn_venta_Click(object sender, EventArgs e)
        {
            #region descontar stock
           //try
           // {
           //     OleDbConnection con = new OleDbConnection("Provider=sqloledb;Data Source=LENOY97;Initial Catalog=ProyectoPdeVDelsel;Integrated Security=SSPI");
           //     con.Open();
           //     OleDbCommand cmd = new OleDbCommand("update Table_Producto set Cantidad = Cantidad - '" + txt_cantidad.Text + "' where IdProducto='" + lbl_conCant.Text + "' ", con);



           //     // = "@cantidad";
           //     //cmd.Parameters.AddWithValue("@cantidad", txt_cantidad.Text);
           //     //cmd.Parameters.AddWithValue("@fechac", this.datefechacliente.Text);
           //     //cmd.Parameters.AddWithValue("@IdP", lbl_conCant.Text);

           //     cmd.ExecuteNonQuery();
           //     //MessageBox.Show("Se desconto el producto");
           //     lbl_stockgood.Visible = true;
           //     con.Close();
           // }
           // catch
           // {
           //     //MessageBox.Show("Error");
           //     lbl_stockbad.Visible = true;
           // } 
            #endregion

            #region guardar la venta o generar venta
           try
            {
                OleDbCommand com = new OleDbCommand();
                OleDbConnection cnn = new OleDbConnection("Provider=sqloledb;Data Source=LENOY97;Initial Catalog=ProyectoPdeVDelsel;Integrated Security=SSPI");
                cnn.Open();
                //com.CommandText = "Insert into Table_Venta (Nombre, RFC, RazonSocial, Direccion, Email, Telefono, Producto, Cantidad, FormadePago, Subtotal, Total, Fecha, FolioVenta) values ('" + txt_nombre.Text + "','" + txt_rfc.Text + "','" + txt_razonsocial.Text + "','" + txt_direccion.Text + "','" + txt_email.Text + "','" + txt_telefono.Text + "','" + comboBox_productos.Text + "','" + txt_cantidad.Text + "','" + comboBox_FormaPago.Text + "','" + txt_subtotal.Text + "','" + txt_total.Text + "','" + this.dateTimePicker_fecha.Text + "','" + lbl_numerodeventa.Text + "')";
                com.CommandText = "Insert into Table_Venta (Nombre, RFC, RazonSocial, Direccion, Email, Telefono, FormadePago, Subtotal, Total, Fecha, FolioVenta) values ('" + txt_nombre.Text + "','" + txt_rfc.Text + "','" + txt_razonsocial.Text + "','" + txt_direccion.Text + "','" + txt_email.Text + "','" + txt_telefono.Text + "','" + comboBox_FormaPago.Text + "','" + txt_subtotal.Text + "','" + txt_total.Text + "','" + this.dateTimePicker_fecha.Text + "','" + lbl_numerodeventa.Text + "')";

                com.Connection = cnn;

                com.ExecuteNonQuery();
                //MessageBox.Show("Venta realizada");
                lbl_mostrarExito.Visible = true;
                cnn.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Hay problemas " + ex);
                lbl_ventabad.Visible = true;
            } 
            #endregion
        }
        #region validaciones
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

        #endregion

        /*private void timer_fecha_Tick(object sender, EventArgs e)
        {
            lbl_fechadeahora.Text = DateTime.Now.ToLongDateString();   
            
    } */
    }
}
