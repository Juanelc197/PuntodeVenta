namespace PdeV_Delsel
{
    partial class Form_venta
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
            this.tableLayoutPanel_Titulo = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.tableLayoutPanel_contenedorTop = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox_cliente = new System.Windows.Forms.ComboBox();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_rfc = new System.Windows.Forms.Label();
            this.txt_rfc = new System.Windows.Forms.TextBox();
            this.lbl_razonsocial = new System.Windows.Forms.Label();
            this.txt_razonsocial = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel_con2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Ucotizacion = new System.Windows.Forms.Label();
            this.lbl_Ultimacotizacion = new System.Windows.Forms.Label();
            this.lbl_domicilio = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel_con3 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.txt_precioU = new System.Windows.Forms.TextBox();
            this.lbl_producto = new System.Windows.Forms.Label();
            this.lbl_precioU = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.comboBox_productos = new System.Windows.Forms.ComboBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_ver = new System.Windows.Forms.Button();
            this.dataGridView_verdatos = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel_con4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_final = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_formaPago = new System.Windows.Forms.Label();
            this.checkBox_efectivo = new System.Windows.Forms.CheckBox();
            this.checkBox_tarjeta = new System.Windows.Forms.CheckBox();
            this.lbl_subtotal = new System.Windows.Forms.Label();
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.checkBox_iva = new System.Windows.Forms.CheckBox();
            this.lbl_iva = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_venta = new System.Windows.Forms.Button();
            this.lbl_numerodeventa = new System.Windows.Forms.Label();
            this.tableLayoutPanel_Titulo.SuspendLayout();
            this.tableLayoutPanel_contenedorTop.SuspendLayout();
            this.tableLayoutPanel_con2.SuspendLayout();
            this.tableLayoutPanel_con3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_verdatos)).BeginInit();
            this.tableLayoutPanel_con4.SuspendLayout();
            this.tableLayoutPanel_final.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Titulo
            // 
            this.tableLayoutPanel_Titulo.ColumnCount = 1;
            this.tableLayoutPanel_Titulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Titulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_Titulo.Controls.Add(this.lbl_titulo, 0, 0);
            this.tableLayoutPanel_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel_Titulo.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Titulo.Name = "tableLayoutPanel_Titulo";
            this.tableLayoutPanel_Titulo.RowCount = 1;
            this.tableLayoutPanel_Titulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Titulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel_Titulo.Size = new System.Drawing.Size(1263, 62);
            this.tableLayoutPanel_Titulo.TabIndex = 3;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Lithos Pro Regular", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.Black;
            this.lbl_titulo.Location = new System.Drawing.Point(534, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(195, 62);
            this.lbl_titulo.TabIndex = 2;
            this.lbl_titulo.Text = "Venta";
            // 
            // tableLayoutPanel_contenedorTop
            // 
            this.tableLayoutPanel_contenedorTop.ColumnCount = 5;
            this.tableLayoutPanel_contenedorTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.588365F));
            this.tableLayoutPanel_contenedorTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.76158F));
            this.tableLayoutPanel_contenedorTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.24406F));
            this.tableLayoutPanel_contenedorTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.49704F));
            this.tableLayoutPanel_contenedorTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.90895F));
            this.tableLayoutPanel_contenedorTop.Controls.Add(this.btn_ver, 4, 1);
            this.tableLayoutPanel_contenedorTop.Controls.Add(this.lbl_Ucotizacion, 3, 0);
            this.tableLayoutPanel_contenedorTop.Controls.Add(this.lbl_Ultimacotizacion, 4, 0);
            this.tableLayoutPanel_contenedorTop.Controls.Add(this.lbl_cliente, 0, 0);
            this.tableLayoutPanel_contenedorTop.Controls.Add(this.comboBox_cliente, 1, 0);
            this.tableLayoutPanel_contenedorTop.Controls.Add(this.lbl_numerodeventa, 3, 1);
            this.tableLayoutPanel_contenedorTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel_contenedorTop.Location = new System.Drawing.Point(0, 62);
            this.tableLayoutPanel_contenedorTop.Name = "tableLayoutPanel_contenedorTop";
            this.tableLayoutPanel_contenedorTop.RowCount = 3;
            this.tableLayoutPanel_contenedorTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.03226F));
            this.tableLayoutPanel_contenedorTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.54546F));
            this.tableLayoutPanel_contenedorTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.27273F));
            this.tableLayoutPanel_contenedorTop.Size = new System.Drawing.Size(1263, 110);
            this.tableLayoutPanel_contenedorTop.TabIndex = 4;
            // 
            // comboBox_cliente
            // 
            this.comboBox_cliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.comboBox_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_cliente.ForeColor = System.Drawing.Color.White;
            this.comboBox_cliente.FormattingEnabled = true;
            this.comboBox_cliente.Location = new System.Drawing.Point(124, 3);
            this.comboBox_cliente.Name = "comboBox_cliente";
            this.comboBox_cliente.Size = new System.Drawing.Size(256, 28);
            this.comboBox_cliente.TabIndex = 21;
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cliente.ForeColor = System.Drawing.Color.Black;
            this.lbl_cliente.Location = new System.Drawing.Point(37, 7);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(81, 24);
            this.lbl_cliente.TabIndex = 23;
            this.lbl_cliente.Text = "Cliente:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.Black;
            this.lbl_nombre.Location = new System.Drawing.Point(112, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(143, 36);
            this.lbl_nombre.TabIndex = 5;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.Color.White;
            this.txt_nombre.Location = new System.Drawing.Point(261, 3);
            this.txt_nombre.Multiline = true;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(369, 30);
            this.txt_nombre.TabIndex = 13;
            // 
            // lbl_rfc
            // 
            this.lbl_rfc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_rfc.AutoSize = true;
            this.lbl_rfc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_rfc.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rfc.ForeColor = System.Drawing.Color.Black;
            this.lbl_rfc.Location = new System.Drawing.Point(166, 36);
            this.lbl_rfc.Name = "lbl_rfc";
            this.lbl_rfc.Size = new System.Drawing.Size(89, 36);
            this.lbl_rfc.TabIndex = 6;
            this.lbl_rfc.Text = "RFC:";
            // 
            // txt_rfc
            // 
            this.txt_rfc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_rfc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.txt_rfc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rfc.ForeColor = System.Drawing.Color.White;
            this.txt_rfc.Location = new System.Drawing.Point(261, 39);
            this.txt_rfc.Multiline = true;
            this.txt_rfc.Name = "txt_rfc";
            this.txt_rfc.Size = new System.Drawing.Size(369, 30);
            this.txt_rfc.TabIndex = 14;
            // 
            // lbl_razonsocial
            // 
            this.lbl_razonsocial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_razonsocial.AutoSize = true;
            this.lbl_razonsocial.BackColor = System.Drawing.Color.Transparent;
            this.lbl_razonsocial.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_razonsocial.ForeColor = System.Drawing.Color.Black;
            this.lbl_razonsocial.Location = new System.Drawing.Point(4, 72);
            this.lbl_razonsocial.Name = "lbl_razonsocial";
            this.lbl_razonsocial.Size = new System.Drawing.Size(251, 37);
            this.lbl_razonsocial.TabIndex = 7;
            this.lbl_razonsocial.Text = "Razón social:";
            // 
            // txt_razonsocial
            // 
            this.txt_razonsocial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_razonsocial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.txt_razonsocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_razonsocial.ForeColor = System.Drawing.Color.White;
            this.txt_razonsocial.Location = new System.Drawing.Point(261, 76);
            this.txt_razonsocial.Multiline = true;
            this.txt_razonsocial.Name = "txt_razonsocial";
            this.txt_razonsocial.Size = new System.Drawing.Size(369, 30);
            this.txt_razonsocial.TabIndex = 15;
            // 
            // tableLayoutPanel_con2
            // 
            this.tableLayoutPanel_con2.ColumnCount = 4;
            this.tableLayoutPanel_con2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.44374F));
            this.tableLayoutPanel_con2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.71474F));
            this.tableLayoutPanel_con2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.3233F));
            this.tableLayoutPanel_con2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.51823F));
            this.tableLayoutPanel_con2.Controls.Add(this.txt_telefono, 3, 2);
            this.tableLayoutPanel_con2.Controls.Add(this.txt_email, 3, 1);
            this.tableLayoutPanel_con2.Controls.Add(this.txt_direccion, 3, 0);
            this.tableLayoutPanel_con2.Controls.Add(this.lbl_telefono, 2, 2);
            this.tableLayoutPanel_con2.Controls.Add(this.lbl_email, 2, 1);
            this.tableLayoutPanel_con2.Controls.Add(this.lbl_domicilio, 2, 0);
            this.tableLayoutPanel_con2.Controls.Add(this.txt_rfc, 1, 1);
            this.tableLayoutPanel_con2.Controls.Add(this.txt_razonsocial, 1, 2);
            this.tableLayoutPanel_con2.Controls.Add(this.lbl_nombre, 0, 0);
            this.tableLayoutPanel_con2.Controls.Add(this.lbl_razonsocial, 0, 2);
            this.tableLayoutPanel_con2.Controls.Add(this.txt_nombre, 1, 0);
            this.tableLayoutPanel_con2.Controls.Add(this.lbl_rfc, 0, 1);
            this.tableLayoutPanel_con2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel_con2.Location = new System.Drawing.Point(0, 172);
            this.tableLayoutPanel_con2.Name = "tableLayoutPanel_con2";
            this.tableLayoutPanel_con2.RowCount = 4;
            this.tableLayoutPanel_con2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.125F));
            this.tableLayoutPanel_con2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.125F));
            this.tableLayoutPanel_con2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.90625F));
            this.tableLayoutPanel_con2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.84375F));
            this.tableLayoutPanel_con2.Size = new System.Drawing.Size(1263, 128);
            this.tableLayoutPanel_con2.TabIndex = 5;
            // 
            // lbl_Ucotizacion
            // 
            this.lbl_Ucotizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Ucotizacion.AutoSize = true;
            this.lbl_Ucotizacion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Ucotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ucotizacion.ForeColor = System.Drawing.Color.Black;
            this.lbl_Ucotizacion.Location = new System.Drawing.Point(948, 7);
            this.lbl_Ucotizacion.Name = "lbl_Ucotizacion";
            this.lbl_Ucotizacion.Size = new System.Drawing.Size(173, 24);
            this.lbl_Ucotizacion.TabIndex = 22;
            this.lbl_Ucotizacion.Text = "Última cotización:";
            // 
            // lbl_Ultimacotizacion
            // 
            this.lbl_Ultimacotizacion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Ultimacotizacion.AutoSize = true;
            this.lbl_Ultimacotizacion.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ultimacotizacion.ForeColor = System.Drawing.Color.White;
            this.lbl_Ultimacotizacion.Location = new System.Drawing.Point(1183, 9);
            this.lbl_Ultimacotizacion.Name = "lbl_Ultimacotizacion";
            this.lbl_Ultimacotizacion.Size = new System.Drawing.Size(20, 22);
            this.lbl_Ultimacotizacion.TabIndex = 23;
            this.lbl_Ultimacotizacion.Text = "#";
            // 
            // lbl_domicilio
            // 
            this.lbl_domicilio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_domicilio.AutoSize = true;
            this.lbl_domicilio.BackColor = System.Drawing.Color.Transparent;
            this.lbl_domicilio.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_domicilio.ForeColor = System.Drawing.Color.Black;
            this.lbl_domicilio.Location = new System.Drawing.Point(639, 0);
            this.lbl_domicilio.Name = "lbl_domicilio";
            this.lbl_domicilio.Size = new System.Drawing.Size(197, 36);
            this.lbl_domicilio.TabIndex = 6;
            this.lbl_domicilio.Text = "Dirección:";
            // 
            // lbl_email
            // 
            this.lbl_email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_email.AutoSize = true;
            this.lbl_email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_email.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.Black;
            this.lbl_email.Location = new System.Drawing.Point(693, 36);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(143, 36);
            this.lbl_email.TabIndex = 7;
            this.lbl_email.Text = "E-mail:";
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.BackColor = System.Drawing.Color.Transparent;
            this.lbl_telefono.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono.ForeColor = System.Drawing.Color.Black;
            this.lbl_telefono.Location = new System.Drawing.Point(657, 72);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(179, 37);
            this.lbl_telefono.TabIndex = 7;
            this.lbl_telefono.Text = "Teléfono:";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_direccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.txt_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion.ForeColor = System.Drawing.Color.White;
            this.txt_direccion.Location = new System.Drawing.Point(842, 3);
            this.txt_direccion.Multiline = true;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(418, 30);
            this.txt_direccion.TabIndex = 16;
            // 
            // txt_email
            // 
            this.txt_email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.ForeColor = System.Drawing.Color.White;
            this.txt_email.Location = new System.Drawing.Point(842, 39);
            this.txt_email.Multiline = true;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(418, 30);
            this.txt_email.TabIndex = 16;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_telefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.txt_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.ForeColor = System.Drawing.Color.White;
            this.txt_telefono.Location = new System.Drawing.Point(842, 76);
            this.txt_telefono.Multiline = true;
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(418, 30);
            this.txt_telefono.TabIndex = 16;
            // 
            // tableLayoutPanel_con3
            // 
            this.tableLayoutPanel_con3.ColumnCount = 4;
            this.tableLayoutPanel_con3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.44374F));
            this.tableLayoutPanel_con3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.71474F));
            this.tableLayoutPanel_con3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.7498F));
            this.tableLayoutPanel_con3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.13143F));
            this.tableLayoutPanel_con3.Controls.Add(this.btn_agregar, 3, 2);
            this.tableLayoutPanel_con3.Controls.Add(this.comboBox_productos, 1, 0);
            this.tableLayoutPanel_con3.Controls.Add(this.lbl_cantidad, 2, 0);
            this.tableLayoutPanel_con3.Controls.Add(this.lbl_producto, 0, 0);
            this.tableLayoutPanel_con3.Controls.Add(this.txt_cantidad, 3, 0);
            this.tableLayoutPanel_con3.Controls.Add(this.txt_precioU, 3, 1);
            this.tableLayoutPanel_con3.Controls.Add(this.lbl_precioU, 2, 1);
            this.tableLayoutPanel_con3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel_con3.Location = new System.Drawing.Point(0, 300);
            this.tableLayoutPanel_con3.Name = "tableLayoutPanel_con3";
            this.tableLayoutPanel_con3.RowCount = 3;
            this.tableLayoutPanel_con3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_con3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_con3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_con3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_con3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_con3.Size = new System.Drawing.Size(1263, 115);
            this.tableLayoutPanel_con3.TabIndex = 6;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_cantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.txt_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.ForeColor = System.Drawing.Color.White;
            this.txt_cantidad.Location = new System.Drawing.Point(1036, 9);
            this.txt_cantidad.Multiline = true;
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(224, 26);
            this.txt_cantidad.TabIndex = 16;
            // 
            // txt_precioU
            // 
            this.txt_precioU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_precioU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.txt_precioU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precioU.ForeColor = System.Drawing.Color.White;
            this.txt_precioU.Location = new System.Drawing.Point(1036, 47);
            this.txt_precioU.Multiline = true;
            this.txt_precioU.Name = "txt_precioU";
            this.txt_precioU.Size = new System.Drawing.Size(224, 26);
            this.txt_precioU.TabIndex = 14;
            // 
            // lbl_producto
            // 
            this.lbl_producto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_producto.AutoSize = true;
            this.lbl_producto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_producto.ForeColor = System.Drawing.Color.Black;
            this.lbl_producto.Location = new System.Drawing.Point(155, 14);
            this.lbl_producto.Name = "lbl_producto";
            this.lbl_producto.Size = new System.Drawing.Size(100, 24);
            this.lbl_producto.TabIndex = 24;
            this.lbl_producto.Text = "Producto:";
            // 
            // lbl_precioU
            // 
            this.lbl_precioU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_precioU.AutoSize = true;
            this.lbl_precioU.BackColor = System.Drawing.Color.Transparent;
            this.lbl_precioU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precioU.ForeColor = System.Drawing.Color.Black;
            this.lbl_precioU.Location = new System.Drawing.Point(879, 52);
            this.lbl_precioU.Name = "lbl_precioU";
            this.lbl_precioU.Size = new System.Drawing.Size(151, 24);
            this.lbl_precioU.TabIndex = 24;
            this.lbl_precioU.Text = "Precio unitario:";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.ForeColor = System.Drawing.Color.Black;
            this.lbl_cantidad.Location = new System.Drawing.Point(932, 14);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(98, 24);
            this.lbl_cantidad.TabIndex = 24;
            this.lbl_cantidad.Text = "Cantidad:";
            // 
            // comboBox_productos
            // 
            this.comboBox_productos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_productos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.comboBox_productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_productos.ForeColor = System.Drawing.Color.White;
            this.comboBox_productos.FormattingEnabled = true;
            this.comboBox_productos.Location = new System.Drawing.Point(261, 7);
            this.comboBox_productos.Name = "comboBox_productos";
            this.comboBox_productos.Size = new System.Drawing.Size(369, 32);
            this.comboBox_productos.TabIndex = 22;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_agregar.BackgroundImage = global::PdeV_Delsel.Properties.Resources.agregar_super_mini;
            this.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_agregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.btn_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregar.Location = new System.Drawing.Point(1127, 81);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(133, 31);
            this.btn_agregar.TabIndex = 9;
            this.btn_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // btn_ver
            // 
            this.btn_ver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ver.BackgroundImage = global::PdeV_Delsel.Properties.Resources.ver_super_mini;
            this.btn_ver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.btn_ver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.btn_ver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ver.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ver.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_ver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ver.Location = new System.Drawing.Point(1127, 34);
            this.btn_ver.Name = "btn_ver";
            this.btn_ver.Size = new System.Drawing.Size(133, 31);
            this.btn_ver.TabIndex = 8;
            this.btn_ver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ver.UseVisualStyleBackColor = true;
            // 
            // dataGridView_verdatos
            // 
            this.dataGridView_verdatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_verdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_verdatos.Location = new System.Drawing.Point(262, 3);
            this.dataGridView_verdatos.Name = "dataGridView_verdatos";
            this.dataGridView_verdatos.Size = new System.Drawing.Size(762, 211);
            this.dataGridView_verdatos.TabIndex = 7;
            // 
            // tableLayoutPanel_con4
            // 
            this.tableLayoutPanel_con4.ColumnCount = 3;
            this.tableLayoutPanel_con4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.58591F));
            this.tableLayoutPanel_con4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.88678F));
            this.tableLayoutPanel_con4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.60649F));
            this.tableLayoutPanel_con4.Controls.Add(this.dataGridView_verdatos, 1, 0);
            this.tableLayoutPanel_con4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel_con4.Location = new System.Drawing.Point(0, 415);
            this.tableLayoutPanel_con4.Name = "tableLayoutPanel_con4";
            this.tableLayoutPanel_con4.RowCount = 1;
            this.tableLayoutPanel_con4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_con4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_con4.Size = new System.Drawing.Size(1263, 217);
            this.tableLayoutPanel_con4.TabIndex = 8;
            // 
            // tableLayoutPanel_final
            // 
            this.tableLayoutPanel_final.ColumnCount = 5;
            this.tableLayoutPanel_final.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.42755F));
            this.tableLayoutPanel_final.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.28028F));
            this.tableLayoutPanel_final.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.87648F));
            this.tableLayoutPanel_final.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.976247F));
            this.tableLayoutPanel_final.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.36025F));
            this.tableLayoutPanel_final.Controls.Add(this.btn_venta, 0, 2);
            this.tableLayoutPanel_final.Controls.Add(this.lbl_iva, 4, 1);
            this.tableLayoutPanel_final.Controls.Add(this.lbl_subtotal, 3, 0);
            this.tableLayoutPanel_final.Controls.Add(this.txt_subtotal, 4, 0);
            this.tableLayoutPanel_final.Controls.Add(this.checkBox_iva, 3, 1);
            this.tableLayoutPanel_final.Controls.Add(this.lbl_total, 3, 2);
            this.tableLayoutPanel_final.Controls.Add(this.textBox1, 4, 2);
            this.tableLayoutPanel_final.Controls.Add(this.checkBox_efectivo, 2, 0);
            this.tableLayoutPanel_final.Controls.Add(this.checkBox_tarjeta, 2, 1);
            this.tableLayoutPanel_final.Controls.Add(this.lbl_formaPago, 1, 0);
            this.tableLayoutPanel_final.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_final.Location = new System.Drawing.Point(0, 632);
            this.tableLayoutPanel_final.Name = "tableLayoutPanel_final";
            this.tableLayoutPanel_final.RowCount = 3;
            this.tableLayoutPanel_final.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.55906F));
            this.tableLayoutPanel_final.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.19685F));
            this.tableLayoutPanel_final.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.45669F));
            this.tableLayoutPanel_final.Size = new System.Drawing.Size(1263, 127);
            this.tableLayoutPanel_final.TabIndex = 9;
            // 
            // lbl_formaPago
            // 
            this.lbl_formaPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_formaPago.AutoSize = true;
            this.lbl_formaPago.BackColor = System.Drawing.Color.Transparent;
            this.lbl_formaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_formaPago.ForeColor = System.Drawing.Color.Black;
            this.lbl_formaPago.Location = new System.Drawing.Point(630, 11);
            this.lbl_formaPago.Name = "lbl_formaPago";
            this.lbl_formaPago.Size = new System.Drawing.Size(159, 24);
            this.lbl_formaPago.TabIndex = 24;
            this.lbl_formaPago.Text = "Forma de pago:";
            // 
            // checkBox_efectivo
            // 
            this.checkBox_efectivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox_efectivo.AutoSize = true;
            this.checkBox_efectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_efectivo.Location = new System.Drawing.Point(795, 8);
            this.checkBox_efectivo.Name = "checkBox_efectivo";
            this.checkBox_efectivo.Size = new System.Drawing.Size(93, 24);
            this.checkBox_efectivo.TabIndex = 25;
            this.checkBox_efectivo.Text = "Efectivo";
            this.checkBox_efectivo.UseVisualStyleBackColor = true;
            // 
            // checkBox_tarjeta
            // 
            this.checkBox_tarjeta.AutoSize = true;
            this.checkBox_tarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_tarjeta.Location = new System.Drawing.Point(795, 38);
            this.checkBox_tarjeta.Name = "checkBox_tarjeta";
            this.checkBox_tarjeta.Size = new System.Drawing.Size(84, 24);
            this.checkBox_tarjeta.TabIndex = 26;
            this.checkBox_tarjeta.Text = "Tarjeta";
            this.checkBox_tarjeta.UseVisualStyleBackColor = true;
            // 
            // lbl_subtotal
            // 
            this.lbl_subtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_subtotal.AutoSize = true;
            this.lbl_subtotal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtotal.ForeColor = System.Drawing.Color.Black;
            this.lbl_subtotal.Location = new System.Drawing.Point(951, 11);
            this.lbl_subtotal.Name = "lbl_subtotal";
            this.lbl_subtotal.Size = new System.Drawing.Size(114, 24);
            this.lbl_subtotal.TabIndex = 24;
            this.lbl_subtotal.Text = "Sub total: $";
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_subtotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.txt_subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_subtotal.ForeColor = System.Drawing.Color.White;
            this.txt_subtotal.Location = new System.Drawing.Point(1071, 6);
            this.txt_subtotal.Multiline = true;
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.Size = new System.Drawing.Size(189, 26);
            this.txt_subtotal.TabIndex = 14;
            // 
            // checkBox_iva
            // 
            this.checkBox_iva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_iva.AutoSize = true;
            this.checkBox_iva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_iva.Location = new System.Drawing.Point(992, 40);
            this.checkBox_iva.Name = "checkBox_iva";
            this.checkBox_iva.Size = new System.Drawing.Size(73, 24);
            this.checkBox_iva.TabIndex = 26;
            this.checkBox_iva.Text = "I.V.A:";
            this.checkBox_iva.UseVisualStyleBackColor = true;
            // 
            // lbl_iva
            // 
            this.lbl_iva.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_iva.AutoSize = true;
            this.lbl_iva.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_iva.ForeColor = System.Drawing.Color.White;
            this.lbl_iva.Location = new System.Drawing.Point(1155, 45);
            this.lbl_iva.Name = "lbl_iva";
            this.lbl_iva.Size = new System.Drawing.Size(20, 22);
            this.lbl_iva.TabIndex = 23;
            this.lbl_iva.Text = "#";
            // 
            // lbl_total
            // 
            this.lbl_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.Color.Transparent;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.Black;
            this.lbl_total.Location = new System.Drawing.Point(986, 67);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(79, 24);
            this.lbl_total.TabIndex = 24;
            this.lbl_total.Text = "Total: $";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(1071, 70);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 26);
            this.textBox1.TabIndex = 14;
            // 
            // btn_venta
            // 
            this.btn_venta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_venta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_venta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.btn_venta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.btn_venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_venta.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_venta.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_venta.Image = global::PdeV_Delsel.Properties.Resources.new_venta;
            this.btn_venta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_venta.Location = new System.Drawing.Point(3, 73);
            this.btn_venta.Name = "btn_venta";
            this.btn_venta.Size = new System.Drawing.Size(146, 51);
            this.btn_venta.TabIndex = 9;
            this.btn_venta.Text = "Venta";
            this.btn_venta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_venta.UseVisualStyleBackColor = true;
            // 
            // lbl_numerodeventa
            // 
            this.lbl_numerodeventa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_numerodeventa.AutoSize = true;
            this.lbl_numerodeventa.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numerodeventa.ForeColor = System.Drawing.Color.White;
            this.lbl_numerodeventa.Location = new System.Drawing.Point(973, 36);
            this.lbl_numerodeventa.Name = "lbl_numerodeventa";
            this.lbl_numerodeventa.Size = new System.Drawing.Size(30, 32);
            this.lbl_numerodeventa.TabIndex = 23;
            this.lbl_numerodeventa.Text = "#";
            // 
            // Form_venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1263, 759);
            this.Controls.Add(this.tableLayoutPanel_final);
            this.Controls.Add(this.tableLayoutPanel_con4);
            this.Controls.Add(this.tableLayoutPanel_con3);
            this.Controls.Add(this.tableLayoutPanel_con2);
            this.Controls.Add(this.tableLayoutPanel_contenedorTop);
            this.Controls.Add(this.tableLayoutPanel_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_venta";
            this.Opacity = 0.98D;
            this.Text = "Form_venta";
            this.tableLayoutPanel_Titulo.ResumeLayout(false);
            this.tableLayoutPanel_Titulo.PerformLayout();
            this.tableLayoutPanel_contenedorTop.ResumeLayout(false);
            this.tableLayoutPanel_contenedorTop.PerformLayout();
            this.tableLayoutPanel_con2.ResumeLayout(false);
            this.tableLayoutPanel_con2.PerformLayout();
            this.tableLayoutPanel_con3.ResumeLayout(false);
            this.tableLayoutPanel_con3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_verdatos)).EndInit();
            this.tableLayoutPanel_con4.ResumeLayout(false);
            this.tableLayoutPanel_final.ResumeLayout(false);
            this.tableLayoutPanel_final.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Titulo;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_contenedorTop;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.ComboBox comboBox_cliente;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_razonsocial;
        private System.Windows.Forms.Label lbl_razonsocial;
        private System.Windows.Forms.TextBox txt_rfc;
        private System.Windows.Forms.Label lbl_rfc;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_con2;
        private System.Windows.Forms.Button btn_ver;
        private System.Windows.Forms.Label lbl_Ucotizacion;
        private System.Windows.Forms.Label lbl_Ultimacotizacion;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_domicilio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_con3;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Label lbl_precioU;
        private System.Windows.Forms.Label lbl_producto;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.TextBox txt_precioU;
        private System.Windows.Forms.ComboBox comboBox_productos;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DataGridView dataGridView_verdatos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_con4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_final;
        private System.Windows.Forms.Button btn_venta;
        private System.Windows.Forms.Label lbl_iva;
        private System.Windows.Forms.Label lbl_subtotal;
        private System.Windows.Forms.TextBox txt_subtotal;
        private System.Windows.Forms.CheckBox checkBox_iva;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox_efectivo;
        private System.Windows.Forms.CheckBox checkBox_tarjeta;
        private System.Windows.Forms.Label lbl_formaPago;
        private System.Windows.Forms.Label lbl_numerodeventa;
    }
}