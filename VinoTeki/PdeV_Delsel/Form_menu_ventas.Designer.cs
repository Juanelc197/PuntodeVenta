﻿namespace PdeV_Delsel
{
    partial class Form_menu_ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_menu_ventas));
            this.panel_opciones = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_consulta = new System.Windows.Forms.Panel();
            this.panel_agregar = new System.Windows.Forms.Panel();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.panel_opcionestop = new System.Windows.Forms.Panel();
            this.panel_contenedor = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_restaurar = new System.Windows.Forms.Button();
            this.btn_menuboton = new System.Windows.Forms.Button();
            this.btn_minimisar = new System.Windows.Forms.Button();
            this.btn_maximisar = new System.Windows.Forms.Button();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.btn_verDatos = new System.Windows.Forms.Button();
            this.btn_consulta = new System.Windows.Forms.Button();
            this.btn_ventas = new System.Windows.Forms.Button();
            this.picturebox_logo = new System.Windows.Forms.PictureBox();
            this.panel_opciones.SuspendLayout();
            this.panel_opcionestop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_opciones
            // 
            this.panel_opciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel_opciones.Controls.Add(this.panel1);
            this.panel_opciones.Controls.Add(this.panel2);
            this.panel_opciones.Controls.Add(this.panel_consulta);
            this.panel_opciones.Controls.Add(this.panel_agregar);
            this.panel_opciones.Controls.Add(this.btn_regresar);
            this.panel_opciones.Controls.Add(this.lbl_titulo);
            this.panel_opciones.Controls.Add(this.btn_verDatos);
            this.panel_opciones.Controls.Add(this.btn_consulta);
            this.panel_opciones.Controls.Add(this.btn_ventas);
            this.panel_opciones.Controls.Add(this.picturebox_logo);
            this.panel_opciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_opciones.Location = new System.Drawing.Point(0, 0);
            this.panel_opciones.Name = "panel_opciones";
            this.panel_opciones.Size = new System.Drawing.Size(250, 650);
            this.panel_opciones.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.panel1.Location = new System.Drawing.Point(96, 581);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 57);
            this.panel1.TabIndex = 6;
            // 
            // panel_consulta
            // 
            this.panel_consulta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_consulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.panel_consulta.Location = new System.Drawing.Point(236, 292);
            this.panel_consulta.Name = "panel_consulta";
            this.panel_consulta.Size = new System.Drawing.Size(8, 57);
            this.panel_consulta.TabIndex = 6;
            // 
            // panel_agregar
            // 
            this.panel_agregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.panel_agregar.Location = new System.Drawing.Point(236, 189);
            this.panel_agregar.Name = "panel_agregar";
            this.panel_agregar.Size = new System.Drawing.Size(8, 57);
            this.panel_agregar.TabIndex = 5;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_titulo.Location = new System.Drawing.Point(74, 106);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(90, 31);
            this.lbl_titulo.TabIndex = 2;
            this.lbl_titulo.Text = "Venta";
            // 
            // panel_opcionestop
            // 
            this.panel_opcionestop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.panel_opcionestop.Controls.Add(this.btn_restaurar);
            this.panel_opcionestop.Controls.Add(this.btn_menuboton);
            this.panel_opcionestop.Controls.Add(this.btn_minimisar);
            this.panel_opcionestop.Controls.Add(this.btn_maximisar);
            this.panel_opcionestop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_opcionestop.Location = new System.Drawing.Point(250, 0);
            this.panel_opcionestop.Name = "panel_opcionestop";
            this.panel_opcionestop.Size = new System.Drawing.Size(1050, 38);
            this.panel_opcionestop.TabIndex = 5;
            this.panel_opcionestop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_opcionestop_MouseDown);
            // 
            // panel_contenedor
            // 
            this.panel_contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.panel_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenedor.Location = new System.Drawing.Point(250, 38);
            this.panel_contenedor.Name = "panel_contenedor";
            this.panel_contenedor.Size = new System.Drawing.Size(1050, 612);
            this.panel_contenedor.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.panel2.Location = new System.Drawing.Point(236, 392);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 57);
            this.panel2.TabIndex = 6;
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
            this.btn_restaurar.Location = new System.Drawing.Point(1013, 7);
            this.btn_restaurar.Name = "btn_restaurar";
            this.btn_restaurar.Size = new System.Drawing.Size(25, 25);
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
            this.btn_menuboton.Location = new System.Drawing.Point(6, 7);
            this.btn_menuboton.Name = "btn_menuboton";
            this.btn_menuboton.Size = new System.Drawing.Size(25, 25);
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
            this.btn_minimisar.Location = new System.Drawing.Point(982, 7);
            this.btn_minimisar.Name = "btn_minimisar";
            this.btn_minimisar.Size = new System.Drawing.Size(25, 25);
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
            this.btn_maximisar.Location = new System.Drawing.Point(1013, 7);
            this.btn_maximisar.Name = "btn_maximisar";
            this.btn_maximisar.Size = new System.Drawing.Size(25, 25);
            this.btn_maximisar.TabIndex = 3;
            this.btn_maximisar.UseVisualStyleBackColor = true;
            this.btn_maximisar.Click += new System.EventHandler(this.btn_maximisar_Click);
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
            this.btn_regresar.Location = new System.Drawing.Point(12, 581);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(92, 57);
            this.btn_regresar.TabIndex = 3;
            this.btn_regresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // btn_verDatos
            // 
            this.btn_verDatos.FlatAppearance.BorderSize = 0;
            this.btn_verDatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.btn_verDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_verDatos.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verDatos.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_verDatos.Image = global::PdeV_Delsel.Properties.Resources.lupita;
            this.btn_verDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_verDatos.Location = new System.Drawing.Point(21, 392);
            this.btn_verDatos.Name = "btn_verDatos";
            this.btn_verDatos.Size = new System.Drawing.Size(223, 57);
            this.btn_verDatos.TabIndex = 1;
            this.btn_verDatos.Text = "Consultar";
            this.btn_verDatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_verDatos.UseVisualStyleBackColor = true;
            this.btn_verDatos.Click += new System.EventHandler(this.btn_verDatos_Click);
            // 
            // btn_consulta
            // 
            this.btn_consulta.FlatAppearance.BorderSize = 0;
            this.btn_consulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.btn_consulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consulta.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consulta.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_consulta.Image = global::PdeV_Delsel.Properties.Resources.new_consulta_venta;
            this.btn_consulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_consulta.Location = new System.Drawing.Point(21, 292);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(223, 57);
            this.btn_consulta.TabIndex = 1;
            this.btn_consulta.Text = "Detalle Venta";
            this.btn_consulta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_consulta.UseVisualStyleBackColor = true;
            this.btn_consulta.Click += new System.EventHandler(this.btn_consulta_Click);
            // 
            // btn_ventas
            // 
            this.btn_ventas.FlatAppearance.BorderSize = 0;
            this.btn_ventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.btn_ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ventas.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ventas.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_ventas.Image = global::PdeV_Delsel.Properties.Resources.new_venta;
            this.btn_ventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ventas.Location = new System.Drawing.Point(21, 189);
            this.btn_ventas.Name = "btn_ventas";
            this.btn_ventas.Size = new System.Drawing.Size(223, 57);
            this.btn_ventas.TabIndex = 0;
            this.btn_ventas.Text = "Ventas";
            this.btn_ventas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ventas.UseVisualStyleBackColor = true;
            this.btn_ventas.Click += new System.EventHandler(this.btn_ventas_Click);
            // 
            // picturebox_logo
            // 
            this.picturebox_logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picturebox_logo.Image = global::PdeV_Delsel.Properties.Resources.Logo_delsel_1;
            this.picturebox_logo.Location = new System.Drawing.Point(3, 3);
            this.picturebox_logo.Name = "picturebox_logo";
            this.picturebox_logo.Size = new System.Drawing.Size(241, 100);
            this.picturebox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturebox_logo.TabIndex = 0;
            this.picturebox_logo.TabStop = false;
            this.picturebox_logo.Click += new System.EventHandler(this.picturebox_logo_Click);
            // 
            // Form_menu_ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panel_contenedor);
            this.Controls.Add(this.panel_opcionestop);
            this.Controls.Add(this.panel_opciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_menu_ventas";
            this.Opacity = 0.98D;
            this.Text = "Form_menu_ventas";
            this.panel_opciones.ResumeLayout(false);
            this.panel_opciones.PerformLayout();
            this.panel_opcionestop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_opciones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_consulta;
        private System.Windows.Forms.Panel panel_agregar;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.Button btn_ventas;
        private System.Windows.Forms.PictureBox picturebox_logo;
        private System.Windows.Forms.Panel panel_opcionestop;
        private System.Windows.Forms.Button btn_restaurar;
        private System.Windows.Forms.Button btn_menuboton;
        private System.Windows.Forms.Button btn_minimisar;
        private System.Windows.Forms.Button btn_maximisar;
        private System.Windows.Forms.Panel panel_contenedor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_verDatos;
    }
}