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
    public partial class Himno_2 : Form
    {
        public Himno_2()
        {
            InitializeComponent();
        }
        int a=0;
        private void pcbPlay_Click(object sender, EventArgs e)
        {
            wmp1.URL = @"C:\GLORIA\1 - 50\Himno 003.mp3";
            wmp1.Ctlcontrols.play();
        }

        private void pcbPausa_Click(object sender, EventArgs e)
        {            
           wmp1.Ctlcontrols.pause();    
        }

        private void pcbStop_Click(object sender, EventArgs e)
        {
            wmp1.Ctlcontrols.stop();
        }

        private void Himno_2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.A)
            {
                wmp1.URL = @"C:\GLORIA\1 - 50\Himno 003.mp3";
                wmp1.Ctlcontrols.play();
            }
            if (e.KeyCode == Keys.S)
            {
                wmp1.Ctlcontrols.pause();
            }
            if (e.KeyCode == Keys.D)
            {
                wmp1.Ctlcontrols.stop();
            }
            if (e.KeyCode == Keys.Left)
            {
                switch (a)
                {
                    case 2:
                        pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva6;
                        a -= 1;
                        break;
                    case 3: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva7; a -= 1; break;
                    case 4: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva8; a -= 1; break;
                    case 5: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva9; a -= 1; break;
                    case 6: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva10; a -= 1; break;
                    case 7: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva11; a -= 1; break;
                    case 8: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva12; a -= 1; break;
                    case 9: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva13; a -= 1; break;
                    case 10: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva14; a = 1; break;
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                switch (a)
                {
                    case 1: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva7; a += 1; break;
                    case 2: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva8; a += 1; break;
                    case 3: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva9; a += 1; break;
                    case 4: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva10; a += 1; break;
                    case 5: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva11; a += 1; break;
                    case 6: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva12; a += 1; break;
                    case 7: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva13; a += 1; break;
                    case 8: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva14; a += 1; break;
                    case 9: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva6; a = 1; break;
                }
            }
        }

        private void Himno_2_Load(object sender, EventArgs e)
        {
            pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva6;
            a += 1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
