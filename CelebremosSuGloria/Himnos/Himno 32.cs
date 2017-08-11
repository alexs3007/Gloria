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
    public partial class himno_32 : Form
    {
        public himno_32()
        {
            InitializeComponent();
        }
        int a = 0;
        private void himno_32_Load(object sender, EventArgs e)
        {
            pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva208;
            a += 1;
        }

        private void himno_32_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                wmp1.URL = @"C:\GLORIA\1 - 50\Himno 032.mp3";
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
                        pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva208;
                        a -= 1;
                        break;
                    case 3: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva209; a -= 1; break;
                    case 4: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva210; a -= 1; break;
                    case 5: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva211; a -= 1; break;
                    case 6: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva212; a -= 1; break;
                    case 7: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva213; a -= 1; break;
                    case 8: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva214; a -= 1; break;
                    case 9: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva215; a -= 1; break;
                    case 10: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva216; a -= 1; break;
                    case 11: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva217; a -= 1; break;
                    case 12: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva218; a -= 1; break;
                    case 13: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva219; a -= 1; break;
                    case 14: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva220; a -= 1; break;
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                switch (a)
                {
                    case 1: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva209; a += 1; break;
                    case 2: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva210; a += 1; break;
                    case 3: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva211; a += 1; break;
                    case 4: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva212; a += 1; break;
                    case 5: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva213; a += 1; break;
                    case 6: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva214; a += 1; break;
                    case 7: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva215; a += 1; break;
                    case 8: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva216; a += 1; break;
                    case 9: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva217; a += 1; break;
                    case 10: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva218; a += 1; break;
                    case 11: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva219; a += 1; break;
                    case 12: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva220; a += 1; break;
                    case 13: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva208; a = 1; break;
                }
            }
        }
    }
}
