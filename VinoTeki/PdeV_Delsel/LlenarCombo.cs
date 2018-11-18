using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PdeV_Delsel
{
    class LlenarCombo
    {
        OleDbConnection cnn;
        OleDbCommand com;
        OleDbDataReader dr;

        public LlenarCombo()
        {
            try
            {
                cnn = new OleDbConnection("Provider=sqloledb;Data Source=LENOY97;Initial Catalog=ProyectoPdeVDelsel;Integrated Security=SSPI");
                cnn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hay problemas..." + ex.ToString());
            }
        }

        public void ItemLlenarP(ComboBox cb)
        {
            try
            {
                com = new OleDbCommand("select Producto from Table_Producto", cnn);
                dr = com.ExecuteReader();
                //parte de aztualizar comboboxproductoo
                cb.Items.Clear();
                while (dr.Read())
                {
                    cb.Items.Add(dr["Producto"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hay problemas..." + ex.ToString());
            }
        }

        public void ItemLlenarC(ComboBox cb)
        {
            try
            {
                com = new OleDbCommand("select Nombre from Table_Cliente", cnn);
                dr = com.ExecuteReader();
                //parte de aztualizar combobox cliente
                cb.Items.Clear();
                while (dr.Read())
                {
                    cb.Items.Add(dr["Nombre"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hay problemas..." + ex.ToString());
            }
        }
    }
}
