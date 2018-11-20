namespace PdeV_Delsel
{
    partial class Form_Cotizacion
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
            this.panel_barraT = new System.Windows.Forms.Panel();
            this.lbl_cotizacion = new System.Windows.Forms.Label();
            this.btn_restaurar = new System.Windows.Forms.Button();
            this.btn_minimisar = new System.Windows.Forms.Button();
            this.btn_maximisar = new System.Windows.Forms.Button();
            this.tableLayoutPanel_final = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_iva = new System.Windows.Forms.Label();
            this.lbl_subtotal = new System.Windows.Forms.Label();
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.checkBox_iva = new System.Windows.Forms.CheckBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.btn_cotizar = new System.Windows.Forms.Button();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.tableLayoutPanel_con4 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView_verdatos = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel_con3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_idP = new System.Windows.Forms.Label();
            this.lbl_conCant = new System.Windows.Forms.Label();
            this.lbl_precioP = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.comboBox_productos = new System.Windows.Forms.ComboBox();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.lbl_preciosolo = new System.Windows.Forms.Label();
            this.lbl_producto = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.lbl_precioU = new System.Windows.Forms.Label();
            this.tableLayoutPanel_con2 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_domicilio = new System.Windows.Forms.Label();
            this.txt_rfc = new System.Windows.Forms.TextBox();
            this.txt_razonsocial = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_razonsocial = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_rfc = new System.Windows.Forms.Label();
            this.tableLayoutPanel_contenedorTop = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.comboBox_cliente = new System.Windows.Forms.ComboBox();
            this.lbl_numerodeventa = new System.Windows.Forms.Label();
            this.panel_barraT.SuspendLayout();
            this.tableLayoutPanel_final.SuspendLayout();
            this.tableLayoutPanel_con4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_verdatos)).BeginInit();
            this.tableLayoutPanel_con3.SuspendLayout();
            this.tableLayoutPanel_con2.SuspendLayout();
            this.tableLayoutPanel_contenedorTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_barraT
            // 
            this.panel_barraT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.panel_barraT.Controls.Add(this.lbl_cotizacion);
            this.panel_barraT.Controls.Add(this.btn_restaurar);
            this.panel_barraT.Controls.Add(this.btn_minimisar);
            this.panel_barraT.Controls.Add(this.btn_maximisar);
            this.panel_barraT.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_barraT.Location = new System.Drawing.Point(0, 0);
            this.panel_barraT.Name = "panel_barraT";
            this.panel_barraT.Size = new System.Drawing.Size(1263, 38);
            this.panel_barraT.TabIndex = 1;
            this.panel_barraT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_barraT_MouseDown);
            // 
            // lbl_cotizacion
            // 
            this.lbl_cotizacion.AutoSize = true;
            this.lbl_cotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cotizacion.Location = new System.Drawing.Point(12, 9);
            this.lbl_cotizacion.Name = "lbl_cotizacion";
            this.lbl_cotizacion.Size = new System.Drawing.Size(113, 24);
            this.lbl_cotizacion.TabIndex = 9;
            this.lbl_cotizacion.Text = "Cotización ";
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
            this.btn_restaurar.Location = new System.Drawing.Point(1226, 7);
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
            this.btn_minimisar.Location = new System.Drawing.Point(1195, 7);
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
            this.btn_maximisar.Location = new System.Drawing.Point(1226, 7);
            this.btn_maximisar.Name = "btn_maximisar";
            this.btn_maximisar.Size = new System.Drawing.Size(25, 25);
            this.btn_maximisar.TabIndex = 2;
            this.btn_maximisar.UseVisualStyleBackColor = true;
            this.btn_maximisar.Click += new System.EventHandler(this.btn_maximisar_Click);
            // 
            // tableLayoutPanel_final
            // 
            this.tableLayoutPanel_final.ColumnCount = 5;
            this.tableLayoutPanel_final.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.42755F));
            this.tableLayoutPanel_final.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.28028F));
            this.tableLayoutPanel_final.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.87648F));
            this.tableLayoutPanel_final.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.976247F));
            this.tableLayoutPanel_final.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.36025F));
            this.tableLayoutPanel_final.Controls.Add(this.lbl_iva, 4, 1);
            this.tableLayoutPanel_final.Controls.Add(this.lbl_subtotal, 3, 0);
            this.tableLayoutPanel_final.Controls.Add(this.txt_subtotal, 4, 0);
            this.tableLayoutPanel_final.Controls.Add(this.checkBox_iva, 3, 1);
            this.tableLayoutPanel_final.Controls.Add(this.lbl_total, 3, 2);
            this.tableLayoutPanel_final.Controls.Add(this.txt_total, 4, 2);
            this.tableLayoutPanel_final.Controls.Add(this.btn_cotizar, 1, 2);
            this.tableLayoutPanel_final.Controls.Add(this.btn_inicio, 0, 2);
            this.tableLayoutPanel_final.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_final.Location = new System.Drawing.Point(0, 608);
            this.tableLayoutPanel_final.Name = "tableLayoutPanel_final";
            this.tableLayoutPanel_final.RowCount = 3;
            this.tableLayoutPanel_final.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.55906F));
            this.tableLayoutPanel_final.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.19685F));
            this.tableLayoutPanel_final.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.45669F));
            this.tableLayoutPanel_final.Size = new System.Drawing.Size(1263, 151);
            this.tableLayoutPanel_final.TabIndex = 14;
            // 
            // lbl_iva
            // 
            this.lbl_iva.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_iva.AutoSize = true;
            this.lbl_iva.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_iva.ForeColor = System.Drawing.Color.White;
            this.lbl_iva.Location = new System.Drawing.Point(1155, 57);
            this.lbl_iva.Name = "lbl_iva";
            this.lbl_iva.Size = new System.Drawing.Size(20, 22);
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
            this.lbl_subtotal.Location = new System.Drawing.Point(951, 17);
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
            this.txt_subtotal.Location = new System.Drawing.Point(1071, 12);
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
            this.checkBox_iva.Location = new System.Drawing.Point(992, 52);
            this.checkBox_iva.Name = "checkBox_iva";
            this.checkBox_iva.Size = new System.Drawing.Size(73, 24);
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
            this.lbl_total.Location = new System.Drawing.Point(986, 79);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(79, 24);
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
            this.txt_total.Location = new System.Drawing.Point(1071, 82);
            this.txt_total.Multiline = true;
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(189, 26);
            this.txt_total.TabIndex = 14;
            // 
            // btn_cotizar
            // 
            this.btn_cotizar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_cotizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cotizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.btn_cotizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.btn_cotizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cotizar.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cotizar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_cotizar.Image = global::PdeV_Delsel.Properties.Resources.consultar_super_mini2;
            this.btn_cotizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cotizar.Location = new System.Drawing.Point(429, 97);
            this.btn_cotizar.Name = "btn_cotizar";
            this.btn_cotizar.Size = new System.Drawing.Size(192, 51);
            this.btn_cotizar.TabIndex = 9;
            this.btn_cotizar.Text = "Cotizar";
            this.btn_cotizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cotizar.UseVisualStyleBackColor = true;
            // 
            // btn_inicio
            // 
            this.btn_inicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_inicio.BackgroundImage = global::PdeV_Delsel.Properties.Resources.inicio_super_mini;
            this.btn_inicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_inicio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.btn_inicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.btn_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inicio.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inicio.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_inicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inicio.Location = new System.Drawing.Point(3, 97);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(85, 51);
            this.btn_inicio.TabIndex = 9;
            this.btn_inicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_inicio.UseVisualStyleBackColor = true;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // tableLayoutPanel_con4
            // 
            this.tableLayoutPanel_con4.ColumnCount = 3;
            this.tableLayoutPanel_con4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.58591F));
            this.tableLayoutPanel_con4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.88678F));
            this.tableLayoutPanel_con4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.60649F));
            this.tableLayoutPanel_con4.Controls.Add(this.dataGridView_verdatos, 1, 0);
            this.tableLayoutPanel_con4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel_con4.Location = new System.Drawing.Point(0, 391);
            this.tableLayoutPanel_con4.Name = "tableLayoutPanel_con4";
            this.tableLayoutPanel_con4.RowCount = 1;
            this.tableLayoutPanel_con4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_con4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 217F));
            this.tableLayoutPanel_con4.Size = new System.Drawing.Size(1263, 217);
            this.tableLayoutPanel_con4.TabIndex = 13;
            // 
            // dataGridView_verdatos
            // 
            this.dataGridView_verdatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_verdatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.dataGridView_verdatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_verdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_verdatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Cantidad,
            this.Precio,
            this.CostoT});
            this.dataGridView_verdatos.Location = new System.Drawing.Point(262, 3);
            this.dataGridView_verdatos.Name = "dataGridView_verdatos";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_verdatos.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_verdatos.Size = new System.Drawing.Size(762, 211);
            this.dataGridView_verdatos.TabIndex = 7;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // CostoT
            // 
            this.CostoT.HeaderText = "Costo Total";
            this.CostoT.Name = "CostoT";
            // 
            // tableLayoutPanel_con3
            // 
            this.tableLayoutPanel_con3.ColumnCount = 4;
            this.tableLayoutPanel_con3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.44374F));
            this.tableLayoutPanel_con3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.71474F));
            this.tableLayoutPanel_con3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.86698F));
            this.tableLayoutPanel_con3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.01425F));
            this.tableLayoutPanel_con3.Controls.Add(this.lbl_idP, 0, 2);
            this.tableLayoutPanel_con3.Controls.Add(this.lbl_conCant, 0, 2);
            this.tableLayoutPanel_con3.Controls.Add(this.lbl_precioP, 0, 2);
            this.tableLayoutPanel_con3.Controls.Add(this.btn_agregar, 3, 2);
            this.tableLayoutPanel_con3.Controls.Add(this.comboBox_productos, 1, 0);
            this.tableLayoutPanel_con3.Controls.Add(this.lbl_cantidad, 2, 0);
            this.tableLayoutPanel_con3.Controls.Add(this.lbl_preciosolo, 3, 1);
            this.tableLayoutPanel_con3.Controls.Add(this.lbl_producto, 0, 0);
            this.tableLayoutPanel_con3.Controls.Add(this.txt_cantidad, 3, 0);
            this.tableLayoutPanel_con3.Controls.Add(this.lbl_precioU, 2, 1);
            this.tableLayoutPanel_con3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel_con3.Location = new System.Drawing.Point(0, 276);
            this.tableLayoutPanel_con3.Name = "tableLayoutPanel_con3";
            this.tableLayoutPanel_con3.RowCount = 3;
            this.tableLayoutPanel_con3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_con3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_con3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_con3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_con3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_con3.Size = new System.Drawing.Size(1263, 115);
            this.tableLayoutPanel_con3.TabIndex = 12;
            // 
            // lbl_idP
            // 
            this.lbl_idP.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_idP.AutoSize = true;
            this.lbl_idP.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idP.ForeColor = System.Drawing.Color.White;
            this.lbl_idP.Location = new System.Drawing.Point(430, 83);
            this.lbl_idP.Name = "lbl_idP";
            this.lbl_idP.Size = new System.Drawing.Size(30, 32);
            this.lbl_idP.TabIndex = 27;
            this.lbl_idP.Text = "#";
            this.lbl_idP.Visible = false;
            // 
            // lbl_conCant
            // 
            this.lbl_conCant.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_conCant.AutoSize = true;
            this.lbl_conCant.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_conCant.ForeColor = System.Drawing.Color.White;
            this.lbl_conCant.Location = new System.Drawing.Point(84, 83);
            this.lbl_conCant.Name = "lbl_conCant";
            this.lbl_conCant.Size = new System.Drawing.Size(90, 32);
            this.lbl_conCant.TabIndex = 26;
            this.lbl_conCant.Text = "Stock";
            // 
            // lbl_precioP
            // 
            this.lbl_precioP.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_precioP.AutoSize = true;
            this.lbl_precioP.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precioP.ForeColor = System.Drawing.Color.White;
            this.lbl_precioP.Location = new System.Drawing.Point(709, 83);
            this.lbl_precioP.Name = "lbl_precioP";
            this.lbl_precioP.Size = new System.Drawing.Size(300, 32);
            this.lbl_precioP.TabIndex = 25;
            this.lbl_precioP.Text = "Precio del producto";
            this.lbl_precioP.Visible = false;
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
            this.comboBox_productos.Location = new System.Drawing.Point(261, 3);
            this.comboBox_productos.Name = "comboBox_productos";
            this.comboBox_productos.Size = new System.Drawing.Size(369, 32);
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
            this.lbl_cantidad.Location = new System.Drawing.Point(984, 14);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(98, 24);
            this.lbl_cantidad.TabIndex = 24;
            this.lbl_cantidad.Text = "Cantidad:";
            // 
            // lbl_preciosolo
            // 
            this.lbl_preciosolo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_preciosolo.AutoSize = true;
            this.lbl_preciosolo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_preciosolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_preciosolo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_preciosolo.Location = new System.Drawing.Point(1163, 52);
            this.lbl_preciosolo.Name = "lbl_preciosolo";
            this.lbl_preciosolo.Size = new System.Drawing.Size(21, 24);
            this.lbl_preciosolo.TabIndex = 24;
            this.lbl_preciosolo.Text = "#";
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
            // txt_cantidad
            // 
            this.txt_cantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_cantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.txt_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.ForeColor = System.Drawing.Color.White;
            this.txt_cantidad.Location = new System.Drawing.Point(1088, 9);
            this.txt_cantidad.Multiline = true;
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(172, 26);
            this.txt_cantidad.TabIndex = 16;
            // 
            // lbl_precioU
            // 
            this.lbl_precioU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_precioU.AutoSize = true;
            this.lbl_precioU.BackColor = System.Drawing.Color.Transparent;
            this.lbl_precioU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precioU.ForeColor = System.Drawing.Color.Black;
            this.lbl_precioU.Location = new System.Drawing.Point(931, 52);
            this.lbl_precioU.Name = "lbl_precioU";
            this.lbl_precioU.Size = new System.Drawing.Size(151, 24);
            this.lbl_precioU.TabIndex = 24;
            this.lbl_precioU.Text = "Precio unitario:";
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
            this.tableLayoutPanel_con2.Location = new System.Drawing.Point(0, 148);
            this.tableLayoutPanel_con2.Name = "tableLayoutPanel_con2";
            this.tableLayoutPanel_con2.RowCount = 4;
            this.tableLayoutPanel_con2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.125F));
            this.tableLayoutPanel_con2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.125F));
            this.tableLayoutPanel_con2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.90625F));
            this.tableLayoutPanel_con2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.84375F));
            this.tableLayoutPanel_con2.Size = new System.Drawing.Size(1263, 128);
            this.tableLayoutPanel_con2.TabIndex = 11;
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
            // tableLayoutPanel_contenedorTop
            // 
            this.tableLayoutPanel_contenedorTop.ColumnCount = 5;
            this.tableLayoutPanel_contenedorTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.588365F));
            this.tableLayoutPanel_contenedorTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.76158F));
            this.tableLayoutPanel_contenedorTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.24406F));
            this.tableLayoutPanel_contenedorTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.49704F));
            this.tableLayoutPanel_contenedorTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.90895F));
            this.tableLayoutPanel_contenedorTop.Controls.Add(this.lbl_cliente, 0, 0);
            this.tableLayoutPanel_contenedorTop.Controls.Add(this.comboBox_cliente, 1, 0);
            this.tableLayoutPanel_contenedorTop.Controls.Add(this.lbl_numerodeventa, 4, 0);
            this.tableLayoutPanel_contenedorTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel_contenedorTop.Location = new System.Drawing.Point(0, 38);
            this.tableLayoutPanel_contenedorTop.Name = "tableLayoutPanel_contenedorTop";
            this.tableLayoutPanel_contenedorTop.RowCount = 3;
            this.tableLayoutPanel_contenedorTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.03226F));
            this.tableLayoutPanel_contenedorTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.54546F));
            this.tableLayoutPanel_contenedorTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.27273F));
            this.tableLayoutPanel_contenedorTop.Size = new System.Drawing.Size(1263, 110);
            this.tableLayoutPanel_contenedorTop.TabIndex = 10;
            this.tableLayoutPanel_contenedorTop.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel_contenedorTop_Paint);
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
            this.comboBox_cliente.SelectedIndexChanged += new System.EventHandler(this.comboBox_cliente_SelectedIndexChanged);
            // 
            // lbl_numerodeventa
            // 
            this.lbl_numerodeventa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_numerodeventa.AutoSize = true;
            this.lbl_numerodeventa.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numerodeventa.ForeColor = System.Drawing.Color.White;
            this.lbl_numerodeventa.Location = new System.Drawing.Point(1178, 0);
            this.lbl_numerodeventa.Name = "lbl_numerodeventa";
            this.lbl_numerodeventa.Size = new System.Drawing.Size(30, 31);
            this.lbl_numerodeventa.TabIndex = 23;
            this.lbl_numerodeventa.Text = "#";
            // 
            // Form_Cotizacion
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
            this.Controls.Add(this.panel_barraT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Cotizacion";
            this.Opacity = 0.98D;
            this.Text = "Form_Cotizacion";
            this.Load += new System.EventHandler(this.Form_Cotizacion_Load);
            this.panel_barraT.ResumeLayout(false);
            this.panel_barraT.PerformLayout();
            this.tableLayoutPanel_final.ResumeLayout(false);
            this.tableLayoutPanel_final.PerformLayout();
            this.tableLayoutPanel_con4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_verdatos)).EndInit();
            this.tableLayoutPanel_con3.ResumeLayout(false);
            this.tableLayoutPanel_con3.PerformLayout();
            this.tableLayoutPanel_con2.ResumeLayout(false);
            this.tableLayoutPanel_con2.PerformLayout();
            this.tableLayoutPanel_contenedorTop.ResumeLayout(false);
            this.tableLayoutPanel_contenedorTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_barraT;
        private System.Windows.Forms.Label lbl_cotizacion;
        private System.Windows.Forms.Button btn_restaurar;
        private System.Windows.Forms.Button btn_minimisar;
        private System.Windows.Forms.Button btn_maximisar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_final;
        private System.Windows.Forms.Button btn_cotizar;
        private System.Windows.Forms.Label lbl_iva;
        private System.Windows.Forms.Label lbl_subtotal;
        private System.Windows.Forms.TextBox txt_subtotal;
        private System.Windows.Forms.CheckBox checkBox_iva;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_con4;
        private System.Windows.Forms.DataGridView dataGridView_verdatos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_con3;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.ComboBox comboBox_productos;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Label lbl_producto;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label lbl_precioU;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_con2;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_domicilio;
        private System.Windows.Forms.TextBox txt_rfc;
        private System.Windows.Forms.TextBox txt_razonsocial;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_razonsocial;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_rfc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_contenedorTop;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.ComboBox comboBox_cliente;
        private System.Windows.Forms.Label lbl_numerodeventa;
        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.Label lbl_idP;
        private System.Windows.Forms.Label lbl_conCant;
        private System.Windows.Forms.Label lbl_precioP;
        private System.Windows.Forms.Label lbl_preciosolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoT;
    }
}