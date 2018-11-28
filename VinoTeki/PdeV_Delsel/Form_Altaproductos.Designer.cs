namespace PdeV_Delsel
{
    partial class Form_Altaproductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Altaproductos));
            this.tableLayoutPanel_Titulo = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.tableLayoutPanel_ContenedorGlobal = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Producto = new System.Windows.Forms.Label();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.lbl_modelo = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.lbl_costo = new System.Windows.Forms.Label();
            this.lbl_presio = new System.Windows.Forms.Label();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.txt_tipo = new System.Windows.Forms.TextBox();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.txt_modelo = new System.Windows.Forms.TextBox();
            this.txt_descrip = new System.Windows.Forms.TextBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.txt_costo = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.panel_agregar = new System.Windows.Forms.Panel();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel_Titulo.SuspendLayout();
            this.tableLayoutPanel_ContenedorGlobal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
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
            this.tableLayoutPanel_Titulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel_Titulo.Name = "tableLayoutPanel_Titulo";
            this.tableLayoutPanel_Titulo.RowCount = 1;
            this.tableLayoutPanel_Titulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Titulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel_Titulo.Size = new System.Drawing.Size(1733, 76);
            this.tableLayoutPanel_Titulo.TabIndex = 1;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.Black;
            this.lbl_titulo.Location = new System.Drawing.Point(666, 0);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(401, 76);
            this.lbl_titulo.TabIndex = 2;
            this.lbl_titulo.Text = "Alta Producto";
            // 
            // tableLayoutPanel_ContenedorGlobal
            // 
            this.tableLayoutPanel_ContenedorGlobal.ColumnCount = 3;
            this.tableLayoutPanel_ContenedorGlobal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.23077F));
            this.tableLayoutPanel_ContenedorGlobal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.69231F));
            this.tableLayoutPanel_ContenedorGlobal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.tableLayoutPanel_ContenedorGlobal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel_ContenedorGlobal.Controls.Add(this.lbl_Producto, 0, 0);
            this.tableLayoutPanel_ContenedorGlobal.Controls.Add(this.lbl_tipo, 0, 1);
            this.tableLayoutPanel_ContenedorGlobal.Controls.Add(this.lbl_marca, 0, 2);
            this.tableLayoutPanel_ContenedorGlobal.Controls.Add(this.lbl_modelo, 0, 3);
            this.tableLayoutPanel_ContenedorGlobal.Controls.Add(this.lbl_descripcion, 0, 4);
            this.tableLayoutPanel_ContenedorGlobal.Controls.Add(this.lbl_cantidad, 0, 5);
            this.tableLayoutPanel_ContenedorGlobal.Controls.Add(this.lbl_costo, 0, 6);
            this.tableLayoutPanel_ContenedorGlobal.Controls.Add(this.lbl_presio, 0, 7);
            this.tableLayoutPanel_ContenedorGlobal.Controls.Add(this.txt_producto, 1, 0);
            this.tableLayoutPanel_ContenedorGlobal.Controls.Add(this.txt_tipo, 1, 1);
            this.tableLayoutPanel_ContenedorGlobal.Controls.Add(this.txt_marca, 1, 2);
            this.tableLayoutPanel_ContenedorGlobal.Controls.Add(this.txt_modelo, 1, 3);
            this.tableLayoutPanel_ContenedorGlobal.Controls.Add(this.txt_descrip, 1, 4);
            this.tableLayoutPanel_ContenedorGlobal.Controls.Add(this.txt_cantidad, 1, 5);
            this.tableLayoutPanel_ContenedorGlobal.Controls.Add(this.txt_costo, 1, 6);
            this.tableLayoutPanel_ContenedorGlobal.Controls.Add(this.txt_precio, 1, 7);
            this.tableLayoutPanel_ContenedorGlobal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_ContenedorGlobal.Location = new System.Drawing.Point(0, 76);
            this.tableLayoutPanel_ContenedorGlobal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel_ContenedorGlobal.Name = "tableLayoutPanel_ContenedorGlobal";
            this.tableLayoutPanel_ContenedorGlobal.RowCount = 9;
            this.tableLayoutPanel_ContenedorGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel_ContenedorGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel_ContenedorGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel_ContenedorGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel_ContenedorGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel_ContenedorGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel_ContenedorGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel_ContenedorGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel_ContenedorGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel_ContenedorGlobal.Size = new System.Drawing.Size(1733, 724);
            this.tableLayoutPanel_ContenedorGlobal.TabIndex = 4;
            // 
            // lbl_Producto
            // 
            this.lbl_Producto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Producto.AutoSize = true;
            this.lbl_Producto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Producto.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Producto.ForeColor = System.Drawing.Color.Black;
            this.lbl_Producto.Location = new System.Drawing.Point(198, 33);
            this.lbl_Producto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Producto.Name = "lbl_Producto";
            this.lbl_Producto.Size = new System.Drawing.Size(218, 47);
            this.lbl_Producto.TabIndex = 4;
            this.lbl_Producto.Text = "Producto:";
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tipo.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo.ForeColor = System.Drawing.Color.Black;
            this.lbl_tipo.Location = new System.Drawing.Point(286, 113);
            this.lbl_tipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(130, 47);
            this.lbl_tipo.TabIndex = 5;
            this.lbl_tipo.Text = "Tipo:";
            // 
            // lbl_marca
            // 
            this.lbl_marca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.BackColor = System.Drawing.Color.Transparent;
            this.lbl_marca.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_marca.ForeColor = System.Drawing.Color.Black;
            this.lbl_marca.Location = new System.Drawing.Point(264, 193);
            this.lbl_marca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(152, 47);
            this.lbl_marca.TabIndex = 6;
            this.lbl_marca.Text = "Marca:";
            // 
            // lbl_modelo
            // 
            this.lbl_modelo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_modelo.AutoSize = true;
            this.lbl_modelo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_modelo.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_modelo.ForeColor = System.Drawing.Color.Black;
            this.lbl_modelo.Location = new System.Drawing.Point(242, 273);
            this.lbl_modelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_modelo.Name = "lbl_modelo";
            this.lbl_modelo.Size = new System.Drawing.Size(174, 47);
            this.lbl_modelo.TabIndex = 7;
            this.lbl_modelo.Text = "Modelo:";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_descripcion.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.ForeColor = System.Drawing.Color.Black;
            this.lbl_descripcion.Location = new System.Drawing.Point(132, 353);
            this.lbl_descripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(284, 47);
            this.lbl_descripcion.TabIndex = 8;
            this.lbl_descripcion.Text = "Descripción:";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cantidad.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.ForeColor = System.Drawing.Color.Black;
            this.lbl_cantidad.Location = new System.Drawing.Point(198, 433);
            this.lbl_cantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(218, 47);
            this.lbl_cantidad.TabIndex = 9;
            this.lbl_cantidad.Text = "Cantidad:";
            // 
            // lbl_costo
            // 
            this.lbl_costo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_costo.AutoSize = true;
            this.lbl_costo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_costo.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_costo.ForeColor = System.Drawing.Color.Black;
            this.lbl_costo.Location = new System.Drawing.Point(264, 513);
            this.lbl_costo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_costo.Name = "lbl_costo";
            this.lbl_costo.Size = new System.Drawing.Size(152, 47);
            this.lbl_costo.TabIndex = 10;
            this.lbl_costo.Text = "Costo:";
            // 
            // lbl_presio
            // 
            this.lbl_presio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_presio.AutoSize = true;
            this.lbl_presio.BackColor = System.Drawing.Color.Transparent;
            this.lbl_presio.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_presio.ForeColor = System.Drawing.Color.Black;
            this.lbl_presio.Location = new System.Drawing.Point(242, 593);
            this.lbl_presio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_presio.Name = "lbl_presio";
            this.lbl_presio.Size = new System.Drawing.Size(174, 47);
            this.lbl_presio.TabIndex = 11;
            this.lbl_presio.Text = "Precio:";
            // 
            // txt_producto
            // 
            this.txt_producto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.txt_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_producto.ForeColor = System.Drawing.Color.White;
            this.txt_producto.Location = new System.Drawing.Point(424, 40);
            this.txt_producto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_producto.Multiline = true;
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.Size = new System.Drawing.Size(975, 36);
            this.txt_producto.TabIndex = 12;
            this.txt_producto.Enter += new System.EventHandler(this.txt_producto_Enter);
            this.txt_producto.Leave += new System.EventHandler(this.txt_producto_Leave);
            this.txt_producto.Validated += new System.EventHandler(this.txt_producto_Validated);
            // 
            // txt_tipo
            // 
            this.txt_tipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.txt_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tipo.ForeColor = System.Drawing.Color.White;
            this.txt_tipo.Location = new System.Drawing.Point(424, 120);
            this.txt_tipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_tipo.Multiline = true;
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.Size = new System.Drawing.Size(975, 36);
            this.txt_tipo.TabIndex = 13;
            this.txt_tipo.Enter += new System.EventHandler(this.txt_tipo_Enter);
            this.txt_tipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tipo_KeyPress);
            this.txt_tipo.Leave += new System.EventHandler(this.txt_tipo_Leave);
            this.txt_tipo.Validated += new System.EventHandler(this.txt_tipo_Validated);
            // 
            // txt_marca
            // 
            this.txt_marca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_marca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.txt_marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_marca.ForeColor = System.Drawing.Color.White;
            this.txt_marca.Location = new System.Drawing.Point(424, 200);
            this.txt_marca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_marca.Multiline = true;
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(975, 36);
            this.txt_marca.TabIndex = 14;
            this.txt_marca.Enter += new System.EventHandler(this.txt_marca_Enter);
            this.txt_marca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_marca_KeyPress);
            this.txt_marca.Leave += new System.EventHandler(this.txt_marca_Leave);
            this.txt_marca.Validated += new System.EventHandler(this.txt_marca_Validated);
            // 
            // txt_modelo
            // 
            this.txt_modelo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_modelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.txt_modelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_modelo.ForeColor = System.Drawing.Color.White;
            this.txt_modelo.Location = new System.Drawing.Point(424, 280);
            this.txt_modelo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_modelo.Multiline = true;
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(975, 36);
            this.txt_modelo.TabIndex = 15;
            this.txt_modelo.Enter += new System.EventHandler(this.txt_modelo_Enter);
            this.txt_modelo.Leave += new System.EventHandler(this.txt_modelo_Leave);
            this.txt_modelo.Validated += new System.EventHandler(this.txt_modelo_Validated);
            // 
            // txt_descrip
            // 
            this.txt_descrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_descrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.txt_descrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descrip.ForeColor = System.Drawing.Color.White;
            this.txt_descrip.Location = new System.Drawing.Point(424, 360);
            this.txt_descrip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_descrip.Multiline = true;
            this.txt_descrip.Name = "txt_descrip";
            this.txt_descrip.Size = new System.Drawing.Size(975, 36);
            this.txt_descrip.TabIndex = 16;
            this.txt_descrip.Enter += new System.EventHandler(this.txt_descrip_Enter);
            this.txt_descrip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_descrip_KeyPress);
            this.txt_descrip.Leave += new System.EventHandler(this.txt_descrip_Leave);
            this.txt_descrip.Validated += new System.EventHandler(this.txt_descrip_Validated);
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_cantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.txt_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.ForeColor = System.Drawing.Color.White;
            this.txt_cantidad.Location = new System.Drawing.Point(424, 440);
            this.txt_cantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cantidad.Multiline = true;
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(975, 36);
            this.txt_cantidad.TabIndex = 17;
            this.txt_cantidad.Enter += new System.EventHandler(this.txt_cantidad_Enter);
            this.txt_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidad_KeyPress);
            this.txt_cantidad.Leave += new System.EventHandler(this.txt_cantidad_Leave);
            this.txt_cantidad.Validated += new System.EventHandler(this.txt_cantidad_Validated);
            // 
            // txt_costo
            // 
            this.txt_costo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_costo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.txt_costo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_costo.ForeColor = System.Drawing.Color.White;
            this.txt_costo.Location = new System.Drawing.Point(424, 520);
            this.txt_costo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_costo.Multiline = true;
            this.txt_costo.Name = "txt_costo";
            this.txt_costo.Size = new System.Drawing.Size(975, 36);
            this.txt_costo.TabIndex = 18;
            this.txt_costo.Enter += new System.EventHandler(this.txt_costo_Enter);
            this.txt_costo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_costo_KeyPress);
            this.txt_costo.Leave += new System.EventHandler(this.txt_costo_Leave);
            this.txt_costo.Validated += new System.EventHandler(this.txt_costo_Validated);
            // 
            // txt_precio
            // 
            this.txt_precio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_precio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.txt_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio.ForeColor = System.Drawing.Color.White;
            this.txt_precio.Location = new System.Drawing.Point(424, 600);
            this.txt_precio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_precio.Multiline = true;
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(975, 36);
            this.txt_precio.TabIndex = 19;
            this.txt_precio.Enter += new System.EventHandler(this.txt_precio_Enter);
            this.txt_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_KeyPress);
            this.txt_precio.Leave += new System.EventHandler(this.txt_precio_Leave);
            this.txt_precio.Validated += new System.EventHandler(this.txt_precio_Validated);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_guardar.Image = global::PdeV_Delsel.Properties.Resources.guardar_super_mini;
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(1420, 731);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(297, 54);
            this.btn_guardar.TabIndex = 1;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // panel_agregar
            // 
            this.panel_agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_agregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.panel_agregar.Location = new System.Drawing.Point(1707, 731);
            this.panel_agregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_agregar.Name = "panel_agregar";
            this.panel_agregar.Size = new System.Drawing.Size(11, 54);
            this.panel_agregar.TabIndex = 6;
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // Form_Altaproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1733, 800);
            this.Controls.Add(this.panel_agregar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.tableLayoutPanel_ContenedorGlobal);
            this.Controls.Add(this.tableLayoutPanel_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_Altaproductos";
            this.Opacity = 0.98D;
            this.Text = "Form_Altaproductos";
            this.tableLayoutPanel_Titulo.ResumeLayout(false);
            this.tableLayoutPanel_Titulo.PerformLayout();
            this.tableLayoutPanel_ContenedorGlobal.ResumeLayout(false);
            this.tableLayoutPanel_ContenedorGlobal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Titulo;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_ContenedorGlobal;
        private System.Windows.Forms.Label lbl_Producto;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label lbl_marca;
        private System.Windows.Forms.Label lbl_modelo;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Label lbl_costo;
        private System.Windows.Forms.Label lbl_presio;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Panel panel_agregar;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.TextBox txt_tipo;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.TextBox txt_modelo;
        private System.Windows.Forms.TextBox txt_descrip;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.TextBox txt_costo;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.ErrorProvider errorP;
    }
}