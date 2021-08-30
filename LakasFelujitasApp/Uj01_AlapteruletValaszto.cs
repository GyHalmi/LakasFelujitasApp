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
            alapterGombEvent();
            this.Shown += Uj01_AlapteruletValaszto_Shown;
        }

        private void alapterGombEvent()
        {
            foreach (Control c in gbAlapterulet.Controls)
            {
                ((Button)c).Click += btnAlapter_Click;
            }
        }
        private void btnAlapter_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackgroundImageLayout = ImageLayout.Zoom;
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
            this.Focus();

        }

        private void btnTovabb_Click(object sender, EventArgs e)
        {
            Alapterulet valasztottAlapter()
            {
                int ind = 0;
                bool talalt = false;
                do
                {
                    if (((Button)gbAlapterulet.Controls[ind]).Focused) talalt = true;
                    ind++;
                } while (!talalt);
                return (Alapterulet)((Button)gbAlapterulet.Controls[ind]).Tag;
            }
            szoba = new Szoba(txtNev.Text, valasztottAlapter());
            Form form2 = new Uj02_SzobatKeszit();
            form2.Tag = szoba;
            this.Close();
            form2.Show();
        }
    }
}
