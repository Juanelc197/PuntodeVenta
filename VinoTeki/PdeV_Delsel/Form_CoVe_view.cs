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

        }

        private void cb_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region busqueda formadepago
            //try
            //{
            //    OleDbCommand comando = new OleDbCommand();
            //    OleDbConnection cnn = new OleDbConnection("Provider=sqloledb;Data Source=LENOY97;Initial Catalog=ProyectoPdeVDelsel;Integrated Security=SSPI");
            //    comando.Connection = cnn;
            //    cnn.Open();
            //    string cadena = "Select * from Table_Venta where FolioVenta ='" + combo_folio.Text + "' ";

            //    comando.CommandText = cadena;

            //    OleDbDataAdapter adaptador = new OleDbDataAdapter(comando);
            //    DataTable dt = new DataTable();
            //    adaptador.Fill(dt);
            //    dataGridView_verdatos.DataSource = dt;

            //    comando.Clone();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Tenemos problemas" + ex.ToString());
            //}
            #endregion

        }
    }
}
