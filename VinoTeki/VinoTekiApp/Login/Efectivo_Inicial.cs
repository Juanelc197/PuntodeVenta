﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VinoTekiApp.Usuario
{
    public partial class Efectivo_Inicial : Form
    {
        public Efectivo_Inicial()
        {
            InitializeComponent();
        }

        private void Efectivo_Inicial_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(75, Color.Black);
        }
    }
}
