using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PdeV_Delsel
{
    class Class_BasedeDatos
    {
        public static OleDbConnection cnn = new OleDbConnection("Provider=sqloledb;Data Source=LENOY97;Initial Catalog=ProyectoPdeVDelsel;Integrated Security=SSPI");

        public static DataSet ds;

        #region Productos
        public static DataTable MostrarProducto()
        {
            OleDbCommand comando = new OleDbCommand(string.Format("select * from Table_Producto where IdProducto "), cnn);

            try
            {
                cnn.Open();
                OleDbDataAdapter da = new OleDbDataAdapter(comando);
                ds = new DataSet();
                da.Fill(ds, "Table_Producto");
                //MessageBox.Show("Exito");
                cnn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hay problemas...");
                throw;
            }
            finally
            { cnn.Close(); }

            return ds.Tables["Table_Producto"];
        }

        public static void GuardarP(Class_ProductoTB P)
        {
            OleDbCommand comando = new OleDbCommand(string.Format("Insert into Table_Producto (Producto, Tipo, Marca, Modelo, Descripcion, Cantidad, Costo, Precio) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", P.Producto1, P.Tipo1, P.Marca1, P.Modelo1, P.Descripcion1, P.Cantidad1, P.Costo1, P.Precio1), cnn);
            

            try
            {
                cnn.Open();
                
                comando.ExecuteNonQuery();
               
                MessageBox.Show("Se guardo exitosamente");
                cnn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hay problemas...");
                throw;
            }
            finally
            { cnn.Close(); }


        }

        public static void EliminarP(Class_ProductoTB P)
        {
            OleDbCommand comando = new OleDbCommand(string.Format("Delete from Table_Producto where IdProducto='{0}'", P.IdProducto1), cnn);
            

            try
            {
                cnn.Open();
                
                comando.ExecuteNonQuery();
                
                MessageBox.Show("Se elimino exitosamente");
                cnn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hay problemas...");
                throw;
            }
            finally
            { cnn.Close(); }


        }

        public static void ActualisarP(Class_ProductoTB P)
        {
            OleDbCommand comando = new OleDbCommand(string.Format("Update Table_Producto set Producto='{0}', Tipo='{1}', Marca='{2}', Modelo='{3}', Descripcion='{4}', Cantidad='{5}', Costo='{6}', Precio='{7}' where IdProducto='{8}'", P.Producto1, P.Tipo1, P.Marca1, P.Modelo1, P.Descripcion1, P.Cantidad1, P.Costo1, P.Precio1, P.IdProducto1), cnn);
            

            try
            {
                cnn.Open();
                
                comando.ExecuteNonQuery();
                
                MessageBox.Show("Se Modifico correctamente");
                cnn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hay problemas...");
                throw;
            }
            finally
            { cnn.Close(); }


        }

        public static DataTable BuscarP(Class_ProductoTB P)
        {
            OleDbCommand comando = new OleDbCommand(string.Format("select * from Table_Producto where Producto LIKE '%{0}%'", P.Producto1), cnn);
            

            try
            {
                cnn.Open();
                OleDbDataAdapter da = new OleDbDataAdapter(comando);
                
                ds = new DataSet();
                da.Fill(ds, "Table_Producto");
                
                cnn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hay problemas...");
                throw;
            }
            finally
            { cnn.Close(); }

            return ds.Tables["Table_Producto"];


        }

        #endregion

        #region Cliente
        public static DataTable MostrarCliente()
        {
            OleDbCommand comando = new OleDbCommand(string.Format("select * from Table_Cliente where IdCliente "), cnn);

            try
            {
                cnn.Open();
                OleDbDataAdapter da = new OleDbDataAdapter(comando);
                ds = new DataSet();
                da.Fill(ds, "Table_Cliente");
                //MessageBox.Show("Exito");
                cnn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hay problemas...");
                throw;
            }
            finally
            { cnn.Close(); }

            return ds.Tables["Table_Cliente"];
        }

        public static void GuardarC(Class_ClienteTB C)
        {
            OleDbCommand comando = new OleDbCommand(string.Format("Insert into Table_Cliente (Nombre, RFC, Direccion, Telefono, Email, Razonsocial) values ('{0}','{1}','{2}','{3}','{4}','{5}')", C.Nombre1, C.RFC1, C.Direccion1, C.Telefono1, C.Email1, C.Razonsocial1), cnn);


            try
            {
                cnn.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Se guardo exitosamente");
                cnn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hay problemas...");
                throw;
            }
            finally
            { cnn.Close(); }


        }

        public static void EliminarC(Class_ClienteTB C)
        {
            OleDbCommand comando = new OleDbCommand(string.Format("Delete from Table_Cliente where IdCliente='{0}'", C.IdCliente1), cnn);


            try
            {
                cnn.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Se elimino exitosamente");
                cnn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hay problemas...");
                throw;
            }
            finally
            { cnn.Close(); }


        }

        public static void ActualisarC(Class_ClienteTB C)
        {
            OleDbCommand comando = new OleDbCommand(string.Format("Update Table_Cliente set Nombre='{0}', RFC='{1}', Direccion='{2}', Telefono='{3}', Email='{4}', Razonsocial='{5}' where IdCliente='{6}'", C.Nombre1, C.RFC1, C.Direccion1, C.Telefono1, C.Email1, C.Razonsocial1, C.IdCliente1), cnn);


            try
            {
                cnn.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Se Modifico correctamente");
                cnn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hay problemas...");
                throw;
            }
            finally
            { cnn.Close(); }


        }

        public static DataTable BuscarC(Class_ClienteTB C)
        {
            OleDbCommand comando = new OleDbCommand(string.Format("select * from Table_Cliente where Nombre LIKE '%{0}%'", C.Nombre1), cnn);


            try
            {
                cnn.Open();
                OleDbDataAdapter da = new OleDbDataAdapter(comando);

                ds = new DataSet();
                da.Fill(ds, "Table_Cliente");

                cnn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hay problemas...");
                throw;
            }
            finally
            { cnn.Close(); }

            return ds.Tables["Table_Cliente"];


        }
        #endregion
    }
}
