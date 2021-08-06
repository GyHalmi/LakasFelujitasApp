namespace LakasFelujitasApp
{
    partial class AlapteruletValaszto
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSzabalyos
            // 
            this.btnSzabalyos.Image = global::LakasFelujitasApp.Properties.Resources.szabalyos;
            this.btnSzabalyos.Location = new System.Drawing.Point(47, 117);
            this.btnSzabalyos.Name = "btnSzabalyos";
            this.btnSzabalyos.Size = new System.Drawing.Size(184, 156);
            this.btnSzabalyos.TabIndex = 0;
            this.btnSzabalyos.UseVisualStyleBackColor = true;
            // 
            // btnSzabalytalan
            // 
            this.btnSzabalytalan.Image = global::LakasFelujitasApp.Properties.Resources.szabalytalan;
            this.btnSzabalytalan.Location = new System.Drawing.Point(292, 117);
            this.btnSzabalytalan.Name = "btnSzabalytalan";
            this.btnSzabalytalan.Size = new System.Drawing.Size(184, 156);
            this.btnSzabalytalan.TabIndex = 1;
            this.btnSzabalytalan.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(143, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Válassz alapterület formát";
            // 
            // AlapteruletValaszto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 331);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSzabalytalan);
            this.Controls.Add(this.btnSzabalyos);
            this.Name = "AlapteruletValaszto";
            this.Text = "AlapteruletValaszto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSzabalyos;
        private System.Windows.Forms.Button btnSzabalytalan;
        private System.Windows.Forms.Label label1;
    }
}