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

namespace Trigonometry
{
    public partial class Form1 : Form
    {
        struct Booleans
        {
            public int trigplot;
        }
        private Color Backcolor;
        public Form1()
        {
            InitializeComponent();
            Backcolor = Color.Gray;
        }
        Random ran = new Random();
        Booleans booleans = new Booleans();
        PictureBox[] pictureboxes = new PictureBox[2];
        //int count = 0;
        private float theta;
        private float rad;
        private int endingpoint;
        private bool n = false;
        private bool inv = false;
        private bool round = false;
        private int funcA;
        private void button1_Click(object sender, EventArgs e)
        {
            Thread graph = new Thread(new ThreadStart(GraphTrig));
            graph.Start();
        }
        private void GraphTrig()
        {
            round = false;
            pictureBox2.Invalidate();
            Invoke(new Action(() => chart1.Series["SINE"].Points.Clear()));
            Invoke(new Action(() => chart1.Series["COSINE"].Points.Clear()));
            Invoke(new Action(() => chart1.Series["SINE1"].Points.Clear()));
            Invoke(new Action(() => chart1.Series["COSINE1"].Points.Clear()));
            Point start;
            Point end;
            int a = (int)numericUpDown2.Value;
            int w = (int)numericUpDown3.Value;
            int p = (int)numericUpDown5.Value;
            int v = (int)numericUpDown4.Value;
            int s = (int)numericUpDown1.Value;
            int xvalue;
            int xsin = 0;
            int xcos = 0;
            int xtan = 0;
            int xcot = 0;
            int xsec = 0;
            int xcsc = 0;
            int ysin = 0;
            int ycos = 0;
            int ytan = 0;
            int ycot = 0;
            int ysec = 0;
            int ycsc = 0;
            int dx = 70;
            int dy = 70;
            int sx = 72;
            int sy = 280;
            int check = 0;
            int max = 0xFFFF;
            int negative = 1;
            string minus = "";
            if (checkBox12.Checked)
            {
                negative = -1;
                minus = "-";
            }
            getdeg();
            for (theta = 0; theta <= endingpoint; theta += (int)numericUpDown7.Value)
            {
                string amp = "";
                string wav = "";
                string phas = "";
                string vert = "";
                if (numericUpDown2.Value != 1)
                {
                    amp = a.ToString();
                }
                if (numericUpDown3.Value != 1)
                {
                    wav = "(" + w + ")";
                }
                if (numericUpDown5.Value != 0)
                {
                    phas = "+" + p;
                }
                if (numericUpDown4.Value != 0)
                {
                    vert = "+" + v;
                }
                rad = (float)((Math.PI / 180) * theta);
                xvalue = sx + (int)((rad) * dx / w) + p * dx;

                //SINE
                #region
                if (checkBox4.Checked)
                {
                    start = new Point(xsin, ysin);
                    xsin = xvalue;
                    ysin = sy + (int)(Math.Sin(rad * -1 * negative) * (dy * a)) - (v * 70);
                    end = new Point(xsin, ysin);
                    if (theta != 0)
                    {
                        pictureboxes[booleans.trigplot].CreateGraphics().DrawLine(new Pen(Brushes.Red, s), start, end);
                    }
                    if (checkBox10.Checked && check == theta)
                    {
                        Invoke(new Action(() => chart1.Series["SINE"].Points.AddXY("", Math.Sin(rad * negative) * a)));
                        Invoke(new Action(() => chart1.Series["SINE1"].Points.AddXY("", Math.Sin(rad * negative) * a)));
                    }
                    if (checkBox1.Checked)
                    {
                        Invoke(new Action(() => label1.Location = new Point(xsin + 410, ysin + 75)));
                    }
                }
                #endregion

                //COSINE
                #region
                if (checkBox5.Checked)
                {
                    start = new Point(xcos, ycos);
                    xcos = xvalue;
                    if (true)
                    {
                        if (n == true)
                        {
                            ycos = sy - (int)(-1 * Math.Cos(rad) * (dy * a)) + v;
                        }
                        else
                        {
                            ycos = sy + (int)(-1 * Math.Cos(rad) * (dy * a)) + v;
                        }
                    }
                    end = new Point(xcos, ycos);
                    if (theta != 0)
                    {
                        pictureboxes[booleans.trigplot].CreateGraphics().DrawLine(new Pen(Brushes.Turquoise, s), start, end);
                    }
                    if (checkBox10.Checked && check == theta)
                    {
                        Invoke(new Action(() => chart1.Series["COSINE"].Points.AddXY("", negative * Math.Cos(rad) * a)));
                        Invoke(new Action(() => chart1.Series["COSINE1"].Points.AddXY("", negative * Math.Cos(rad) * a)));
                    }
                }
                #endregion

                //TANGENT
                #region
                if (checkBox7.Checked)
                {
                    start = new Point(xtan, ytan);
                    xtan = xvalue;
                    if (2 * Math.Tan(rad) < max && 2 * Math.Tan(rad) > -max)
                    {
                        ytan = sy + (int)(Math.Tan(rad * -1 * negative) * (dy * a)) - v;
                    }
                    end = new Point(xtan, ytan);
                    if (theta != 0)
                    {
                        pictureboxes[booleans.trigplot].CreateGraphics().DrawLine(new Pen(Brushes.Lime, s), start, end);
                    }
                }
                #endregion

                //COTANGENT
                #region
                if (checkBox6.Checked)
                {
                    start = new Point(xcot, ycot);
                    xcot = xvalue;
                    if (theta != 0)
                    {
                        if (1 / Math.Tan(rad) < max && 1 / Math.Tan(rad) > -max)
                        {
                            ycot = sy + (int)((1 / Math.Tan(rad * -1 * negative)) * (dy * a)) - v;
                            end = new Point(xcot, ycot);
                            if (theta != 0)
                            {
                                pictureboxes[booleans.trigplot].CreateGraphics().DrawLine(new Pen(Brushes.Orange, s), start, end);
                            }
                        }
                    }
                }
                #endregion

                //SECANT
                #region
                if (checkBox9.Checked)
                {
                    start = new Point(xsec, ysec);
                    xsec = xvalue;
                    if (2 * (1 / Math.Cos(rad)) < max && 2 * (1 / Math.Cos(rad)) > -max)
                    {
                        if (checkBox12.Checked)
                        {
                            ysec = sy + (int)((1 / Math.Cos(rad)) * (dy * a) + v);
                        }
                        else
                        {
                            ysec = sy + (int)(-1 * (1 / Math.Cos(rad)) * (dy * a) + v);
                        }
                        end = new Point(xsec, ysec);
                        if (theta != 0)
                        {
                            pictureboxes[booleans.trigplot].CreateGraphics().DrawLine(new Pen(Brushes.Gold, s), start, end);
                        }
                    }
                }
                #endregion

                //COSECANT
                #region
                if (checkBox8.Checked)
                {
                    start = new Point(xcsc, ycsc);
                    xcsc = xvalue;
                    if (theta != 0)
                    {
                        if (360 + (int)(2 * (1 / Math.Sin(rad)) * -1 * (60 * a)) - (v * 2) * 60 > -max && 360 + (int)(2 * (1 / Math.Sin(rad)) * -1 * (60 * a)) - (v * 2) * 60 < max)
                        {
                            ycsc = sy + (int)((1 / Math.Sin(rad * -1 * negative)) * (dy * a)) - v;
                            end = new Point(xcsc, ycsc);
                            if (theta != 0)
                            {
                                pictureboxes[booleans.trigplot].CreateGraphics().DrawLine(new Pen(Brushes.Violet, s), start, end);
                            }
                        }
                    }
                }
                #endregion
                if (checkBox3.Checked)
                {
                    UnitCircle();
                }
                if (checkBox2.Checked)
                {
                    Formulas();
                }
                if (check == theta)
                {
                    check += 5;
                }
                Invoke(new Action(() => label1.Text = ("θ = " + minus + theta + "°")));
                Invoke(new Action(() => label2.Text = "rad = " + minus + rad));
                Invoke(new Action(() => label28.Text = minus + amp + "sin(" + wav + theta + "°" + phas + ")" + vert));
                Thread.Sleep((int)numericUpDown6.Value);
            }
            Invoke(new Action(() => label22.Text = "Sinθ = opp/hyp = 1/cscθ = " + (int)Math.Sin(Math.PI / 180 * (theta - 1))));
            Invoke(new Action(() => label23.Text = "Cosθ = adj/hyp = 1/secθ = " + (int)Math.Cos(Math.PI / 180 * (theta - 1))));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            pictureBox1.Invalidate();
            pictureBox2.Invalidate();
            pictureBox3.Invalidate();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            label6.Text = "Period = 2π/" + numericUpDown3.Value.ToString();
            if (numericUpDown3.Value == -1)
            {
                numericUpDown3.Value = 1;
            }
            if (numericUpDown3.Value == 0)
            {
                numericUpDown3.Value = 1;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                label1.Location = new Point(142, 235);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void Formulas()
        {
            if (checkBox2.Checked)
            {
                if (inv == true)
                {
                    switch (funcA)
                    {
                        case 0:
                            {
                                if (theta < 1)
                                {
                                    rad = (float)Math.Asin(theta);
                                }
                                break;
                            }
                        case 1:
                            {
                                if (theta < 1)
                                {
                                    rad = (float)Math.Acos(theta);
                                }
                                break;
                            }
                        case 2:
                            {
                                rad = (float)Math.Atan(theta);
                                break;
                            }
                    }
                }
                else
                {
                    rad = (float)(Math.PI / 180 * theta);
                }
                int rounder = 3;
                if (round == true)
                {
                    rounder = 0;
                }
                float sin = (float)Math.Round((Math.Sin(rad)), rounder);
                float cos = (float)Math.Round((Math.Cos(rad)), rounder);
                float tan = (float)Math.Round((Math.Tan(rad)), rounder);
                float cot = (float)Math.Round((1 / Math.Tan(rad)), rounder);
                float sec = (float)Math.Round((1 / Math.Cos(rad)), rounder);
                float csc = (float)Math.Round((1 / Math.Sin(rad)), rounder);
                Invoke(new Action(() => label22.Text = "Sinθ = opp/hyp = 1/cscθ = " + sin));
                Invoke(new Action(() => label23.Text = "Cosθ = adj/hyp = 1/secθ = " + cos));

                //TAN
                if (tan < 0xFF && tan > -0xFF)
                {
                    Invoke(new Action(() => label24.Text = "Tanθ = opp/adj = sinθ/cosθ = 1/cotθ = " + tan));
                }
                else
                {
                    Invoke(new Action(() => label24.Text = "Tanθ = opp/adj = sinθ/cosθ = 1/cotθ = Undefined")); 
                }
                //COT
                if ((int)(cot) < 0xFF && (int)(cot) > -0xFF)
                {
                    Invoke(new Action(() => label25.Text = "Cotθ = adj/opp = cosθ/sinθ = 1/tanθ = " + cot));
                }
                else
                {
                    Invoke(new Action(() => label25.Text = "Cotθ = adj/opp = cosθ/sinθ = 1/tanθ = Undefined"));
                }
                //SEC
                if (sec < 0xFF && (int)sec > -0xFF)
                {
                    Invoke(new Action(() => label26.Text = "Secθ = hyp/adj = 1/cosθ = " + sec));
                }
                else
                {
                    Invoke(new Action(() => label26.Text = "Secθ = hyp/adj = 1/cosθ = Undefinded"));
                }
                //CSC
                if ((int)csc < 0xFF && (int)csc > -0xFF)
                {
                    Invoke(new Action(() => label27.Text = "Cscθ = hyp/opp = 1/sinθ = " + csc));
                }
                else
                {
                    Invoke(new Action(() => label27.Text = "Cscθ = hyp/opp = 1/sinθ = Undefinded"));
                }
                //ARCSIN
                Invoke(new Action(() => label21.Text = "Arcsin(-1 ≤ x ≤ 1) = " + Math.Round(Math.Asin(sin), 5)));
                //ARCCOS
                Invoke(new Action(() => label20.Text = "Arccos(-1 ≤ x ≤ 1) = " + Math.Round(Math.Acos(cos), 5)));
                //ARCTAN
                Invoke(new Action(() => label19.Text = "Arctan(-∞ ≤ x ≤ ∞) = " + Math.Round(Math.Atan(tan), 5)));
                /*
                //ARCCOT
                Invoke(new Action(() => label18.Text = "Arccot(-∞ ≤ x ≤ ∞) = " + Math.Round(Math.Atan(cot), 3)));
                //ARCSEC
                Invoke(new Action(() => label17.Text = "Arcsec(-1 ≤ x ≤ 1) = " + Math.Round(Math.Acos(sec), 3)));
                //ARCCSC
                Invoke(new Action(() => label16.Text = "Arccsc(-1 ≤ x ≤ 1) = " + Math.Round(Math.Asin(csc), 3)));
                */
            }
        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                pictureBox2.Visible = true;
                checkBox11.Enabled = true;
            }
            else
            {
                pictureBox2.Visible = false;
                checkBox11.Checked = false;
                checkBox11.Enabled = false;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void UnitCircle()
        {
            int arc = 90;
            int pos = -1;
            float oldrad = 0;
            if (n == true)
            {
                pos = 1;
            }
            int o = 120;
            int radii = 78;
            if (inv == true)
            {
                switch (funcA)
                {
                    case 0:
                        {
                            rad = (float)(Math.Asin(theta));
                            if (theta - (0.01f * (int)numericUpDown7.Value) > -1)
                            {
                                oldrad = (float)(Math.Asin(theta - (0.01f * (int)numericUpDown7.Value)));
                            }
                            else
                            {
                                oldrad = (float)(-Math.PI / 2);
                            }
                            break;
                        }
                    case 1:
                        {
                            rad = (float)(Math.Acos(theta));
                            if (theta - (0.01f * (int)numericUpDown7.Value) > -1)
                            {
                                oldrad = (float)(Math.Acos(theta - (0.01f * (int)numericUpDown7.Value)));
                            }
                            else
                            {
                                oldrad = (float)Math.PI;
                            }
                            break;
                        }
                    case 2:
                        {
                            rad = (float)(Math.Atan(theta));
                            oldrad = (float)(Math.Atan(theta - (0.2f * (int)numericUpDown7.Value)));
                            break;
                        }
                }
            }
            else if (inv == false)
            {
                rad = (float)((Math.PI / 180) * theta);
                oldrad = (float)((Math.PI / 180) * (theta - 2));
            }
            Point hypoldendingpoint = new Point();
            Point hypnewendingpoint = new Point();
            if (n == true)
            {
                if (funcA == 1)
                {
                    hypoldendingpoint = new Point((int)(o - Math.Cos(oldrad) * radii), o - (int)(Math.Sin(oldrad) * radii));
                    hypnewendingpoint = new Point((int)(o - Math.Cos(rad) * radii), o - (int)(Math.Sin(rad) * radii));
                }
                else
                {
                    hypoldendingpoint = new Point((int)(o + Math.Cos(oldrad) * radii), o + (int)(Math.Sin(oldrad) * radii));
                    hypnewendingpoint = new Point((int)(o + Math.Cos(rad) * radii), o + (int)(Math.Sin(rad) * radii));
                }
            }
            else if (n == false)
            {
                hypoldendingpoint = new Point((int)(o + Math.Cos(oldrad) * radii), o - (int)(Math.Sin(oldrad) * radii));
                hypnewendingpoint = new Point((int)(o + Math.Cos(rad) * radii), o - (int)(Math.Sin(rad) * radii));
            }
            if (inv == false)
            {
                if (checkBox4.Checked)
                {
                    //OPP
                    Point deleteoppositestart = new Point((int)(Math.Cos(oldrad) * radii) + o, o);
                    pictureBox2.CreateGraphics().DrawLine(new Pen(Backcolor, 3), deleteoppositestart, hypoldendingpoint);

                    Point oppositestart = new Point((int)(Math.Cos(rad) * radii) + o, o);
                    pictureBox2.CreateGraphics().DrawLine(new Pen(Brushes.Red, 3), oppositestart, hypnewendingpoint);
                }

                if (checkBox5.Checked)
                {
                    //ADJ

                    Point deleteadjacentstart = new Point(o, (int)(Math.Sin(oldrad * pos) * radii) + o);
                    pictureBox2.CreateGraphics().DrawLine(new Pen(Backcolor, 3), deleteadjacentstart, hypoldendingpoint);

                    Point adjacentstart = new Point(o, (int)(Math.Sin(rad * pos) * radii) + o);
                    pictureBox2.CreateGraphics().DrawLine(new Pen(Brushes.Turquoise, 3), adjacentstart, hypnewendingpoint);
                }
            }
            try
            {
                //HYP
                Point deletehypotenusestart = new Point(o, o);
                pictureBox2.CreateGraphics().DrawLine(new Pen(Backcolor, 3), deletehypotenusestart, hypoldendingpoint);

                Point hypotenusestart = new Point(o, o);
                pictureBox2.CreateGraphics().DrawLine(new Pen(Brushes.Black, 3), hypotenusestart, hypnewendingpoint);

                //AXIS
                Point x = new Point(0, o);
                Point x2 = new Point(o * 2, o);
                pictureBox2.CreateGraphics().DrawLine(new Pen(Brushes.Black, 2), x, x2);

                Point y = new Point(o, 0);
                Point y2 = new Point(o, o * 2);
                pictureBox2.CreateGraphics().DrawLine(new Pen(Brushes.Black, 2), y, y2);

                //ARC
                Point oldarc = new Point();
                Point newarc = new Point();
                if (true)
                {
                    if (n == true)
                    {
                        if (funcA == 1)
                        {
                            oldarc = new Point((int)(o - Math.Cos(oldrad) * arc), o - (int)(Math.Sin(oldrad) * arc));
                            newarc = new Point((int)(o - Math.Cos(rad) * arc), o - (int)(Math.Sin(rad) * arc));
                        }
                        else
                        {
                            oldarc = new Point((int)(o + Math.Cos(oldrad) * arc), o + (int)(Math.Sin(oldrad) * arc));
                            newarc = new Point((int)(o + Math.Cos(rad) * arc), o + (int)(Math.Sin(rad) * arc));
                        }
                    }
                    else if (n != true)
                    {
                        if (funcA == 1)
                        {
                            oldarc = new Point((int)(o + Math.Cos(oldrad) * arc), o - (int)(Math.Sin(oldrad) * arc));
                            newarc = new Point((int)(o + Math.Cos(rad) * arc), o - (int)(Math.Sin(rad) * arc));
                        }
                        else
                        {
                            oldarc = new Point((int)(o + Math.Cos(oldrad) * arc), o - (int)(Math.Sin(oldrad) * arc));
                            newarc = new Point((int)(o + Math.Cos(rad) * arc), o - (int)(Math.Sin(rad) * arc));
                        }
                    }
                    pictureBox2.CreateGraphics().DrawLine(new Pen(Brushes.Gold, 4), oldarc, newarc);
                }
                //RELATIONSHIP
                if (checkBox11.Checked)
                {
                    if (n == true)
                    {
                        if (funcA == 0)
                        {
                            Invoke(new Action(() => panel5.Location = new Point(254 + (int)(radii * Math.Cos(rad * pos)), 343)));
                            Invoke(new Action(() => panel6.Location = new Point(254, 343 + (int)(radii * Math.Sin(rad * pos)))));
                        } 
                        else if (funcA == 1)
                        {
                            Invoke(new Action(() => panel5.Location = new Point(254 - (int)(radii * Math.Cos(rad * pos)), 343)));
                            Invoke(new Action(() => panel6.Location = new Point(254, 343 - (int)(radii * Math.Sin(rad * pos)))));
                        }
                    }
                    else
                    {
                        Invoke(new Action(() => panel5.Location = new Point((int)(radii * Math.Cos(rad * pos)) + 254, 343)));
                        Invoke(new Action(() => panel6.Location = new Point(254, 343 + (int)(radii * Math.Sin(rad * pos)))));
                    }
                }
            }
            catch
            {
                //MessageBox.Show("rad: " + rad + " oldrad: " + oldrad + Environment.NewLine + "hypnewendingpoint: " + hypnewendingpoint + Environment.NewLine + "hypoldendingpoint: " + hypoldendingpoint + Environment.NewLine + "oldrad calc: " + (theta - 0.005f));
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                panel4.Visible = true;
            }
            else
            {
                panel4.Visible = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "360";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = (Math.PI * 4).ToString();
        }

        private void getdeg()
        {
            if (radioButton2.Checked)
            {
                endingpoint = (int)((180 / Math.PI) * Convert.ToDouble(textBox1.Text));
            }
            else
            {
                endingpoint = Convert.ToInt32(textBox1.Text);
            }
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            label8.Text = "Midline: " + numericUpDown4.Value.ToString();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            label9.Text = "Amplitude: " + numericUpDown2.Value.ToString();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                chart1.Visible = true;
            }
            else
            {
                chart1.Visible = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Invalidate();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Invalidate();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                panel5.Visible = true;
                panel6.Visible = true;
            }
            else
            {
                panel5.Visible = false;
                panel6.Visible = false;
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {
                n = true;
            }
            else
            {
                n = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            Thread graphinv = new Thread(new ThreadStart(GraphInverse));
            graphinv.Start();
        }

        private void GraphInverse()
        {
            round = false;
            Invoke(new Action(() => chart1.Series["SINE"].Points.Clear()));
            Invoke(new Action(() => chart1.Series["COSINE"].Points.Clear()));
            Invoke(new Action(() => chart1.Series["SINE1"].Points.Clear()));
            Invoke(new Action(() => chart1.Series["COSINE1"].Points.Clear()));
            pictureBox2.Invalidate();
            if (radioButton3.Checked == true)
            {
                funcA = 0;
            }
            if (radioButton4.Checked == true)
            {
                funcA = 1;
            }
            if (radioButton5.Checked == true)
            {
                funcA = 2;
            }
            Point start;
            Point end;
            int xasin = 416;
            int yasin = 386;
            float xacos = 416;
            int yacos = 62;
            int xatan = -1;
            int yatan = 277;
            int dx = 70;
            int dy = 70;
            int sx = 486;
            int sysin = 277;
            int sycos = 62;
            int sytan = 277;
            int negative = 1;
            int s = (int)numericUpDown1.Value;
            int deginterval = (int)numericUpDown7.Value;
            string minus = "";
            if (checkBox12.Checked)
            {
                yacos = 277;
                negative = -1;
            }
            getdeg();
            switch (funcA)
            {
                //ARCSINE
                #region
                case 0:
                    {
                        for (theta = -1; theta <= 1; theta += 0.01f * deginterval)
                        {
                            start = new Point(xasin, yasin);
                            xasin = sx + (int)(theta * dx);
                            yasin = sysin + (int)(Math.Asin(theta * -1 * negative) * dy);
                            end = new Point(xasin, yasin);
                            if (theta != -1)
                            {
                                pictureBox3.CreateGraphics().DrawLine(new Pen(Brushes.Red, s), start, end);
                            }
                            if (checkBox10.Checked)
                            {
                                Invoke(new Action(() => chart1.Series["SINE"].Points.AddXY("", Math.Asin(theta))));
                                Invoke(new Action(() => chart1.Series["SINE1"].Points.AddXY("", Math.Asin(theta))));
                            }
                            if (checkBox3.Checked)
                            {
                                UnitCircle();
                            }
                            if (checkBox1.Checked)
                            {
                                Invoke(new Action(() => label1.Location = new Point(xasin + 410, yasin + 75)));
                            }
                            if (checkBox2.Checked)
                            {
                                Formulas();
                            }
                            Invoke(new Action(() => label1.Text = ("θ = " + minus + (int)((float)((180 / Math.PI) * Math.Asin(theta * negative)) + negative) + "°")));
                            Invoke(new Action(() => label2.Text = "π = " + minus + Math.Round(Math.Asin(theta * negative), 8)));
                            Thread.Sleep((int)numericUpDown6.Value);
                        }
                        break;
                    }
                #endregion

                //ARCCOSINE
                #region
                case 1:
                    {
                        int roundtheta = 0;
                        for (theta = -1; theta <= 1; theta += 0.01f * deginterval)
                        {
                            start = new Point((int)xacos, yacos);
                            xacos = sx + (int)(theta * dx);
                            yacos = sycos + (int)(Math.Acos(theta * -1 * negative) * dy);
                            end = new Point((int)xacos, yacos);
                            if (theta != 0)
                            {
                                pictureBox3.CreateGraphics().DrawLine(new Pen(Brushes.Red, s), start, end);
                            }
                            if (checkBox10.Checked)
                            {
                                Invoke(new Action(() => chart1.Series["COSINE"].Points.AddXY("", Math.Acos(theta))));
                                Invoke(new Action(() => chart1.Series["COSINE1"].Points.AddXY("", Math.Acos(theta))));
                            }
                            if (checkBox3.Checked)
                            {
                                UnitCircle();
                            }
                            if (checkBox1.Checked)
                            {
                                Invoke(new Action(() => label1.Location = new Point((int)xacos + 410, yacos + 75)));
                            }
                            if (checkBox2.Checked)
                            {
                                Formulas();
                            }
                            if (negative == -1)
                            {
                                Invoke(new Action(() => label1.Text = ("θ = " + minus + (int)((float)(180 - (180 / Math.PI) * Math.Acos(theta)) + 1) + "°")));
                                Invoke(new Action(() => label2.Text = "π = " + minus + (Math.Round(Math.PI, 8) - Math.Round(Math.Acos(theta), 8))));
                            }
                            else if (negative != -1)
                            {
                                Invoke(new Action(() => label1.Text = ("θ = " + minus + (int)((float)((180 / Math.PI) * Math.Acos(theta))) + "°")));
                                Invoke(new Action(() => label2.Text = "π = " + minus + Math.Round(Math.Acos(theta), 8)));
                            }
                            roundtheta = (int)Math.Round(Math.Acos(theta), 0);
                            Thread.Sleep((int)numericUpDown6.Value);
                        }
                        Invoke(new Action(() => label2.Text = "π = " + minus + roundtheta));
                        break;
                    }
                #endregion

                //ARCTANGENT
                #region
                case 2:
                    {
                        xacos = 0;
                        for (theta = -45; theta <= 45; theta += 0.2f * deginterval)
                        {
                            start = new Point(xatan, yatan);
                            xatan = sx + (int)(theta * dx);
                            yatan = sytan + (int)(Math.Atan(theta * -1 * negative) * dy);
                            end = new Point(xatan, yatan);
                            if (theta != 0)
                            {
                                pictureBox3.CreateGraphics().DrawLine(new Pen(Brushes.Red, s), start, end);
                            }
                            if (theta > 1)
                            {
                                xacos = 1.5f;
                            }
                            if (checkBox10.Checked)
                            {
                                Invoke(new Action(() => chart1.Series["COSINE"].Points.AddXY("", Math.Atan(theta))));
                                Invoke(new Action(() => chart1.Series["COSINE1"].Points.AddXY("", Math.Atan(theta))));
                            }
                            if (checkBox3.Checked)
                            {
                                UnitCircle();
                            }
                            if (checkBox1.Checked)
                            {
                                Invoke(new Action(() => label1.Location = new Point(xatan + 410, yatan + 75)));
                            }
                            if (checkBox2.Checked)
                            {
                                Formulas();
                            }
                            Invoke(new Action(() => label1.Text = ("θ = " + minus + (int)((float)((180 / Math.PI) * Math.Atan(theta * negative)) + (negative * xacos))) + "°"));
                            Invoke(new Action(() => label2.Text = "π = " + minus + Math.Round(Math.Atan(theta * negative), 8)));
                            Thread.Sleep((int)numericUpDown6.Value);
                        }
                        break;
                    }
                    #endregion
            }
            round = true;
            if (checkBox2.Checked)
            {
                Formulas();
            }
            Invoke(new Action(() => button4.Enabled = true));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void IndexChanged(object sender, EventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                case 0:
                    pictureBox1.Visible = true;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    Visible1(true);
                    inv = false;
                    funcA = 0;
                    break;
                case 1:
                    pictureBox3.Visible = true;
                    pictureBox1.Visible = false;
                    pictureBox4.Visible = false;
                    Visible1(true);
                    inv = true;
                    break;
                case 2:
                    pictureBox1.Visible = false;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = false;
                    Visible1(false);
                    inv = false;
                    break;
                case 3:
                    Visible1(false);
                    label1.Visible = true;
                    label2.Visible = true;
                    if (checkBox2.Checked)
                    {
                        panel4.Visible = true;
                    }

                    pictureBox1.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = true;
                    inv = false;
                    break;
                case 4:
                    pictureBox1.Visible = false;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = false;
                    Visible1(false);
                    inv = false;
                    break;
                case 5:
                    {
                        pictureBox1.Visible = false;
                        pictureBox3.Visible = true;
                        pictureBox4.Visible = false;
                        Visible1(false);
                        inv = false;
                        break;
                    }
            }
        }

        private void Visible1(bool visible)
        {
            panel4.Visible = visible;
            pictureBox2.Visible = visible;
            chart1.Visible = visible;
            panel6.Visible = visible;
            panel5.Visible = visible;
            label1.Visible = visible;
            label2.Visible = visible;
            label9.Visible = visible;
            label8.Visible = visible;
            label6.Visible = visible;
            label14.Visible = visible;
            label15.Visible = visible;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form domainsandranges = new Form2();
            domainsandranges.Show();
        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            solvelog();
        }

        private void solvelog()
        {
            label18.Text = "logx(" + numericUpDown9.Value + ")";
            label29.Text = "logx(" + numericUpDown8.Value + ")";
            try
            {
                int base_ = (int)numericUpDown8.Value;
                int of = (int)numericUpDown9.Value;
                textBox2.Text = (Math.Log10(of) / Math.Log10(base_)).ToString();
            }
            catch
            {
                textBox2.Text = "Too big, sorry";
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form changeofbasetheorem = new Form3();
            changeofbasetheorem.Show();
        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {
            solvelog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Thread graphlog = new Thread(new ThreadStart(GraphLogarithm));
            graphlog.Start();
        }

        private void GraphLogarithm()
        {
            fixlog();
            int ms = (int)numericUpDown6.Value;
            int s = (int)numericUpDown1.Value;
            Point start = new Point();
            Point end = new Point();
            float y;
            int dx = 70;
            int dy = 70;
            int sx = 487;
            int sy = 277;
            double b = 0;
            try
            {
                b = Convert.ToDouble(textBox3.Text);
            }
            catch
            {

            }
            //LOG
            #region
            if (radioButton7.Checked == true)
            {
                int x1 = 487;
                int y1 = 555;
                for (float x = 0.05f; x <= 7; x += 0.05f)
                {
                    start = new Point(x1, y1);
                    x1 = (int)(x * dx) + sx;
                    y1 = sy + (int)(Math.Log(x, b) * dy * -1);
                    end = new Point(x1, y1);
                    if (b > 1)
                    {
                        pictureBox3.CreateGraphics().DrawLine(new Pen(Brushes.Red, s), start, end);
                    }
                    else
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            Invoke(new Action(() => label31.Font = new Font(label31.Font, FontStyle.Bold)));
                            Thread.Sleep(500);
                            Invoke(new Action(() => label31.Font = new Font(label31.Font, FontStyle.Regular)));
                            Thread.Sleep(500);
                        }
                        break;
                    }
                    Invoke(new Action(() => label28.Text = "log" + b + "(" + Math.Round(x, 2).ToString() + ")"));
                    Invoke(new Action(() => label33.Text = "a = " + Math.Round(x, 2)));
                    Invoke(new Action(() => label34.Text = "Y = " + Math.Round(Math.Log(x, b), 5)));
                    Thread.Sleep(ms * 2);
                }
            }
            #endregion

            //LOG BASE
            #region
            else
            {
                int x1 = 277;
                int y1 = 0;
                for (float x = 1.05f; x <= 7; x += 0.05f)
                {
                    y = (float)Math.Log(b, x);
                    start = new Point(x1, y1);
                    x1 = (int)(x * dx) + sx;
                    y1 = sy + (int)(y * dy * -1);
                    end = new Point(x1, y1);
                    if (b > 0)
                    {
                        pictureBox3.CreateGraphics().DrawLine(new Pen(Brushes.Red, s), start, end);
                    }
                    else
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            Invoke(new Action(() => label31.Font = new Font(label31.Font, FontStyle.Bold)));
                            Thread.Sleep(500);
                            Invoke(new Action(() => label31.Font = new Font(label31.Font, FontStyle.Regular)));
                            Thread.Sleep(500);
                        }
                        break;
                    }
                    Invoke(new Action(() => label28.Text = "log" + x + "(" + Math.Round(b, 2).ToString() + ")"));
                    Invoke(new Action(() => label33.Text = "b = " + Math.Round(x, 2)));
                    Invoke(new Action(() => label34.Text = "Y = " + Math.Round(y, 5)));
                    Thread.Sleep(ms * 2);
                }
            }
            #endregion
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            fixlog();
            textBox3.Text = "10";
            label32.Text = "Base:";
            label31.Text = "Remember, the base domain is x > 1:";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            fixlog();
            textBox3.Text = "2";
            label32.Text = "Number:";
            label31.Text = "Remember, the log domain is x > 0:";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            fixlog();
        }

        private void fixlog()
        {
            if (radioButton7.Checked)
            {
                Invoke(new Action(() => label36.Text = textBox3.Text));
                label37.Text = "a";
                Invoke(new Action(() => label37.Location = new Point((textBox3.Text.Length * 7) + 42, 6)));
            }
            else
            {
                label37.Text = textBox3.Text;
                label37.Location = new Point(48, 6);
                label36.Text = "b";
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Thread unitcircle = new Thread(new ThreadStart(UnitCircle1));
            unitcircle.Start();
        }

        private void UnitCircle1()
        {
            double initialS = Convert.ToDouble(textBox4.Text);
            double terminalS = Convert.ToDouble(textBox5.Text);
            double radii = 1;
            int dx = 402;
            int dy = 403;
            int radius = 243;
            int arcradius = 253;
            if (radioButton2.Checked)
            {
                radii = Math.PI / 180;
            }
            double rad = 0;
            double oldrad = 0;
            double interval = (double)numericUpDown12.Value * radii;
            int thickness = (int)numericUpDown10.Value;
            pictureBox4.Invalidate();
            if (initialS < terminalS)
            {
                Point hypoldendingpoint = new Point();
                Point hypnewendingpoint = new Point();
                Point origin = new Point(dx, dy);
                for (theta = (float)initialS; theta <= terminalS; theta += (float)interval)
                {
                    oldrad = (Math.PI / 180) * (theta - interval);
                    rad = (Math.PI / 180) * (theta);

                    //FORMULAS
                    if (checkBox2.Checked)
                    {
                        Formulas();
                    }

                    //AXIS
                    #region
                    Point x_0 = new Point(70, 402);
                    Point x_1 = new Point(730, 402);
                    pictureBox4.CreateGraphics().DrawLine(new Pen(Brushes.Black, 3), x_0, x_1);
                    Point y_0 = new Point(dx, 70);
                    Point y_1 = new Point(dx, 730);
                    pictureBox4.CreateGraphics().DrawLine(new Pen(Brushes.Black, 3), y_0, y_1);
                    #endregion

                    //CIRCLE
                    #region
                    for (int i = 0; i <= 360; i += 10)
                    {
                        double oldrad1 = (Math.PI / 180) * (i - 10);
                        double rad1 = (Math.PI / 180) * i;
                        Point oldarc = new Point((int)(Math.Cos(oldrad1 * -1) * radius) + dx, (int)(Math.Sin(oldrad1 * -1) * radius) + dy);
                        Point newarc = new Point((int)(Math.Cos(rad1 * -1) * radius) + dx, (int)(Math.Sin(rad1 * -1) * radius) + dy);
                        //MessageBox.Show("oldrad1: " + oldrad1 + " rad1: " + rad1 + Environment.NewLine + "Oldarc coords: " + oldarc + Environment.NewLine + "Newarc coords: " + newarc);
                        pictureBox4.CreateGraphics().DrawLine(new Pen(Brushes.DarkGray, thickness + 4), oldarc, newarc);
                    }
                    #endregion

                    //HYPOTENUSE
                    #region
                    hypoldendingpoint = new Point((int)((Math.Cos(oldrad * -1) * radius) + dx), (int)(Math.Sin(oldrad * -1) * radius) + dy);
                    hypnewendingpoint = new Point((int)((Math.Cos(rad * -1) * radius) + dx), (int)(Math.Sin(rad * -1) * radius) + dy);
                    pictureBox4.CreateGraphics().DrawLine(new Pen(Backcolor, thickness), origin, hypoldendingpoint);

                    Point hypotenusestart = new Point(dx, dy);
                    pictureBox4.CreateGraphics().DrawLine(new Pen(Brushes.Black, thickness), origin, hypnewendingpoint);
                    #endregion

                    //OPPOSITE
                    #region
                    Point OPPoldendingpoint = new Point((int)((Math.Cos(oldrad * -1) * radius) + dx), dy);
                    Point OPPnewendingpoint = new Point((int)((Math.Cos(rad * -1) * radius) + dx), dy);
                    Point OPP2oldendingpointUP = new Point(dx, (int)((Math.Sin(oldrad * -1) * radius) + dy));
                    Point OPP2newendingpointUP = new Point(dx, (int)((Math.Sin(rad * -1) * radius) + dy));
                    if (checkBox18.Checked)
                    {
                        pictureBox4.CreateGraphics().DrawLine(new Pen(Backcolor, thickness), OPPoldendingpoint, hypoldendingpoint);
                        pictureBox4.CreateGraphics().DrawLine(new Pen(Brushes.Red, thickness), OPPnewendingpoint, hypnewendingpoint);
                        //#2
                        pictureBox4.CreateGraphics().DrawLine(new Pen(Backcolor, thickness), origin, OPP2oldendingpointUP);
                        pictureBox4.CreateGraphics().DrawLine(new Pen(Brushes.Red, thickness), origin, OPP2newendingpointUP);
                    }
                    #endregion

                    //ADJACENT
                    #region
                    Point ADJoldendingpoint = new Point((int)((Math.Cos(oldrad * -1) * radius) + dx), dy);
                    Point ADJnewendingpoint = new Point((int)((Math.Cos(rad * -1) * radius) + dx), dy);
                    if (checkBox17.Checked)
                    {
                        pictureBox4.CreateGraphics().DrawLine(new Pen(Backcolor, thickness), origin, OPPoldendingpoint);
                        pictureBox4.CreateGraphics().DrawLine(new Pen(Brushes.Turquoise, thickness), origin, OPPnewendingpoint);
                        //#2
                        pictureBox4.CreateGraphics().DrawLine(new Pen(Backcolor, thickness), OPP2oldendingpointUP, hypoldendingpoint);
                        pictureBox4.CreateGraphics().DrawLine(new Pen(Brushes.Turquoise, thickness), OPP2newendingpointUP, hypnewendingpoint);
                    }
                    #endregion

                    //TANGENT & SECANT
                    #region
                    Point TANoldendingpoint = new Point((int)((1 / Math.Cos(oldrad) * radius) + dx), dy);
                    Point SEColdendingpoint = new Point((int)((1 / Math.Cos(oldrad) * radius) + dx), dy + 5);
                    Point TANnewendingpoint = new Point((int)((1 / Math.Cos(rad) * radius) + dx), dy);
                    Point SECnewendingpoint = new Point((int)((1 / Math.Cos(rad) * radius) + dx), dy + 5);
                    if (checkBox16.Checked)
                    {
                        Point secorigin = new Point(dx, dy + 5);
                        if (Math.Tan(oldrad) < 0xFF && Math.Tan(oldrad) > -0xFF)
                        {
                            pictureBox4.CreateGraphics().DrawLine(new Pen(Backcolor, thickness), hypoldendingpoint, TANoldendingpoint);
                            //SECANT
                            if (checkBox14.Checked)
                            {
                                pictureBox4.CreateGraphics().DrawLine(new Pen(Backcolor, thickness), secorigin, SEColdendingpoint);
                            }
                        }
                        if (Math.Tan(rad) < 0xFF && Math.Tan(rad) > -0xFF)
                        {
                            pictureBox4.CreateGraphics().DrawLine(new Pen(Brushes.Tan, thickness), hypnewendingpoint, TANnewendingpoint);
                            if (checkBox14.Checked)
                            {
                                pictureBox4.CreateGraphics().DrawLine(new Pen(Brushes.DarkCyan, thickness), secorigin, SECnewendingpoint);
                            }
                        }
                    }
                    #endregion

                    //COTANGENT & COSECANT
                    #region
                    Point COToldendingpoint = new Point(dx, (int)((1 / Math.Sin(oldrad * -1) * radius) + dy));
                    Point CSColdendingpoint = new Point(dx - 5, (int)((1 / Math.Sin(oldrad * -1) * radius) + dy));
                    Point COTnewendingpoint = new Point(dx, (int)((1 / Math.Sin(rad * -1) * radius) + dy));
                    Point CSCnewendingpoint = new Point(dx - 5, (int)((1 / Math.Sin(rad * -1) * radius) + dy));
                    if (checkBox15.Checked)
                    {
                        Point cscorigin = new Point(dx - 5, dy);
                        if (1 / Math.Sin(oldrad) < 0xFF && 1 / Math.Sin(oldrad) > -0xFF)
                        {
                            pictureBox4.CreateGraphics().DrawLine(new Pen(Backcolor, thickness), hypoldendingpoint, COToldendingpoint);
                            if (checkBox13.Checked)
                            {
                                pictureBox4.CreateGraphics().DrawLine(new Pen(Backcolor, thickness), cscorigin, CSColdendingpoint);
                            }
                        }
                        if (1 / Math.Sin(rad) < 0xFF && 1 / Math.Sin(rad) > -0xFF)
                        {
                            pictureBox4.CreateGraphics().DrawLine(new Pen(Brushes.Orange, thickness), hypnewendingpoint, COTnewendingpoint);
                            if (checkBox13.Checked)
                            {
                                pictureBox4.CreateGraphics().DrawLine(new Pen(Brushes.Violet, thickness), cscorigin, CSCnewendingpoint);
                            }

                        }
                    }
                    #endregion

                    //VERSINE & COVERSINE
                    #region
                    if (checkBox21.Checked)
                    {
                        Point VsinstartOld;
                        Point VsinstartNew;
                        if (Math.Cos(oldrad) > 0)
                        {
                            VsinstartOld = new Point(dx + radius, dy);
                        }
                        else
                        {
                            VsinstartOld = new Point(dx - radius, dy);
                        }
                        if (Math.Cos(rad) > 0)
                        {
                            VsinstartNew = new Point(dx + radius, dy);
                            Invoke(new Action(() => label45.Text = "Versine: " + Math.Round((1 - Math.Cos(rad)), 3)));
                        }
                        else
                        {
                            VsinstartNew = new Point(dx - radius, dy);
                            Invoke(new Action(() => label45.Text = "Versine: -" + Math.Round((1 + Math.Cos(-1 * rad)), 3)));
                        }
                        pictureBox4.CreateGraphics().DrawLine(new Pen(Backcolor, thickness), VsinstartOld, ADJoldendingpoint);
                        pictureBox4.CreateGraphics().DrawLine(new Pen(Brushes.Lime, thickness), VsinstartNew, ADJnewendingpoint);
                    }
                    if (checkBox20.Checked)
                    {
                        Point COVsinstartOld;
                        Point COVsinstartNew;
                        if (Math.Sin(oldrad) > 0)
                        {
                            COVsinstartOld = new Point(dx, dy - radius);
                        }
                        else
                        {
                            COVsinstartOld = new Point(dx, dy + radius);
                        }
                        if (Math.Sin(rad) > 0)
                        {
                            COVsinstartNew = new Point(dx, dy - radius);
                            Invoke(new Action(() => label46.Text = "Coversine: " + Math.Round((1 - Math.Sin(rad)), 3)));
                        }
                        else
                        {
                            COVsinstartNew = new Point(dx, dy + radius);
                            Invoke(new Action(() => label46.Text = "Coversine: -" + Math.Round((1 + Math.Sin(rad)), 3)));
                        }
                        pictureBox4.CreateGraphics().DrawLine(new Pen(Backcolor, thickness), COVsinstartOld, OPP2oldendingpointUP);
                        pictureBox4.CreateGraphics().DrawLine(new Pen(Brushes.RoyalBlue, thickness), COVsinstartNew, OPP2newendingpointUP);
                    }
                    #endregion

                    //ARC
                    #region
                    if (checkBox19.Checked)
                    {
                        if (theta > 360)
                        {
                            for (int i = 0; i < 360; i += (int)interval + 5)
                            {
                                float oldnewrad = (float)(Math.PI / 180) * (i - ((int)interval + 5));
                                float newrad = (float)(Math.PI / 180) * i;
                                Point OldArc = new Point((int)((Math.Cos(oldnewrad * -1) * arcradius) + dx), (int)((Math.Sin(oldnewrad * -1) * arcradius) + dy));
                                Point NewArc = new Point((int)((Math.Cos(newrad * -1) * arcradius) + dx), (int)((Math.Sin(newrad * -1) * arcradius) + dy));
                                pictureBox4.CreateGraphics().DrawLine(new Pen(Brushes.Gold, thickness), OldArc, NewArc);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < theta; i += (int)interval + 5)
                            {
                                float oldnewrad = (float)(Math.PI / 180) * (i - ((int)interval + 5));
                                float newrad = (float)(Math.PI / 180) * i;
                                Point OldArc = new Point((int)((Math.Cos(oldnewrad * -1) * arcradius) + dx), (int)((Math.Sin(oldnewrad * -1) * arcradius) + dy));
                                Point NewArc = new Point((int)((Math.Cos(newrad * -1) * arcradius) + dx), (int)((Math.Sin(newrad * -1) * arcradius) + dy));
                                pictureBox4.CreateGraphics().DrawLine(new Pen(Brushes.Gold, thickness), OldArc, NewArc);
                            }
                        }
                        Invoke(new Action(() => label44.Text = "Arc: " + Math.Round(rad, 8)));
                    }
                    #endregion

                    if (theta == 360)
                    {
                        Invoke(new Action(() => label46.Text = "Coversine: 1"));
                        Invoke(new Action(() => label44.Text = "Arc: 2π"));
                    }
                    //Move Circle
                    Thread.Sleep((int)numericUpDown13.Value);
                    Invoke(new Action(() => label1.Text = "θ = " + theta + "°"));
                    Invoke(new Action(() => label2.Text = "rad = " + rad));
                    //MessageBox.Show("oldrad: " + oldrad + " rad: " + rad + Environment.NewLine + "Interval: " + interval + Environment.NewLine + "Old Hyp Point: " + hypoldendingpoint + Environment.NewLine + "New Hyp Point:" + hypnewendingpoint);
                }
                if (checkBox13.Checked && checkBox14.Checked && theta != 360)
                {
                    //AXIS
                    #region
                    if (true)
                    {
                        Point x_0 = new Point(70, 402);
                        Point x_1 = new Point(730, 402);
                        pictureBox4.CreateGraphics().DrawLine(new Pen(Brushes.Black, 3), x_0, x_1);
                        Point y_0 = new Point(dx, 70);
                        Point y_1 = new Point(dx, 730);
                        pictureBox4.CreateGraphics().DrawLine(new Pen(Brushes.Black, 3), y_0, y_1);
                    }
                    #endregion
                }
            }
            else
            {
            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            clearCircle();
        }
        private void clearCircle()
        {
            pictureBox4.Invalidate();
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            clearCircle();
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            clearCircle();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pictureBox4.Invalidate();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Gray")
            {
                Backcolor = Color.Gray;
            }
            if (comboBox1.Text == "DimGray")
            {
                Backcolor = Color.DimGray;
            }
            if (comboBox1.Text == "DarkOliveGreen")
            {
                Backcolor = Color.DarkOliveGreen;
            }
            if (comboBox1.Text == "DarkSlateGray")
            {
                Backcolor = Color.DarkSlateGray;
            }
            if (comboBox1.Text == "Black")
            {
                Backcolor = Color.Black;
            }
            this.BackColor = Backcolor;
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox19.Checked)
            {
                label44.Visible = true;
            }
            else
            {
                label44.Visible = false;
            }
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox21.Checked)
            {
                label45.Visible = true;
            }
            else
            {
                label45.Visible = false;
            }
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked)
            {
                label46.Visible = true;
            }
            else
            {
                label46.Visible = false;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Thread mitrix = new Thread(new ThreadStart(matrixtriangle));
            mitrix.Start();
        }

        private void matrixtriangle()
        {

            int totalShapes = (int)numericUpDown11.Value;
            int h = 0;
            while(h < totalShapes)
            {
                Color[] color = { Color.Red, Color.Lime, Color.Turquoise, Color.Purple, Color.Green, Color.Purple, Color.Yellow, Color.White, Color.Brown, Color.PowderBlue, Color.Orange };
                Point A;
                Point B;
                Point C;
                Point D;
                int thick = ran.Next(2, 7);
                int dx = ran.Next(100, 800);
                int dy = ran.Next(100, 500);
                //Verticies
                int Ax = ran.Next(150, 200);
                int Ay = ran.Next(-70, 0);
                int Bx = ran.Next(100, 200);
                int By = ran.Next(100, 200);
                int Cx = ran.Next(-75, 25);
                int Cy = ran.Next(75, 150);
                int Dx = ran.Next(-50, 15);
                int Dy = ran.Next(-175, -50);
                Color sideAcolor = color[ran.Next(color.Length)];
                Color sideBcolor = color[ran.Next(color.Length)];
                Color sideCcolor = color[ran.Next(color.Length)];
                Color sideDcolor = color[ran.Next(color.Length)];
                int waittime = (ran.Next(0, 15));
                float ranscale = (float)Math.Pow(ran.Next(3, 30), 1f / 3f) - 1.2f;
                float[] preimage = { Ax * ranscale, Ay * ranscale, Bx * ranscale, By * ranscale, Cx * ranscale, Cy * ranscale, Dx * ranscale, Dy * ranscale };
                for (int i = ran.Next(360, 700); i > ran.Next(-300, 0); i--)
                {
                    float[] image = rotateTheorem(preimage, i);
                    A = new Point((int)((image[0])) + dx, (int)((image[1])) + dy);
                    B = new Point((int)((image[2])) + dx, (int)((image[3])) + dy);
                    C = new Point((int)((image[4])) + dx, (int)((image[5])) + dy);
                    D = new Point((int)((image[6])) + dx, (int)((image[7])) + dy);
                    pictureBox3.CreateGraphics().DrawLine(new Pen(sideAcolor, thick), A, B);
                    pictureBox3.CreateGraphics().DrawLine(new Pen(sideBcolor, thick), B, C);
                    pictureBox3.CreateGraphics().DrawLine(new Pen(sideCcolor, thick), C, D);
                    pictureBox3.CreateGraphics().DrawLine(new Pen(sideDcolor, thick), A, D);
                    //MessageBox.Show("A: " + A.ToString() + Environment.NewLine + " B: " + B.ToString() + Environment.NewLine + " C " + C.ToString());
                    Thread.Sleep(waittime);
                    pictureBox3.CreateGraphics().DrawLine(new Pen(Backcolor, thick), A, B);
                    pictureBox3.CreateGraphics().DrawLine(new Pen(BackColor, thick), B, C);
                    pictureBox3.CreateGraphics().DrawLine(new Pen(Backcolor, thick), C, D);
                    pictureBox3.CreateGraphics().DrawLine(new Pen(Backcolor, thick), A, D);
                }
                h++;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form matrixtheorem = new Form4();
            matrixtheorem.Show();
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            booleans.trigplot = 0;  
            pictureboxes[0] = pictureBox1;
            pictureboxes[1] = pictureBox3;
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Thread boxer = new Thread(new ThreadStart(boxRotation));
            boxer.Start();
        }
        private void boxRotation()
        {
            int dxx = 791;
            int dyy = 278;
            int dyyy = 555;
            int dxxx = 975;
            int len = 50;
            int alpha = 0;
            float[] box = { 0, 0, len, 0, 0, len, len, len};
            while (true)
            {
                int dy = (int)(200f * (float)Math.Sin((alpha / 360f))) + dyy;
                int dx = (int)(75f * (float)Math.Cos((alpha / 360f))) + dxx;
                float[] newbox = rotateTheorem(box, alpha);
                float[] prevbox = rotateTheorem(box, alpha);
                Point[] verts = new Point[4];
                for (int i = 0; i < box.Length; i += 2)
                {
                    verts[i / 2] = new Point((int)newbox[i] + dx, (int)newbox[i + 1] + dy);
                }
                for (int i = 1; i < verts.Length + 1; i++)
                {
                    pictureBox3.CreateGraphics().DrawLine(new Pen(Color.Red, 4), verts[i % 4], verts[(i + 1) % 4]);
                }


                alpha += 5;
                Thread.Sleep(10);
                for (int i = 1; i < verts.Length + 1; i++)
                {
                    pictureBox3.CreateGraphics().DrawLine(new Pen(Backcolor, 4), verts[i % 4], verts[(i + 1) % 4]);
                }
            }
        }
        private float[] rotateTheorem(float[] verts, int alpha)
        {
            float rad = ((float)Math.PI / 180f) * alpha;
            float[] mult = { (float)Math.Cos(rad), (float)Math.Sin(rad), (float)(-Math.Sin(rad)), (float)(Math.Cos(rad)) };
            float[] newtransf = new float[verts.Length];
            for (int i = 0; i < verts.Length; i += 2)
            {
                newtransf[i] = (mult[0] * verts[i]) + (mult[2] * verts[i + 1]);
                newtransf[i + 1] = (mult[1] * verts[i]) + (mult[(3)] * verts[i + 1]);
            }
            return newtransf;
        }
    }
}