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
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(325, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(118, 29);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Producto";
            // 
            // lbl_nombreP
            // 
            this.lbl_nombreP.AutoSize = true;
            this.lbl_nombreP.Location = new System.Drawing.Point(58, 113);
            this.lbl_nombreP.Name = "lbl_nombreP";
            this.lbl_nombreP.Size = new System.Drawing.Size(50, 13);
            this.lbl_nombreP.TabIndex = 1;
            this.lbl_nombreP.Text = "Nombre: ";
            // 
            // lbl_cantidadP
            // 
            this.lbl_cantidadP.AutoSize = true;
            this.lbl_cantidadP.Location = new System.Drawing.Point(56, 170);
            this.lbl_cantidadP.Name = "lbl_cantidadP";
            this.lbl_cantidadP.Size = new System.Drawing.Size(52, 13);
            this.lbl_cantidadP.TabIndex = 2;
            this.lbl_cantidadP.Text = "Cantidad:";
            // 
            // lbl_precioP
            // 
            this.lbl_precioP.AutoSize = true;
            this.lbl_precioP.Location = new System.Drawing.Point(58, 221);
            this.lbl_precioP.Name = "lbl_precioP";
            this.lbl_precioP.Size = new System.Drawing.Size(40, 13);
            this.lbl_precioP.TabIndex = 3;
            this.lbl_precioP.Text = "Precio:";
            // 
            // lbl_costoP
            // 
            this.lbl_costoP.AutoSize = true;
            this.lbl_costoP.Location = new System.Drawing.Point(56, 284);
            this.lbl_costoP.Name = "lbl_costoP";
            this.lbl_costoP.Size = new System.Drawing.Size(37, 13);
            this.lbl_costoP.TabIndex = 4;
            this.lbl_costoP.Text = "Costo:";
            // 
            // comboBox_consultaP
            // 
            this.comboBox_consultaP.FormattingEnabled = true;
            this.comboBox_consultaP.Location = new System.Drawing.Point(641, 135);
            this.comboBox_consultaP.Name = "comboBox_consultaP";
            this.comboBox_consultaP.Size = new System.Drawing.Size(121, 21);
            this.comboBox_consultaP.TabIndex = 5;
            // 
            // lbl_consultaP
            // 
            this.lbl_consultaP.AutoSize = true;
            this.lbl_consultaP.Location = new System.Drawing.Point(638, 113);
            this.lbl_consultaP.Name = "lbl_consultaP";
            this.lbl_consultaP.Size = new System.Drawing.Size(114, 13);
            this.lbl_consultaP.TabIndex = 6;
            this.lbl_consultaP.Text = "Consulta de Productos";
            // 
            // btn_modificar
            // 
            this.btn_modificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_modificar.Location = new System.Drawing.Point(1213, 615);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 7;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_guardar.Location = new System.Drawing.Point(12, 615);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 8;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // Form_Altaproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.lbl_consultaP);
            this.Controls.Add(this.comboBox_consultaP);
            this.Controls.Add(this.lbl_costoP);
            this.Controls.Add(this.lbl_precioP);
            this.Controls.Add(this.lbl_cantidadP);
            this.Controls.Add(this.lbl_nombreP);
            this.Controls.Add(this.lbl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Altaproductos";
            this.Text = "Form_Altaproductos";
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
    }
}