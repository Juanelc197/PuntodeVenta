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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_nombreP = new System.Windows.Forms.Label();
            this.lbl_cantidadP = new System.Windows.Forms.Label();
            this.lbl_precioP = new System.Windows.Forms.Label();
            this.lbl_costoP = new System.Windows.Forms.Label();
            this.comboBox_consultaP = new System.Windows.Forms.ComboBox();
            this.lbl_consultaP = new System.Windows.Forms.Label();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.txt_costo = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(485, 99);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(118, 29);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Producto";
            // 
            // lbl_nombreP
            // 
            this.lbl_nombreP.AutoSize = true;
            this.lbl_nombreP.Location = new System.Drawing.Point(3, 62);
            this.lbl_nombreP.Name = "lbl_nombreP";
            this.lbl_nombreP.Size = new System.Drawing.Size(50, 13);
            this.lbl_nombreP.TabIndex = 1;
            this.lbl_nombreP.Text = "Nombre: ";
            // 
            // lbl_cantidadP
            // 
            this.lbl_cantidadP.AutoSize = true;
            this.lbl_cantidadP.Location = new System.Drawing.Point(3, 124);
            this.lbl_cantidadP.Name = "lbl_cantidadP";
            this.lbl_cantidadP.Size = new System.Drawing.Size(52, 13);
            this.lbl_cantidadP.TabIndex = 2;
            this.lbl_cantidadP.Text = "Cantidad:";
            // 
            // lbl_precioP
            // 
            this.lbl_precioP.AutoSize = true;
            this.lbl_precioP.Location = new System.Drawing.Point(3, 198);
            this.lbl_precioP.Name = "lbl_precioP";
            this.lbl_precioP.Size = new System.Drawing.Size(40, 13);
            this.lbl_precioP.TabIndex = 3;
            this.lbl_precioP.Text = "Precio:";
            // 
            // lbl_costoP
            // 
            this.lbl_costoP.AutoSize = true;
            this.lbl_costoP.Location = new System.Drawing.Point(3, 161);
            this.lbl_costoP.Name = "lbl_costoP";
            this.lbl_costoP.Size = new System.Drawing.Size(37, 13);
            this.lbl_costoP.TabIndex = 4;
            this.lbl_costoP.Text = "Costo:";
            // 
            // comboBox_consultaP
            // 
            this.comboBox_consultaP.FormattingEnabled = true;
            this.comboBox_consultaP.Location = new System.Drawing.Point(1090, 201);
            this.comboBox_consultaP.Name = "comboBox_consultaP";
            this.comboBox_consultaP.Size = new System.Drawing.Size(121, 21);
            this.comboBox_consultaP.TabIndex = 5;
            // 
            // lbl_consultaP
            // 
            this.lbl_consultaP.AutoSize = true;
            this.lbl_consultaP.Location = new System.Drawing.Point(1090, 161);
            this.lbl_consultaP.Name = "lbl_consultaP";
            this.lbl_consultaP.Size = new System.Drawing.Size(114, 13);
            this.lbl_consultaP.TabIndex = 6;
            this.lbl_consultaP.Text = "Consulta de Productos";
            // 
            // btn_modificar
            // 
            this.btn_modificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_modificar.Location = new System.Drawing.Point(1198, 409);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 7;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_guardar.Location = new System.Drawing.Point(3, 409);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 8;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.910156F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.08984F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.tableLayoutPanel1.Controls.Add(this.comboBox_consultaP, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_consultaP, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_modificar, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.txt_precio, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_costo, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_cantidad, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_guardar, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbl_nombreP, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_cantidadP, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_nombre, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_costoP, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_precioP, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 203);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1276, 435);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(84, 65);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 5;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(84, 127);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(100, 20);
            this.txt_cantidad.TabIndex = 13;
            // 
            // txt_costo
            // 
            this.txt_costo.Location = new System.Drawing.Point(84, 164);
            this.txt_costo.Name = "txt_costo";
            this.txt_costo.Size = new System.Drawing.Size(100, 20);
            this.txt_costo.TabIndex = 13;
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(84, 201);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(100, 20);
            this.txt_precio.TabIndex = 13;
            // 
            // Form_Altaproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Altaproductos";
            this.Text = "Form_Altaproductos";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_nombreP;
        private System.Windows.Forms.Label lbl_cantidadP;
        private System.Windows.Forms.Label lbl_precioP;
        private System.Windows.Forms.Label lbl_costoP;
        private System.Windows.Forms.ComboBox comboBox_consultaP;
        private System.Windows.Forms.Label lbl_consultaP;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_costo;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.TextBox txt_nombre;
    }
}