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
    public partial class Form_menu_productos : Form
    {
        public Form_menu_productos()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btn_maximisar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_maximisar.Visible = false;
            btn_restaurar.Visible = true;
        }

        private void btn_restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_restaurar.Visible = false;
            btn_maximisar.Visible = true;
        }

        private void btn_minimisar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_menuboton_Click(object sender, EventArgs e)
        {
            if (panel_opciones.Width == 250)
            {
                panel_opciones.Width = 80;
            }
            else
                panel_opciones.Width = 250;
        }

        private void picturebox_logo_Click(object sender, EventArgs e)
        {
            
            Form_menu form_Menu = new Form_menu();
            this.Close();
            form_Menu.Show();
        }

        private void panel_opcionestop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            Form_menu form_Menu = new Form_menu();
            this.Close();
            form_Menu.Show();
        }
    }
}
