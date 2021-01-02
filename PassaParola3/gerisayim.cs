using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassaParola3
{
    public partial class gerisayim : Form
    {
        public gerisayim()
        {
            InitializeComponent();
        }

        private void gerisayim_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int saniye=10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            saniye = saniye - 1;
            label2.Text = saniye.ToString();
            if (saniye == 0)
            {
                timer1.Stop();
                Form1 fr = new Form1();
                fr.otobaslat();
                fr.Show();
                this.Hide();
            }
        }
    }
}
