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
        private Size alapMeret;
        private Size nagyMeret;
        private int alapGombDb;
        public Uj01_AlapteruletValaszto()
        {
            InitializeComponent();
            alapMeret = btnSzabalyos.Image.Size;
            nagyMeret = new Size(alapMeret.Width + 30, alapMeret.Height + 30);
            alapGombDb = gbAlapterulet.Controls.Count;
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
            if (btn.Image.Size == alapMeret)
            {
                foreach (Control c in gbAlapterulet.Controls)
                {
                    Button b = (Button)c;
                    b.Image = new Bitmap(b.Image, alapMeret);
                }
                gombKepetNagyit(btn);
            }
        }

        private void Uj01_AlapteruletValaszto_Shown(object sender, EventArgs e)
        {
            szoba = Eszkozok.tagOlvaso(this);
            if (szoba != null)
            {
                txtNev.Text = szoba.Nev;
                int ind = 0;
                while (ind < alapGombDb &&
                    szoba.AlapteruletTipus != (Alapterulet)alapGomb(ind).Tag)
                {
                    ind++;
                }
                if (ind < alapGombDb)
                {
                    gombKepetNagyit(alapGomb(ind));
                }
            }
            this.Focus();

        }

        private void btnTovabb_Click(object sender, EventArgs e)
        {
            Alapterulet valasztottAlapter()
            {
                int ind = 0;
                while (alapGombDb > ind &&
                    alapGomb(ind).Image.Size == alapMeret)
                {
                    ind++;
                }
                return (Alapterulet)((Button)gbAlapterulet.Controls[ind]).Tag;
            }

            szoba = new Szoba(txtNev.Text, valasztottAlapter());
            Form form2 = new Uj02_SzobatKeszit();
            form2.Tag = szoba;
            this.Close();
            form2.Show();
        }

        private Button alapGomb(int index)
        {
            return (Button)gbAlapterulet.Controls[index];
        }
        private void gombKepetNagyit(Button btn)
        {
            btn.Image = new Bitmap(btn.Image, nagyMeret);
        }
    }
}
