namespace PdeV_Delsel
{
    partial class FormConsultacliente
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
            this.tableLayoutPanel_ContenedorGlobal = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_rfc = new System.Windows.Forms.Label();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_rfc = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.comboBox_consultaC = new System.Windows.Forms.ComboBox();
            this.lbl_consultaP = new System.Windows.Forms.Label();
            this.lbl_rasonsocial = new System.Windows.Forms.Label();
            this.txt_rasonsocial = new System.Windows.Forms.TextBox();
            this.panel_agregar = new System.Windows.Forms.Panel();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.lbl_idcliente = new System.Windows.Forms.Label();
            this.tableLayoutPanel_Titulo.SuspendLayout();
            this.tableLayoutPanel_ContenedorGlobal.SuspendLayout();
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
            this.tableLayoutPanel_Titulo.Size = new System.Drawing.Size(1300, 62);
            this.tableLayoutPanel_Titulo.TabIndex = 3;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Lithos Pro Regular", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.Black;
            this.lbl_titulo.Location = new System.Drawing.Point(403, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(494, 62);
            this.lbl_titulo.TabIndex = 2;
            this.lbl_titulo.Text = "Consulta Cliente";
            // 
            // tableLayoutPanel_ContenedorGlobal
            // 
            this.tableLayoutPanel_ContenedorGlobal.ColumnCount = 3;
            this.tableLayoutPanel_ContenedorGlobal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.24942F));
            this.tableLayoutPanel_ContenedorGlobal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.73595F));
            this.tableLayoutPanel_ContenedorGlobal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.01463F));
            this.tableLayoutPanel_ContenedorGlobal.Controls.Add(this.lbl_nombre, 0, 0);
            this.tableLayoutPanel_ContenedorGlobal.Controls.Add(this.lbl_rfc, 0, 1);
            this.tableLayoutPanel_ContenedorGlobal.Controls.Add(this.lbl_direccion, 0, 2);
            this.tableLayoutPanel_ContenedorGlobal.Controls.Add(this.lbl_telefono, 0, 3);
            this.tableLayoutPanel_ContenedorGlobal.Controls.Add(this.lbl_email, 0, 4);
            this.tableLayoutPanel_ContenedorGlobal.Controls.Add(this.txt_nombre, 1, 0);
            this.tableLayoutPanel_ContenedorGlobal.Controls.Add(this.txt_rfc, 1, 1);
            this.tableLayoutPanel_ContenedorGlobal.Controls.Add(this.txt_direccion, 1, 2);
            this.tableLayoutPanel_ContenedorGlobal.Controls.Add(this.txt_telefono, 1, 3);
            this.tableLayoutPanel_ContenedorGlobal.Controls.Add(this.txt_email, 1, 4);
            this.tableLayoutPanel_ContenedorGlobal.Controls.Add(this.lbl_rasonsocial, 0, 5);
            this.tableLayoutPanel_ContenedorGlobal.Controls.Add(this.txt_rasonsocial, 1, 5);
            this.tableLayoutPanel_ContenedorGlobal.Controls.Add(this.comboBox_consultaC, 2, 3);
            this.tableLayoutPanel_ContenedorGlobal.Controls.Add(this.lbl_consultaP, 2, 2);
            this.tableLayoutPanel_ContenedorGlobal.Controls.Add(this.lbl_idcliente, 2, 0);
            this.tableLayoutPanel_ContenedorGlobal.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel_ContenedorGlobal.Location = new System.Drawing.Point(0, 62);
            this.tableLayoutPanel_ContenedorGlobal.Name = "tableLayoutPanel_ContenedorGlobal";
            this.tableLayoutPanel_ContenedorGlobal.RowCount = 6;
            this.tableLayoutPanel_ContenedorGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_ContenedorGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_ContenedorGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_ContenedorGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_ContenedorGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_ContenedorGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_ContenedorGlobal.Size = new System.Drawing.Size(1300, 420);
            this.tableLayoutPanel_ContenedorGlobal.TabIndex = 15;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.Black;
            this.lbl_nombre.Location = new System.Drawing.Point(169, 32);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(143, 37);
            this.lbl_nombre.TabIndex = 4;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // lbl_rfc
            // 
            this.lbl_rfc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_rfc.AutoSize = true;
            this.lbl_rfc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_rfc.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rfc.ForeColor = System.Drawing.Color.Black;
            this.lbl_rfc.Location = new System.Drawing.Point(223, 101);
            this.lbl_rfc.Name = "lbl_rfc";
            this.lbl_rfc.Size = new System.Drawing.Size(89, 37);
            this.lbl_rfc.TabIndex = 5;
            this.lbl_rfc.Text = "RFC:";
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_direccion.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccion.ForeColor = System.Drawing.Color.Black;
            this.lbl_direccion.Location = new System.Drawing.Point(115, 170);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(197, 37);
            this.lbl_direccion.TabIndex = 6;
            this.lbl_direccion.Text = "Dirección:";
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.BackColor = System.Drawing.Color.Transparent;
            this.lbl_telefono.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono.ForeColor = System.Drawing.Color.Black;
            this.lbl_telefono.Location = new System.Drawing.Point(133, 239);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(179, 37);
            this.lbl_telefono.TabIndex = 7;
            this.lbl_telefono.Text = "Telefono:";
            // 
            // lbl_email
            // 
            this.lbl_email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_email.AutoSize = true;
            this.lbl_email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_email.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.Black;
            this.lbl_email.Location = new System.Drawing.Point(169, 308);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(143, 37);
            this.lbl_email.TabIndex = 8;
            this.lbl_email.Text = "E-mail:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.Color.SeaGreen;
            this.txt_nombre.Location = new System.Drawing.Point(318, 36);
            this.txt_nombre.Multiline = true;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(731, 30);
            this.txt_nombre.TabIndex = 12;
            this.txt_nombre.Text = "NOMBRE";
            // 
            // txt_rfc
            // 
            this.txt_rfc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_rfc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.txt_rfc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rfc.ForeColor = System.Drawing.Color.SeaGreen;
            this.txt_rfc.Location = new System.Drawing.Point(318, 105);
            this.txt_rfc.Multiline = true;
            this.txt_rfc.Name = "txt_rfc";
            this.txt_rfc.Size = new System.Drawing.Size(731, 30);
            this.txt_rfc.TabIndex = 13;
            this.txt_rfc.Text = "RFC";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_direccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.txt_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion.ForeColor = System.Drawing.Color.SeaGreen;
            this.txt_direccion.Location = new System.Drawing.Point(318, 174);
            this.txt_direccion.Multiline = true;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(731, 30);
            this.txt_direccion.TabIndex = 14;
            this.txt_direccion.Text = "DIRECCION";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_telefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.txt_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.ForeColor = System.Drawing.Color.SeaGreen;
            this.txt_telefono.Location = new System.Drawing.Point(318, 243);
            this.txt_telefono.Multiline = true;
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(731, 30);
            this.txt_telefono.TabIndex = 15;
            this.txt_telefono.Text = "TELEFONO";
            // 
            // txt_email
            // 
            this.txt_email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.ForeColor = System.Drawing.Color.SeaGreen;
            this.txt_email.Location = new System.Drawing.Point(318, 312);
            this.txt_email.Multiline = true;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(731, 30);
            this.txt_email.TabIndex = 16;
            this.txt_email.Text = "E-MAIL";
            // 
            // comboBox_consultaC
            // 
            this.comboBox_consultaC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_consultaC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.comboBox_consultaC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_consultaC.ForeColor = System.Drawing.Color.White;
            this.comboBox_consultaC.FormattingEnabled = true;
            this.comboBox_consultaC.Location = new System.Drawing.Point(1055, 210);
            this.comboBox_consultaC.Name = "comboBox_consultaC";
            this.comboBox_consultaC.Size = new System.Drawing.Size(242, 28);
            this.comboBox_consultaC.TabIndex = 21;
            // 
            // lbl_consultaP
            // 
            this.lbl_consultaP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_consultaP.AutoSize = true;
            this.lbl_consultaP.BackColor = System.Drawing.Color.Transparent;
            this.lbl_consultaP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_consultaP.ForeColor = System.Drawing.Color.Black;
            this.lbl_consultaP.Location = new System.Drawing.Point(1055, 183);
            this.lbl_consultaP.Name = "lbl_consultaP";
            this.lbl_consultaP.Size = new System.Drawing.Size(242, 24);
            this.lbl_consultaP.TabIndex = 22;
            this.lbl_consultaP.Text = "Consulta de productos";
            // 
            // lbl_rasonsocial
            // 
            this.lbl_rasonsocial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_rasonsocial.AutoSize = true;
            this.lbl_rasonsocial.BackColor = System.Drawing.Color.Transparent;
            this.lbl_rasonsocial.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rasonsocial.ForeColor = System.Drawing.Color.Black;
            this.lbl_rasonsocial.Location = new System.Drawing.Point(61, 383);
            this.lbl_rasonsocial.Name = "lbl_rasonsocial";
            this.lbl_rasonsocial.Size = new System.Drawing.Size(251, 37);
            this.lbl_rasonsocial.TabIndex = 8;
            this.lbl_rasonsocial.Text = "Razón social:";
            // 
            // txt_rasonsocial
            // 
            this.txt_rasonsocial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_rasonsocial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.txt_rasonsocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rasonsocial.ForeColor = System.Drawing.Color.SeaGreen;
            this.txt_rasonsocial.Location = new System.Drawing.Point(318, 387);
            this.txt_rasonsocial.Multiline = true;
            this.txt_rasonsocial.Name = "txt_rasonsocial";
            this.txt_rasonsocial.Size = new System.Drawing.Size(731, 30);
            this.txt_rasonsocial.TabIndex = 16;
            this.txt_rasonsocial.Text = "RAZON SOCIAL";
            // 
            // panel_agregar
            // 
            this.panel_agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_agregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.panel_agregar.Location = new System.Drawing.Point(1280, 594);
            this.panel_agregar.Name = "panel_agregar";
            this.panel_agregar.Size = new System.Drawing.Size(8, 44);
            this.panel_agregar.TabIndex = 17;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_modificar.FlatAppearance.BorderSize = 0;
            this.btn_modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificar.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_modificar.Image = global::PdeV_Delsel.Properties.Resources.consultar_super_mini1;
            this.btn_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modificar.Location = new System.Drawing.Point(1065, 594);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(223, 44);
            this.btn_modificar.TabIndex = 16;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.panel1.Location = new System.Drawing.Point(227, 594);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 44);
            this.panel1.TabIndex = 19;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btn_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_eliminar.Image = global::PdeV_Delsel.Properties.Resources.eliminar_super_pequeño;
            this.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminar.Location = new System.Drawing.Point(12, 594);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(223, 44);
            this.btn_eliminar.TabIndex = 18;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // lbl_idcliente
            // 
            this.lbl_idcliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_idcliente.AutoSize = true;
            this.lbl_idcliente.BackColor = System.Drawing.Color.Transparent;
            this.lbl_idcliente.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idcliente.ForeColor = System.Drawing.Color.White;
            this.lbl_idcliente.Location = new System.Drawing.Point(1262, 32);
            this.lbl_idcliente.Name = "lbl_idcliente";
            this.lbl_idcliente.Size = new System.Drawing.Size(35, 37);
            this.lbl_idcliente.TabIndex = 4;
            this.lbl_idcliente.Text = "#";
            // 
            // FormConsultacliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.panel_agregar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.tableLayoutPanel_ContenedorGlobal);
            this.Controls.Add(this.tableLayoutPanel_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConsultacliente";
            this.Opacity = 0.98D;
            this.Text = "FormConsultacliente";
            this.Load += new System.EventHandler(this.FormConsultacliente_Load);
            this.tableLayoutPanel_Titulo.ResumeLayout(false);
            this.tableLayoutPanel_Titulo.PerformLayout();
            this.tableLayoutPanel_ContenedorGlobal.ResumeLayout(false);
            this.tableLayoutPanel_ContenedorGlobal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Titulo;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_ContenedorGlobal;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_rfc;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_rfc;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Panel panel_agregar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.ComboBox comboBox_consultaC;
        private System.Windows.Forms.Label lbl_consultaP;
        private System.Windows.Forms.Label lbl_rasonsocial;
        private System.Windows.Forms.TextBox txt_rasonsocial;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label lbl_idcliente;
    }
}