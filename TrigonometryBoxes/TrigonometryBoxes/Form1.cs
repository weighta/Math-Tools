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

namespace TrigonometryBoxes
{
    public partial class Form1 : Form
    {
        Random ran = new Random();
        private int x;
        private int y;
        private int a;
        private int vs;
        private int ps;
        private int deg;
        private int t;
        private float w;
        private float degree;
        private float siny;
        private float sinx;
        public Form1()
        {
            InitializeComponent();
            x = panel1.Location.X;
            y = panel1.Location.Y;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            parseVariables();
            Thread sin = new Thread(new ThreadStart(sine));
            sin.Start();
        }
        private void sine()
        {
            Invoke(new Action(() => label3.Text = Convert.ToInt32(textBox1.Text) + "sin(" + w + "x + " + Convert.ToInt32(textBox2.Text) + ") + " + Convert.ToInt32(textBox3.Text))); 
            for(int i = 0; i < deg; i++)
            {
                siny = (float)Math.Sin(degree * i * w) * a;
                sinx = (675 / 492f) * i;
                Invoke(new Action(() => panel1.Location = new Point(x + (int)sinx + vs, y - (int)siny - ps)));
                Thread.Sleep(t);
            }
            Thread.EndThreadAffinity();
        }
        private void Cosine()
        {
            Invoke(new Action(() => label3.Text = Convert.ToInt32(textBox1.Text) + "cos(" + w + "x + " + Convert.ToInt32(textBox2.Text) + ") + " + Convert.ToInt32(textBox3.Text)));
            for (int i = 0; i < deg; i++)
            {
                siny = (float)Math.Cos(degree * i * w) * a;
                sinx = (675 / 492f) * i;
                Invoke(new Action(() => panel2.Location = new Point(x + (int)sinx + vs, y - (int)siny - ps)));
                Thread.Sleep(t);
            }
            Thread.EndThreadAffinity();
        }
        private void Tangent()
        {
            Invoke(new Action(() => label3.Text = Convert.ToInt32(textBox1.Text) + "tan(" + w + "x + " + Convert.ToInt32(textBox2.Text) + ") + " + Convert.ToInt32(textBox3.Text)));
            for (int i = 0; i < deg; i++)
            {
                siny = (float)Math.Tan(degree * i * w) * a;
                sinx = (675 / 492f) * i;
                Invoke(new Action(() => panel3.Location = new Point(x + (int)sinx + vs, y - (int)siny - ps)));
                Thread.Sleep(t);
            }
            Thread.EndThreadAffinity();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            parseVariables();
            Thread cos = new Thread(new ThreadStart(Cosine));
            cos.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            parseVariables();
            Thread tan = new Thread(new ThreadStart(Tangent));
            tan.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void parseVariables()
        {
            try
            {
                a = Convert.ToInt32(textBox1.Text) * 78;
                vs = Convert.ToInt32(textBox3.Text) * 246;
                ps = Convert.ToInt32(textBox2.Text) * 130;
                deg = Convert.ToInt32(textBox4.Text);
                t = Convert.ToInt32(textBox5.Text);
                w = (float)Convert.ToDouble(textBox6.Text);
                degree = (float)((2 * Math.PI) / 360);
            }
            catch
            {
                MessageBox.Show("Invalid Equation");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            parseVariables();
            Thread sin = new Thread(new ThreadStart(sine));
            Thread cos = new Thread(new ThreadStart(Cosine));
            Thread tan = new Thread(new ThreadStart(Tangent));
            sin.Start();
            cos.Start();
            tan.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            int inc;
            float rad;
            float sin;
            try
            {
                inc = Convert.ToInt32(textBox7.Text);
                for (int i = 0; i <= 360; i += inc)
                {
                    rad = (float)(Math.PI / 180) * i;
                    sin = (float)Math.Sin(rad);
                    richTextBox1.AppendText("Deg: " + i + " Sine: " + sin + Environment.NewLine);
                }
            }
            catch
            {
                MessageBox.Show("Invalid Increment");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            int inc;
            float rad;
            float cos;
            try
            {
                inc = Convert.ToInt32(textBox7.Text);
                for (int i = 0; i <= 360; i += inc)
                {
                    rad = (float)(Math.PI / 180) * i;
                    cos = (float)Math.Cos(rad);
                    richTextBox1.AppendText("Deg: " + i + " Cosine: " + cos + Environment.NewLine);
                }
            }
            catch
            {
                MessageBox.Show("Invalid Increment");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            int inc;
            float rad;
            string tan;
            try
            {
                inc = Convert.ToInt32(textBox7.Text);
                for (int i = 0; i <= 360; i += inc)
                {
                    rad = (float)(Math.PI / 180) * i;
                    tan = Math.Tan(rad).ToString();
                    richTextBox1.AppendText("Deg: " + i + " Tangent: " + tan + Environment.NewLine);
                }
            }
            catch
            {
                MessageBox.Show("Invalid Increment");
            }
        }

        Point[] pts = { new Point(100, 100), new Point(200, 230), new Point(120, 110), new Point(340, 203), new Point(120, 222), new Point(123, 203) };
        //int count = 0;
        private void button8_Click(object sender, EventArgs e)
        {
            //pts[count++] = new Point((int)numericUpDown1.Value, (int)numericUpDown2.Value);

            for (int i = 0; i < pts.Length; i++)
            {

                if (i != 0)
                {

                    this.CreateGraphics().DrawLine(new Pen(Brushes.Black, 4), pts[i - 1], pts[i]);
                }

                else
                {
                    this.CreateGraphics().DrawLine(new Pen(Brushes.Black, 4), pts[i], pts[i]);

                }


            }

        }
    }
}
