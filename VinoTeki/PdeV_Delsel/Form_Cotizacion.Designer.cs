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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cotizacion));
            this.panel_barraT = new System.Windows.Forms.Panel();
            this.lbl_cotizacion = new System.Windows.Forms.Label();
            this.btn_restaurar = new System.Windows.Forms.Button();
            this.btn_minimisar = new System.Windows.Forms.Button();
            this.btn_maximisar = new System.Windows.Forms.Button();
            this.tableLayoutPanel_final = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_mostrarExito = new System.Windows.Forms.Label();
            this.lbl_iva = new System.Windows.Forms.Label();
            this.lbl_subtotal = new System.Windows.Forms.Label();
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.checkBox_iva = new System.Windows.Forms.CheckBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.btn_cotizar = new System.Windows.Forms.Button();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.lbl_cotizacionbad = new System.Windows.Forms.Label();
            this.tableLayoutPanel_con4 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView_verdatos = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel_con3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.comboBox_productos = new System.Windows.Forms.ComboBox();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.lbl_preciosolo = new System.Windows.Forms.Label();
            this.lbl_producto = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.lbl_precioU = new System.Windows.Forms.Label();
            this.lbl_precioP = new System.Windows.Forms.Label();
            this.lbl_idP = new System.Windows.Forms.Label();
            this.lbl_conCant = new System.Windows.Forms.Label();
            this.lbl_stockgood = new System.Windows.Forms.Label();
            this.lbl_stockbad = new System.Windows.Forms.Label();
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
            this.lbl_folioCoti = new System.Windows.Forms.Label();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.ProductoTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_barraT.SuspendLayout();
            this.tableLayoutPanel_final.SuspendLayout();
            this.tableLayoutPanel_con4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_verdatos)).BeginInit();
            this.tableLayoutPanel_con3.SuspendLayout();
            this.tableLayoutPanel_con2.SuspendLayout();
            this.tableLayoutPanel_contenedorTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
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
            this.panel_barraT.Margin = new System.Windows.Forms.Padding(4);
            this.panel_barraT.Name = "panel_barraT";
            this.panel_barraT.Size = new System.Drawing.Size(1684, 47);
            this.panel_barraT.TabIndex = 1;
            this.panel_barraT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_barraT_MouseDown);
            // 
            // lbl_cotizacion
            // 
            this.lbl_cotizacion.AutoSize = true;
            this.lbl_cotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cotizacion.Location = new System.Drawing.Point(16, 11);
            this.lbl_cotizacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cotizacion.Name = "lbl_cotizacion";
            this.lbl_cotizacion.Size = new System.Drawing.Size(142, 29);
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
            this.btn_restaurar.Location = new System.Drawing.Point(1635, 9);
            this.btn_restaurar.Margin = new System.Windows.Forms.Padding(4);
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
            this.btn_minimisar.Location = new System.Drawing.Point(1593, 9);
            this.btn_minimisar.Margin = new System.Windows.Forms.Padding(4);
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
            this.btn_maximisar.Location = new System.Drawing.Point(1635, 9);
            this.btn_maximisar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_maximisar.Name = "btn_maximisar";
            this.btn_maximisar.Size = new System.Drawing.Size(33, 31);
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
            this.tableLayoutPanel_final.Controls.Add(this.lbl_mostrarExito, 1, 0);
            this.tableLayoutPanel_final.Controls.Add(this.lbl_iva, 4, 1);
            this.tableLayoutPanel_final.Controls.Add(this.lbl_subtotal, 3, 0);
            this.tableLayoutPanel_final.Controls.Add(this.txt_subtotal, 4, 0);
            this.tableLayoutPanel_final.Controls.Add(this.checkBox_iva, 3, 1);
            this.tableLayoutPanel_final.Controls.Add(this.lbl_total, 3, 2);
            this.tableLayoutPanel_final.Controls.Add(this.txt_total, 4, 2);
            this.tableLayoutPanel_final.Controls.Add(this.btn_cotizar, 1, 2);
            this.tableLayoutPanel_final.Controls.Add(this.btn_inicio, 0, 2);
            this.tableLayoutPanel_final.Controls.Add(this.lbl_cotizacionbad, 0, 0);
            this.tableLayoutPanel_final.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_final.Location = new System.Drawing.Point(0, 749);
            this.tableLayoutPanel_final.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel_final.Name = "tableLayoutPanel_final";
            this.tableLayoutPanel_final.RowCount = 3;
            this.tableLayoutPanel_final.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.55906F));
            this.tableLayoutPanel_final.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.19685F));
            this.tableLayoutPanel_final.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.45669F));
            this.tableLayoutPanel_final.Size = new System.Drawing.Size(1684, 185);
            this.tableLayoutPanel_final.TabIndex = 14;
            // 
            // lbl_mostrarExito
            // 
            this.lbl_mostrarExito.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_mostrarExito.AutoSize = true;
            this.lbl_mostrarExito.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mostrarExito.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mostrarExito.ForeColor = System.Drawing.Color.GreenYellow;
            this.lbl_mostrarExito.Location = new System.Drawing.Point(380, 9);
            this.lbl_mostrarExito.Name = "lbl_mostrarExito";
            this.lbl_mostrarExito.Size = new System.Drawing.Size(640, 42);
            this.lbl_mostrarExito.TabIndex = 25;
            this.lbl_mostrarExito.Text = "Cotizacion creada, ¡exitosamente!";
            this.lbl_mostrarExito.Visible = false;
            // 
            // lbl_iva
            // 
            this.lbl_iva.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_iva.AutoSize = true;
            this.lbl_iva.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_iva.ForeColor = System.Drawing.Color.White;
            this.lbl_iva.Location = new System.Drawing.Point(1541, 69);
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
            this.lbl_subtotal.Location = new System.Drawing.Point(1276, 22);
            this.lbl_subtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_subtotal.Name = "lbl_subtotal";
            this.lbl_subtotal.Size = new System.Drawing.Size(144, 29);
            this.lbl_subtotal.TabIndex = 24;
            this.lbl_subtotal.Text = "Sub total: $";
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_subtotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.txt_subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_subtotal.ForeColor = System.Drawing.Color.White;
            this.txt_subtotal.Location = new System.Drawing.Point(1474, 16);
            this.txt_subtotal.Margin = new System.Windows.Forms.Padding(4);
            this.txt_subtotal.Multiline = true;
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.ReadOnly = true;
            this.txt_subtotal.Size = new System.Drawing.Size(159, 31);
            this.txt_subtotal.TabIndex = 14;
            this.txt_subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox_iva
            // 
            this.checkBox_iva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_iva.AutoSize = true;
            this.checkBox_iva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_iva.Location = new System.Drawing.Point(1331, 64);
            this.checkBox_iva.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_iva.Name = "checkBox_iva";
            this.checkBox_iva.Size = new System.Drawing.Size(89, 29);
            this.checkBox_iva.TabIndex = 0;
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
            this.lbl_total.Location = new System.Drawing.Point(1319, 97);
            this.lbl_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(101, 29);
            this.lbl_total.TabIndex = 24;
            this.lbl_total.Text = "Total: $";
            // 
            // txt_total
            // 
            this.txt_total.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.txt_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.ForeColor = System.Drawing.Color.White;
            this.txt_total.Location = new System.Drawing.Point(1470, 101);
            this.txt_total.Margin = new System.Windows.Forms.Padding(4);
            this.txt_total.Multiline = true;
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(168, 31);
            this.txt_total.TabIndex = 14;
            this.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btn_cotizar.Location = new System.Drawing.Point(572, 118);
            this.btn_cotizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cotizar.Name = "btn_cotizar";
            this.btn_cotizar.Size = new System.Drawing.Size(256, 63);
            this.btn_cotizar.TabIndex = 1;
            this.btn_cotizar.Text = "Cotizar";
            this.btn_cotizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cotizar.UseVisualStyleBackColor = true;
            this.btn_cotizar.Click += new System.EventHandler(this.btn_cotizar_Click);
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
            this.btn_inicio.Location = new System.Drawing.Point(4, 118);
            this.btn_inicio.Margin = new System.Windows.Forms.Padding(4);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(113, 63);
            this.btn_inicio.TabIndex = 2;
            this.btn_inicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_inicio.UseVisualStyleBackColor = true;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // lbl_cotizacionbad
            // 
            this.lbl_cotizacionbad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_cotizacionbad.AutoSize = true;
            this.lbl_cotizacionbad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cotizacionbad.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cotizacionbad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_cotizacionbad.Location = new System.Drawing.Point(33, 16);
            this.lbl_cotizacionbad.Name = "lbl_cotizacionbad";
            this.lbl_cotizacionbad.Size = new System.Drawing.Size(278, 35);
            this.lbl_cotizacionbad.TabIndex = 25;
            this.lbl_cotizacionbad.Text = "Hay problemas... ";
            this.lbl_cotizacionbad.Visible = false;
            // 
            // tableLayoutPanel_con4
            // 
            this.tableLayoutPanel_con4.ColumnCount = 3;
            this.tableLayoutPanel_con4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.58591F));
            this.tableLayoutPanel_con4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.88678F));
            this.tableLayoutPanel_con4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.60649F));
            this.tableLayoutPanel_con4.Controls.Add(this.dataGridView_verdatos, 1, 0);
            this.tableLayoutPanel_con4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel_con4.Location = new System.Drawing.Point(0, 482);
            this.tableLayoutPanel_con4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel_con4.Name = "tableLayoutPanel_con4";
            this.tableLayoutPanel_con4.RowCount = 1;
            this.tableLayoutPanel_con4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_con4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.tableLayoutPanel_con4.Size = new System.Drawing.Size(1684, 267);
            this.tableLayoutPanel_con4.TabIndex = 13;
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
            this.ProductoTB,
            this.CantidadTB,
            this.PrecioTB,
            this.CostoTB,
            this.Column1,
            this.Column2});
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
            this.dataGridView_verdatos.TabIndex = 7;
            // 
            // tableLayoutPanel_con3
            // 
            this.tableLayoutPanel_con3.ColumnCount = 4;
            this.tableLayoutPanel_con3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.44374F));
            this.tableLayoutPanel_con3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.71474F));
            this.tableLayoutPanel_con3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.86698F));
            this.tableLayoutPanel_con3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.01425F));
            this.tableLayoutPanel_con3.Controls.Add(this.btn_agregar, 3, 2);
            this.tableLayoutPanel_con3.Controls.Add(this.comboBox_productos, 1, 0);
            this.tableLayoutPanel_con3.Controls.Add(this.lbl_cantidad, 2, 0);
            this.tableLayoutPanel_con3.Controls.Add(this.lbl_preciosolo, 3, 1);
            this.tableLayoutPanel_con3.Controls.Add(this.lbl_producto, 0, 0);
            this.tableLayoutPanel_con3.Controls.Add(this.txt_cantidad, 3, 0);
            this.tableLayoutPanel_con3.Controls.Add(this.lbl_precioU, 2, 1);
            this.tableLayoutPanel_con3.Controls.Add(this.lbl_precioP, 2, 2);
            this.tableLayoutPanel_con3.Controls.Add(this.lbl_idP, 1, 2);
            this.tableLayoutPanel_con3.Controls.Add(this.lbl_conCant, 1, 1);
            this.tableLayoutPanel_con3.Controls.Add(this.lbl_stockgood, 0, 1);
            this.tableLayoutPanel_con3.Controls.Add(this.lbl_stockbad, 0, 2);
            this.tableLayoutPanel_con3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel_con3.Location = new System.Drawing.Point(0, 340);
            this.tableLayoutPanel_con3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel_con3.Name = "tableLayoutPanel_con3";
            this.tableLayoutPanel_con3.RowCount = 3;
            this.tableLayoutPanel_con3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_con3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_con3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_con3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel_con3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel_con3.Size = new System.Drawing.Size(1684, 142);
            this.tableLayoutPanel_con3.TabIndex = 12;
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
            this.btn_agregar.TabIndex = 2;
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
            this.comboBox_productos.TabIndex = 0;
            this.comboBox_productos.SelectedIndexChanged += new System.EventHandler(this.comboBox_productos_SelectedIndexChanged);
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.ForeColor = System.Drawing.Color.Black;
            this.lbl_cantidad.Location = new System.Drawing.Point(1319, 18);
            this.lbl_cantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(124, 29);
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
            this.lbl_preciosolo.Location = new System.Drawing.Point(1552, 65);
            this.lbl_preciosolo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_preciosolo.Name = "lbl_preciosolo";
            this.lbl_preciosolo.Size = new System.Drawing.Size(27, 29);
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
            this.lbl_producto.Location = new System.Drawing.Point(215, 18);
            this.lbl_producto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_producto.Name = "lbl_producto";
            this.lbl_producto.Size = new System.Drawing.Size(125, 29);
            this.lbl_producto.TabIndex = 24;
            this.lbl_producto.Text = "Producto:";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_cantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.txt_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.ForeColor = System.Drawing.Color.White;
            this.txt_cantidad.Location = new System.Drawing.Point(1481, 12);
            this.txt_cantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cantidad.Multiline = true;
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(169, 31);
            this.txt_cantidad.TabIndex = 1;
            this.txt_cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidad_KeyPress);
            this.txt_cantidad.Validated += new System.EventHandler(this.txt_cantidad_Validated);
            // 
            // lbl_precioU
            // 
            this.lbl_precioU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_precioU.AutoSize = true;
            this.lbl_precioU.BackColor = System.Drawing.Color.Transparent;
            this.lbl_precioU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precioU.ForeColor = System.Drawing.Color.Black;
            this.lbl_precioU.Location = new System.Drawing.Point(1253, 65);
            this.lbl_precioU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_precioU.Name = "lbl_precioU";
            this.lbl_precioU.Size = new System.Drawing.Size(190, 29);
            this.lbl_precioU.TabIndex = 24;
            this.lbl_precioU.Text = "Precio unitario:";
            // 
            // lbl_precioP
            // 
            this.lbl_precioP.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_precioP.AutoSize = true;
            this.lbl_precioP.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precioP.ForeColor = System.Drawing.Color.White;
            this.lbl_precioP.Location = new System.Drawing.Point(956, 102);
            this.lbl_precioP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_precioP.Name = "lbl_precioP";
            this.lbl_precioP.Size = new System.Drawing.Size(378, 40);
            this.lbl_precioP.TabIndex = 25;
            this.lbl_precioP.Text = "Precio del producto";
            this.lbl_precioP.Visible = false;
            // 
            // lbl_idP
            // 
            this.lbl_idP.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_idP.AutoSize = true;
            this.lbl_idP.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idP.ForeColor = System.Drawing.Color.White;
            this.lbl_idP.Location = new System.Drawing.Point(576, 102);
            this.lbl_idP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_idP.Name = "lbl_idP";
            this.lbl_idP.Size = new System.Drawing.Size(36, 40);
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
            this.lbl_conCant.Location = new System.Drawing.Point(538, 54);
            this.lbl_conCant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_conCant.Name = "lbl_conCant";
            this.lbl_conCant.Size = new System.Drawing.Size(112, 40);
            this.lbl_conCant.TabIndex = 26;
            this.lbl_conCant.Text = "Stock";
            this.lbl_conCant.Visible = false;
            // 
            // lbl_stockgood
            // 
            this.lbl_stockgood.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_stockgood.AutoSize = true;
            this.lbl_stockgood.BackColor = System.Drawing.Color.Transparent;
            this.lbl_stockgood.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stockgood.ForeColor = System.Drawing.Color.GreenYellow;
            this.lbl_stockgood.Location = new System.Drawing.Point(16, 59);
            this.lbl_stockgood.Name = "lbl_stockgood";
            this.lbl_stockgood.Size = new System.Drawing.Size(312, 35);
            this.lbl_stockgood.TabIndex = 25;
            this.lbl_stockgood.Text = "Stock, !descontado¡";
            this.lbl_stockgood.Visible = false;
            // 
            // lbl_stockbad
            // 
            this.lbl_stockbad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_stockbad.AutoSize = true;
            this.lbl_stockbad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_stockbad.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stockbad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_stockbad.Location = new System.Drawing.Point(33, 107);
            this.lbl_stockbad.Name = "lbl_stockbad";
            this.lbl_stockbad.Size = new System.Drawing.Size(278, 35);
            this.lbl_stockbad.TabIndex = 25;
            this.lbl_stockbad.Text = "Hay problemas... ";
            this.lbl_stockbad.Visible = false;
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
            this.tableLayoutPanel_con2.Location = new System.Drawing.Point(0, 182);
            this.tableLayoutPanel_con2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel_con2.Name = "tableLayoutPanel_con2";
            this.tableLayoutPanel_con2.RowCount = 4;
            this.tableLayoutPanel_con2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.125F));
            this.tableLayoutPanel_con2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.125F));
            this.tableLayoutPanel_con2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.90625F));
            this.tableLayoutPanel_con2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.84375F));
            this.tableLayoutPanel_con2.Size = new System.Drawing.Size(1684, 158);
            this.tableLayoutPanel_con2.TabIndex = 11;
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
            this.txt_telefono.ReadOnly = true;
            this.txt_telefono.Size = new System.Drawing.Size(558, 36);
            this.txt_telefono.TabIndex = 5;
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
            this.txt_email.ReadOnly = true;
            this.txt_email.Size = new System.Drawing.Size(558, 36);
            this.txt_email.TabIndex = 4;
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
            this.txt_direccion.ReadOnly = true;
            this.txt_direccion.Size = new System.Drawing.Size(558, 36);
            this.txt_direccion.TabIndex = 3;
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
            this.txt_rfc.ReadOnly = true;
            this.txt_rfc.Size = new System.Drawing.Size(492, 36);
            this.txt_rfc.TabIndex = 1;
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
            this.txt_razonsocial.ReadOnly = true;
            this.txt_razonsocial.Size = new System.Drawing.Size(492, 36);
            this.txt_razonsocial.TabIndex = 2;
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
            this.txt_nombre.ReadOnly = true;
            this.txt_nombre.Size = new System.Drawing.Size(492, 36);
            this.txt_nombre.TabIndex = 0;
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
            this.tableLayoutPanel_contenedorTop.Controls.Add(this.lbl_folioCoti, 3, 1);
            this.tableLayoutPanel_contenedorTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel_contenedorTop.Location = new System.Drawing.Point(0, 47);
            this.tableLayoutPanel_contenedorTop.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel_contenedorTop.Name = "tableLayoutPanel_contenedorTop";
            this.tableLayoutPanel_contenedorTop.RowCount = 3;
            this.tableLayoutPanel_contenedorTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.03226F));
            this.tableLayoutPanel_contenedorTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.54546F));
            this.tableLayoutPanel_contenedorTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.27273F));
            this.tableLayoutPanel_contenedorTop.Size = new System.Drawing.Size(1684, 135);
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
            this.lbl_cliente.Location = new System.Drawing.Point(54, 9);
            this.lbl_cliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(103, 29);
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
            this.comboBox_cliente.Location = new System.Drawing.Point(165, 4);
            this.comboBox_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_cliente.Name = "comboBox_cliente";
            this.comboBox_cliente.Size = new System.Drawing.Size(341, 33);
            this.comboBox_cliente.TabIndex = 0;
            this.comboBox_cliente.SelectedIndexChanged += new System.EventHandler(this.comboBox_cliente_SelectedIndexChanged);
            // 
            // lbl_numerodeventa
            // 
            this.lbl_numerodeventa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_numerodeventa.AutoSize = true;
            this.lbl_numerodeventa.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numerodeventa.ForeColor = System.Drawing.Color.White;
            this.lbl_numerodeventa.Location = new System.Drawing.Point(1573, 0);
            this.lbl_numerodeventa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_numerodeventa.Name = "lbl_numerodeventa";
            this.lbl_numerodeventa.Size = new System.Drawing.Size(36, 38);
            this.lbl_numerodeventa.TabIndex = 23;
            this.lbl_numerodeventa.Text = "#";
            this.lbl_numerodeventa.Visible = false;
            // 
            // lbl_folioCoti
            // 
            this.lbl_folioCoti.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_folioCoti.AutoSize = true;
            this.lbl_folioCoti.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_folioCoti.ForeColor = System.Drawing.Color.White;
            this.lbl_folioCoti.Location = new System.Drawing.Point(1300, 44);
            this.lbl_folioCoti.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_folioCoti.Name = "lbl_folioCoti";
            this.lbl_folioCoti.Size = new System.Drawing.Size(36, 40);
            this.lbl_folioCoti.TabIndex = 26;
            this.lbl_folioCoti.Text = "#";
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // ProductoTB
            // 
            this.ProductoTB.HeaderText = "Producto";
            this.ProductoTB.Name = "ProductoTB";
            this.ProductoTB.Width = 162;
            // 
            // CantidadTB
            // 
            this.CantidadTB.HeaderText = "Cantidad";
            this.CantidadTB.Name = "CantidadTB";
            this.CantidadTB.Width = 162;
            // 
            // PrecioTB
            // 
            this.PrecioTB.HeaderText = "Precio";
            this.PrecioTB.Name = "PrecioTB";
            this.PrecioTB.Width = 132;
            // 
            // CostoTB
            // 
            this.CostoTB.HeaderText = "Costo Total";
            this.CostoTB.Name = "CostoTB";
            this.CostoTB.Width = 207;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            this.Column1.Width = 72;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "idCoVe";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            this.Column2.Width = 132;
            // 
            // Form_Cotizacion
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
            this.Controls.Add(this.panel_barraT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
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
        private System.Windows.Forms.ErrorProvider errorP;
        private System.Windows.Forms.Label lbl_mostrarExito;
        private System.Windows.Forms.Label lbl_cotizacionbad;
        private System.Windows.Forms.Label lbl_stockgood;
        private System.Windows.Forms.Label lbl_stockbad;
        private System.Windows.Forms.Label lbl_folioCoti;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}