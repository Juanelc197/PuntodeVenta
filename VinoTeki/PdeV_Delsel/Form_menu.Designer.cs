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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_menu));
            this.panel_barraT = new System.Windows.Forms.Panel();
            this.lbl_menu = new System.Windows.Forms.Label();
            this.btn_restaurar = new System.Windows.Forms.Button();
            this.btn_minimisar = new System.Windows.Forms.Button();
            this.btn_maximisar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.panel_Contenedor = new System.Windows.Forms.Panel();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.tableLayoutPanel_imagen = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox_galeria = new System.Windows.Forms.PictureBox();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.tableLayoutPanel_titulo = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_delsel = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_a = new System.Windows.Forms.Label();
            this.panel_cotizacion = new System.Windows.Forms.Panel();
            this.panel_ventas = new System.Windows.Forms.Panel();
            this.panel_cliente = new System.Windows.Forms.Panel();
            this.panel_productos = new System.Windows.Forms.Panel();
            this.btn_cotisar = new System.Windows.Forms.Button();
            this.btn_venta = new System.Windows.Forms.Button();
            this.btn_cliente = new System.Windows.Forms.Button();
            this.btn_productos = new System.Windows.Forms.Button();
            this.timer_horafecha = new System.Windows.Forms.Timer(this.components);
            this.panel_barraT.SuspendLayout();
            this.panel_Contenedor.SuspendLayout();
            this.tableLayoutPanel_imagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_galeria)).BeginInit();
            this.tableLayoutPanel_titulo.SuspendLayout();
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
            this.panel_barraT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_barraT.Name = "panel_barraT";
            this.panel_barraT.Size = new System.Drawing.Size(1733, 47);
            this.panel_barraT.TabIndex = 0;
            this.panel_barraT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_barraT_MouseDown);
            // 
            // lbl_menu
            // 
            this.lbl_menu.AutoSize = true;
            this.lbl_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_menu.Location = new System.Drawing.Point(16, 11);
            this.lbl_menu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_menu.Name = "lbl_menu";
            this.lbl_menu.Size = new System.Drawing.Size(77, 29);
            this.lbl_menu.TabIndex = 9;
            this.lbl_menu.Text = "Menu";
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
            this.btn_restaurar.Location = new System.Drawing.Point(1643, 9);
            this.btn_restaurar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_restaurar.Name = "btn_restaurar";
            this.btn_restaurar.Size = new System.Drawing.Size(33, 31);
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
            this.btn_minimisar.Location = new System.Drawing.Point(1601, 9);
            this.btn_minimisar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_minimisar.Name = "btn_minimisar";
            this.btn_minimisar.Size = new System.Drawing.Size(33, 31);
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
            this.btn_maximisar.Location = new System.Drawing.Point(1643, 9);
            this.btn_maximisar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_maximisar.Name = "btn_maximisar";
            this.btn_maximisar.Size = new System.Drawing.Size(33, 31);
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
            this.btn_cerrar.Location = new System.Drawing.Point(1684, 9);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(33, 31);
            this.btn_cerrar.TabIndex = 0;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // panel_Contenedor
            // 
            this.panel_Contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel_Contenedor.Controls.Add(this.lbl_hora);
            this.panel_Contenedor.Controls.Add(this.tableLayoutPanel_imagen);
            this.panel_Contenedor.Controls.Add(this.lbl_fecha);
            this.panel_Contenedor.Controls.Add(this.tableLayoutPanel_titulo);
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
            this.panel_Contenedor.Location = new System.Drawing.Point(0, 0);
            this.panel_Contenedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_Contenedor.Name = "panel_Contenedor";
            this.panel_Contenedor.Size = new System.Drawing.Size(1733, 800);
            this.panel_Contenedor.TabIndex = 1;
            // 
            // lbl_hora
            // 
            this.lbl_hora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hora.Font = new System.Drawing.Font("Consolas", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.lbl_hora.Location = new System.Drawing.Point(16, 674);
            this.lbl_hora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(612, 94);
            this.lbl_hora.TabIndex = 12;
            this.lbl_hora.Text = "01:50:00 p.m.";
            // 
            // tableLayoutPanel_imagen
            // 
            this.tableLayoutPanel_imagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_imagen.ColumnCount = 1;
            this.tableLayoutPanel_imagen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_imagen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel_imagen.Controls.Add(this.pictureBox_galeria, 0, 0);
            this.tableLayoutPanel_imagen.Location = new System.Drawing.Point(1179, 412);
            this.tableLayoutPanel_imagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel_imagen.Name = "tableLayoutPanel_imagen";
            this.tableLayoutPanel_imagen.RowCount = 1;
            this.tableLayoutPanel_imagen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_imagen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 373F));
            this.tableLayoutPanel_imagen.Size = new System.Drawing.Size(539, 373);
            this.tableLayoutPanel_imagen.TabIndex = 16;
            // 
            // pictureBox_galeria
            // 
            this.pictureBox_galeria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_galeria.Image = global::PdeV_Delsel.Properties.Resources.fondo;
            this.pictureBox_galeria.Location = new System.Drawing.Point(4, 4);
            this.pictureBox_galeria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_galeria.Name = "pictureBox_galeria";
            this.pictureBox_galeria.Size = new System.Drawing.Size(531, 365);
            this.pictureBox_galeria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_galeria.TabIndex = 8;
            this.pictureBox_galeria.TabStop = false;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fecha.Font = new System.Drawing.Font("Consolas", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_fecha.Location = new System.Drawing.Point(20, 580);
            this.lbl_fecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(1020, 70);
            this.lbl_fecha.TabIndex = 11;
            this.lbl_fecha.Text = "jueves, 1 de noviembre de 2018";
            // 
            // tableLayoutPanel_titulo
            // 
            this.tableLayoutPanel_titulo.ColumnCount = 1;
            this.tableLayoutPanel_titulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_titulo.Controls.Add(this.lbl_delsel, 0, 3);
            this.tableLayoutPanel_titulo.Controls.Add(this.lbl_titulo, 0, 1);
            this.tableLayoutPanel_titulo.Controls.Add(this.lbl_a, 0, 2);
            this.tableLayoutPanel_titulo.Location = new System.Drawing.Point(725, 54);
            this.tableLayoutPanel_titulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel_titulo.Name = "tableLayoutPanel_titulo";
            this.tableLayoutPanel_titulo.RowCount = 4;
            this.tableLayoutPanel_titulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.12121F));
            this.tableLayoutPanel_titulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.31818F));
            this.tableLayoutPanel_titulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.37879F));
            this.tableLayoutPanel_titulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.80303F));
            this.tableLayoutPanel_titulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel_titulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel_titulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel_titulo.Size = new System.Drawing.Size(992, 325);
            this.tableLayoutPanel_titulo.TabIndex = 14;
            // 
            // lbl_delsel
            // 
            this.lbl_delsel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_delsel.AutoSize = true;
            this.lbl_delsel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_delsel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_delsel.ForeColor = System.Drawing.Color.White;
            this.lbl_delsel.Location = new System.Drawing.Point(416, 265);
            this.lbl_delsel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_delsel.Name = "lbl_delsel";
            this.lbl_delsel.Size = new System.Drawing.Size(159, 54);
            this.lbl_delsel.TabIndex = 13;
            this.lbl_delsel.Text = "Delsel";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 71.99999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(134, 39);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(724, 135);
            this.lbl_titulo.TabIndex = 11;
            this.lbl_titulo.Text = "Bienvenidos";
            // 
            // lbl_a
            // 
            this.lbl_a.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_a.AutoSize = true;
            this.lbl_a.BackColor = System.Drawing.Color.Transparent;
            this.lbl_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_a.ForeColor = System.Drawing.Color.White;
            this.lbl_a.Location = new System.Drawing.Point(464, 183);
            this.lbl_a.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(64, 69);
            this.lbl_a.TabIndex = 12;
            this.lbl_a.Text = "a";
            // 
            // panel_cotizacion
            // 
            this.panel_cotizacion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel_cotizacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_cotizacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.panel_cotizacion.Location = new System.Drawing.Point(509, 485);
            this.panel_cotizacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_cotizacion.Name = "panel_cotizacion";
            this.panel_cotizacion.Size = new System.Drawing.Size(11, 80);
            this.panel_cotizacion.TabIndex = 7;
            // 
            // panel_ventas
            // 
            this.panel_ventas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel_ventas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_ventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.panel_ventas.Location = new System.Drawing.Point(509, 361);
            this.panel_ventas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_ventas.Name = "panel_ventas";
            this.panel_ventas.Size = new System.Drawing.Size(11, 80);
            this.panel_ventas.TabIndex = 6;
            // 
            // panel_cliente
            // 
            this.panel_cliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel_cliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.panel_cliente.Location = new System.Drawing.Point(509, 231);
            this.panel_cliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_cliente.Name = "panel_cliente";
            this.panel_cliente.Size = new System.Drawing.Size(11, 80);
            this.panel_cliente.TabIndex = 5;
            // 
            // panel_productos
            // 
            this.panel_productos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel_productos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_productos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.panel_productos.Location = new System.Drawing.Point(509, 107);
            this.panel_productos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_productos.Name = "panel_productos";
            this.panel_productos.Size = new System.Drawing.Size(11, 80);
            this.panel_productos.TabIndex = 4;
            // 
            // btn_cotisar
            // 
            this.btn_cotisar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_cotisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cotisar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.btn_cotisar.FlatAppearance.BorderSize = 0;
            this.btn_cotisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.btn_cotisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cotisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cotisar.ForeColor = System.Drawing.Color.White;
            this.btn_cotisar.Image = global::PdeV_Delsel.Properties.Resources.cotizacion_mini;
            this.btn_cotisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cotisar.Location = new System.Drawing.Point(16, 485);
            this.btn_cotisar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cotisar.Name = "btn_cotisar";
            this.btn_cotisar.Size = new System.Drawing.Size(504, 80);
            this.btn_cotisar.TabIndex = 3;
            this.btn_cotisar.Text = "Cotización";
            this.btn_cotisar.UseVisualStyleBackColor = true;
            this.btn_cotisar.Click += new System.EventHandler(this.btn_cotisar_Click);
            // 
            // btn_venta
            // 
            this.btn_venta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_venta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_venta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_venta.FlatAppearance.BorderSize = 0;
            this.btn_venta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.btn_venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_venta.ForeColor = System.Drawing.Color.White;
            this.btn_venta.Image = global::PdeV_Delsel.Properties.Resources.venta_mini;
            this.btn_venta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_venta.Location = new System.Drawing.Point(16, 361);
            this.btn_venta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_venta.Name = "btn_venta";
            this.btn_venta.Size = new System.Drawing.Size(504, 80);
            this.btn_venta.TabIndex = 2;
            this.btn_venta.Text = "Venta";
            this.btn_venta.UseVisualStyleBackColor = true;
            this.btn_venta.Click += new System.EventHandler(this.btn_venta_Click);
            // 
            // btn_cliente
            // 
            this.btn_cliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_cliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cliente.FlatAppearance.BorderSize = 0;
            this.btn_cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.btn_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cliente.ForeColor = System.Drawing.Color.White;
            this.btn_cliente.Image = global::PdeV_Delsel.Properties.Resources.cliente_mini;
            this.btn_cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cliente.Location = new System.Drawing.Point(16, 231);
            this.btn_cliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(504, 80);
            this.btn_cliente.TabIndex = 1;
            this.btn_cliente.Text = "Cliente";
            this.btn_cliente.UseVisualStyleBackColor = true;
            this.btn_cliente.Click += new System.EventHandler(this.btn_cliente_Click);
            // 
            // btn_productos
            // 
            this.btn_productos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_productos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_productos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_productos.FlatAppearance.BorderSize = 0;
            this.btn_productos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.btn_productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_productos.ForeColor = System.Drawing.Color.White;
            this.btn_productos.Image = global::PdeV_Delsel.Properties.Resources.producto_mini;
            this.btn_productos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_productos.Location = new System.Drawing.Point(16, 107);
            this.btn_productos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_productos.Name = "btn_productos";
            this.btn_productos.Size = new System.Drawing.Size(504, 80);
            this.btn_productos.TabIndex = 0;
            this.btn_productos.Text = "Producto";
            this.btn_productos.UseVisualStyleBackColor = true;
            this.btn_productos.Click += new System.EventHandler(this.btn_productos_Click);
            // 
            // timer_horafecha
            // 
            this.timer_horafecha.Enabled = true;
            this.timer_horafecha.Tick += new System.EventHandler(this.timer_horafecha_Tick);
            // 
            // Form_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1733, 800);
            this.Controls.Add(this.panel_barraT);
            this.Controls.Add(this.panel_Contenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_menu";
            this.Opacity = 0.98D;
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.Form_menu_Load);
            this.panel_barraT.ResumeLayout(false);
            this.panel_barraT.PerformLayout();
            this.panel_Contenedor.ResumeLayout(false);
            this.panel_Contenedor.PerformLayout();
            this.tableLayoutPanel_imagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_galeria)).EndInit();
            this.tableLayoutPanel_titulo.ResumeLayout(false);
            this.tableLayoutPanel_titulo.PerformLayout();
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
        private System.Windows.Forms.Timer timer_horafecha;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_delsel;
        private System.Windows.Forms.Label lbl_a;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_titulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_imagen;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Label lbl_fecha;
    }
}

