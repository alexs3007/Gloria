using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CelebremosSuGloria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlCat1.Visible = false;
            pnlCat2.Visible = false;
            pnlCat3.Visible = false;
            pnlCat4.Visible = false;
            pnlCat5.Visible = false;
            pnlCat6.Visible = false;
            pnlCat7.Visible = false;
            pnlCat8.Visible = false;
        }

        private void pcb1_Click(object sender, EventArgs e)
        {
            pnlCat1.Visible = true;
            pnlCat1.Size = new Size(1215, 670);
            pnlCat1.Location = new Point(143, 101);
            pnlCat7.Visible = false;
            pnlCat2.Visible = false;
            pnlCat3.Visible = false;
            pnlCat4.Visible = false;
            pnlCat5.Visible = false;
            pnlCat6.Visible = false;
            pnlCat8.Visible = false;
        }

        private void pcb2_Click(object sender, EventArgs e)
        {
            pnlCat2.Visible = true;
            pnlCat2.Size = new Size(1215, 670);
            pnlCat2.Location = new Point(143, 101);
            pnlCat1.Visible = false;
            pnlCat7.Visible = false;
            pnlCat3.Visible = false;
            pnlCat4.Visible = false;
            pnlCat5.Visible = false;
            pnlCat6.Visible = false;
            pnlCat8.Visible = false;
        }

        private void pcb3_Click(object sender, EventArgs e)
        {
            pnlCat3.Visible = true;
            pnlCat3.Size = new Size(1215, 670);
            pnlCat3.Location = new Point(143, 101);
            pnlCat1.Visible = false;
            pnlCat2.Visible = false;
            pnlCat7.Visible = false;
            pnlCat4.Visible = false;
            pnlCat5.Visible = false;
            pnlCat6.Visible = false;
            pnlCat8.Visible = false;

        }

        private void pcb4_Click(object sender, EventArgs e)
        {
            pnlCat4.Visible = true;
            pnlCat4.Size = new Size(1215, 670);
            pnlCat4.Location = new Point(143, 101);
            pnlCat1.Visible = false;
            pnlCat2.Visible = false;
            pnlCat3.Visible = false;
            pnlCat7.Visible = false;
            pnlCat5.Visible = false;
            pnlCat6.Visible = false;
            pnlCat8.Visible = false;
        }

        private void pcb5_Click(object sender, EventArgs e)
        {
            pnlCat5.Visible = true;
            pnlCat5.Size = new Size(1215, 670);
            pnlCat5.Location = new Point(143, 101);
            pnlCat1.Visible = false;
            pnlCat2.Visible = false;
            pnlCat3.Visible = false;
            pnlCat4.Visible = false;
            pnlCat7.Visible = false;
            pnlCat6.Visible = false;
            pnlCat8.Visible = false;
        }

        private void pcb6_Click(object sender, EventArgs e)
        {
            pnlCat6.Visible = true;
            pnlCat6.Size = new Size(1215, 670);
            pnlCat6.Location = new Point(143, 101);
            pnlCat1.Visible = false;
            pnlCat2.Visible = false;
            pnlCat3.Visible = false;
            pnlCat4.Visible = false;
            pnlCat5.Visible = false;
            pnlCat7.Visible = false;
            pnlCat8.Visible = false;
        }

        private void pcb7_Click(object sender, EventArgs e)
        {
            pnlCat7.Visible = true;
            pnlCat7.Size = new Size(1215, 670);
            pnlCat7.Location = new Point(143, 101);
            pnlCat1.Visible = false;
            pnlCat2.Visible = false;
            pnlCat3.Visible = false;
            pnlCat4.Visible = false;
            pnlCat5.Visible = false;
            pnlCat6.Visible = false;
            pnlCat8.Visible = false;
        }

        private void pcb8_Click(object sender, EventArgs e)
        {
            pnlCat8.Visible = true;
            pnlCat8.Size = new Size(1215, 670);
            pnlCat8.Location = new Point(143, 101);
            pnlCat1.Visible = false;
            pnlCat2.Visible = false;
            pnlCat3.Visible = false;
            pnlCat4.Visible = false;
            pnlCat5.Visible = false;
            pnlCat6.Visible = false;
            pnlCat7.Visible = false;
        }

        private void pcbCerrar_Click(object sender, EventArgs e)
        {
            Principales.Mesage frm = new Principales.Mesage();
            frm.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Himnos.Himno_2 frm = new Himnos.Himno_2();
            frm.Show();
            pnlCat1.Visible = false;
        }

        private void bnt3_Click(object sender, EventArgs e)
        {
            Himnos.Himno_3 frm = new Himnos.Himno_3();
            frm.Show();
            pnlCat1.Visible = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Himnos.Himno_4 frm = new Himnos.Himno_4();
            frm.Show();
            pnlCat1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Himnos.Himno_5 frm = new Himnos.Himno_5();
            frm.Show();
            pnlCat1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Principales.Message frm = new Principales.Message();
            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Himnos.Himno_7 frm = new Himnos.Himno_7();
            frm.Show();
            pnlCat1.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Himnos.Himno_8 frm = new Himnos.Himno_8();
            frm.Show();
            pnlCat1.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Himnos.Himno_9 frm = new Himnos.Himno_9();
            frm.Show();
            pnlCat1.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Himnos.Himno_10 frm = new Himnos.Himno_10();
            frm.Show();
            pnlCat1.Visible = false;
        }

        private void button63_Click(object sender, EventArgs e)
        {
            Himnos.Himno_11 frm = new Himnos.Himno_11();
            frm.Show();
            pnlCat1.Visible = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Himnos.Himno_12 frm = new Himnos.Himno_12();
            frm.Show();
            pnlCat1.Visible = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Himnos.Himno_13 frm = new Himnos.Himno_13();
            frm.Show();
            pnlCat1.Visible = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Principales.Message frm = new Principales.Message();
            frm.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Himnos.Himno_15 frm = new Himnos.Himno_15();
            frm.Show();
            pnlCat1.Visible = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Himnos.Himno_16 frm = new Himnos.Himno_16();
            frm.Show();
            pnlCat1.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Himnos.Himno_17 frm = new Himnos.Himno_17();
            frm.Show();
            pnlCat1.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Himnos.Himno_18 frm = new Himnos.Himno_18();
            frm.Show();
            pnlCat1.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Himnos.Himno_19 frm = new Himnos.Himno_19();
            frm.Show();
            pnlCat1.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Himnos.Himno_20 frm = new Himnos.Himno_20();
            frm.Show();
            pnlCat1.Visible = false;
        }
    }
}
