﻿namespace PdeV_Delsel
{
    partial class Form_menu_productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_menu_productos));
            this.panel_opciones = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_consulta = new System.Windows.Forms.Panel();
            this.panel_agregar = new System.Windows.Forms.Panel();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_consulta = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.picturebox_logo = new System.Windows.Forms.PictureBox();
            this.panel_opcionestop = new System.Windows.Forms.Panel();
            this.btn_restaurar = new System.Windows.Forms.Button();
            this.btn_menuboton = new System.Windows.Forms.Button();
            this.btn_minimisar = new System.Windows.Forms.Button();
            this.btn_maximisar = new System.Windows.Forms.Button();
            this.panel_contenedor = new System.Windows.Forms.Panel();
            this.panel_opciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_logo)).BeginInit();
            this.panel_opcionestop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_opciones
            // 
            this.panel_opciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel_opciones.Controls.Add(this.panel1);
            this.panel_opciones.Controls.Add(this.panel_consulta);
            this.panel_opciones.Controls.Add(this.panel_agregar);
            this.panel_opciones.Controls.Add(this.btn_regresar);
            this.panel_opciones.Controls.Add(this.lbl_titulo);
            this.panel_opciones.Controls.Add(this.btn_consulta);
            this.panel_opciones.Controls.Add(this.btn_Agregar);
            this.panel_opciones.Controls.Add(this.picturebox_logo);
            this.panel_opciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_opciones.Location = new System.Drawing.Point(0, 0);
            this.panel_opciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_opciones.Name = "panel_opciones";
            this.panel_opciones.Size = new System.Drawing.Size(333, 800);
            this.panel_opciones.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.panel1.Location = new System.Drawing.Point(128, 715);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(11, 70);
            this.panel1.TabIndex = 6;
            // 
            // panel_consulta
            // 
            this.panel_consulta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_consulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.panel_consulta.Location = new System.Drawing.Point(315, 359);
            this.panel_consulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_consulta.Name = "panel_consulta";
            this.panel_consulta.Size = new System.Drawing.Size(11, 70);
            this.panel_consulta.TabIndex = 6;
            // 
            // panel_agregar
            // 
            this.panel_agregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.panel_agregar.Location = new System.Drawing.Point(315, 233);
            this.panel_agregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_agregar.Name = "panel_agregar";
            this.panel_agregar.Size = new System.Drawing.Size(11, 70);
            this.panel_agregar.TabIndex = 5;
            // 
            // btn_regresar
            // 
            this.btn_regresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_regresar.FlatAppearance.BorderSize = 0;
            this.btn_regresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.btn_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regresar.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regresar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_regresar.Image = global::PdeV_Delsel.Properties.Resources.flecha_atras_super_mini_blanca;
            this.btn_regresar.Location = new System.Drawing.Point(16, 715);
            this.btn_regresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(123, 70);
            this.btn_regresar.TabIndex = 3;
            this.btn_regresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_titulo.Location = new System.Drawing.Point(99, 130);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(161, 39);
            this.lbl_titulo.TabIndex = 2;
            this.lbl_titulo.Text = "Producto";
            // 
            // btn_consulta
            // 
            this.btn_consulta.FlatAppearance.BorderSize = 0;
            this.btn_consulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.btn_consulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consulta.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consulta.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_consulta.Image = global::PdeV_Delsel.Properties.Resources.consulta_icono_mini_new;
            this.btn_consulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_consulta.Location = new System.Drawing.Point(28, 359);
            this.btn_consulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(297, 70);
            this.btn_consulta.TabIndex = 1;
            this.btn_consulta.Text = "Consulta";
            this.btn_consulta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_consulta.UseVisualStyleBackColor = true;
            this.btn_consulta.Click += new System.EventHandler(this.btn_consulta_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.FlatAppearance.BorderSize = 0;
            this.btn_Agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agregar.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Agregar.Image = global::PdeV_Delsel.Properties.Resources.estesiesalta;
            this.btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Agregar.Location = new System.Drawing.Point(28, 233);
            this.btn_Agregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(297, 70);
            this.btn_Agregar.TabIndex = 0;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // picturebox_logo
            // 
            this.picturebox_logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picturebox_logo.Image = global::PdeV_Delsel.Properties.Resources.Logo_delsel_1;
            this.picturebox_logo.Location = new System.Drawing.Point(4, 4);
            this.picturebox_logo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picturebox_logo.Name = "picturebox_logo";
            this.picturebox_logo.Size = new System.Drawing.Size(321, 123);
            this.picturebox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturebox_logo.TabIndex = 0;
            this.picturebox_logo.TabStop = false;
            this.picturebox_logo.Click += new System.EventHandler(this.picturebox_logo_Click);
            // 
            // panel_opcionestop
            // 
            this.panel_opcionestop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.panel_opcionestop.Controls.Add(this.btn_restaurar);
            this.panel_opcionestop.Controls.Add(this.btn_menuboton);
            this.panel_opcionestop.Controls.Add(this.btn_minimisar);
            this.panel_opcionestop.Controls.Add(this.btn_maximisar);
            this.panel_opcionestop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_opcionestop.Location = new System.Drawing.Point(333, 0);
            this.panel_opcionestop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_opcionestop.Name = "panel_opcionestop";
            this.panel_opcionestop.Size = new System.Drawing.Size(1400, 47);
            this.panel_opcionestop.TabIndex = 3;
            this.panel_opcionestop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_opcionestop_MouseDown);
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_restaurar.BackgroundImage = global::PdeV_Delsel.Properties.Resources.minimisar;
            this.btn_restaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_restaurar.FlatAppearance.BorderSize = 0;
            this.btn_restaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btn_restaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.btn_restaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_restaurar.Location = new System.Drawing.Point(1351, 9);
            this.btn_restaurar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_restaurar.Name = "btn_restaurar";
            this.btn_restaurar.Size = new System.Drawing.Size(33, 31);
            this.btn_restaurar.TabIndex = 4;
            this.btn_restaurar.UseVisualStyleBackColor = true;
            this.btn_restaurar.Visible = false;
            this.btn_restaurar.Click += new System.EventHandler(this.btn_restaurar_Click);
            // 
            // btn_menuboton
            // 
            this.btn_menuboton.BackgroundImage = global::PdeV_Delsel.Properties.Resources.botonmenu;
            this.btn_menuboton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_menuboton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_menuboton.FlatAppearance.BorderSize = 0;
            this.btn_menuboton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btn_menuboton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.btn_menuboton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menuboton.Location = new System.Drawing.Point(8, 9);
            this.btn_menuboton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_menuboton.Name = "btn_menuboton";
            this.btn_menuboton.Size = new System.Drawing.Size(33, 31);
            this.btn_menuboton.TabIndex = 6;
            this.btn_menuboton.UseVisualStyleBackColor = true;
            this.btn_menuboton.Click += new System.EventHandler(this.btn_menuboton_Click);
            // 
            // btn_minimisar
            // 
            this.btn_minimisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimisar.BackgroundImage = global::PdeV_Delsel.Properties.Resources.ocultar;
            this.btn_minimisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_minimisar.FlatAppearance.BorderSize = 0;
            this.btn_minimisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btn_minimisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.btn_minimisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimisar.Location = new System.Drawing.Point(1309, 9);
            this.btn_minimisar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_minimisar.Name = "btn_minimisar";
            this.btn_minimisar.Size = new System.Drawing.Size(33, 31);
            this.btn_minimisar.TabIndex = 5;
            this.btn_minimisar.UseVisualStyleBackColor = true;
            this.btn_minimisar.Click += new System.EventHandler(this.btn_minimisar_Click);
            // 
            // btn_maximisar
            // 
            this.btn_maximisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maximisar.BackgroundImage = global::PdeV_Delsel.Properties.Resources.maximisar;
            this.btn_maximisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_maximisar.FlatAppearance.BorderSize = 0;
            this.btn_maximisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btn_maximisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.btn_maximisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_maximisar.Location = new System.Drawing.Point(1351, 9);
            this.btn_maximisar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_maximisar.Name = "btn_maximisar";
            this.btn_maximisar.Size = new System.Drawing.Size(33, 31);
            this.btn_maximisar.TabIndex = 3;
            this.btn_maximisar.UseVisualStyleBackColor = true;
            this.btn_maximisar.Click += new System.EventHandler(this.btn_maximisar_Click);
            // 
            // panel_contenedor
            // 
            this.panel_contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.panel_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenedor.Location = new System.Drawing.Point(333, 47);
            this.panel_contenedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_contenedor.Name = "panel_contenedor";
            this.panel_contenedor.Size = new System.Drawing.Size(1400, 753);
            this.panel_contenedor.TabIndex = 4;
            // 
            // Form_menu_productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1733, 800);
            this.Controls.Add(this.panel_contenedor);
            this.Controls.Add(this.panel_opcionestop);
            this.Controls.Add(this.panel_opciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_menu_productos";
            this.Opacity = 0.98D;
            this.Text = "Form_menu_productos";
            this.panel_opciones.ResumeLayout(false);
            this.panel_opciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_logo)).EndInit();
            this.panel_opcionestop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_opciones;
        private System.Windows.Forms.Panel panel_opcionestop;
        private System.Windows.Forms.Panel panel_contenedor;
        private System.Windows.Forms.Button btn_minimisar;
        private System.Windows.Forms.Button btn_restaurar;
        private System.Windows.Forms.Button btn_maximisar;
        private System.Windows.Forms.Button btn_menuboton;
        private System.Windows.Forms.PictureBox picturebox_logo;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Panel panel_agregar;
        private System.Windows.Forms.Panel panel_consulta;
        private System.Windows.Forms.Panel panel1;
    }
}