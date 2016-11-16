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

namespace VinoTekiApp.Inventario
{
    public partial class Reporte_de_Inventario : Form
    {
        public Reporte_de_Inventario()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Agregar_Inventario agregar = new Agregar_Inventario();
            agregar.ShowDialog();
            if (agregar.DialogResult == DialogResult.Yes)
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Producto agregar = new Producto();
            agregar.ShowDialog();
            if (agregar.DialogResult == DialogResult.Yes)
            {
            }
        }
    }
}
