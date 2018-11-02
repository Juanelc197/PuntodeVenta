using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PdeV_Delsel
{
    public partial class Form_menu_clientes : Form
    {
        public Form_menu_clientes()
        {
            InitializeComponent();
        }

        #region codigo para mover interface
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panel_opcionestop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region codigo de los botones de la parte Top y logo

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

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            Form_menu form_Menu = new Form_menu();
            this.Close();
            form_Menu.Show();
        }

        private void btn_maximisar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_maximisar.Visible = false;
            btn_restaurar.Visible = true;
        }

        private void btn_minimisar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_restaurar.Visible = false;
            btn_maximisar.Visible = true;
        }


        /* private void btn_maximisar_Click_1(object sender, EventArgs e)
         {
             this.WindowState = FormWindowState.Maximized;
             btn_maximisar.Visible = false;
             btn_restaurar.Visible = true;
         } */
        #endregion

        #region codigo para mostrar y ocultar panel y abrir form dentro del form
        /* private void AbrirFormInPanel(object Formson)
        {
            if (this.panel_contenedor.Controls.Count > 0)
                this.panel_contenedor.Controls.RemoveAt(0);
            Form fh = Formson as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_contenedor.Controls.Add(fh);
            this.panel_contenedor.Tag = fh;
            fh.Show();
        } */

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panel_contenedor.Controls.OfType<MiForm>().FirstOrDefault(); //busca en la colecion de formulario
            //si el formulario no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                //formulario.FormBorderStyle = FormBorderStyle.FixedSingle;
                formulario.Dock = DockStyle.Fill;
                panel_contenedor.Controls.Add(formulario);
                panel_contenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario existe
            else
            {
                formulario.BringToFront();
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            //AbrirFormInPanel(new Form_Altacliente());
            AbrirFormulario<Form_Altacliente>();
        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            //AbrirFormInPanel(new FormConsultacliente());
            AbrirFormulario<FormConsultacliente>();
        }
        #endregion
    }
}
