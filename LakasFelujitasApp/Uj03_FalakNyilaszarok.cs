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
    public partial class Uj03_FalakNyilaszarok : Form
    {
        private Szoba szoba;
        private List<Button> falgombok;
        private Color szines;
        public Uj03_FalakNyilaszarok()
        {
            InitializeComponent();
            szines = Color.Red;
            button1.ForeColor = szines;
            this.Shown += Uj03_FalakNyilaszarok_Shown;
            falgombLista();
            falGombEventek();

        }

        private void falgombLista()
        {
            falgombok = new List<Button>();
            foreach (Control ctrl in panelFalGombok.Controls)
            {
                if (ctrl is Button) falgombok.Add((Button)ctrl);
            }
        }

        private void falGombEventek()
        {
            foreach (Button btn in falgombok)
            {
                btn.Click += falvalasztas;
            }
        }

        private void Uj03_FalakNyilaszarok_Shown(Object sender, EventArgs e)
        {
            szoba = Eszkozok.tagOlvaso(this);
            switch (szoba.AlapteruletTipus)
            {
                case Alapterulet.Szabalyos:
                    {
                        pictureBox1.Image = Properties.Resources.szabalyos_szamozva;
                        button5.Visible = false;
                        button6.Visible = false;
                        button3.Location = new Point(button1.Location.X, button3.Location.Y);
                        button4.Location = new Point(button5.Location.X, button2.Location.Y);
                    }
                    break;
                case Alapterulet.Szabalytalan:
                    {
                        pictureBox1.Image = Properties.Resources.szabalytalan_szamozva;
                    }
                    break;
                default:
                    break;
            }
        }

        private void falvalasztas(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.ForeColor != szines)
            {
                foreach (Button b in falgombok)
                {
                    b.ForeColor = Color.Black;
                }
                btn.ForeColor = szines;
            }
            else
            {
                btn.ForeColor = Color.Black;
            }

            nyilaszarokatListaz();
            this.Focus();
        }

        private void btnKesz_Click(object sender, EventArgs e)
        {
            Szoba.szobaKesz(szoba);
            this.Close();
        }

        private void btnKovetkezoSzoba_Click(object sender, EventArgs e)
        {
            Szoba.szobaKesz(szoba);
            this.Close();
            new Uj01_AlapteruletValaszto().Show();
        }

        private void btnHozzaad_Click(object sender, EventArgs e)
        {
            kivalasztottFal().nyilaszarotHozzaad(txtSzelesseg, txtMagassag, txtBeepMag);
            nyilaszarokatListaz();
        }

        private Fal kivalasztottFal()
        {
            int ind = 0;
            foreach (Button b in falgombok)
            {
                if (b.ForeColor == szines) ind = int.Parse(b.Text) - 1;
            }
            return szoba.Falak[ind];
        }

        private void btnVissza_Click(object sender, EventArgs e)
        {
            Uj02_SzobatKeszit form2 = new Uj02_SzobatKeszit();
            szoba.nyilaszarokTorles();
            form2.Tag = szoba;
            form2.Show();
            this.Close();
        }

        private void nyilaszarokatListaz()
        {
            listBox1.Items.Clear();
            foreach (Nyilaszaro ny in kivalasztottFal().Nyilaszarok)
            {
                listBox1.Items.Add(ny);
            }
        }

        private void btnNyilasTorles_Click(object sender, EventArgs e)
        {
            kivalasztottFal().Nyilaszarok.RemoveAt(listBox1.SelectedIndex);
            nyilaszarokatListaz();
        }


    }
}