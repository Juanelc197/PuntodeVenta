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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel_Titulo = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.tableLayoutPanel_contenedorTop = new System.Windows.Forms.TableLayoutPanel();
            this.btn_ver = new System.Windows.Forms.Button();
            this.lbl_Ucotizacion = new System.Windows.Forms.Label();
            this.lbl_Ultimacotizacion = new System.Windows.Forms.Label();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.comboBox_clienteCot = new System.Windows.Forms.ComboBox();
            this.lbl_numerodeventa = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_rfc = new System.Windows.Forms.Label();
            this.txt_rfc = new System.Windows.Forms.TextBox();
            this.lbl_razonsocial = new System.Windows.Forms.Label();
            this.txt_razonsocial = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel_con2 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_domicilio = new System.Windows.Forms.Label();
            this.tableLayoutPanel_con3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_conCant = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.comboBox_productos = new System.Windows.Forms.ComboBox();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.lbl_producto = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.lbl_precioU = new System.Windows.Forms.Label();
            this.lbl_preciosolo = new System.Windows.Forms.Label();
            this.tableLayoutPanel_con4 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_fechita = new System.Windows.Forms.Label();
            this.dataGridView_verdatos = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel_final = new System.Windows.Forms.TableLayoutPanel();
            this.btn_venta = new System.Windows.Forms.Button();
            this.lbl_iva = new System.Windows.Forms.Label();
            this.lbl_subtotal = new System.Windows.Forms.Label();
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.checkBox_iva = new System.Windows.Forms.CheckBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.lbl_letras = new System.Windows.Forms.Label();
            this.comboBox_FormaPago = new System.Windows.Forms.ComboBox();
            this.lbl_formaPago = new System.Windows.Forms.Label();
            this.dateTimePicker_fecha = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel_Titulo.SuspendLayout();
            this.tableLayoutPanel_contenedorTop.SuspendLayout();
            this.tableLayoutPanel_con2.SuspendLayout();
            this.tableLayoutPanel_con3.SuspendLayout();
            this.tableLayoutPanel_con4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_verdatos)).BeginInit();
            this.tableLayoutPanel_final.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Titulo
            // 
            this.tableLayoutPanel_Titulo.ColumnCount = 1;
            this.tableLayoutPanel_Titulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Titulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel_Titulo.Controls.Add(this.lbl_titulo, 0, 0);
            this.tableLayoutPanel_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel_Titulo.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Titulo.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel_Titulo.Name = "tableLayoutPanel_Titulo";
            this.tableLayoutPanel_Titulo.RowCount = 1;
            this.tableLayoutPanel_Titulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Titulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel_Titulo.Size = new System.Drawing.Size(1684, 76);
            this.tableLayoutPanel_Titulo.TabIndex = 3;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.Black;
            this.lbl_titulo.Location = new System.Drawing.Point(746, 0);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(191, 76);
            this.lbl_titulo.TabIndex = 2;
            this.lbl_titulo.Text = "Venta";
            // 
            // tableLayoutPanel_contenedorTop
            // 
            this.tableLayoutPanel_contenedorTop.ColumnCount = 5;
            this.tableLayoutPanel_contenedorTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.40855F));
            this.tableLayoutPanel_contenedorTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.75297F));
            this.tableLayoutPanel_contenedorTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.35629F));
            this.tableLayoutPanel_contenedorTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.49704F));
            this.tableLayoutPanel_contenedorTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.90895F));
            this.tableLayoutPanel_contenedorTop.Controls.Add(this.btn_ver, 4, 1);
            this.tableLayoutPanel_contenedorTop.Controls.Add(this.lbl_Ucotizacion, 3, 0);
            this.tableLayoutPanel_contenedorTop.Controls.Add(this.lbl_Ultimacotizacion, 4, 0);
            this.tableLayoutPanel_contenedorTop.Controls.Add(this.lbl_cliente, 0, 0);
            this.tableLayoutPanel_contenedorTop.Controls.Add(this.comboBox_clienteCot, 1, 0);
            this.tableLayoutPanel_contenedorTop.Controls.Add(this.lbl_numerodeventa, 3, 1);
            this.tableLayoutPanel_contenedorTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel_contenedorTop.Location = new System.Drawing.Point(0, 76);
            this.tableLayoutPanel_contenedorTop.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel_contenedorTop.Name = "tableLayoutPanel_contenedorTop";
            this.tableLayoutPanel_contenedorTop.RowCount = 3;
            this.tableLayoutPanel_contenedorTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.03226F));
            this.tableLayoutPanel_contenedorTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.54546F));
            this.tableLayoutPanel_contenedorTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.27273F));
            this.tableLayoutPanel_contenedorTop.Size = new System.Drawing.Size(1684, 135);
            this.tableLayoutPanel_contenedorTop.TabIndex = 4;
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
            this.btn_ver.Location = new System.Drawing.Point(1503, 42);
            this.btn_ver.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ver.Name = "btn_ver";
            this.btn_ver.Size = new System.Drawing.Size(177, 38);
            this.btn_ver.TabIndex = 8;
            this.btn_ver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ver.UseVisualStyleBackColor = true;
            this.btn_ver.Visible = false;
            // 
            // lbl_Ucotizacion
            // 
            this.lbl_Ucotizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Ucotizacion.AutoSize = true;
            this.lbl_Ucotizacion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Ucotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ucotizacion.ForeColor = System.Drawing.Color.Black;
            this.lbl_Ucotizacion.Location = new System.Drawing.Point(1277, 9);
            this.lbl_Ucotizacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Ucotizacion.Name = "lbl_Ucotizacion";
            this.lbl_Ucotizacion.Size = new System.Drawing.Size(218, 29);
            this.lbl_Ucotizacion.TabIndex = 22;
            this.lbl_Ucotizacion.Text = "Última cotización:";
            this.lbl_Ucotizacion.Visible = false;
            // 
            // lbl_Ultimacotizacion
            // 
            this.lbl_Ultimacotizacion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Ultimacotizacion.AutoSize = true;
            this.lbl_Ultimacotizacion.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ultimacotizacion.ForeColor = System.Drawing.Color.White;
            this.lbl_Ultimacotizacion.Location = new System.Drawing.Point(1579, 10);
            this.lbl_Ultimacotizacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Ultimacotizacion.Name = "lbl_Ultimacotizacion";
            this.lbl_Ultimacotizacion.Size = new System.Drawing.Size(25, 28);
            this.lbl_Ultimacotizacion.TabIndex = 23;
            this.lbl_Ultimacotizacion.Text = "#";
            this.lbl_Ultimacotizacion.Visible = false;
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cliente.ForeColor = System.Drawing.Color.Black;
            this.lbl_cliente.Location = new System.Drawing.Point(42, 9);
            this.lbl_cliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(264, 29);
            this.lbl_cliente.TabIndex = 23;
            this.lbl_cliente.Text = "Cotizacion de cliente:";
            // 
            // comboBox_clienteCot
            // 
            this.comboBox_clienteCot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_clienteCot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.comboBox_clienteCot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_clienteCot.ForeColor = System.Drawing.Color.White;
            this.comboBox_clienteCot.FormattingEnabled = true;
            this.comboBox_clienteCot.Location = new System.Drawing.Point(314, 4);
            this.comboBox_clienteCot.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_clienteCot.Name = "comboBox_clienteCot";
            this.comboBox_clienteCot.Size = new System.Drawing.Size(392, 33);
            this.comboBox_clienteCot.TabIndex = 21;
            this.comboBox_clienteCot.SelectedIndexChanged += new System.EventHandler(this.comboBox_clienteCot_SelectedIndexChanged);
            // 
            // lbl_numerodeventa
            // 
            this.lbl_numerodeventa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_numerodeventa.AutoSize = true;
            this.lbl_numerodeventa.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numerodeventa.ForeColor = System.Drawing.Color.White;
            this.lbl_numerodeventa.Location = new System.Drawing.Point(1300, 44);
            this.lbl_numerodeventa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_numerodeventa.Name = "lbl_numerodeventa";
            this.lbl_numerodeventa.Size = new System.Drawing.Size(36, 40);
            this.lbl_numerodeventa.TabIndex = 23;
            this.lbl_numerodeventa.Text = "#";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.Black;
            this.lbl_nombre.Location = new System.Drawing.Point(166, 0);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(174, 44);
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
            this.txt_nombre.Location = new System.Drawing.Point(348, 4);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre.Multiline = true;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(492, 36);
            this.txt_nombre.TabIndex = 13;
            // 
            // lbl_rfc
            // 
            this.lbl_rfc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_rfc.AutoSize = true;
            this.lbl_rfc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_rfc.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rfc.ForeColor = System.Drawing.Color.Black;
            this.lbl_rfc.Location = new System.Drawing.Point(232, 44);
            this.lbl_rfc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_rfc.Name = "lbl_rfc";
            this.lbl_rfc.Size = new System.Drawing.Size(108, 44);
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
            this.txt_rfc.Location = new System.Drawing.Point(348, 48);
            this.txt_rfc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_rfc.Multiline = true;
            this.txt_rfc.Name = "txt_rfc";
            this.txt_rfc.Size = new System.Drawing.Size(492, 36);
            this.txt_rfc.TabIndex = 14;
            // 
            // lbl_razonsocial
            // 
            this.lbl_razonsocial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_razonsocial.AutoSize = true;
            this.lbl_razonsocial.BackColor = System.Drawing.Color.Transparent;
            this.lbl_razonsocial.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_razonsocial.ForeColor = System.Drawing.Color.Black;
            this.lbl_razonsocial.Location = new System.Drawing.Point(34, 88);
            this.lbl_razonsocial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_razonsocial.Name = "lbl_razonsocial";
            this.lbl_razonsocial.Size = new System.Drawing.Size(306, 45);
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
            this.txt_razonsocial.Location = new System.Drawing.Point(348, 93);
            this.txt_razonsocial.Margin = new System.Windows.Forms.Padding(4);
            this.txt_razonsocial.Multiline = true;
            this.txt_razonsocial.Name = "txt_razonsocial";
            this.txt_razonsocial.Size = new System.Drawing.Size(492, 36);
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
            this.tableLayoutPanel_con2.Location = new System.Drawing.Point(0, 211);
            this.tableLayoutPanel_con2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel_con2.Name = "tableLayoutPanel_con2";
            this.tableLayoutPanel_con2.RowCount = 4;
            this.tableLayoutPanel_con2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.125F));
            this.tableLayoutPanel_con2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.125F));
            this.tableLayoutPanel_con2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.90625F));
            this.tableLayoutPanel_con2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.84375F));
            this.tableLayoutPanel_con2.Size = new System.Drawing.Size(1684, 158);
            this.tableLayoutPanel_con2.TabIndex = 5;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_telefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.txt_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.ForeColor = System.Drawing.Color.White;
            this.txt_telefono.Location = new System.Drawing.Point(1122, 93);
            this.txt_telefono.Margin = new System.Windows.Forms.Padding(4);
            this.txt_telefono.Multiline = true;
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(558, 36);
            this.txt_telefono.TabIndex = 16;
            // 
            // txt_email
            // 
            this.txt_email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.ForeColor = System.Drawing.Color.White;
            this.txt_email.Location = new System.Drawing.Point(1122, 48);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_email.Multiline = true;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(558, 36);
            this.txt_email.TabIndex = 16;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_direccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.txt_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion.ForeColor = System.Drawing.Color.White;
            this.txt_direccion.Location = new System.Drawing.Point(1122, 4);
            this.txt_direccion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_direccion.Multiline = true;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(558, 36);
            this.txt_direccion.TabIndex = 16;
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.BackColor = System.Drawing.Color.Transparent;
            this.lbl_telefono.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono.ForeColor = System.Drawing.Color.Black;
            this.lbl_telefono.Location = new System.Drawing.Point(896, 88);
            this.lbl_telefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(218, 45);
            this.lbl_telefono.TabIndex = 7;
            this.lbl_telefono.Text = "Teléfono:";
            // 
            // lbl_email
            // 
            this.lbl_email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_email.AutoSize = true;
            this.lbl_email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_email.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.Black;
            this.lbl_email.Location = new System.Drawing.Point(940, 44);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(174, 44);
            this.lbl_email.TabIndex = 7;
            this.lbl_email.Text = "E-mail:";
            // 
            // lbl_domicilio
            // 
            this.lbl_domicilio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_domicilio.AutoSize = true;
            this.lbl_domicilio.BackColor = System.Drawing.Color.Transparent;
            this.lbl_domicilio.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_domicilio.ForeColor = System.Drawing.Color.Black;
            this.lbl_domicilio.Location = new System.Drawing.Point(874, 0);
            this.lbl_domicilio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_domicilio.Name = "lbl_domicilio";
            this.lbl_domicilio.Size = new System.Drawing.Size(240, 44);
            this.lbl_domicilio.TabIndex = 6;
            this.lbl_domicilio.Text = "Dirección:";
            // 
            // tableLayoutPanel_con3
            // 
            this.tableLayoutPanel_con3.ColumnCount = 4;
            this.tableLayoutPanel_con3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.44374F));
            this.tableLayoutPanel_con3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.71474F));
            this.tableLayoutPanel_con3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.7498F));
            this.tableLayoutPanel_con3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.13143F));
            this.tableLayoutPanel_con3.Controls.Add(this.lbl_conCant, 0, 2);
            this.tableLayoutPanel_con3.Controls.Add(this.btn_agregar, 3, 2);
            this.tableLayoutPanel_con3.Controls.Add(this.comboBox_productos, 1, 0);
            this.tableLayoutPanel_con3.Controls.Add(this.lbl_cantidad, 2, 0);
            this.tableLayoutPanel_con3.Controls.Add(this.lbl_producto, 0, 0);
            this.tableLayoutPanel_con3.Controls.Add(this.txt_cantidad, 3, 0);
            this.tableLayoutPanel_con3.Controls.Add(this.lbl_precioU, 2, 1);
            this.tableLayoutPanel_con3.Controls.Add(this.lbl_preciosolo, 3, 1);
            this.tableLayoutPanel_con3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel_con3.Location = new System.Drawing.Point(0, 369);
            this.tableLayoutPanel_con3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel_con3.Name = "tableLayoutPanel_con3";
            this.tableLayoutPanel_con3.RowCount = 3;
            this.tableLayoutPanel_con3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_con3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_con3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_con3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel_con3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel_con3.Size = new System.Drawing.Size(1684, 142);
            this.tableLayoutPanel_con3.TabIndex = 6;
            // 
            // lbl_conCant
            // 
            this.lbl_conCant.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_conCant.AutoSize = true;
            this.lbl_conCant.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_conCant.ForeColor = System.Drawing.Color.White;
            this.lbl_conCant.Location = new System.Drawing.Point(116, 102);
            this.lbl_conCant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_conCant.Name = "lbl_conCant";
            this.lbl_conCant.Size = new System.Drawing.Size(112, 40);
            this.lbl_conCant.TabIndex = 27;
            this.lbl_conCant.Text = "Stock";
            this.lbl_conCant.Visible = false;
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
            this.btn_agregar.Location = new System.Drawing.Point(1503, 100);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(177, 38);
            this.btn_agregar.TabIndex = 9;
            this.btn_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // comboBox_productos
            // 
            this.comboBox_productos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_productos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.comboBox_productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_productos.ForeColor = System.Drawing.Color.White;
            this.comboBox_productos.FormattingEnabled = true;
            this.comboBox_productos.Location = new System.Drawing.Point(348, 6);
            this.comboBox_productos.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_productos.Name = "comboBox_productos";
            this.comboBox_productos.Size = new System.Drawing.Size(492, 37);
            this.comboBox_productos.TabIndex = 22;
            this.comboBox_productos.SelectedIndexChanged += new System.EventHandler(this.comboBox_productos_SelectedIndexChanged);
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.ForeColor = System.Drawing.Color.Black;
            this.lbl_cantidad.Location = new System.Drawing.Point(1250, 18);
            this.lbl_cantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(124, 29);
            this.lbl_cantidad.TabIndex = 24;
            this.lbl_cantidad.Text = "Cantidad:";
            // 
            // lbl_producto
            // 
            this.lbl_producto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_producto.AutoSize = true;
            this.lbl_producto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_producto.ForeColor = System.Drawing.Color.Black;
            this.lbl_producto.Location = new System.Drawing.Point(215, 18);
            this.lbl_producto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_producto.Name = "lbl_producto";
            this.lbl_producto.Size = new System.Drawing.Size(125, 29);
            this.lbl_producto.TabIndex = 24;
            this.lbl_producto.Text = "Producto:";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_cantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.txt_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.ForeColor = System.Drawing.Color.White;
            this.txt_cantidad.Location = new System.Drawing.Point(1382, 12);
            this.txt_cantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cantidad.Multiline = true;
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(298, 31);
            this.txt_cantidad.TabIndex = 16;
            // 
            // lbl_precioU
            // 
            this.lbl_precioU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_precioU.AutoSize = true;
            this.lbl_precioU.BackColor = System.Drawing.Color.Transparent;
            this.lbl_precioU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precioU.ForeColor = System.Drawing.Color.Black;
            this.lbl_precioU.Location = new System.Drawing.Point(1184, 65);
            this.lbl_precioU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_precioU.Name = "lbl_precioU";
            this.lbl_precioU.Size = new System.Drawing.Size(190, 29);
            this.lbl_precioU.TabIndex = 24;
            this.lbl_precioU.Text = "Precio unitario:";
            // 
            // lbl_preciosolo
            // 
            this.lbl_preciosolo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_preciosolo.AutoSize = true;
            this.lbl_preciosolo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_preciosolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_preciosolo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_preciosolo.Location = new System.Drawing.Point(1517, 65);
            this.lbl_preciosolo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_preciosolo.Name = "lbl_preciosolo";
            this.lbl_preciosolo.Size = new System.Drawing.Size(27, 29);
            this.lbl_preciosolo.TabIndex = 28;
            this.lbl_preciosolo.Text = "#";
            // 
            // tableLayoutPanel_con4
            // 
            this.tableLayoutPanel_con4.ColumnCount = 3;
            this.tableLayoutPanel_con4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.58591F));
            this.tableLayoutPanel_con4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.88678F));
            this.tableLayoutPanel_con4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.60649F));
            this.tableLayoutPanel_con4.Controls.Add(this.lbl_fechita, 0, 0);
            this.tableLayoutPanel_con4.Controls.Add(this.dataGridView_verdatos, 1, 0);
            this.tableLayoutPanel_con4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel_con4.Location = new System.Drawing.Point(0, 511);
            this.tableLayoutPanel_con4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel_con4.Name = "tableLayoutPanel_con4";
            this.tableLayoutPanel_con4.RowCount = 1;
            this.tableLayoutPanel_con4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_con4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.tableLayoutPanel_con4.Size = new System.Drawing.Size(1684, 267);
            this.tableLayoutPanel_con4.TabIndex = 8;
            // 
            // lbl_fechita
            // 
            this.lbl_fechita.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_fechita.AutoSize = true;
            this.lbl_fechita.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechita.ForeColor = System.Drawing.Color.White;
            this.lbl_fechita.Location = new System.Drawing.Point(136, 227);
            this.lbl_fechita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fechita.Name = "lbl_fechita";
            this.lbl_fechita.Size = new System.Drawing.Size(74, 40);
            this.lbl_fechita.TabIndex = 27;
            this.lbl_fechita.Text = "...";
            this.lbl_fechita.Visible = false;
            // 
            // dataGridView_verdatos
            // 
            this.dataGridView_verdatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_verdatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_verdatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_verdatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.dataGridView_verdatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_verdatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_verdatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_verdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_verdatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Cantidad,
            this.Precio,
            this.CostoT});
            this.dataGridView_verdatos.EnableHeadersVisualStyles = false;
            this.dataGridView_verdatos.GridColor = System.Drawing.Color.LimeGreen;
            this.dataGridView_verdatos.Location = new System.Drawing.Point(350, 4);
            this.dataGridView_verdatos.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_verdatos.Name = "dataGridView_verdatos";
            this.dataGridView_verdatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_verdatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_verdatos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_verdatos.Size = new System.Drawing.Size(1016, 259);
            this.dataGridView_verdatos.TabIndex = 8;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.Width = 162;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 162;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.Width = 132;
            // 
            // CostoT
            // 
            this.CostoT.HeaderText = "Costo Total";
            this.CostoT.Name = "CostoT";
            this.CostoT.Width = 207;
            // 
            // tableLayoutPanel_final
            // 
            this.tableLayoutPanel_final.ColumnCount = 5;
            this.tableLayoutPanel_final.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.42755F));
            this.tableLayoutPanel_final.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.30166F));
            this.tableLayoutPanel_final.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.85511F));
            this.tableLayoutPanel_final.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.976247F));
            this.tableLayoutPanel_final.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.36025F));
            this.tableLayoutPanel_final.Controls.Add(this.btn_venta, 0, 2);
            this.tableLayoutPanel_final.Controls.Add(this.lbl_iva, 4, 1);
            this.tableLayoutPanel_final.Controls.Add(this.lbl_subtotal, 3, 0);
            this.tableLayoutPanel_final.Controls.Add(this.txt_subtotal, 4, 0);
            this.tableLayoutPanel_final.Controls.Add(this.checkBox_iva, 3, 1);
            this.tableLayoutPanel_final.Controls.Add(this.lbl_total, 3, 2);
            this.tableLayoutPanel_final.Controls.Add(this.txt_total, 4, 2);
            this.tableLayoutPanel_final.Controls.Add(this.lbl_letras, 1, 2);
            this.tableLayoutPanel_final.Controls.Add(this.comboBox_FormaPago, 2, 1);
            this.tableLayoutPanel_final.Controls.Add(this.lbl_formaPago, 2, 0);
            this.tableLayoutPanel_final.Controls.Add(this.dateTimePicker_fecha, 1, 0);
            this.tableLayoutPanel_final.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_final.Location = new System.Drawing.Point(0, 778);
            this.tableLayoutPanel_final.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel_final.Name = "tableLayoutPanel_final";
            this.tableLayoutPanel_final.RowCount = 3;
            this.tableLayoutPanel_final.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.55906F));
            this.tableLayoutPanel_final.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.19685F));
            this.tableLayoutPanel_final.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.45669F));
            this.tableLayoutPanel_final.Size = new System.Drawing.Size(1684, 156);
            this.tableLayoutPanel_final.TabIndex = 9;
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
            this.btn_venta.Location = new System.Drawing.Point(4, 89);
            this.btn_venta.Margin = new System.Windows.Forms.Padding(4);
            this.btn_venta.Name = "btn_venta";
            this.btn_venta.Size = new System.Drawing.Size(195, 63);
            this.btn_venta.TabIndex = 9;
            this.btn_venta.Text = "Venta";
            this.btn_venta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_venta.UseVisualStyleBackColor = true;
            this.btn_venta.Click += new System.EventHandler(this.btn_venta_Click);
            // 
            // lbl_iva
            // 
            this.lbl_iva.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_iva.AutoSize = true;
            this.lbl_iva.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_iva.ForeColor = System.Drawing.Color.White;
            this.lbl_iva.Location = new System.Drawing.Point(1541, 54);
            this.lbl_iva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_iva.Name = "lbl_iva";
            this.lbl_iva.Size = new System.Drawing.Size(25, 28);
            this.lbl_iva.TabIndex = 23;
            this.lbl_iva.Text = "#";
            // 
            // lbl_subtotal
            // 
            this.lbl_subtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_subtotal.AutoSize = true;
            this.lbl_subtotal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtotal.ForeColor = System.Drawing.Color.Black;
            this.lbl_subtotal.Location = new System.Drawing.Point(1276, 14);
            this.lbl_subtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_subtotal.Name = "lbl_subtotal";
            this.lbl_subtotal.Size = new System.Drawing.Size(144, 29);
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
            this.txt_subtotal.Location = new System.Drawing.Point(1428, 8);
            this.txt_subtotal.Margin = new System.Windows.Forms.Padding(4);
            this.txt_subtotal.Multiline = true;
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.Size = new System.Drawing.Size(252, 31);
            this.txt_subtotal.TabIndex = 14;
            // 
            // checkBox_iva
            // 
            this.checkBox_iva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_iva.AutoSize = true;
            this.checkBox_iva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_iva.Location = new System.Drawing.Point(1331, 49);
            this.checkBox_iva.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_iva.Name = "checkBox_iva";
            this.checkBox_iva.Size = new System.Drawing.Size(89, 29);
            this.checkBox_iva.TabIndex = 26;
            this.checkBox_iva.Text = "I.V.A:";
            this.checkBox_iva.UseVisualStyleBackColor = true;
            this.checkBox_iva.CheckedChanged += new System.EventHandler(this.checkBox_iva_CheckedChanged);
            // 
            // lbl_total
            // 
            this.lbl_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.Color.Transparent;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.Black;
            this.lbl_total.Location = new System.Drawing.Point(1319, 82);
            this.lbl_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(101, 29);
            this.lbl_total.TabIndex = 24;
            this.lbl_total.Text = "Total: $";
            // 
            // txt_total
            // 
            this.txt_total.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.txt_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.ForeColor = System.Drawing.Color.White;
            this.txt_total.Location = new System.Drawing.Point(1428, 86);
            this.txt_total.Margin = new System.Windows.Forms.Padding(4);
            this.txt_total.Multiline = true;
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(252, 31);
            this.txt_total.TabIndex = 14;
            this.txt_total.TextChanged += new System.EventHandler(this.txt_total_TextChanged);
            // 
            // lbl_letras
            // 
            this.lbl_letras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_letras.AutoSize = true;
            this.lbl_letras.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_letras.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_letras.Location = new System.Drawing.Point(347, 133);
            this.lbl_letras.Name = "lbl_letras";
            this.lbl_letras.Size = new System.Drawing.Size(43, 23);
            this.lbl_letras.TabIndex = 28;
            this.lbl_letras.Text = "...";
            // 
            // comboBox_FormaPago
            // 
            this.comboBox_FormaPago.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_FormaPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.comboBox_FormaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_FormaPago.ForeColor = System.Drawing.Color.White;
            this.comboBox_FormaPago.FormattingEnabled = true;
            this.comboBox_FormaPago.Location = new System.Drawing.Point(993, 47);
            this.comboBox_FormaPago.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_FormaPago.Name = "comboBox_FormaPago";
            this.comboBox_FormaPago.Size = new System.Drawing.Size(259, 37);
            this.comboBox_FormaPago.TabIndex = 27;
            // 
            // lbl_formaPago
            // 
            this.lbl_formaPago.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_formaPago.AutoSize = true;
            this.lbl_formaPago.BackColor = System.Drawing.Color.Transparent;
            this.lbl_formaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_formaPago.ForeColor = System.Drawing.Color.Black;
            this.lbl_formaPago.Location = new System.Drawing.Point(1027, 14);
            this.lbl_formaPago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_formaPago.Name = "lbl_formaPago";
            this.lbl_formaPago.Size = new System.Drawing.Size(191, 29);
            this.lbl_formaPago.TabIndex = 24;
            this.lbl_formaPago.Text = "Forma de pago";
            // 
            // dateTimePicker_fecha
            // 
            this.dateTimePicker_fecha.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dateTimePicker_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_fecha.Location = new System.Drawing.Point(576, 6);
            this.dateTimePicker_fecha.Name = "dateTimePicker_fecha";
            this.dateTimePicker_fecha.Size = new System.Drawing.Size(181, 34);
            this.dateTimePicker_fecha.TabIndex = 29;
            // 
            // Form_venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1684, 934);
            this.Controls.Add(this.tableLayoutPanel_final);
            this.Controls.Add(this.tableLayoutPanel_con4);
            this.Controls.Add(this.tableLayoutPanel_con3);
            this.Controls.Add(this.tableLayoutPanel_con2);
            this.Controls.Add(this.tableLayoutPanel_contenedorTop);
            this.Controls.Add(this.tableLayoutPanel_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_venta";
            this.Opacity = 0.98D;
            this.Text = "Form_venta";
            this.Load += new System.EventHandler(this.Form_venta_Load);
            this.tableLayoutPanel_Titulo.ResumeLayout(false);
            this.tableLayoutPanel_Titulo.PerformLayout();
            this.tableLayoutPanel_contenedorTop.ResumeLayout(false);
            this.tableLayoutPanel_contenedorTop.PerformLayout();
            this.tableLayoutPanel_con2.ResumeLayout(false);
            this.tableLayoutPanel_con2.PerformLayout();
            this.tableLayoutPanel_con3.ResumeLayout(false);
            this.tableLayoutPanel_con3.PerformLayout();
            this.tableLayoutPanel_con4.ResumeLayout(false);
            this.tableLayoutPanel_con4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_verdatos)).EndInit();
            this.tableLayoutPanel_final.ResumeLayout(false);
            this.tableLayoutPanel_final.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Titulo;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_contenedorTop;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.ComboBox comboBox_clienteCot;
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
        private System.Windows.Forms.ComboBox comboBox_productos;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_con4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_final;
        private System.Windows.Forms.Button btn_venta;
        private System.Windows.Forms.Label lbl_iva;
        private System.Windows.Forms.Label lbl_subtotal;
        private System.Windows.Forms.TextBox txt_subtotal;
        private System.Windows.Forms.CheckBox checkBox_iva;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label lbl_formaPago;
        private System.Windows.Forms.Label lbl_numerodeventa;
        private System.Windows.Forms.Label lbl_conCant;
        private System.Windows.Forms.Label lbl_preciosolo;
        private System.Windows.Forms.DataGridView dataGridView_verdatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoT;
        private System.Windows.Forms.ComboBox comboBox_FormaPago;
        private System.Windows.Forms.Label lbl_letras;
        private System.Windows.Forms.Label lbl_fechita;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fecha;
    }
}