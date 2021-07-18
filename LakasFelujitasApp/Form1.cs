﻿using System;
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

            //bal oldal
            szobakatLetrehoz();
            listakatFeltolt();
            pictureBox1.BackColor = Color.White;
            cmbSzoba.SelectedIndexChanged += cmbSzoba_SelectedIndexChanged;
            //cmbSzoba.SelectedIndex = 0;

            //jobb oldal
            szobaCheckBoxok_FalGombok();
            numMagassag.Maximum = 300;
            numMagassag.Value = 200;
            numMagassag.ValueChanged += numMagassag_ValueChanged;
            chbPlafon.Enabled = false;
            MessageBox.Show(
                "\n  festekeSzamol() ellenorzés (nyilaszarok levonódnak?)" +
                "\n\tplafon számolás" +
                 "\n\tnyilászáro hozzarandelés, falgombok működése(\n" +
                 "\na faltagkiolvasó saját FormatException-t majd tesztelni" +
                "\n\nnincs kezdő alaprajz -> load eventben nem lehet rajzolni" +
                "\n!! a nyilászárók nincsenek falakhoz rendelve !!" +
                "\n a beépítési magasság mindhol = 1");
        }


        //szobaInfo-s bal oldal

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

            Nyilaszaro nappaliAjto = new Nyilaszaro(1, 2, 1, -1);
            Nyilaszaro babaAjto = new Nyilaszaro(.97, 1.94, 1, -.97);
            Nyilaszaro haloAjto = new Nyilaszaro(.97, 2, 1, -.97);

            Nyilaszaro konyhaAjto = new Nyilaszaro(.93, 2);

            //kulso nyilaszarok
            Nyilaszaro konyhaAblak = new Nyilaszaro(1.3, 1.43);
            Nyilaszaro haloAblak = new Nyilaszaro(1.3, 1.43, 1, (2 * 0.14));
            Nyilaszaro nappaliAblak = new Nyilaszaro(1.35, 1.5);
            Nyilaszaro nappaliErkelyAjto = new Nyilaszaro(0.85, 2.38, 1, (2 * 0.18 - 0.97));
            Nyilaszaro babaErkelyAjto = new Nyilaszaro(1.34, 2.4, 1, (2 * 0.18 - 1.34));
            Nyilaszaro kamraAblak = new Nyilaszaro(.46, .59);

            //nyilaszarokat szobakhoz rendel
            kamra.Nyilaszarok.AddRange(new List<Nyilaszaro>() { kamraAblak, kamraAjto });
            konyha.Nyilaszarok.AddRange(new List<Nyilaszaro>() { konyhaAblak, konyhaAjto });
            folyoso.Nyilaszarok.AddRange(new List<Nyilaszaro>() { kamraAjto, wcAjto, furdoAjto, nappaliAjto, haloAjto, konyhaAjto });
            halo.Nyilaszarok.AddRange(new List<Nyilaszaro>() { haloAjto, haloAblak });
            nappali.Nyilaszarok.AddRange(new List<Nyilaszaro>() { nappaliAblak, nappaliErkelyAjto, nappaliAjto });
            baba.Nyilaszarok.AddRange(new List<Nyilaszaro>() { babaAjto, babaErkelyAjto });

        }
        private void listakatFeltolt()
        {
            foreach (var sz in Szoba.mindenSzoba)
            {
                cmbSzoba.Items.Add(sz.Nev);
            }
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
                if (ind < 0) ind = Szoba.mindenSzoba.Count - 1;
            }
            cmbSzoba.SelectedIndex = ind;
        }
        private void szobaInfo(Szoba sz)
        {
            txtSzelesseg.Text = sz.Szelesseg + "";
            txtHossz.Text = sz.Hossz.ToString();
            txtAlapter.Text = sz.alapterulet().ToString();
            txtOsszFal.Text = sz.festendoFeluletPlafonnal().ToString();
            listNyilaszarok.Items.Clear();
            foreach (var ny in sz.Nyilaszarok)
            {
                listNyilaszarok.Items.Add($"{ny.Szelesseg} x {ny.Magassag}");
            }

            txtNyilasOsszfel.Text = sz.nyilaszarokFelulete().ToString();
            rajzol(sz.alaprajz());
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
        private void cmbSzoba_SelectedIndexChanged(object sender, EventArgs e)
        {
            Szoba sz = Szoba.mindenSzoba[((ComboBox)sender).SelectedIndex];
            szobaInfo(sz);
        }


        //festék számolós jobb oldal

        private void szobaCheckBoxok_FalGombok()
        {
            Point poz = chb1.Location;
            grbSzobak.Controls.Remove(chb1);
            int szobaTag = 0;

            //checkBox
            foreach (var szoba in Szoba.mindenSzoba)
            {
                int falTag = 0;
                CheckBox chb = new CheckBox();
                chb.Text = szoba.Nev;
                chb.Location = poz;
                chb.Tag = szobaTag;
                chb.Size = new Size(75, 25);
                chb.CheckedChanged += chbSzoba_CheckedChanged;
                grbSzobak.Controls.Add(chb);

                //fal gombok
                Point btnPoz = new Point(poz.X + 80, poz.Y);
                foreach (var fal in szoba.Falak)
                {
                    Button btn = new Button();
                    btn.Text = fal.Szelesseg.ToString();
                    btn.Size = new Size(40, 25);
                    btn.Location = btnPoz;
                    btn.Tag = szobaTag + "-" + falTag;
                    falTag++;
                    grbSzobak.Controls.Add(btn);
                    btnPoz.X += 43;
                    btn.Click += btnSzobafal_Click;
                    btn.Enabled = false;
                    btn.ForeColor = Color.Green;
                }

                poz.Y += 30;
                szobaTag++;
                Size s = grbSzobak.Size;
                grbSzobak.Size = new Size(s.Width, s.Height + 30);
            }
        }
        private int falTagKiolvas(Control ctrl)
        {
            string[] tagek = ctrl.Tag.ToString().Split('-');
            if (tagek.Length == 1) { throw new FormatException(); }
            return int.Parse(tagek[1]);
        }
        private int szobaTagKiolvas(Control ctrl)
        {
            string[] tagek = ctrl.Tag.ToString().Split('-');
            return int.Parse(tagek[0]);
        }

        private void btnSzobafal_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Szoba szoba = Szoba.mindenSzoba[szobaTagKiolvas(btn)];
            Fal f = szoba.Falak[falTagKiolvas(btn)];
            f.Festendo = !f.Festendo;

            falGombSzinezes(btn);
            festeketSzamol();

            //double fal = double.Parse(btn.Text);

            //double numFal = (double)numTobbSzobaMagassag.Value / 100;
            //double szobaMag = Szoba.mindenSzoba[(int)btn.Tag].Magassag;
            //numFal = numFal > szobaMag ? szobaMag : numFal;

            //fal *= numFal;


            //double osszesFal = double.Parse(txtTobbSzobaSzinesFestek.Text);

            //if (btn.ForeColor == Color.Green)
            //{
            //    btn.ForeColor = Color.Red;
            //    txtTobbSzobaSzinesFestek.Text = osszesFal - fal + "";
            //}
            //else
            //{
            //    btn.ForeColor = Color.Green;
            //    txtTobbSzobaSzinesFestek.Text = osszesFal + fal + "";
            //}
        }

        private void chbSzoba_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chb = (CheckBox)sender;

            foreach (Control item in grbSzobak.Controls)
            {
                int szobaInd = szobaTagKiolvas(item);
                if (item is Button && szobaInd == szobaTagKiolvas(chb))
                {
                    Button btn = (Button)item;
                    btn.Enabled = chb.Checked;
                    Szoba.mindenSzoba[szobaInd].falakatFest(chb.Checked);
                    falGombSzinezes(btn);
                }
            }
            festeketSzamol();
        }

        private void falGombSzinezes(Button btn)
        {
            int sz = szobaTagKiolvas(btn);
            int f = falTagKiolvas(btn);
            if (Szoba.mindenSzoba[sz].Falak[f].Festendo) btn.ForeColor = Color.Green;
            else btn.ForeColor = Color.Red;
        }

        private void numMagassag_ValueChanged(object sender, EventArgs e)
        {
            festeketSzamol();
        }

        private void festeketSzamol()
        {
            double mag = (double)numMagassag.Value / 100;
            double felulet = 0;
            foreach (var szoba in Szoba.mindenSzoba)
            {
                felulet += szoba.festendoFelulet(mag);
            }


            //double osszFal = 0;
            //double osszAlap = 0;
            //foreach (Control ctrl in grbSzobak.Controls)
            //{
            //    if (ctrl is CheckBox)
            //    {
            //        CheckBox chb = (CheckBox)ctrl;
            //        if (chb.Checked)
            //        {
            //            Szoba szoba = Szoba.mindenSzoba[(int)chb.Tag];
            //            osszFal += szoba.festendoFeluletAdottMagassagig(mag);
            //            osszAlap += szoba.alapterulet();
            //        }
            //    }

            //}

            //if (chbPlafon.Checked) txtTobbSzobaSzinesFestek.Text = osszFal + osszAlap + "";
            txtFestendoFelulet.Text = felulet.ToString();
        }




        private void chbPlafon_CheckedChanged(object sender, EventArgs e)
        {
            festeketSzamol();
        }

        private void chbMindenSzoba_CheckedChanged(object sender, EventArgs e)
        {
            if (!chbMindenSzoba.Checked) chbPlafon.Checked = false;
            chbPlafon.Enabled = chbMindenSzoba.Checked;
            foreach (Control ctrl in grbSzobak.Controls)
            {
                if (ctrl is CheckBox) ((CheckBox)ctrl).Checked = chbMindenSzoba.Checked;
            }
        }
    }


}
