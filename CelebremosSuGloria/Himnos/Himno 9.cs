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
    public partial class Himno_9 : Form
    {
        public Himno_9()
        {
            InitializeComponent();
        }
        int a = 0;
        private void Himno_9_Load(object sender, EventArgs e)
        {
            pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva62;
            a += 1;
        }

        private void Himno_9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                wmp1.URL = @"C:\GLORIA\1 - 50\Himno 009.mp3";
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
                        pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva62;
                        a -= 1;
                        break;
                    case 3: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva63; a -= 1; break;
                    case 4: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva64; a -= 1; break;
                    case 5: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva65; a -= 1; break;
                    case 6: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva66; a -= 1; break;
                    case 7: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva67; a -= 1; break;
                    case 8: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva68; a -= 1; break;

                }
            }
            if (e.KeyCode == Keys.Right)
            {
                switch (a)
                {
                    case 1: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva63; a += 1; break;
                    case 2: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva64; a += 1; break;
                    case 3: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva65; a += 1; break;
                    case 4: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva66; a += 1; break;
                    case 5: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva67; a += 1; break;
                    case 6: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva68; a += 1; break;
                    case 7: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva62; a = 1; break;

                }
            }
        }
    }
}
