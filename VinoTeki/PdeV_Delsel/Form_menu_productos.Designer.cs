namespace PdeV_Delsel
{
    partial class Form_menu_productos
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
            this.panel_opciones = new System.Windows.Forms.Panel();
            this.panel_opcionestop = new System.Windows.Forms.Panel();
            this.panel_contenedor = new System.Windows.Forms.Panel();
            this.btn_menuboton = new System.Windows.Forms.Button();
            this.btn_restaurar = new System.Windows.Forms.Button();
            this.btn_minimisar = new System.Windows.Forms.Button();
            this.btn_maximisar = new System.Windows.Forms.Button();
            this.panel_opcionestop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_opciones
            // 
            this.panel_opciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel_opciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_opciones.Location = new System.Drawing.Point(0, 0);
            this.panel_opciones.Name = "panel_opciones";
            this.panel_opciones.Size = new System.Drawing.Size(250, 650);
            this.panel_opciones.TabIndex = 2;
            // 
            // panel_opcionestop
            // 
            this.panel_opcionestop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.panel_opcionestop.Controls.Add(this.btn_menuboton);
            this.panel_opcionestop.Controls.Add(this.btn_restaurar);
            this.panel_opcionestop.Controls.Add(this.btn_minimisar);
            this.panel_opcionestop.Controls.Add(this.btn_maximisar);
            this.panel_opcionestop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_opcionestop.Location = new System.Drawing.Point(250, 0);
            this.panel_opcionestop.Name = "panel_opcionestop";
            this.panel_opcionestop.Size = new System.Drawing.Size(1050, 38);
            this.panel_opcionestop.TabIndex = 3;
            // 
            // panel_contenedor
            // 
            this.panel_contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.panel_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenedor.Location = new System.Drawing.Point(250, 38);
            this.panel_contenedor.Name = "panel_contenedor";
            this.panel_contenedor.Size = new System.Drawing.Size(1050, 612);
            this.panel_contenedor.TabIndex = 4;
            // 
            // btn_menuboton
            // 
            this.btn_menuboton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_menuboton.BackgroundImage = global::PdeV_Delsel.Properties.Resources.botonmenu;
            this.btn_menuboton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_menuboton.FlatAppearance.BorderSize = 0;
            this.btn_menuboton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btn_menuboton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.btn_menuboton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menuboton.Location = new System.Drawing.Point(6, 7);
            this.btn_menuboton.Name = "btn_menuboton";
            this.btn_menuboton.Size = new System.Drawing.Size(25, 25);
            this.btn_menuboton.TabIndex = 6;
            this.btn_menuboton.UseVisualStyleBackColor = true;
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
            this.btn_restaurar.Location = new System.Drawing.Point(1013, 7);
            this.btn_restaurar.Name = "btn_restaurar";
            this.btn_restaurar.Size = new System.Drawing.Size(25, 25);
            this.btn_restaurar.TabIndex = 4;
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
            this.btn_minimisar.Location = new System.Drawing.Point(982, 7);
            this.btn_minimisar.Name = "btn_minimisar";
            this.btn_minimisar.Size = new System.Drawing.Size(25, 25);
            this.btn_minimisar.TabIndex = 5;
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
            this.btn_maximisar.Location = new System.Drawing.Point(1013, 7);
            this.btn_maximisar.Name = "btn_maximisar";
            this.btn_maximisar.Size = new System.Drawing.Size(25, 25);
            this.btn_maximisar.TabIndex = 3;
            this.btn_maximisar.UseVisualStyleBackColor = true;
            this.btn_maximisar.Click += new System.EventHandler(this.btn_maximisar_Click);
            // 
            // Form_menu_productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panel_contenedor);
            this.Controls.Add(this.panel_opcionestop);
            this.Controls.Add(this.panel_opciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_menu_productos";
            this.Text = "Form_menu_productos";
            this.panel_opcionestop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_opciones;
        private System.Windows.Forms.Panel panel_opcionestop;
        private System.Windows.Forms.Panel panel_contenedor;
        private System.Windows.Forms.Button btn_minimisar;
        private System.Windows.Forms.Button btn_restaurar;
        private System.Windows.Forms.Button btn_maximisar;
        private System.Windows.Forms.Button btn_menuboton;
    }
}