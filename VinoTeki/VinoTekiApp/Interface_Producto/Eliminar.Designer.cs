namespace VinoTekiApp.Interface_Producto
{
    partial class Eliminar
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
            this.gbmod = new System.Windows.Forms.GroupBox();
            this.btnmod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbmod.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbmod
            // 
            this.gbmod.BackColor = System.Drawing.SystemColors.MenuBar;
            this.gbmod.Controls.Add(this.btnAceptar);
            this.gbmod.Controls.Add(this.btnmod);
            this.gbmod.Controls.Add(this.label1);
            this.gbmod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbmod.Location = new System.Drawing.Point(272, 177);
            this.gbmod.Name = "gbmod";
            this.gbmod.Size = new System.Drawing.Size(421, 198);
            this.gbmod.TabIndex = 4;
            this.gbmod.TabStop = false;
            // 
            // btnmod
            // 
            this.btnmod.Location = new System.Drawing.Point(57, 80);
            this.btnmod.Multiline = true;
            this.btnmod.Name = "btnmod";
            this.btnmod.Size = new System.Drawing.Size(297, 32);
            this.btnmod.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eliminar Producto";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Image = global::VinoTekiApp.Properties.Resources.Entypo_2713_0__48;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(57, 133);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(297, 38);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(940, 591);
            this.Controls.Add(this.gbmod);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Eliminar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar";
            this.gbmod.ResumeLayout(false);
            this.gbmod.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbmod;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox btnmod;
        private System.Windows.Forms.Label label1;
    }
}