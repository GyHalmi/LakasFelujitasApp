namespace LakasFelujitasApp
{
    partial class Form1
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
            this.btnKovetkezo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNyilasOsszfel = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.listNyilaszarok = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAlapter = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHossz = new System.Windows.Forms.TextBox();
            this.txtSzelesseg = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOsszFal = new System.Windows.Forms.TextBox();
            this.cmbSzoba = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label13 = new System.Windows.Forms.Label();
            this.numMagassag = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.chbPlafon = new System.Windows.Forms.CheckBox();
            this.chb1 = new System.Windows.Forms.CheckBox();
            this.grbSzobak = new System.Windows.Forms.GroupBox();
            this.txtFestendoFelulet = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.chbMindenSzoba = new System.Windows.Forms.CheckBox();
            this.btnElozo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMagassag)).BeginInit();
            this.grbSzobak.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKovetkezo
            // 
            this.btnKovetkezo.Location = new System.Drawing.Point(205, 12);
            this.btnKovetkezo.Name = "btnKovetkezo";
            this.btnKovetkezo.Size = new System.Drawing.Size(75, 23);
            this.btnKovetkezo.TabIndex = 0;
            this.btnKovetkezo.Tag = "+";
            this.btnKovetkezo.Text = "következő";
            this.btnKovetkezo.UseVisualStyleBackColor = true;
            this.btnKovetkezo.Click += new System.EventHandler(this.btnVisszaTovabb);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 175);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNyilasOsszfel);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.listNyilaszarok);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtAlapter);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtHossz);
            this.groupBox1.Controls.Add(this.txtSzelesseg);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtOsszFal);
            this.groupBox1.Controls.Add(this.cmbSzoba);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(165, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 345);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Szoba info";
            // 
            // txtNyilasOsszfel
            // 
            this.txtNyilasOsszfel.Location = new System.Drawing.Point(146, 264);
            this.txtNyilasOsszfel.Name = "txtNyilasOsszfel";
            this.txtNyilasOsszfel.Size = new System.Drawing.Size(100, 20);
            this.txtNyilasOsszfel.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 267);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "nyílászárók összfelülete";
            // 
            // listNyilaszarok
            // 
            this.listNyilaszarok.FormattingEnabled = true;
            this.listNyilaszarok.Location = new System.Drawing.Point(146, 161);
            this.listNyilaszarok.Name = "listNyilaszarok";
            this.listNyilaszarok.Size = new System.Drawing.Size(100, 95);
            this.listNyilaszarok.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "nyílászárók";
            // 
            // txtAlapter
            // 
            this.txtAlapter.Location = new System.Drawing.Point(146, 105);
            this.txtAlapter.Name = "txtAlapter";
            this.txtAlapter.Size = new System.Drawing.Size(100, 20);
            this.txtAlapter.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "alapterület";
            // 
            // txtHossz
            // 
            this.txtHossz.Location = new System.Drawing.Point(146, 78);
            this.txtHossz.Name = "txtHossz";
            this.txtHossz.Size = new System.Drawing.Size(100, 20);
            this.txtHossz.TabIndex = 12;
            // 
            // txtSzelesseg
            // 
            this.txtSzelesseg.Location = new System.Drawing.Point(146, 51);
            this.txtSzelesseg.Name = "txtSzelesseg";
            this.txtSzelesseg.Size = new System.Drawing.Size(100, 20);
            this.txtSzelesseg.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "hossz:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "szélesség:";
            // 
            // txtOsszFal
            // 
            this.txtOsszFal.Location = new System.Drawing.Point(146, 132);
            this.txtOsszFal.Name = "txtOsszFal";
            this.txtOsszFal.Size = new System.Drawing.Size(100, 20);
            this.txtOsszFal.TabIndex = 7;
            // 
            // cmbSzoba
            // 
            this.cmbSzoba.FormattingEnabled = true;
            this.cmbSzoba.Location = new System.Drawing.Point(125, 24);
            this.cmbSzoba.Name = "cmbSzoba";
            this.cmbSzoba.Size = new System.Drawing.Size(121, 21);
            this.cmbSzoba.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "össz falfelület:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "szoba: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(668, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "cm";
            // 
            // numMagassag
            // 
            this.numMagassag.Location = new System.Drawing.Point(593, 46);
            this.numMagassag.Name = "numMagassag";
            this.numMagassag.Size = new System.Drawing.Size(69, 20);
            this.numMagassag.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(468, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "színezett magasság:";
            // 
            // chbPlafon
            // 
            this.chbPlafon.AutoSize = true;
            this.chbPlafon.Location = new System.Drawing.Point(566, 101);
            this.chbPlafon.Name = "chbPlafon";
            this.chbPlafon.Size = new System.Drawing.Size(101, 17);
            this.chbPlafon.TabIndex = 26;
            this.chbPlafon.Text = "plafonnal együtt";
            this.chbPlafon.UseVisualStyleBackColor = true;
            this.chbPlafon.CheckedChanged += new System.EventHandler(this.chbPlafon_CheckedChanged);
            // 
            // chb1
            // 
            this.chb1.AutoSize = true;
            this.chb1.Location = new System.Drawing.Point(6, 27);
            this.chb1.Name = "chb1";
            this.chb1.Size = new System.Drawing.Size(50, 17);
            this.chb1.TabIndex = 29;
            this.chb1.Text = "chb1";
            this.chb1.UseVisualStyleBackColor = true;
            // 
            // grbSzobak
            // 
            this.grbSzobak.Controls.Add(this.chb1);
            this.grbSzobak.Location = new System.Drawing.Point(455, 142);
            this.grbSzobak.Name = "grbSzobak";
            this.grbSzobak.Size = new System.Drawing.Size(412, 72);
            this.grbSzobak.TabIndex = 30;
            this.grbSzobak.TabStop = false;
            this.grbSzobak.Text = "Festendő szobák";
            // 
            // txtFestendoFelulet
            // 
            this.txtFestendoFelulet.Location = new System.Drawing.Point(593, 72);
            this.txtFestendoFelulet.Name = "txtFestendoFelulet";
            this.txtFestendoFelulet.Size = new System.Drawing.Size(100, 20);
            this.txtFestendoFelulet.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(468, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "színezett falfelület";
            // 
            // chbMindenSzoba
            // 
            this.chbMindenSzoba.AutoSize = true;
            this.chbMindenSzoba.Location = new System.Drawing.Point(469, 101);
            this.chbMindenSzoba.Name = "chbMindenSzoba";
            this.chbMindenSzoba.Size = new System.Drawing.Size(91, 17);
            this.chbMindenSzoba.TabIndex = 31;
            this.chbMindenSzoba.Text = "minden szoba";
            this.chbMindenSzoba.UseVisualStyleBackColor = true;
            this.chbMindenSzoba.CheckedChanged += new System.EventHandler(this.chbMindenSzoba_CheckedChanged);
            // 
            // btnElozo
            // 
            this.btnElozo.Location = new System.Drawing.Point(114, 11);
            this.btnElozo.Name = "btnElozo";
            this.btnElozo.Size = new System.Drawing.Size(75, 23);
            this.btnElozo.TabIndex = 32;
            this.btnElozo.Tag = "-";
            this.btnElozo.Text = "előző";
            this.btnElozo.UseVisualStyleBackColor = true;
            this.btnElozo.Click += new System.EventHandler(this.btnVisszaTovabb);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 498);
            this.Controls.Add(this.btnElozo);
            this.Controls.Add(this.chbMindenSzoba);
            this.Controls.Add(this.grbSzobak);
            this.Controls.Add(this.chbPlafon);
            this.Controls.Add(this.txtFestendoFelulet);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.numMagassag);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnKovetkezo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMagassag)).EndInit();
            this.grbSzobak.ResumeLayout(false);
            this.grbSzobak.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKovetkezo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmbSzoba;
        private System.Windows.Forms.TextBox txtOsszFal;
        private System.Windows.Forms.TextBox txtAlapter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHossz;
        private System.Windows.Forms.TextBox txtSzelesseg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listNyilaszarok;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNyilasOsszfel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numMagassag;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox chbPlafon;
        private System.Windows.Forms.CheckBox chb1;
        private System.Windows.Forms.GroupBox grbSzobak;
        private System.Windows.Forms.TextBox txtFestendoFelulet;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox chbMindenSzoba;
        private System.Windows.Forms.Button btnElozo;
    }
}

