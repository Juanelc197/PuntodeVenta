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

        private void Form_menu_Load(object sender, EventArgs e)
        {
            
            //pictureBox_galeria.Image = Properties.Resources.fondo1delsel;
            //pictureBox_galeria.SizeMode = PictureBoxSizeMode.Zoom;
            //Timer tm = new Timer();
            //tm.Interval = 400;
            //tm.Tick += new EventHandler(changeimage);
            //tm.Start();

        }

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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel_barraT_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void timer_horafecha_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToLongTimeString();

            lbl_fecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
