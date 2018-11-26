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
    public partial class Form_detalledeV : Form
    {
        public Form_detalledeV()
        {
            InitializeComponent();
            comboBox_formadepago.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_formadepago.Items.Add("Efectivo");
            comboBox_formadepago.Items.Add("Tarjeta de credito");
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            #region busqueda de combobox y selecion cliente

            //lbl_des.Text = monthCalendar_desde.SelectionRange.Start.ToString("dd/MM/yyyy");
            //lbl_has.Text = monthCalendar_hasta.SelectionRange.Start.ToString("dd/MM/yyyy");

            /*try
            {
                OleDbCommand comando = new OleDbCommand();
                OleDbConnection cnn = new OleDbConnection("Provider=sqloledb;Data Source=LENOY97;Initial Catalog=ProyectoPdeVDelsel;Integrated Security=SSPI");
                comando.Connection = cnn;
                cnn.Open();
                string cadena = "Select * from Table_Venta where Fecha = @fecha_des";
                comando.Parameters.AddWithValue("@fecha_des", this.lbl_des.Text);
                //comando.Parameters.AddWithValue("@fecha_has", monthCalendar_hasta.SelectionRange.Start);
                comando.CommandText = cadena;

                OleDbDataAdapter adaptador = new OleDbDataAdapter(comando);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataGridView_verdatos.DataSource = dt;

                comando.Clone();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tenemos problemas" + ex.ToString());
            } */

            #endregion
        } 
        

        private void monthCalendar_desde_DateChanged(object sender, DateRangeEventArgs e)
        {
            //lbl_des.Text = monthCalendar_desde.SelectionRange.Start.ToString("dd/MM/yyyy");
        }

        private void monthCalendar_hasta_DateChanged(object sender, DateRangeEventArgs e)
        {
            //lbl_has.Text = monthCalendar_hasta.SelectionRange.Start.ToString("dd/MM/yyyy");
        }

        private void comboBox_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region busqueda combobox cliente
            try
            {
                OleDbCommand comando = new OleDbCommand();
                OleDbConnection cnn = new OleDbConnection("Provider=sqloledb;Data Source=LENOY97;Initial Catalog=ProyectoPdeVDelsel;Integrated Security=SSPI");
                comando.Connection = cnn;
                cnn.Open();
                string cadena = "Select * from Table_Venta where Nombre ='" + comboBox_cliente.Text + "' ";

                comando.CommandText = cadena;

                OleDbDataAdapter adaptador = new OleDbDataAdapter(comando);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataGridView_verdatos.DataSource = dt;

                comando.Clone();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tenemos problemas" + ex.ToString());
            }
            #endregion
        }

        private void comboBox_formadepago_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region busqueda formadepago
            try
            {
                OleDbCommand comando = new OleDbCommand();
                OleDbConnection cnn = new OleDbConnection("Provider=sqloledb;Data Source=LENOY97;Initial Catalog=ProyectoPdeVDelsel;Integrated Security=SSPI");
                comando.Connection = cnn;
                cnn.Open();
                string cadena = "Select * from Table_Venta where FormadePago ='" + comboBox_formadepago.Text + "' ";
                
                comando.CommandText = cadena;

                OleDbDataAdapter adaptador = new OleDbDataAdapter(comando);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataGridView_verdatos.DataSource = dt;

                comando.Clone();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tenemos problemas" + ex.ToString());
            }
            #endregion
        }

        private void Form_detalledeV_Load(object sender, EventArgs e)
        {
            LlenarCombo vent = new LlenarCombo();
            vent.ItemLlenarVenta(comboBox_cliente);

            comboBox_cliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_cliente.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
    }
}
