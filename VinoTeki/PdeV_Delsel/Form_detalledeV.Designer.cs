namespace PdeV_Delsel
{
    partial class Form_detalledeV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel_Titulo = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.monthCalendar_desde = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar_hasta = new System.Windows.Forms.MonthCalendar();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_hasta = new System.Windows.Forms.Label();
            this.lbl_desde = new System.Windows.Forms.Label();
            this.lbl_des = new System.Windows.Forms.Label();
            this.lbl_has = new System.Windows.Forms.Label();
            this.tableLayoutPanel_con3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.comboBox_formadepago = new System.Windows.Forms.ComboBox();
            this.comboBox_cliente = new System.Windows.Forms.ComboBox();
            this.lbl_precioU = new System.Windows.Forms.Label();
            this.lbl_folio = new System.Windows.Forms.Label();
            this.txt_folio = new System.Windows.Forms.TextBox();
            this.dataGridView_verdatos = new System.Windows.Forms.DataGridView();
            this.btn_exportarEx = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.tableLayoutPanel_Titulo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel_con3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_verdatos)).BeginInit();
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
            this.tableLayoutPanel_Titulo.Size = new System.Drawing.Size(1733, 76);
            this.tableLayoutPanel_Titulo.TabIndex = 3;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.Black;
            this.lbl_titulo.Location = new System.Drawing.Point(595, 0);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(543, 76);
            this.lbl_titulo.TabIndex = 2;
            this.lbl_titulo.Text = "Consulta de venta ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.96651F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.70541F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.03122F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.70784F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.58901F));
            this.tableLayoutPanel1.Controls.Add(this.monthCalendar_desde, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.monthCalendar_hasta, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 76);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1733, 229);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // monthCalendar_desde
            // 
            this.monthCalendar_desde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.monthCalendar_desde.Location = new System.Drawing.Point(302, 11);
            this.monthCalendar_desde.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar_desde.Name = "monthCalendar_desde";
            this.monthCalendar_desde.TabIndex = 5;
            this.monthCalendar_desde.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_desde_DateChanged);
            // 
            // monthCalendar_hasta
            // 
            this.monthCalendar_hasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.monthCalendar_hasta.Location = new System.Drawing.Point(1024, 11);
            this.monthCalendar_hasta.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar_hasta.Name = "monthCalendar_hasta";
            this.monthCalendar_hasta.TabIndex = 5;
            this.monthCalendar_hasta.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_hasta_DateChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.96651F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.35141F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.75303F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.27467F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.58901F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_hasta, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_desde, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_des, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_consultar, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_has, 3, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 305);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.30303F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.69697F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1733, 105);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // lbl_hasta
            // 
            this.lbl_hasta.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_hasta.AutoSize = true;
            this.lbl_hasta.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hasta.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hasta.ForeColor = System.Drawing.Color.Black;
            this.lbl_hasta.Location = new System.Drawing.Point(1106, 11);
            this.lbl_hasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_hasta.Name = "lbl_hasta";
            this.lbl_hasta.Size = new System.Drawing.Size(152, 47);
            this.lbl_hasta.TabIndex = 6;
            this.lbl_hasta.Text = "Hasta ";
            // 
            // lbl_desde
            // 
            this.lbl_desde.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_desde.AutoSize = true;
            this.lbl_desde.BackColor = System.Drawing.Color.Transparent;
            this.lbl_desde.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desde.ForeColor = System.Drawing.Color.Black;
            this.lbl_desde.Location = new System.Drawing.Point(362, 11);
            this.lbl_desde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_desde.Name = "lbl_desde";
            this.lbl_desde.Size = new System.Drawing.Size(130, 47);
            this.lbl_desde.TabIndex = 6;
            this.lbl_desde.Text = "Desde";
            // 
            // lbl_des
            // 
            this.lbl_des.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_des.AutoSize = true;
            this.lbl_des.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_des.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_des.Location = new System.Drawing.Point(410, 76);
            this.lbl_des.Name = "lbl_des";
            this.lbl_des.Size = new System.Drawing.Size(34, 29);
            this.lbl_des.TabIndex = 7;
            this.lbl_des.Text = "...";
            // 
            // lbl_has
            // 
            this.lbl_has.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_has.AutoSize = true;
            this.lbl_has.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_has.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_has.Location = new System.Drawing.Point(1165, 76);
            this.lbl_has.Name = "lbl_has";
            this.lbl_has.Size = new System.Drawing.Size(34, 29);
            this.lbl_has.TabIndex = 7;
            this.lbl_has.Text = "...";
            // 
            // tableLayoutPanel_con3
            // 
            this.tableLayoutPanel_con3.ColumnCount = 4;
            this.tableLayoutPanel_con3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.44374F));
            this.tableLayoutPanel_con3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.71474F));
            this.tableLayoutPanel_con3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.7498F));
            this.tableLayoutPanel_con3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.13143F));
            this.tableLayoutPanel_con3.Controls.Add(this.lbl_cliente, 0, 1);
            this.tableLayoutPanel_con3.Controls.Add(this.comboBox_formadepago, 3, 2);
            this.tableLayoutPanel_con3.Controls.Add(this.comboBox_cliente, 1, 1);
            this.tableLayoutPanel_con3.Controls.Add(this.btn_exportarEx, 0, 2);
            this.tableLayoutPanel_con3.Controls.Add(this.lbl_precioU, 2, 2);
            this.tableLayoutPanel_con3.Controls.Add(this.lbl_folio, 2, 1);
            this.tableLayoutPanel_con3.Controls.Add(this.txt_folio, 3, 1);
            this.tableLayoutPanel_con3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel_con3.Location = new System.Drawing.Point(0, 410);
            this.tableLayoutPanel_con3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel_con3.Name = "tableLayoutPanel_con3";
            this.tableLayoutPanel_con3.RowCount = 3;
            this.tableLayoutPanel_con3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.23377F));
            this.tableLayoutPanel_con3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.53719F));
            this.tableLayoutPanel_con3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.76033F));
            this.tableLayoutPanel_con3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel_con3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel_con3.Size = new System.Drawing.Size(1733, 150);
            this.tableLayoutPanel_con3.TabIndex = 7;
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cliente.ForeColor = System.Drawing.Color.Black;
            this.lbl_cliente.Location = new System.Drawing.Point(247, 48);
            this.lbl_cliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(103, 29);
            this.lbl_cliente.TabIndex = 24;
            this.lbl_cliente.Text = "Cliente:";
            // 
            // comboBox_formadepago
            // 
            this.comboBox_formadepago.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_formadepago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.comboBox_formadepago.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_formadepago.ForeColor = System.Drawing.Color.White;
            this.comboBox_formadepago.FormattingEnabled = true;
            this.comboBox_formadepago.Location = new System.Drawing.Point(1422, 109);
            this.comboBox_formadepago.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_formadepago.Name = "comboBox_formadepago";
            this.comboBox_formadepago.Size = new System.Drawing.Size(307, 37);
            this.comboBox_formadepago.TabIndex = 22;
            this.comboBox_formadepago.SelectedIndexChanged += new System.EventHandler(this.comboBox_formadepago_SelectedIndexChanged);
            // 
            // comboBox_cliente
            // 
            this.comboBox_cliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.comboBox_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_cliente.ForeColor = System.Drawing.Color.White;
            this.comboBox_cliente.FormattingEnabled = true;
            this.comboBox_cliente.Location = new System.Drawing.Point(358, 36);
            this.comboBox_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_cliente.Name = "comboBox_cliente";
            this.comboBox_cliente.Size = new System.Drawing.Size(506, 37);
            this.comboBox_cliente.TabIndex = 22;
            this.comboBox_cliente.SelectedIndexChanged += new System.EventHandler(this.comboBox_cliente_SelectedIndexChanged);
            // 
            // lbl_precioU
            // 
            this.lbl_precioU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_precioU.AutoSize = true;
            this.lbl_precioU.BackColor = System.Drawing.Color.Transparent;
            this.lbl_precioU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precioU.ForeColor = System.Drawing.Color.Black;
            this.lbl_precioU.Location = new System.Drawing.Point(1209, 121);
            this.lbl_precioU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_precioU.Name = "lbl_precioU";
            this.lbl_precioU.Size = new System.Drawing.Size(205, 29);
            this.lbl_precioU.TabIndex = 24;
            this.lbl_precioU.Text = "Forma de pago: ";
            // 
            // lbl_folio
            // 
            this.lbl_folio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_folio.AutoSize = true;
            this.lbl_folio.BackColor = System.Drawing.Color.Transparent;
            this.lbl_folio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_folio.ForeColor = System.Drawing.Color.Black;
            this.lbl_folio.Location = new System.Drawing.Point(1306, 48);
            this.lbl_folio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_folio.Name = "lbl_folio";
            this.lbl_folio.Size = new System.Drawing.Size(108, 29);
            this.lbl_folio.TabIndex = 24;
            this.lbl_folio.Text = "Folio, #:";
            this.lbl_folio.Visible = false;
            // 
            // txt_folio
            // 
            this.txt_folio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_folio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.txt_folio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_folio.ForeColor = System.Drawing.Color.White;
            this.txt_folio.Location = new System.Drawing.Point(1422, 42);
            this.txt_folio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_folio.Multiline = true;
            this.txt_folio.Name = "txt_folio";
            this.txt_folio.Size = new System.Drawing.Size(307, 31);
            this.txt_folio.TabIndex = 16;
            this.txt_folio.Visible = false;
            // 
            // dataGridView_verdatos
            // 
            this.dataGridView_verdatos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dataGridView_verdatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_verdatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_verdatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(101)))), ((int)(((byte)(80)))));
            this.dataGridView_verdatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_verdatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_verdatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView_verdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_verdatos.EnableHeadersVisualStyles = false;
            this.dataGridView_verdatos.GridColor = System.Drawing.Color.LimeGreen;
            this.dataGridView_verdatos.Location = new System.Drawing.Point(68, 568);
            this.dataGridView_verdatos.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_verdatos.Name = "dataGridView_verdatos";
            this.dataGridView_verdatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_verdatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_verdatos.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView_verdatos.Size = new System.Drawing.Size(1329, 203);
            this.dataGridView_verdatos.TabIndex = 8;
            // 
            // btn_exportarEx
            // 
            this.btn_exportarEx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exportarEx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_exportarEx.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.btn_exportarEx.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.btn_exportarEx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportarEx.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exportarEx.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_exportarEx.Image = global::PdeV_Delsel.Properties.Resources.ecxel_icono;
            this.btn_exportarEx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exportarEx.Location = new System.Drawing.Point(135, 96);
            this.btn_exportarEx.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exportarEx.Name = "btn_exportarEx";
            this.btn_exportarEx.Size = new System.Drawing.Size(215, 50);
            this.btn_exportarEx.TabIndex = 9;
            this.btn_exportarEx.Text = "Exportar";
            this.btn_exportarEx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exportarEx.UseVisualStyleBackColor = true;
            this.btn_exportarEx.Click += new System.EventHandler(this.btn_exportarEx_Click);
            // 
            // btn_consultar
            // 
            this.btn_consultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_consultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_consultar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.btn_consultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.btn_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultar.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_consultar.Image = global::PdeV_Delsel.Properties.Resources.lupita;
            this.btn_consultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_consultar.Location = new System.Drawing.Point(674, 4);
            this.btn_consultar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(259, 50);
            this.btn_consultar.TabIndex = 9;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // Form_detalledeV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1733, 800);
            this.Controls.Add(this.dataGridView_verdatos);
            this.Controls.Add(this.tableLayoutPanel_con3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_detalledeV";
            this.Opacity = 0.98D;
            this.Text = "Form_detalledeV";
            this.Load += new System.EventHandler(this.Form_detalledeV_Load);
            this.tableLayoutPanel_Titulo.ResumeLayout(false);
            this.tableLayoutPanel_Titulo.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel_con3.ResumeLayout(false);
            this.tableLayoutPanel_con3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_verdatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Titulo;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MonthCalendar monthCalendar_desde;
        private System.Windows.Forms.MonthCalendar monthCalendar_hasta;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_hasta;
        private System.Windows.Forms.Label lbl_desde;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_con3;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.ComboBox comboBox_formadepago;
        private System.Windows.Forms.ComboBox comboBox_cliente;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Label lbl_precioU;
        private System.Windows.Forms.Label lbl_folio;
        private System.Windows.Forms.TextBox txt_folio;
        private System.Windows.Forms.DataGridView dataGridView_verdatos;
        private System.Windows.Forms.Label lbl_des;
        private System.Windows.Forms.Label lbl_has;
        private System.Windows.Forms.Button btn_exportarEx;
    }
}