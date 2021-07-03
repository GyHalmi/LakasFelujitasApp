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
    public partial class Form1 : Form
    {
        private Graphics vaszon;

        public Form1()
        {
            InitializeComponent();
            szobakatLetrehoz();
            szobaCheckBoxok();
            listakatFeltolt();
            pictureBox1.BackColor = Color.White;
            numMagassag.Maximum = 300;
            numTobbSzobaMagassag.Maximum = 300;
            numTobbSzobaMagassag.Value = 245;
            //numMagassag.Value = 200;
            cmbSzoba.SelectedIndexChanged += cmbSzoba_SelectedIndexChanged;
            numMagassag.ValueChanged += numMagassag_ValueChanged;
            numTobbSzobaMagassag.ValueChanged += numTobbSzoba_ValueChanged;
            //szobaKiiras(Szoba.mindenSzoba[0]);
            cmbSzoba.SelectedIndex = 0;
            MessageBox.Show("plafonfestés nem követi le a falak kiválasztását" +
                "\nnincs kezdő alaprajz" +
                "\n!! a nyilászárók nincsenek falakhoz rendelve !!");
        }

        private void szobaCheckBoxok()
        {
            Point poz = chb1.Location;
            grbSzobak.Controls.Remove(chb1);
            int szobaTag = 0;

            //checkBox
            foreach (var szoba in Szoba.mindenSzoba)
            {
                CheckBox chb = new CheckBox();
                chb.Text = szoba.Nev;
                chb.Location = poz;
                chb.Tag = szobaTag;
                chb.Size = new Size(75, 25);
                chb.CheckedChanged += chbSzoba_CheckedChanged;
                grbSzobak.Controls.Add(chb);

                //fal gombok
                Point btnPoz = new Point(poz.X + 80, poz.Y);
                foreach (var fal in szoba.falakEgyesevel())
                {
                    Button btn = new Button();
                    btn.Text = fal.ToString();
                    btn.Size = new Size(40, 25);
                    btn.Location = btnPoz;
                    btn.Tag = szobaTag;
                    grbSzobak.Controls.Add(btn);
                    btnPoz.X += 43;
                    btn.Click += btnSzobafal_Click;
                    btn.Enabled = false;
                    btn.ForeColor = Color.Green;
                }
                ////nyilaszaro chb
                //CheckBox chbNyz = new CheckBox();
                //chbNyz.Text = "nyz.";
                //chbNyz.Checked = true;
                //chbNyz.Location = btnPoz;
                //chbNyz.Enabled = false;
                //grbSzobak.Controls.Add(chbNyz);

                poz.Y += 30;
                szobaTag++;
                Size s = grbSzobak.Size;
                grbSzobak.Size = new Size(s.Width, s.Height + 30);
            }
        }

        private void btnSzobafal_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            double fal = double.Parse(btn.Text);

            double numFal = (double)numTobbSzobaMagassag.Value / 100;
            double szobaMag = Szoba.mindenSzoba[(int)btn.Tag].Magassag;
            numFal = numFal > szobaMag ? szobaMag : numFal;

            fal *= numFal;


            double osszesFal = double.Parse(txtTobbSzobaSzinesFestek.Text);

            if (btn.ForeColor == Color.Green)
            {
                btn.ForeColor = Color.Red;
                txtTobbSzobaSzinesFestek.Text = osszesFal - fal + "";
            }
            else
            {
                btn.ForeColor = Color.Green;
                txtTobbSzobaSzinesFestek.Text = osszesFal + fal + "";
            }
        }
        private void chbSzoba_CheckedChanged(object sender, EventArgs e)
        {
            szinesFestekKiirasTobbSzoba();
            CheckBox chb = (CheckBox)sender;

            foreach (Control item in grbSzobak.Controls)
            {
                if (item is Button && item.Tag.ToString() == chb.Tag.ToString()) ((Button)item).Enabled = chb.Checked;
            }


        }
        private void listakatFeltolt()
        {
            foreach (var sz in Szoba.mindenSzoba)
            {
                cmbSzoba.Items.Add(sz.Nev);
                //chlSzobak.Items.Add(sz.Nev);
            }
        }

        private void szobakatLetrehoz()
        {
            //szobak
            Szoba folyoso = new Szoba("folyoso", 1.25, 4.95);
            Szoba konyha = new Szoba("konyha", 2.5, 3.45);
            Szoba kamra = new Szoba("kamra", 1.18, 1.56);
            Szoba nappali = new Szoba("nappali", 4.5, 4.1);
            Szoba baba = new Szoba("baba", 4.1, 3.15);

            Szoba wc = new Szoba("wc", 1.31, .82, .16, .2, .6);
            Szoba furdo = new Szoba("furdo", 2.02, 1.55, 0.32, .8, .6);
            Szoba halo = new Szoba("halo", 3.75, 3.1, 0.4, 0.4);

            //belso nyilaszarok
            Nyilaszaro kamraAjto = new Nyilaszaro(.73, 2);
            Nyilaszaro wcAjto = new Nyilaszaro(.73, 2);
            Nyilaszaro furdoAjto = new Nyilaszaro(.73, 2);

            Nyilaszaro nappaliAjto = new Nyilaszaro(1, 2, -1);
            Nyilaszaro babaAjto = new Nyilaszaro(.97, 1.94, -.97);
            Nyilaszaro haloAjto = new Nyilaszaro(.97, 2, -.97);

            Nyilaszaro konyhaAjto = new Nyilaszaro(.93, 2);

            //kulso nyilaszarok
            Nyilaszaro konyhaAblak = new Nyilaszaro(1.3, 1.43);
            Nyilaszaro haloAblak = new Nyilaszaro(1.3, 1.43, (2 * 0.14));
            Nyilaszaro nappaliAblak = new Nyilaszaro(1.35, 1.5);
            Nyilaszaro nappaliErkelyAjto = new Nyilaszaro(0.85, 2.38, (2 * 0.18 - 0.97));
            Nyilaszaro babaErkelyAjto = new Nyilaszaro(1.34, 2.4, (2 * 0.18 - 1.34));
            Nyilaszaro kamraAblak = new Nyilaszaro(.46, .59);

            //nyilaszarokat szobakhoz rendel
            kamra.nyilaszarok.AddRange(new List<Nyilaszaro>() { kamraAblak, kamraAjto });
            konyha.nyilaszarok.AddRange(new List<Nyilaszaro>() { konyhaAblak, konyhaAjto });
            folyoso.nyilaszarok.AddRange(new List<Nyilaszaro>() { kamraAjto, wcAjto, furdoAjto, nappaliAjto, haloAjto, konyhaAjto });
            halo.nyilaszarok.AddRange(new List<Nyilaszaro>() { haloAjto, haloAblak });
            nappali.nyilaszarok.AddRange(new List<Nyilaszaro>() { nappaliAblak, nappaliErkelyAjto, nappaliAjto });
            baba.nyilaszarok.AddRange(new List<Nyilaszaro>() { babaAjto, babaErkelyAjto });

        }
        private void rajzol(Point[] koordinatak)
        {
            //vaszonIndit();
            vaszon = pictureBox1.CreateGraphics();
            vaszon.Clear(Color.White);

            Pen myPen = new Pen(Color.Green, 3);
            vaszon.DrawPolygon(myPen, koordinatak);

            myPen.Dispose();
            //vaszonEldob();
            vaszon.Dispose();
        }

        private void btnVisszaTovabb(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int ind = cmbSzoba.SelectedIndex;
            if (btn.Tag.ToString() == "+")
            {
                ind++;
                ind %= Szoba.mindenSzoba.Count;
            }
            else
            {
                ind--;
                if (ind < 0) ind = Szoba.mindenSzoba.Count-1;
            }
            cmbSzoba.SelectedIndex = ind;
        }

        //private void vaszonIndit()
        //{
        //    vaszon = pictureBox1.CreateGraphics();
        //}
        //private void vaszonEldob()
        //{
        //    vaszon.Dispose();
        //}
        //private void vaszonTorol()
        //{
        //    //vaszonIndit();
        //    //vaszon.Clear(Color.White);
        //    //vaszonEldob();
        //}

        private void cmbSzoba_SelectedIndexChanged(object sender, EventArgs e)
        {
            Szoba sz = Szoba.mindenSzoba[((ComboBox)sender).SelectedIndex];
            szobaKiiras(sz);
        }

        private void szobaKiiras(Szoba sz)
        {
            txtSzelesseg.Text = sz.Szelesseg + "";
            txtHossz.Text = sz.Hossz.ToString();
            txtAlapter.Text = sz.alapterulet().ToString();
            txtOsszFal.Text = sz.festendoFeluletPlafonnal().ToString();
            szinesFestekKiiras();
            numMagassag.Value = (decimal)sz.Magassag * 100;
            listNyilaszarok.Items.Clear();
            foreach (var ny in sz.nyilaszarok)
            {
                listNyilaszarok.Items.Add($"{ny.Szelesseg} x {ny.Magassag}");
            }

            txtNyilasOsszfel.Text = sz.nyilaszarokFelulete().ToString();
            rajzol(sz.alaprajz());
        }

        private void numMagassag_ValueChanged(object sender, EventArgs e)
        {
            szinesFestekKiiras();
        }

        private void szinesFestekKiiras()
        {
            double mag = (double)numMagassag.Value / 100;
            txtSzinesFestek.Text = Szoba.mindenSzoba[cmbSzoba.SelectedIndex].festendoFeluletAdottMagassagig(mag).ToString();
        }

        private void numTobbSzoba_ValueChanged(object sender, EventArgs e)
        {
            szinesFestekKiirasTobbSzoba();
        }


        private void szinesFestekKiirasTobbSzoba()
        {
            double mag = (double)numTobbSzobaMagassag.Value / 100;
            double osszFal = 0;
            double osszAlap = 0;
            foreach (Control ctrl in grbSzobak.Controls)
            {
                if (ctrl is CheckBox)
                {
                    CheckBox chb = (CheckBox)ctrl;
                    if (chb.Checked)
                    {
                        Szoba szoba = Szoba.mindenSzoba[(int)chb.Tag];
                        osszFal += szoba.festendoFeluletAdottMagassagig(mag);
                        osszAlap += szoba.alapterulet();
                    }
                }

            }

            if (chbPlafon.Checked) txtTobbSzobaSzinesFestek.Text = osszFal + osszAlap + "";
            else txtTobbSzobaSzinesFestek.Text = osszFal.ToString();
        }

        //private void chlSzobak_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    txtKivalasztottSzobak.Text = chlSzobak.CheckedIndices.Count.ToString();
        //    szinesFestekKiirasTobbSzoba();
        //    CheckedListBox chl = (CheckedListBox)sender;
        //    //szobaFalGombok(chl.SelectedIndex);

        //}




        //runtime gombok

        //private static int x = 700;
        //private static Point lblKezdoPozicio = new Point(x, 10);
        //private static Point btnKezdoPozicio = new Point(x, 30);
        //private static Point lblPoz = lblKezdoPozicio;
        //private static Point btnPoz = btnKezdoPozicio;
        //private static int sorTav = 50;

        //private void szobaFalGombok(int szobaIndex)
        //{
        //    string szobaSzam = szobaIndex.ToString();

        //    int i = 0;
        //    bool nincs = true;
        //    while (i < Controls.Count && nincs)
        //    {
        //        if (Controls[i].Tag != null && Controls[i].Tag.ToString() == szobaSzam) nincs = false;
        //        i++;
        //    }

        //    if (i >= Controls.Count)
        //    {
        //        gombokatKeszit(szobaIndex);
        //    }
        //    else
        //    {
        //        gombokatTorol(szobaSzam);

        //    }
        //}

        //private void gombokatTorol(string szobaSzam)
        //{
        //    foreach (Control ctrl in this.Controls)
        //    {
        //        if (ctrl.Tag != null && ctrl.Tag.ToString() == szobaSzam) Controls.Remove(ctrl);
        //    }
        //}

        //private void gombokatKeszit(int szobaIndex)
        //{
        //    Szoba szoba = Szoba.mindenSzoba[szobaIndex];
        //    Label lbl = new Label();
        //    lbl.Location = lblPoz;
        //    lbl.Size = new Size(80, 20);
        //    lblPoz.Y += sorTav;
        //    lbl.Text = szoba.Nev;
        //    lbl.Tag = szobaIndex;
        //    this.Controls.Add(lbl);

        //    foreach (var fal in szoba.falakEgyesevel())
        //    {
        //        Button btn = new Button();
        //        btn.Text = fal.ToString();
        //        btn.Location = btnPoz;
        //        btnPoz.X += 43;
        //        btn.Size = new Size(40, 25);
        //        btn.Tag = szobaIndex;
        //        Controls.Add(btn);
        //    }
        //    btnPoz.X = btnKezdoPozicio.X;
        //    btnPoz.Y += sorTav;
        //}

        private void chbPlafon_CheckedChanged(object sender, EventArgs e)
        {
            szinesFestekKiirasTobbSzoba();
        }

        private void chbMindenSzoba_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control ctrl in grbSzobak.Controls)
            {
                if (ctrl is CheckBox) ((CheckBox)ctrl).Checked = chbMindenSzoba.Checked;
            }
        }
    }


}
