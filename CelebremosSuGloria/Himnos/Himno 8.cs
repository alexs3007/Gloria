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
    public partial class Himno_8 : Form
    {
        public Himno_8()
        {
            InitializeComponent();
        }
        int a = 0;
        private void Himno_8_Load(object sender, EventArgs e)
        {
            pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva49;
            a += 1;
        }

        private void Himno_8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                wmp1.URL = @"C:\GLORIA\1 - 50\Himno 008.mp3";
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
                        pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva49;
                        a -= 1;
                        break;
                    case 3: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva50; a -= 1; break;
                    case 4: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva51; a -= 1; break;
                    case 5: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva52; a -= 1; break;
                    case 6: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva53; a -= 1; break;
                    case 7: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva54; a -= 1; break;
                    case 8: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva55; a -= 1; break;
                    case 9: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva56; a -= 1; break;
                    case 10: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva57; a -= 1; break;
                    case 11: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva58; a -= 1; break;
                    case 12: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva59; a -= 1; break;
                    case 13: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva60; a -= 1; break;
                    case 14: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva61; a -= 1; break;
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                switch (a)
                {
                    case 1: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva50; a += 1; break;
                    case 2: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva51; a += 1; break;
                    case 3: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva52; a += 1; break;
                    case 4: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva53; a += 1; break;
                    case 5: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva54; a += 1; break;
                    case 6: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva55; a += 1; break;
                    case 7: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva56; a += 1; break;
                    case 8: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva57; a += 1; break;
                    case 9: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva58; a += 1; break;
                    case 10: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva59; a += 1; break;
                    case 11: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva60; a += 1; break;
                    case 12: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva61; a += 1; break;
                    case 13: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva49; a = 1; break;

                }
            }
        }
    }
}
