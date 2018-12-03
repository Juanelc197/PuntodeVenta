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
    public partial class Form_CoVe_view : Form
    {
        public Form_CoVe_view()
        {
            InitializeComponent();
        }

        private void Form_CoVe_view_Load(object sender, EventArgs e)
        {
            LlenarCombo info = new LlenarCombo();
            info.ItemLlenarCotizacionnom(cb_cliente);
            info.ItemLlenarCotizacion(cb_folio);

            cb_cliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb_cliente.AutoCompleteSource = AutoCompleteSource.ListItems;

            cb_folio.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb_folio.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void cb_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region busqueda cliente
            try
            {
                OleDbCommand comando = new OleDbCommand();
                OleDbConnection cnn = new OleDbConnection("Provider=sqloledb;Data Source=LENOY97;Initial Catalog=ProyectoPdeVDelsel;Integrated Security=SSPI");
                comando.Connection = cnn;
                cnn.Open();
                string cadena = "Select * from Table_Cotizacion where Nombre ='" + cb_cliente.Text + "' ";

                comando.CommandText = cadena;

                OleDbDataAdapter adaptador = new OleDbDataAdapter(comando);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dGV_CotizacionCliente.DataSource = dt;

                comando.Clone();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tenemos problemas" + ex.ToString());
            }
            #endregion

        }

        private void cb_folio_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region busqueda cliente por folio
            try
            {
                OleDbCommand comando = new OleDbCommand();
                OleDbConnection cnn = new OleDbConnection("Provider=sqloledb;Data Source=LENOY97;Initial Catalog=ProyectoPdeVDelsel;Integrated Security=SSPI");
                comando.Connection = cnn;
                cnn.Open();
                string cadena = "Select * from Table_Cotizacion where FolioCot ='" + cb_folio.Text + "' ";

                comando.CommandText = cadena;

                OleDbDataAdapter adaptador = new OleDbDataAdapter(comando);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dGV_CotizacionCliente.DataSource = dt;

                comando.Clone();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tenemos problemas" + ex.ToString());
            }
            #endregion

            #region busqueda cliente por folio
            try
            {
                OleDbCommand comando = new OleDbCommand();
                OleDbConnection cnn = new OleDbConnection("Provider=sqloledb;Data Source=LENOY97;Initial Catalog=ProyectoPdeVDelsel;Integrated Security=SSPI");
                comando.Connection = cnn;
                cnn.Open();
                string cadena = "Select * from Table_VentasTemporales where FolioCoVe ='" + cb_folio.Text + "' ";

                comando.CommandText = cadena;

                OleDbDataAdapter adaptador = new OleDbDataAdapter(comando);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dGV_CotizacionProducto.DataSource = dt;

                comando.Clone();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tenemos problemas" + ex.ToString());
            }
            #endregion

        }
    }
}
