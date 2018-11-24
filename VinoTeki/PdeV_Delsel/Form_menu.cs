using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PdeV_Delsel
{
    public partial class Form_menu : Form
    {
        public Form_menu()
        {
            InitializeComponent();
        }
        #region eventos de botones de cerrar, minimisar, mazximisar y restaurar
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_maximisar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_maximisar.Visible = false;
            btn_restaurar.Visible = true;
            lbl_hora.Font = new Font("Murtuza", 72);
            lbl_fecha.Font = new Font("Murtuza", 48);
            


        }

        private void btn_restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_restaurar.Visible = false;
            btn_maximisar.Visible = true;
            lbl_hora.Font = new Font("Murtuza", 48);
            lbl_fecha.Font = new Font("Murtuza", 36);
        }

        private void btn_minimisar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        private void Form_menu_Load(object sender, EventArgs e)
        {
            #region galeria de imagen
            //galeria de imagen
            //pictureBox_galeria.Image = Properties.Resources.fondo1delsel;
            //pictureBox_galeria.SizeMode = PictureBoxSizeMode.Zoom;
            //Timer tm = new Timer();
            //tm.Interval = 400;
            //tm.Tick += new EventHandler(changeimage);
            //tm.Start();

        }
        //galeria de imagen
        //private void changeimage(object sender, EventArgs e)
        //{
        //    List<Bitmap> b1 = new List<Bitmap>();
        //    b1.Add(Properties.Resources.fondo1delsel);
        //    b1.Add(Properties.Resources.fondo2delsel);
        //    b1.Add(Properties.Resources.fondo3delsel);
        //    b1.Add(Properties.Resources.fondo4delsel);
        //    int index = DateTime.Now.Second % b1.Count;
        //    pictureBox_galeria.Image = b1[index];
        //}
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

        #region codigo para poner hora y fecha actual
        private void timer_horafecha_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToLongTimeString();

            lbl_fecha.Text = DateTime.Now.ToLongDateString();
        }
        #endregion

        #region codigo de los principales votones para abrir las otras interfaces
        private void btn_productos_Click(object sender, EventArgs e)
        {
            Form_menu_productos form_Menu_Productos = new Form_menu_productos();
            this.Hide();
            form_Menu_Productos.Show();
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            Form_menu_clientes form_Menu_Clientes = new Form_menu_clientes();
            this.Hide();
            form_Menu_Clientes.Show();
        }

        private void btn_venta_Click(object sender, EventArgs e)
        {
            Form_menu_ventas form_Menu_Ventas = new Form_menu_ventas();
            this.Hide();
            form_Menu_Ventas.Show();
        }
        

        private void btn_cotisar_Click(object sender, EventArgs e)
        {
            Form_Cotizacion form_Cotizacion = new Form_Cotizacion();
            this.Hide();
            form_Cotizacion.Show();
        }
        #endregion
    }
}
