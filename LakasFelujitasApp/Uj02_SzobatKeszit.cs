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
    public partial class Uj02_SzobatKeszit : Form
    {
        private Szoba szoba;
        public Uj02_SzobatKeszit()
        {
            InitializeComponent();
            this.Shown += Uj02_SzobatKeszit_Shown;
        }

        private void Uj02_SzobatKeszit_Shown(Object sender, EventArgs e)
        {
            szoba = Eszkozok.tagOlvaso(this);
            switch (szoba.AlapteruletTipus)
            {
                case Alapterulet.Szabalyos:
                    {
                        pictureBox1.Image = Properties.Resources.szabalyos_meretezve;
                        this.panelKieso.Visible = false;
                    }
                    break;
                case Alapterulet.Szabalytalan:
                    {
                        pictureBox1.Image = Properties.Resources.szabalytalan_meretezve;
                    }
                    break;
                default:
                    break;
            }
            if (szoba.Szelesseg > 0)
            {
                txtSzelesseg.Text = szoba.Szelesseg.ToString();
                txtHosszusag.Text = szoba.Hossz + "";
                txtMagassag.Text = szoba.FesthetoMagassag.ToString();
                txtKiesoSzelesseg.Text = szoba.KiesoSzelesseg.ToString();
                txtKiesoHosszusag.Text = szoba.KiesoHossz.ToString();
            }
            this.Focus();

        }

        private void btnSzobaMeretezve_Click(object sender, EventArgs e)
        {
            szoba.meretekMegadasa(txtSzelesseg, txtHosszusag, txtKiesoSzelesseg, txtKiesoHosszusag, txtMagassag);

            Uj03_FalakNyilaszarok form3 = new Uj03_FalakNyilaszarok();
            form3.Tag = szoba;
            this.Close();
            form3.Show();
        }

        private void btnVissza_Click(object sender, EventArgs e)
        {
            Uj01_AlapteruletValaszto form1 = new Uj01_AlapteruletValaszto();
            form1.Tag = szoba;
            this.Close();
            form1.Show();
        }
    }
}
