using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CelebremosSuGloria.Principales
{
    public partial class Mesage : Form
    {
        public Mesage()
        {
            InitializeComponent();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
