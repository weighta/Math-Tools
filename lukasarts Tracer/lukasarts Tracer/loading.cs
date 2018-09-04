using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace lukasarts_Tracer
{
    public partial class loading : Form
    {
        Thread loader;
        Random ran = new Random();
        int closer = 0;
        public loading()
        {
            InitializeComponent();
            timer1.Start();
            startthethread();
        }
        
        private void startthethread()
        {
            loader = new Thread(new ThreadStart(loading2));
            loader.Start();
        }

        private void loading2()
        {
            float rad;
            float oldrad;
            Point oldtheta;
            Point theta;
            try
            {
                for (int i = 0; i <= 512; i += 2)
                {
                    rad = (float)((Math.PI / 180f) * i * 2f);
                    oldrad = (float)((Math.PI / 180f) * (i - 1) * 2f);
                    oldtheta = new Point(i - 40, (int)(Math.Cos(oldrad * 2) * 50 + 125));
                    theta = new Point(i - 38, (int)(Math.Cos(rad * 2) * 50 + 125));
                    Thread.Sleep(ran.Next(12, 50));
                    Invoke(new Action(() => progressBar1.Value = (int)((i / 512f) * 100)));
                    Invoke(new Action(() => label1.Text = ((int)((i / 512f) * 100)).ToString() + "%"));
                    Invoke(new Action(() => panel1.Location = new Point(i, (int)(Math.Sin(rad) * 50) + 125)));
                    Invoke(new Action(() => panel2.Location = new Point(i - 30, (int)(Math.Cos(rad) * 55) + 125)));
                    pictureBox1.CreateGraphics().DrawLine(new Pen(Color.Red, ran.Next(3, 7)), oldtheta, theta);
                }
            }
            catch
            {

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            closer++;
            if (closer >= 9)
            {
                loader.Abort();
                timer1.Stop();
                Form tracer = new Form1();
                Invoke(new Action(() => tracer.Show()));
                Invoke(new Action(() => this.Hide()));
            }
        }
    }
}
