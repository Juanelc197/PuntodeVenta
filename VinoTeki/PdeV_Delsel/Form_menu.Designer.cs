namespace PdeV_Delsel
{
    partial class Form_menu
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
            this.panel_barraT = new System.Windows.Forms.Panel();
            this.panel_Contenedor = new System.Windows.Forms.Panel();
            this.btn_minimisar = new System.Windows.Forms.Button();
            this.btn_maximisar = new System.Windows.Forms.Button();
            this.btn_restaurar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.panel_barraT.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_barraT
            // 
            this.panel_barraT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(162)))), ((int)(((byte)(2)))));
            this.panel_barraT.Controls.Add(this.btn_restaurar);
            this.panel_barraT.Controls.Add(this.btn_minimisar);
            this.panel_barraT.Controls.Add(this.btn_maximisar);
            this.panel_barraT.Controls.Add(this.btn_cerrar);
            this.panel_barraT.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_barraT.Location = new System.Drawing.Point(0, 0);
            this.panel_barraT.Name = "panel_barraT";
            this.panel_barraT.Size = new System.Drawing.Size(1300, 38);
            this.panel_barraT.TabIndex = 0;
            this.panel_barraT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_barraT_MouseDown);
            // 
            // panel_Contenedor
            // 
            this.panel_Contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.panel_Contenedor.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Contenedor.Location = new System.Drawing.Point(0, 38);
            this.panel_Contenedor.Name = "panel_Contenedor";
            this.panel_Contenedor.Size = new System.Drawing.Size(1300, 612);
            this.panel_Contenedor.TabIndex = 1;
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
            this.btn_minimisar.Location = new System.Drawing.Point(1201, 7);
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
            this.btn_maximisar.Location = new System.Drawing.Point(1232, 7);
            this.btn_maximisar.Name = "btn_maximisar";
            this.btn_maximisar.Size = new System.Drawing.Size(25, 25);
            this.btn_maximisar.TabIndex = 2;
            this.btn_maximisar.UseVisualStyleBackColor = true;
            this.btn_maximisar.Click += new System.EventHandler(this.btn_maximisar_Click);
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
            this.btn_restaurar.Location = new System.Drawing.Point(1232, 7);
            this.btn_restaurar.Name = "btn_restaurar";
            this.btn_restaurar.Size = new System.Drawing.Size(25, 25);
            this.btn_restaurar.TabIndex = 1;
            this.btn_restaurar.UseVisualStyleBackColor = true;
            this.btn_restaurar.Visible = false;
            this.btn_restaurar.Click += new System.EventHandler(this.btn_restaurar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar.BackgroundImage = global::PdeV_Delsel.Properties.Resources.x;
            this.btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Location = new System.Drawing.Point(1263, 7);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(25, 25);
            this.btn_cerrar.TabIndex = 0;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // Form_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panel_Contenedor);
            this.Controls.Add(this.panel_barraT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_menu";
            this.Opacity = 0.98D;
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.Form_menu_Load);
            this.panel_barraT.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_barraT;
        private System.Windows.Forms.Panel panel_Contenedor;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_restaurar;
        private System.Windows.Forms.Button btn_maximisar;
        private System.Windows.Forms.Button btn_minimisar;
    }
}

