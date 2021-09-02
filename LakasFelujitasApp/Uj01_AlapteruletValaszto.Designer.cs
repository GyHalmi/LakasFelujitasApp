namespace LakasFelujitasApp
{
    partial class Uj01_AlapteruletValaszto
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
            this.btnSzabalyos = new System.Windows.Forms.Button();
            this.btnSzabalytalan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNev = new System.Windows.Forms.TextBox();
            this.btnTovabb = new System.Windows.Forms.Button();
            this.gbAlapterulet = new System.Windows.Forms.GroupBox();
            this.gbAlapterulet.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSzabalyos
            // 
            this.btnSzabalyos.Image = global::LakasFelujitasApp.Properties.Resources.szabalyos_sima;
            this.btnSzabalyos.Location = new System.Drawing.Point(37, 37);
            this.btnSzabalyos.Name = "btnSzabalyos";
            this.btnSzabalyos.Size = new System.Drawing.Size(184, 156);
            this.btnSzabalyos.TabIndex = 0;
            this.btnSzabalyos.UseVisualStyleBackColor = true;
            // 
            // btnSzabalytalan
            // 
            this.btnSzabalytalan.Image = global::LakasFelujitasApp.Properties.Resources.szabalytalan_sima;
            this.btnSzabalytalan.Location = new System.Drawing.Point(277, 37);
            this.btnSzabalytalan.Name = "btnSzabalytalan";
            this.btnSzabalytalan.Size = new System.Drawing.Size(184, 156);
            this.btnSzabalytalan.TabIndex = 1;
            this.btnSzabalytalan.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Helyiség neve";
            // 
            // txtNev
            // 
            this.txtNev.Location = new System.Drawing.Point(158, 21);
            this.txtNev.Name = "txtNev";
            this.txtNev.Size = new System.Drawing.Size(192, 20);
            this.txtNev.TabIndex = 4;
            // 
            // btnTovabb
            // 
            this.btnTovabb.Location = new System.Drawing.Point(223, 313);
            this.btnTovabb.Name = "btnTovabb";
            this.btnTovabb.Size = new System.Drawing.Size(75, 23);
            this.btnTovabb.TabIndex = 5;
            this.btnTovabb.Text = "Tovább";
            this.btnTovabb.UseVisualStyleBackColor = true;
            this.btnTovabb.Click += new System.EventHandler(this.btnTovabb_Click);
            // 
            // gbAlapterulet
            // 
            this.gbAlapterulet.Controls.Add(this.btnSzabalyos);
            this.gbAlapterulet.Controls.Add(this.btnSzabalytalan);
            this.gbAlapterulet.Location = new System.Drawing.Point(12, 78);
            this.gbAlapterulet.Name = "gbAlapterulet";
            this.gbAlapterulet.Size = new System.Drawing.Size(499, 213);
            this.gbAlapterulet.TabIndex = 6;
            this.gbAlapterulet.TabStop = false;
            this.gbAlapterulet.Text = "Alapterület típusa";
            // 
            // Uj01_AlapteruletValaszto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 366);
            this.Controls.Add(this.gbAlapterulet);
            this.Controls.Add(this.btnTovabb);
            this.Controls.Add(this.txtNev);
            this.Controls.Add(this.label2);
            this.Name = "Uj01_AlapteruletValaszto";
            this.Text = "AlapteruletValaszto";
            this.gbAlapterulet.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSzabalyos;
        private System.Windows.Forms.Button btnSzabalytalan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNev;
        private System.Windows.Forms.Button btnTovabb;
        private System.Windows.Forms.GroupBox gbAlapterulet;
    }
}