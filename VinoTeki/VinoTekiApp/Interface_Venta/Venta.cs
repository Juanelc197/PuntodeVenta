using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VinoTekiApp.Interface_Producto;
using VinoTekiApp.Interface_Venta;

namespace VinoTekiApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Varios_Productos agregar = new Varios_Productos();
            agregar.ShowDialog();
            if (agregar.DialogResult == DialogResult.Yes)
            {
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Varios_Productos agregar = new Varios_Productos();
            agregar.ShowDialog();
            if (agregar.DialogResult == DialogResult.Yes)
            {
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Registro_de_Entrada_de_Efectivo agregar = new Registro_de_Entrada_de_Efectivo();
            agregar.ShowDialog();
            if (agregar.DialogResult == DialogResult.Yes)
            {
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Borrar agregar = new Borrar();
            agregar.ShowDialog();
            if (agregar.DialogResult == DialogResult.Yes)
            {
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Registro_de_Salida_de_Dinero agregar = new Registro_de_Salida_de_Dinero();
            agregar.ShowDialog();
            if (agregar.DialogResult == DialogResult.Yes)
            {
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Buscar agregar = new Buscar();
            agregar.ShowDialog();
            if (agregar.DialogResult == DialogResult.Yes)
            {
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Producto_Comun agregar = new Producto_Comun();
            agregar.ShowDialog();
            if (agregar.DialogResult == DialogResult.Yes)
            {
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Cambio_de_Ticket agregar = new Cambio_de_Ticket();
            agregar.ShowDialog();
            if (agregar.DialogResult == DialogResult.Yes)
            {
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            TicketPendiente agregar = new TicketPendiente();
            agregar.ShowDialog();
            if (agregar.DialogResult == DialogResult.Yes)
            {
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Borrar agregar = new Borrar();
            agregar.ShowDialog();
            if (agregar.DialogResult == DialogResult.Yes)
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto agregar = new Producto();
            agregar.ShowDialog();
            if (agregar.DialogResult == DialogResult.Yes)
            {
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
