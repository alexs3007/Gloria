namespace CelebremosSuGloria.Himnos
{
    partial class Himno_2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Himno_2));
            this.pbcHimno2 = new System.Windows.Forms.Panel();
            this.wmp1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pcbPausa = new System.Windows.Forms.PictureBox();
            this.pcbStop = new System.Windows.Forms.PictureBox();
            this.pcbPlay = new System.Windows.Forms.PictureBox();
            this.pcbHimno2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbcHimno2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPausa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHimno2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbcHimno2
            // 
            this.pbcHimno2.BackColor = System.Drawing.Color.DodgerBlue;
            this.pbcHimno2.Controls.Add(this.wmp1);
            this.pbcHimno2.Controls.Add(this.pcbPausa);
            this.pbcHimno2.Controls.Add(this.pcbStop);
            this.pbcHimno2.Controls.Add(this.pcbPlay);
            this.pbcHimno2.Location = new System.Drawing.Point(1, 714);
            this.pbcHimno2.Name = "pbcHimno2";
            this.pbcHimno2.Size = new System.Drawing.Size(1378, 66);
            this.pbcHimno2.TabIndex = 0;
            this.pbcHimno2.Visible = false;
            // 
            // wmp1
            // 
            this.wmp1.Enabled = true;
            this.wmp1.Location = new System.Drawing.Point(37, 12);
            this.wmp1.Name = "wmp1";
            this.wmp1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp1.OcxState")));
            this.wmp1.Size = new System.Drawing.Size(309, 44);
            this.wmp1.TabIndex = 3;
            this.wmp1.Visible = false;
            // 
            // pcbPausa
            // 
            this.pcbPausa.BackgroundImage = global::CelebremosSuGloria.Properties.Resources.pausa;
            this.pcbPausa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbPausa.Location = new System.Drawing.Point(582, 3);
            this.pcbPausa.Name = "pcbPausa";
            this.pcbPausa.Size = new System.Drawing.Size(60, 60);
            this.pcbPausa.TabIndex = 2;
            this.pcbPausa.TabStop = false;
            this.pcbPausa.Click += new System.EventHandler(this.pcbPausa_Click);
            // 
            // pcbStop
            // 
            this.pcbStop.BackgroundImage = global::CelebremosSuGloria.Properties.Resources.stop;
            this.pcbStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbStop.Location = new System.Drawing.Point(707, 3);
            this.pcbStop.Name = "pcbStop";
            this.pcbStop.Size = new System.Drawing.Size(60, 60);
            this.pcbStop.TabIndex = 1;
            this.pcbStop.TabStop = false;
            this.pcbStop.Click += new System.EventHandler(this.pcbStop_Click);
            // 
            // pcbPlay
            // 
            this.pcbPlay.BackgroundImage = global::CelebremosSuGloria.Properties.Resources.comienzo;
            this.pcbPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbPlay.Location = new System.Drawing.Point(454, 3);
            this.pcbPlay.Name = "pcbPlay";
            this.pcbPlay.Size = new System.Drawing.Size(60, 60);
            this.pcbPlay.TabIndex = 0;
            this.pcbPlay.TabStop = false;
            this.pcbPlay.Click += new System.EventHandler(this.pcbPlay_Click);
            // 
            // pcbHimno2
            // 
            this.pcbHimno2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbHimno2.Location = new System.Drawing.Point(1, 30);
            this.pcbHimno2.Name = "pcbHimno2";
            this.pcbHimno2.Size = new System.Drawing.Size(1378, 750);
            this.pcbHimno2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbHimno2.TabIndex = 2;
            this.pcbHimno2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1380, 30);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CelebremosSuGloria.Properties.Resources.cerrar;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1341, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Celebremos su Gloria";
            // 
            // Himno_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 780);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbcHimno2);
            this.Controls.Add(this.pcbHimno2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Himno_2";
            this.Text = "Himno_2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Himno_2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Himno_2_KeyDown);
            this.pbcHimno2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wmp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPausa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHimno2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pbcHimno2;
        private System.Windows.Forms.PictureBox pcbPlay;
        private System.Windows.Forms.PictureBox pcbPausa;
        private System.Windows.Forms.PictureBox pcbStop;
        private AxWMPLib.AxWindowsMediaPlayer wmp1;
        private System.Windows.Forms.PictureBox pcbHimno2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}