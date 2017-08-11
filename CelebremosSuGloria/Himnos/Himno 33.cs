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
    public partial class Himno_33 : Form
    {
        public Himno_33()
        {
            InitializeComponent();
        }
        int a = 0;
        private void Himno_33_Load(object sender, EventArgs e)
        {
            pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva221;
            a += 1;
        }

        private void Himno_33_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                wmp1.URL = @"C:\GLORIA\1 - 50\Himno 033.mp3";
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
                        pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva221;
                        a -= 1;
                        break;
                    case 3: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva222; a -= 1; break;
                    case 4: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva223; a -= 1; break;
                    case 5: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva224; a -= 1; break;
                    case 6: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva225; a -= 1; break;
                    case 7: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva226; a -= 1; break;
                    case 8: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva227; a -= 1; break;
                    case 9: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva228; a -= 1; break;
                    case 10: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva229; a -= 1; break;
                    case 11: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva230; a -= 1; break;
                    case 12: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva231; a -= 1; break;

                }
            }
            if (e.KeyCode == Keys.Right)
            {
                switch (a)
                {
                    case 1: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva222; a += 1; break;
                    case 2: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva223; a += 1; break;
                    case 3: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva224; a += 1; break;
                    case 4: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva225; a += 1; break;
                    case 5: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva226; a += 1; break;
                    case 6: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva227; a += 1; break;
                    case 7: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva228; a += 1; break;
                    case 8: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva229; a += 1; break;
                    case 9: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva230; a += 1; break;
                    case 10: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva231; a += 1; break;
                    case 11: pcbHimno2.Image = CelebremosSuGloria.Properties.Resources.Diapositiva221; a = 1; break;
   
                }
            }
        }
    }
}
