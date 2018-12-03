using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
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
            #region combobox llenar y autocompletar
            LlenarCombo c = new LlenarCombo();
            c.ItemLlenarC(comboBox_cliente);

            comboBox_cliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_cliente.AutoCompleteSource = AutoCompleteSource.ListItems;

            LlenarCombo p = new LlenarCombo();
            p.ItemLlenarP(comboBox_productos);

            comboBox_productos.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_productos.AutoCompleteSource = AutoCompleteSource.ListItems;
            #endregion


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
                lbl_numerodeventa.Text = leer["IdCliente"].ToString();
            }
            else
            {
                txt_nombre.Text = "";
                txt_rfc.Text = "";
                txt_direccion.Text = "";
                txt_telefono.Text = "";
                txt_email.Text = "";
                txt_razonsocial.Text = "";
                lbl_numerodeventa.Text = "";
            }
            cnn.Close();
            #endregion

            #region codigo random
            Random rdm = new Random();
            int a = rdm.Next(1000, 9000);
            //int b = rdm.Next(1000, 9000);
            //int c = rdm.Next(1000, 9000);
            //lbl_folioCoti.Text = a.ToString() + "-" + b.ToString() + "-" + c.ToString();
            lbl_folioCoti.Text = a.ToString();
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
                lbl_conCant.Text = leer["Cantidad"].ToString();
                //txt_costo.Text = leer["Costo"].ToString();
                lbl_preciosolo.Text = leer["Precio"].ToString();
                //lbl_precioP.Text = leer["Precio"].ToString();
                lbl_idP.Text = leer["IdProducto"].ToString();
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
                lbl_idP.Text = "#";
                lbl_conCant.Text = "...";
            }
            cnn.Close();
            #endregion
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            #region guardar info en dos tablas diferentes y mostrarlas en un datagridview con base de datos
            //try
            //{
            //    OleDbCommand com = new OleDbCommand();
            //    OleDbConnection cnn = new OleDbConnection("Provider=sqloledb;Data Source=LENOY97;Initial Catalog=ProyectoPdeVDelsel;Integrated Security=SSPI");
            //    cnn.Open();
            //    com.Connection = cnn;
            //    com.CommandText = "Insert into Table_VentasTemporales (Producto, Cantidad, Precio) VALUES ('" + comboBox_productos.Text + "','" + txt_cantidad.Text + "','" + lbl_preciosolo.Text + "')";
            //    //com.CommandText = "insert into CotizacionTB (Producto, Cantidad, PrecioUnitario) VALUES ('" + comboProducto.Text + "','" + numericCont.Value + "','" + txt_valorU.Text + "')";
            //    com.ExecuteNonQuery();
            //    //MessageBox.Show("Cliente guardado exitosamente");
            //    cnn.Close();
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show("No se pudo guardar " + ex);
            //}

            //try
            //{
            //    OleDbCommand com = new OleDbCommand();
            //    OleDbConnection cnn = new OleDbConnection("Provider=sqloledb;Data Source=LENOY97;Initial Catalog=ProyectoPdeVDelsel;Integrated Security=SSPI");
            //    cnn.Open();
            //    com.Connection = cnn;
            //    string query = "select Producto, Cantidad, Precio from Table_VentasTemporales";
            //    com.CommandText = query;

            //    OleDbDataAdapter da = new OleDbDataAdapter(com);
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);
            //    dataGridView_verdatos.DataSource = dt;
            //    com.Clone();
            //    cnn.Close();
            //}
            //catch (Exception ex)
            //{
            //    //connection.Close();
            //    MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
            //}

            //try
            //{
            //    OleDbCommand com = new OleDbCommand();
            //    OleDbConnection cnn = new OleDbConnection("Provider=sqloledb;Data Source=LENOY97;Initial Catalog=ProyectoPdeVDelsel;Integrated Security=SSPI");
            //    cnn.Open();
            //    com.Connection = cnn;
            //    //string IdProducto = Convert.ToString(txtIdProducto.Text);
            //    com.CommandText = "insert into Table_DetalledeVenta (Cantidad, PrecioUnitario) VALUES ('" + txt_cantidad.Text + "','" + lbl_preciosolo.Text + "')";
            //    com.ExecuteNonQuery();
            //    //MessageBox.Show("Venta guardada exitosamente");
            //    cnn.Close();
            //}
            //catch (Exception ex)
            //{
            //    //connection.Close();
            //    MessageBox.Show("error " + ex);
            //}
            #endregion

            #region codigo para realisar una suma en columnas y agregar iva
            double subtotal = 0;
            double iva = 0;
            

            double suma, precio, can, sub;
            string prodo;
            int idcli, idCOvE;
            //int can;
            can = double.Parse(txt_cantidad.Text);
            precio = double.Parse(lbl_preciosolo.Text);
            idcli = int.Parse(lbl_numerodeventa.Text);
            idCOvE = int.Parse(lbl_folioCoti.Text);
            prodo = comboBox_productos.Text;
            //sub = double.Parse(txt_subtotal.Text);
            //txt_subtotal.Text = Convert.ToDouble(sub);

            suma = can * precio;
            txt_subtotal.Text = Convert.ToString(suma);
            sub = double.Parse(txt_subtotal.Text);

            //dataGridView_verdatos.Rows.Add(comboBox_productos.Text, txt_cantidad.Text, lbl_preciosolo.Text, txt_subtotal.Text);
            dataGridView_verdatos.Rows.Add(prodo, can, precio, sub, idcli, idCOvE);

           foreach (DataGridViewRow row in dataGridView_verdatos.Rows)
            {
                subtotal += Convert.ToDouble(row.Cells["CostoTB"].Value);
                //subtotal += Convert.ToDouble(row.Cells["Precio"].Value); 
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

            #region codigo para guardar datos de un datagrid sqlservice
            //SqlConnection con = new SqlConnection("Data Source=LENOY97;Initial Catalog=ProyectoPdeVDelsel;Integrated Security=SSPI");
            //SqlCommand add = new SqlCommand("Insert into Table_VentasTemporales (Producto, Cantidad, Precio, CostoTo) values (@pro, @can, @pre, @cos)", con);
            //con.Open();

            //OleDbCommand add = new OleDbCommand();
            //OleDbConnection con = new OleDbConnection("Provider=sqloledb;Data Source=LENOY97;Initial Catalog=ProyectoPdeVDelsel;Integrated Security=SSPI");
            //con.Open();
            //add.Connection = con;
            //add.CommandText = "Insert into Table_VentasTemporales (Producto, Cantidad, Precio, CostoTo) values (@pro, @can, @pre, @cos)";

            //try
            //{



            //    #region code foreach
            //    foreach (DataGridViewRow fila in dataGridView_verdatos.Rows)
            //    {
            //        string producto = fila.Cells[1].Value;
            //        add.Parameters.Clear();

            //        add.Parameters.AddWithValue("@param1", fila.Cells["Column1"].Value.ToString());
            //        add.Parameters.AddWithValue("@param2", fila.Cells["Column2"].Value.ToString());

            //        add.Parameters.AddWithValue("@pro", Convert.ToString(fila.Cells["ProductoTB"].Value));
            //        add.Parameters.AddWithValue("@can", Convert.ToString(fila.Cells["CantidadTB"].Value));
            //        add.Parameters.AddWithValue("@pre", Convert.ToString(fila.Cells["PrecioTB"].Value));
            //        add.Parameters.AddWithValue("@cos", Convert.ToString(fila.Cells["CostoTB"].Value));

            //        add.ExecuteNonQuery();
            //    }
            //    #endregion

            //    foreach (GridVie)

            //        MessageBox.Show("Datos agregados");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Errror al agregar");
            //}
            //finally
            //{
            //    con.Close();
            //}
            #endregion

            #region codigo para guardar datos de un datagrid sqlservice
            SqlConnection con = new SqlConnection("Data Source=LENOY97;Initial Catalog=ProyectoPdeVDelsel;Integrated Security=SSPI");
            SqlCommand add = new SqlCommand("Insert into Table_VentasTemporales (Producto, Cantidad, Precio, CostoTo, IDCliente, FolioCoVe) values (@pro, @can, @pre, @cos, @idc, @idCoVe)", con);
            con.Open();

            //OleDbCommand add = new OleDbCommand();
            //OleDbConnection con = new OleDbConnection("Provider=sqloledb;Data Source=LENOY97;Initial Catalog=ProyectoPdeVDelsel;Integrated Security=SSPI");
            //con.Open();
            //add.Connection = con;
            //add.CommandText = "Insert into Table_VentasTemporales (Producto, Cantidad, Precio, CostoTo) values (@pro, @can, @pre, @cos)";

            try
            {



                #region code foreach
                foreach (DataGridViewRow fila in dataGridView_verdatos.Rows)
                {
                    //string producto = fila.Cells[1].Value;
                    add.Parameters.Clear();

                    //add.Parameters.AddWithValue("@param1", fila.Cells["Column1"].Value.ToString());
                    //add.Parameters.AddWithValue("@param2", fila.Cells["Column2"].Value.ToString());

                    add.Parameters.AddWithValue("@pro", Convert.ToString(fila.Cells["ProductoTB"].Value));
                    add.Parameters.AddWithValue("@can", Convert.ToString(fila.Cells["CantidadTB"].Value));
                    add.Parameters.AddWithValue("@pre", Convert.ToString(fila.Cells["PrecioTB"].Value));
                    add.Parameters.AddWithValue("@cos", Convert.ToString(fila.Cells["CostoTB"].Value)); 
                    add.Parameters.AddWithValue("@idc", Convert.ToString(fila.Cells["Column1"].Value));
                    add.Parameters.AddWithValue("@idCoVe", Convert.ToString(fila.Cells["Column2"].Value));

                    add.ExecuteNonQuery();
                }
                #endregion

                //foreach (GridVie)

                //MessageBox.Show("good job");
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Errror al agregar");
            }
            finally
            {
                con.Close();
            }
            #endregion

            #region descontar stock
            try
            {
                OleDbConnection conexion = new OleDbConnection("Provider=sqloledb;Data Source=LENOY97;Initial Catalog=ProyectoPdeVDelsel;Integrated Security=SSPI");
                conexion.Open();
                OleDbCommand cmda = new OleDbCommand("update Table_Producto set Cantidad = Cantidad - '" + txt_cantidad.Text + "' where IdProducto='" + lbl_idP.Text + "' ", conexion);



                // = "@cantidad";
                //cmd.Parameters.AddWithValue("@cantidad", txt_cantidad.Text);
                //cmd.Parameters.AddWithValue("@fechac", this.datefechacliente.Text);
                //cmd.Parameters.AddWithValue("@IdP", lbl_conCant.Text);

                cmda.ExecuteNonQuery();
                MessageBox.Show("Se desconto el producto");
                //lbl_stockgood.Visible = true;
                conexion.Close();
            }
            catch
            {
                MessageBox.Show("Error");
                //lbl_stockbad.Visible = true;
            }
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

        private void btn_cotizar_Click(object sender, EventArgs e)
        {
            #region codigo para generar cotizacion
            try
            {
                OleDbCommand com = new OleDbCommand();
                OleDbConnection cnn = new OleDbConnection("Provider=sqloledb;Data Source=LENOY97;Initial Catalog=ProyectoPdeVDelsel;Integrated Security=SSPI");
                cnn.Open();
                //com.CommandText = "Insert into Table_Cotizacion (Nombre, RFC, RazonSocial, Direccion, Email, Telefono, Producto, Cantidad, Subtotal, Total) values ('" + txt_nombre.Text + "','" + txt_rfc.Text + "','" + txt_razonsocial.Text + "','" + txt_direccion.Text + "','" + txt_email.Text + "','" + txt_telefono.Text + "','" + comboBox_productos.Text + "','" + txt_cantidad.Text + "','" + txt_subtotal.Text + "','" + txt_total.Text + "')";
                //com.CommandText = "Insert into Table_Cotizacion (Nombre, RFC, RazonSocial, Direccion, Email, Telefono, Subtotal, Total) values ('" + txt_nombre.Text + "','" + txt_rfc.Text + "','" + txt_razonsocial.Text + "','" + txt_direccion.Text + "','" + txt_email.Text + "','" + txt_telefono.Text + "','" + txt_subtotal.Text + "','" + txt_total.Text + "')";
                com.CommandText = "Insert into Table_Cotizacion (Nombre, RFC, RazonSocial, Direccion, Email, Telefono, Subtotal, Total, IDCliente, FolioCot) values ('" + txt_nombre.Text + "','" + txt_rfc.Text + "','" + txt_razonsocial.Text + "','" + txt_direccion.Text + "','" + txt_email.Text + "','" + txt_telefono.Text + "','" + txt_subtotal.Text + "','" + txt_total.Text + "','" + lbl_numerodeventa.Text + "','" + lbl_folioCoti.Text + "')";
                com.Connection = cnn;

                com.ExecuteNonQuery();
                //MessageBox.Show("Cotizacion creada");
                lbl_mostrarExito.Visible = true;
                cnn.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Hay problemas " + ex);
                lbl_cotizacionbad.Visible = true;
            }
            #endregion

            #region codigo para guardar datos de un data version de prueba
            //OleDbConnection con = new OleDbConnection("Provider=sqloledb;Data Source=LENOY97;Initial Catalog=ProyectoPdeVDelsel;Integrated Security=SSPI");
            ////con.Open();
            ////OleDbCommand add = new OleDbCommand("Insert into Table_Cotizacion values (@nombre, @rfc, @rasonS, @direcc, @emai, @tel, @producto, @cantidad, @precio, @costoto, @subt, @tota)", con);
            ////OleDbCommand add = new OleDbCommand("Insert into Table_Cotizacion values @producto, @cantidad, @precio, @costoto)", con);
            ////OleDbCommand add = new OleDbCommand("Insert into Table_Cotizacion values (@nombre, @rfc, @rasonS, @direcc, @emai, @tel, @subt, @tota)", con);
            //OleDbCommand add = new OleDbCommand("Insert into Table_Cotizacion values (@param1)", con);
            //con.Open();

            //try
            //{
            //    /*add.Parameters.AddWithValue("@nombre", txt_nombre.Text);
            //    add.Parameters.AddWithValue("@rfc", txt_rfc.Text);
            //    add.Parameters.AddWithValue("@rasonS", txt_razonsocial.Text);
            //    add.Parameters.AddWithValue("@direcc", txt_direccion.Text);
            //    add.Parameters.AddWithValue("@emai", txt_email.Text);
            //    add.Parameters.AddWithValue("@tel", txt_telefono.Text);
            //    add.Parameters.AddWithValue("@subt", txt_subtotal.Text);
            //    add.Parameters.AddWithValue("@tota", txt_total.Text);*/
            //    #region code foreach
            //    foreach (DataGridViewRow fila in dataGridView_verdatos.Rows)
            //    {
            //        string producto = fila.Cells[1].Value;
            //        add.Parameters.Clear();

            //        add.Parameters.AddWithValue("@param1", fila.Cells["ProductoTB"].Value.ToString());

            //        add.ExecuteNonQuery();
            //    } 
            //    #endregion

            //    //foreach (GridVie)

            //    MessageBox.Show("Datos agregados");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Errror al agregar");
            //}
            //finally
            //{
            //    con.Close();
            //} 
            #endregion

            
        }


        #region validaciones
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
        #endregion 
    }
}
