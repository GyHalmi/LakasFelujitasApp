using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LakasFelujitasApp
{
    
    public partial class Uj01_AlapteruletValaszto : Form
    {
        private Szoba szoba;
        public Uj01_AlapteruletValaszto()
        {
            InitializeComponent();
            btnSzabalyos.Tag = Alapterulet.Szabalyos;
            btnSzabalytalan.Tag = Alapterulet.Szabalytalan;
            btn_Click_MindenGomra();
            this.Shown += Uj01_AlapteruletValaszto_Shown;
        }

        private void Uj01_AlapteruletValaszto_Shown(object sender, EventArgs e)
        {
            szoba = Eszkozok.tagOlvaso(this);
            if (szoba != null)
            {
                txtNev.Text = szoba.Nev;
                switch (szoba.AlapteruletTipus)
                {
                    case Alapterulet.Szabalyos:
                        btnSzabalyos.Select();
                        break;
                    case Alapterulet.Szabalytalan:
                        btnSzabalytalan.Select();
                        break;
                    default:
                        break;
                }
            }

        }

        private void btn_Click_MindenGomra()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button) ctrl.Click += btn_Click;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Alapterulet szobaAlap = (Alapterulet)((Control)sender).Tag;
            szoba = new Szoba(txtNev.Text, szobaAlap);
            Form form2 = new Uj02_SzobatKeszit();
            form2.Tag = szoba;
            this.Hide();
            form2.Show();
            this.Close();
        }
    }
}
