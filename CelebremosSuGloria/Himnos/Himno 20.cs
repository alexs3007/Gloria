using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CelebremosSuGloria.Himnos
{
    public partial class Himno_20 : Form
    {
        public Himno_20()
        {
            InitializeComponent();
        }
        int a = 0;
        private void Himno_20_Load(object sender, EventArgs e)
        {
            pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva133;
            a += 1;
        }

        private void Himno_20_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                wmp1.URL = @"C:\GLORIA\1 - 50\Himno 020.mp3";
                wmp1.Ctlcontrols.play();
            }
            if (e.KeyCode == Keys.S)
            {
                wmp1.Ctlcontrols.stop();
            }
            if (e.KeyCode == Keys.Left)
            {
                switch (a)
                {
                    case 2:
                        pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva133;
                        a -= 1;
                        break;
                    case 3: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva134; a -= 1; break;
                    case 4: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva135; a -= 1; break;
                    case 5: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva136; a -= 1; break;
                    case 6: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva137; a -= 1; break;
                    case 7: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva138; a -= 1; break;
                    case 8: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva139; a -= 1; break;
                    case 9: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva140; a -= 1; break;
                    case 10: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva141; a -= 1; break;
                    case 11: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva142; a -= 1; break;
                    case 12: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva143; a -= 1; break;
                    case 13: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva144; a -= 1; break;
                    case 14: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva145; a -= 1; break;
                    case 15: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva146; a -= 1; break;
                    case 16: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva147; a -= 1; break;
                    case 17: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva148; a -= 1; break;
                    case 18: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva149; a -= 1; break;

                }
            }
            if (e.KeyCode == Keys.Right)
            {
                switch (a)
                {
                    case 1: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva134; a += 1; break;
                    case 2: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva135; a += 1; break;
                    case 3: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva136; a += 1; break;
                    case 4: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva137; a += 1; break;
                    case 5: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva138; a += 1; break;
                    case 6: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva139; a += 1; break;
                    case 7: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva140; a += 1; break;
                    case 8: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva141; a += 1; break;
                    case 9: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva142; a += 1; break;
                    case 10: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva143; a += 1; break;
                    case 11: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva144; a += 1; break;
                    case 12: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva145; a += 1; break;
                    case 13: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva146; a += 1; break;
                    case 14: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva147; a += 1; break;
                    case 15: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva148; a += 1; break;
                    case 16: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva149; a += 1; break;
                    case 17: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva133; a += 1; break;

                }
            }
        }
    }
}
