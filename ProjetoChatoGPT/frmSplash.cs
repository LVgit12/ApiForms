using System.Drawing.Imaging;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System;
using System.Timers;

namespace ProjetoChatoGPT
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();

            var timer = new System.Windows.Forms.Timer();
            timer.Interval = 3000; // 3 segundos
            timer.Tick += (s, e) =>
            {
                timer.Stop();
                this.Close();
            };
            timer.Start();
        }


        private void frmSplash_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
        }
    }
}