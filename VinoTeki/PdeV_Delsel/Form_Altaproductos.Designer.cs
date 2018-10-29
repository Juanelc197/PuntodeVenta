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
            this.btn_guardar = new System.Windows.Forms.Button();
            this.panel_agregar = new System.Windows.Forms.Panel();
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
            this.tableLayoutPanel_Titulo.TabIndex = 1;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Lithos Pro Regular", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.Black;
            this.lbl_titulo.Location = new System.Drawing.Point(427, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(446, 62);
            this.lbl_titulo.TabIndex = 2;
            this.lbl_titulo.Text = "Alta Producto";
            // 
            // tableLayoutPanel_ContenedorGlobal
            // 
            this.tableLayoutPanel_ContenedorGlobal.ColumnCount = 3;
            this.tableLayoutPanel_ContenedorGlobal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.23077F));
            this.tableLayoutPanel_ContenedorGlobal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.69231F));
            this.tableLayoutPanel_ContenedorGlobal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.tableLayoutPanel_ContenedorGlobal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_ContenedorGlobal.Controls.Add(this.lbl_Producto, 0, 0);
            this.tableLayoutPanel_ContenedorGlobal.Controls.Add(this.lbl_tipo, 0, 1);
            this.tableLayoutPanel_ContenedorGlobal.Controls.Add(this.lbl_marca, 0, 2);
            this.tableLayoutPanel_ContenedorGlobal.Controls.Add(this.lbl_modelo, 0, 3);
            this.tableLayoutPanel_ContenedorGlobal.Controls.Add(this.lbl_descripcion, 0, 4);
            this.tableLayoutPanel_ContenedorGlobal.Controls.Add(this.lbl_cantidad, 0, 5);
            this.tableLayoutPanel_ContenedorGlobal.Controls.Add(this.lbl_costo, 0, 6);
            this.tableLayoutPanel_ContenedorGlobal.Controls.Add(this.lbl_presio, 0, 7);
            this.tableLayoutPanel_ContenedorGlobal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_ContenedorGlobal.Location = new System.Drawing.Point(0, 62);
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
            this.tableLayoutPanel_ContenedorGlobal.Size = new System.Drawing.Size(1300, 588);
            this.tableLayoutPanel_ContenedorGlobal.TabIndex = 4;
            // 
            // lbl_Producto
            // 
            this.lbl_Producto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Producto.AutoSize = true;
            this.lbl_Producto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Producto.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Producto.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Producto.Location = new System.Drawing.Point(133, 28);
            this.lbl_Producto.Name = "lbl_Producto";
            this.lbl_Producto.Size = new System.Drawing.Size(179, 37);
            this.lbl_Producto.TabIndex = 4;
            this.lbl_Producto.Text = "Producto:";
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tipo.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_tipo.Location = new System.Drawing.Point(205, 93);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(107, 37);
            this.lbl_tipo.TabIndex = 5;
            this.lbl_tipo.Text = "Tipo:";
            // 
            // lbl_marca
            // 
            this.lbl_marca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.BackColor = System.Drawing.Color.Transparent;
            this.lbl_marca.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_marca.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_marca.Location = new System.Drawing.Point(187, 158);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(125, 37);
            this.lbl_marca.TabIndex = 6;
            this.lbl_marca.Text = "Marca:";
            // 
            // lbl_modelo
            // 
            this.lbl_modelo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_modelo.AutoSize = true;
            this.lbl_modelo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_modelo.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_modelo.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_modelo.Location = new System.Drawing.Point(169, 223);
            this.lbl_modelo.Name = "lbl_modelo";
            this.lbl_modelo.Size = new System.Drawing.Size(143, 37);
            this.lbl_modelo.TabIndex = 7;
            this.lbl_modelo.Text = "Modelo:";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_descripcion.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_descripcion.Location = new System.Drawing.Point(79, 288);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(233, 37);
            this.lbl_descripcion.TabIndex = 8;
            this.lbl_descripcion.Text = "Descripción:";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cantidad.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_cantidad.Location = new System.Drawing.Point(133, 353);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(179, 37);
            this.lbl_cantidad.TabIndex = 9;
            this.lbl_cantidad.Text = "Cantidad:";
            // 
            // lbl_costo
            // 
            this.lbl_costo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_costo.AutoSize = true;
            this.lbl_costo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_costo.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_costo.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_costo.Location = new System.Drawing.Point(187, 418);
            this.lbl_costo.Name = "lbl_costo";
            this.lbl_costo.Size = new System.Drawing.Size(125, 37);
            this.lbl_costo.TabIndex = 10;
            this.lbl_costo.Text = "Costo:";
            // 
            // lbl_presio
            // 
            this.lbl_presio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_presio.AutoSize = true;
            this.lbl_presio.BackColor = System.Drawing.Color.Transparent;
            this.lbl_presio.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_presio.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_presio.Location = new System.Drawing.Point(169, 483);
            this.lbl_presio.Name = "lbl_presio";
            this.lbl_presio.Size = new System.Drawing.Size(143, 37);
            this.lbl_presio.TabIndex = 11;
            this.lbl_presio.Text = "Precio:";
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
            this.btn_guardar.Location = new System.Drawing.Point(1065, 594);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(223, 44);
            this.btn_guardar.TabIndex = 1;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // panel_agregar
            // 
            this.panel_agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_agregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.panel_agregar.Location = new System.Drawing.Point(1280, 594);
            this.panel_agregar.Name = "panel_agregar";
            this.panel_agregar.Size = new System.Drawing.Size(8, 44);
            this.panel_agregar.TabIndex = 6;
            // 
            // Form_Altaproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panel_agregar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.tableLayoutPanel_ContenedorGlobal);
            this.Controls.Add(this.tableLayoutPanel_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Altaproductos";
            this.Text = "Form_Altaproductos";
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
    }
}