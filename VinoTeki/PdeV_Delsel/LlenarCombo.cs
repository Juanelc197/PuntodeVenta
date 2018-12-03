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

        public void ItemLlenarCotizacion(ComboBox cb)
        {
            try
            {
                com = new OleDbCommand("select FolioCot from Table_Cotizacion", cnn);
                dr = com.ExecuteReader();
                //parte de aztualizar combobox cliente
                cb.Items.Clear();
                while (dr.Read())
                {
                    cb.Items.Add(dr["FolioCot"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hay problemas..." + ex.ToString());
            }
        }

        public void ItemLlenarVenta(ComboBox ve)
        {
            try
            {
                com = new OleDbCommand("select Nombre from Table_Venta", cnn);
                dr = com.ExecuteReader();
                //parte de aztualizar combobox cliente
                ve.Items.Clear();
                while (dr.Read())
                {
                    ve.Items.Add(dr["Nombre"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hay problemas..." + ex.ToString());
            }
        }

        public void ItemLlenarVentafolo(ComboBox fo)
        {
            try
            {
                com = new OleDbCommand("select FolioVenta from Table_Venta", cnn);
                dr = com.ExecuteReader();
                //parte de aztualizar combobox cliente
                fo.Items.Clear();
                while (dr.Read())
                {
                    fo.Items.Add(dr["FolioVenta"].ToString());
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
