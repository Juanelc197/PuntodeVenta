namespace PdeV_Delsel
{
    partial class Form_menu
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
            this.components = new System.ComponentModel.Container();
            this.panel_barraT = new System.Windows.Forms.Panel();
            this.lbl_menu = new System.Windows.Forms.Label();
            this.panel_Contenedor = new System.Windows.Forms.Panel();
            this.lbl_delsel = new System.Windows.Forms.Label();
            this.lbl_a = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.panel_cotizacion = new System.Windows.Forms.Panel();
            this.panel_ventas = new System.Windows.Forms.Panel();
            this.panel_cliente = new System.Windows.Forms.Panel();
            this.panel_productos = new System.Windows.Forms.Panel();
            this.timer_horafecha = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_galeria = new System.Windows.Forms.PictureBox();
            this.btn_cotisar = new System.Windows.Forms.Button();
            this.btn_venta = new System.Windows.Forms.Button();
            this.btn_cliente = new System.Windows.Forms.Button();
            this.btn_productos = new System.Windows.Forms.Button();
            this.btn_restaurar = new System.Windows.Forms.Button();
            this.btn_minimisar = new System.Windows.Forms.Button();
            this.btn_maximisar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.panel_barraT.SuspendLayout();
            this.panel_Contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_galeria)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_barraT
            // 
            this.panel_barraT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.panel_barraT.Controls.Add(this.lbl_menu);
            this.panel_barraT.Controls.Add(this.btn_restaurar);
            this.panel_barraT.Controls.Add(this.btn_minimisar);
            this.panel_barraT.Controls.Add(this.btn_maximisar);
            this.panel_barraT.Controls.Add(this.btn_cerrar);
            this.panel_barraT.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_barraT.Location = new System.Drawing.Point(0, 0);
            this.panel_barraT.Name = "panel_barraT";
            this.panel_barraT.Size = new System.Drawing.Size(1300, 38);
            this.panel_barraT.TabIndex = 0;
            this.panel_barraT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_barraT_MouseDown);
            // 
            // lbl_menu
            // 
            this.lbl_menu.AutoSize = true;
            this.lbl_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_menu.Location = new System.Drawing.Point(12, 9);
            this.lbl_menu.Name = "lbl_menu";
            this.lbl_menu.Size = new System.Drawing.Size(63, 24);
            this.lbl_menu.TabIndex = 9;
            this.lbl_menu.Text = "Menu";
            // 
            // panel_Contenedor
            // 
            this.panel_Contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel_Contenedor.Controls.Add(this.lbl_delsel);
            this.panel_Contenedor.Controls.Add(this.lbl_a);
            this.panel_Contenedor.Controls.Add(this.lbl_titulo);
            this.panel_Contenedor.Controls.Add(this.lbl_fecha);
            this.panel_Contenedor.Controls.Add(this.lbl_hora);
            this.panel_Contenedor.Controls.Add(this.pictureBox_galeria);
            this.panel_Contenedor.Controls.Add(this.panel_cotizacion);
            this.panel_Contenedor.Controls.Add(this.panel_ventas);
            this.panel_Contenedor.Controls.Add(this.panel_cliente);
            this.panel_Contenedor.Controls.Add(this.panel_productos);
            this.panel_Contenedor.Controls.Add(this.btn_cotisar);
            this.panel_Contenedor.Controls.Add(this.btn_venta);
            this.panel_Contenedor.Controls.Add(this.btn_cliente);
            this.panel_Contenedor.Controls.Add(this.btn_productos);
            this.panel_Contenedor.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Contenedor.Location = new System.Drawing.Point(0, 38);
            this.panel_Contenedor.Name = "panel_Contenedor";
            this.panel_Contenedor.Size = new System.Drawing.Size(1300, 612);
            this.panel_Contenedor.TabIndex = 1;
            // 
            // lbl_delsel
            // 
            this.lbl_delsel.AutoSize = true;
            this.lbl_delsel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_delsel.Font = new System.Drawing.Font("Lithos Pro Regular", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_delsel.ForeColor = System.Drawing.Color.White;
            this.lbl_delsel.Location = new System.Drawing.Point(853, 157);
            this.lbl_delsel.Name = "lbl_delsel";
            this.lbl_delsel.Size = new System.Drawing.Size(152, 48);
            this.lbl_delsel.TabIndex = 13;
            this.lbl_delsel.Text = "Delsel";
            // 
            // lbl_a
            // 
            this.lbl_a.AutoSize = true;
            this.lbl_a.BackColor = System.Drawing.Color.Transparent;
            this.lbl_a.Font = new System.Drawing.Font("Lithos Pro Regular", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_a.ForeColor = System.Drawing.Color.White;
            this.lbl_a.Location = new System.Drawing.Point(901, 106);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(64, 62);
            this.lbl_a.TabIndex = 12;
            this.lbl_a.Text = "a";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Lithos Pro Regular", 71.99999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(564, 3);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(733, 124);
            this.lbl_titulo.TabIndex = 11;
            this.lbl_titulo.Text = "Bienvenidos";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fecha.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_fecha.Location = new System.Drawing.Point(0, 484);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(748, 55);
            this.lbl_fecha.TabIndex = 10;
            this.lbl_fecha.Text = "domingo, 28 de octubre de 2018";
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hora.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.lbl_hora.Location = new System.Drawing.Point(0, 539);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(475, 73);
            this.lbl_hora.TabIndex = 9;
            this.lbl_hora.Text = "01:07:09 a. m. ";
            // 
            // panel_cotizacion
            // 
            this.panel_cotizacion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel_cotizacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_cotizacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.panel_cotizacion.Location = new System.Drawing.Point(380, 398);
            this.panel_cotizacion.Name = "panel_cotizacion";
            this.panel_cotizacion.Size = new System.Drawing.Size(8, 65);
            this.panel_cotizacion.TabIndex = 7;
            // 
            // panel_ventas
            // 
            this.panel_ventas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel_ventas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_ventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.panel_ventas.Location = new System.Drawing.Point(380, 297);
            this.panel_ventas.Name = "panel_ventas";
            this.panel_ventas.Size = new System.Drawing.Size(8, 65);
            this.panel_ventas.TabIndex = 6;
            // 
            // panel_cliente
            // 
            this.panel_cliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel_cliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.panel_cliente.Location = new System.Drawing.Point(380, 192);
            this.panel_cliente.Name = "panel_cliente";
            this.panel_cliente.Size = new System.Drawing.Size(8, 65);
            this.panel_cliente.TabIndex = 5;
            // 
            // panel_productos
            // 
            this.panel_productos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel_productos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_productos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.panel_productos.Location = new System.Drawing.Point(380, 91);
            this.panel_productos.Name = "panel_productos";
            this.panel_productos.Size = new System.Drawing.Size(8, 65);
            this.panel_productos.TabIndex = 4;
            // 
            // timer_horafecha
            // 
            this.timer_horafecha.Enabled = true;
            this.timer_horafecha.Tick += new System.EventHandler(this.timer_horafecha_Tick);
            // 
            // pictureBox_galeria
            // 
            this.pictureBox_galeria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_galeria.Image = global::PdeV_Delsel.Properties.Resources.fondo;
            this.pictureBox_galeria.Location = new System.Drawing.Point(884, 297);
            this.pictureBox_galeria.Name = "pictureBox_galeria";
            this.pictureBox_galeria.Size = new System.Drawing.Size(404, 303);
            this.pictureBox_galeria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_galeria.TabIndex = 8;
            this.pictureBox_galeria.TabStop = false;
            // 
            // btn_cotisar
            // 
            this.btn_cotisar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_cotisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cotisar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.btn_cotisar.FlatAppearance.BorderSize = 0;
            this.btn_cotisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.btn_cotisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cotisar.Font = new System.Drawing.Font("Lithos Pro Regular", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cotisar.ForeColor = System.Drawing.Color.White;
            this.btn_cotisar.Image = global::PdeV_Delsel.Properties.Resources.cotizacion_mini;
            this.btn_cotisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cotisar.Location = new System.Drawing.Point(10, 398);
            this.btn_cotisar.Name = "btn_cotisar";
            this.btn_cotisar.Size = new System.Drawing.Size(378, 65);
            this.btn_cotisar.TabIndex = 3;
            this.btn_cotisar.Text = "Cotización";
            this.btn_cotisar.UseVisualStyleBackColor = true;
            // 
            // btn_venta
            // 
            this.btn_venta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_venta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_venta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_venta.FlatAppearance.BorderSize = 0;
            this.btn_venta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.btn_venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_venta.Font = new System.Drawing.Font("Lithos Pro Regular", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_venta.ForeColor = System.Drawing.Color.White;
            this.btn_venta.Image = global::PdeV_Delsel.Properties.Resources.venta_mini;
            this.btn_venta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_venta.Location = new System.Drawing.Point(10, 297);
            this.btn_venta.Name = "btn_venta";
            this.btn_venta.Size = new System.Drawing.Size(378, 65);
            this.btn_venta.TabIndex = 2;
            this.btn_venta.Text = "Ventas";
            this.btn_venta.UseVisualStyleBackColor = true;
            // 
            // btn_cliente
            // 
            this.btn_cliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_cliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cliente.FlatAppearance.BorderSize = 0;
            this.btn_cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.btn_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cliente.Font = new System.Drawing.Font("Lithos Pro Regular", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cliente.ForeColor = System.Drawing.Color.White;
            this.btn_cliente.Image = global::PdeV_Delsel.Properties.Resources.cliente_mini;
            this.btn_cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cliente.Location = new System.Drawing.Point(10, 192);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(378, 65);
            this.btn_cliente.TabIndex = 1;
            this.btn_cliente.Text = "Clientes";
            this.btn_cliente.UseVisualStyleBackColor = true;
            // 
            // btn_productos
            // 
            this.btn_productos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_productos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_productos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_productos.FlatAppearance.BorderSize = 0;
            this.btn_productos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.btn_productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_productos.Font = new System.Drawing.Font("Lithos Pro Regular", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_productos.ForeColor = System.Drawing.Color.White;
            this.btn_productos.Image = global::PdeV_Delsel.Properties.Resources.producto_mini;
            this.btn_productos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_productos.Location = new System.Drawing.Point(10, 91);
            this.btn_productos.Name = "btn_productos";
            this.btn_productos.Size = new System.Drawing.Size(378, 65);
            this.btn_productos.TabIndex = 0;
            this.btn_productos.Text = "Productos";
            this.btn_productos.UseVisualStyleBackColor = true;
            this.btn_productos.Click += new System.EventHandler(this.btn_productos_Click);
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
            this.btn_restaurar.Location = new System.Drawing.Point(1232, 8);
            this.btn_restaurar.Name = "btn_restaurar";
            this.btn_restaurar.Size = new System.Drawing.Size(25, 25);
            this.btn_restaurar.TabIndex = 1;
            this.btn_restaurar.UseVisualStyleBackColor = true;
            this.btn_restaurar.Visible = false;
            this.btn_restaurar.Click += new System.EventHandler(this.btn_restaurar_Click);
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
            this.btn_minimisar.Location = new System.Drawing.Point(1201, 7);
            this.btn_minimisar.Name = "btn_minimisar";
            this.btn_minimisar.Size = new System.Drawing.Size(25, 25);
            this.btn_minimisar.TabIndex = 2;
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
            this.btn_maximisar.Location = new System.Drawing.Point(1232, 7);
            this.btn_maximisar.Name = "btn_maximisar";
            this.btn_maximisar.Size = new System.Drawing.Size(25, 25);
            this.btn_maximisar.TabIndex = 2;
            this.btn_maximisar.UseVisualStyleBackColor = true;
            this.btn_maximisar.Click += new System.EventHandler(this.btn_maximisar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar.BackgroundImage = global::PdeV_Delsel.Properties.Resources.x;
            this.btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Location = new System.Drawing.Point(1263, 7);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(25, 25);
            this.btn_cerrar.TabIndex = 0;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // Form_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panel_Contenedor);
            this.Controls.Add(this.panel_barraT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_menu";
            this.Opacity = 0.98D;
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.Form_menu_Load);
            this.panel_barraT.ResumeLayout(false);
            this.panel_barraT.PerformLayout();
            this.panel_Contenedor.ResumeLayout(false);
            this.panel_Contenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_galeria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_barraT;
        private System.Windows.Forms.Panel panel_Contenedor;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_restaurar;
        private System.Windows.Forms.Button btn_maximisar;
        private System.Windows.Forms.Button btn_minimisar;
        private System.Windows.Forms.Button btn_productos;
        private System.Windows.Forms.Button btn_cliente;
        private System.Windows.Forms.Button btn_venta;
        private System.Windows.Forms.Button btn_cotisar;
        private System.Windows.Forms.Panel panel_productos;
        private System.Windows.Forms.Panel panel_cotizacion;
        private System.Windows.Forms.Panel panel_ventas;
        private System.Windows.Forms.Panel panel_cliente;
        private System.Windows.Forms.PictureBox pictureBox_galeria;
        private System.Windows.Forms.Label lbl_menu;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Timer timer_horafecha;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_delsel;
        private System.Windows.Forms.Label lbl_a;
    }
}

