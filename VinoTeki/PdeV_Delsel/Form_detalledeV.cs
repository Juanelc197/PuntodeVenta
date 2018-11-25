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
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            #region busqueda de combobox y selecion cliente
            string cadena = "Select * from Table_Cliente where Fecha between = '" + monthCalendar_desde.Text + "' and '" + monthCalendar_hasta.Text + "' ";
            OleDbConnection cnn = new OleDbConnection("Provider=sqloledb;Data Source=LENOY97;Initial Catalog=ProyectoPdeVDelsel;Integrated Security=SSPI");
            //OleDbCommand comando = new OleDbCommand(cadena, cnn);
            cnn.Open();
            OleDbDataAdapter ad = new OleDbDataAdapter(cadena, cnn);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            dataGridView_verdatos.DataSource = ds.Tables[0];
            
            cnn.Close();
            #endregion
        }
    }
}
