using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading;
using System.IO;


/*
 * lukasartsTracer Utility: pVBTRACE7
 * 04/04/18
 * Association: (UNRELEASED)
 *  aAdProjectsTrac:
 * .text:00401A0C                 unicode 0, <*\AD:\projects\tracer utility\pVBTrace6.vbp>,0
 * .text:00401A64                 dd 6Eh dup(0)
 * .text:00401C1C                 dd offset dword_401EF0
 * .text:00401C20 dword_401C20    dd 5Ah, 30001h, 405160h, 0 ; DATA XREF: .text:00401D84o
 * .text:00401C20                                         ; .text:off_405244o ...
 * 
 * cisi_87400 * 5 # (x:1 y:0 z:-2) //Kill all oxygen in air within a 5 ft radius
 * kspa_24111 * 2 //DESTORY Ribbosoms in membrane cytoplasms within a 2 ft radius
 * ruxe_16433 * 4 //Ignite ruthenium into xenon gas conversion
 * gvfd_50 * 1 # (x:1 y z) //Create electromagnetic field with positive charges to oxygen within 1 ft radius
 * crra_560 * 4 //Remove the Atp process from mitochondria in Eukaryotic cells (doesn't work with prokaryotic cells)
 * noxe_44.013 * 3 # (x:50 y:25 z:0) //Converts low density gases into Nitrous oxide.
 * 
 * (frequencyID)_(EffectStrength) * (Radius Of Effect) # (Coordinates: (x: y: z:))
*/




namespace lukasarts_Tracer
{
    public partial class Form1 : Form
    {
        private string version = "(pVBTrace7.vbp)";
        private int clock = 0;
        private int a = 0;
        private int b = 0;
        private int id;
        private string photonamp = "low";
        private bool act = true;
        private double resistance = 0;
        private int coloric;
        private int staticc;
        private int moleculescollided;
        private int oscillations;
        private int oxygencontent;
        private int electroncharge;
        private int emwavecollisions;
        private int periodconversions;
        private Color hypc = Color.Red;
        private Color oppc = Color.Green;
        private Color adjc = Color.Blue;
        private string frequencytype = "SINE";
        private int hz = 0;
        int[] frequency;
        private string[] frequencies = { "SINE", "COSINE", "LOGARITHMIC", "ZETA", "XRAY", "PREGAMMA", "PREDIGAMMA" };
        Random ran = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "Vermehrung")
            {
                button12.Enabled = true;
                treeView1.Enabled = true;
                panel5.Enabled = true;
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0)
            {
                MessageBox.Show("Sie müssen die Dauer größer als Null festlegen.");
            }
            else
            {
                act = true;
                try
                {
                    if (textBox3.Text.Contains("^"))
                    {
                        frequency = textBox3.Text.Split('^').Select(b => Convert.ToInt32(b)).ToArray();
                        hz = (int)Math.Pow(frequency[0], (frequency[1] / 2));
                    }
                    else
                    {
                        hz = Convert.ToInt32(textBox3.Text);
                    }
                    textBox3.Text = hz.ToString();

                }
                catch (Exception EX)
                {
                    richTextBox3.AppendText(EX.ToString());
                    MessageBox.Show("Das folgende Programm hat einen oder mehrere Fehler bei Ihrer Eingabe festgestellt:" + Environment.NewLine + EX.ToString());
                }
                if ((int)numericUpDown1.Value != 0)
                {
                    label10.Text = "wave density: 0." + ran.Next(0, 1000) + " λ";
                }
                Thread newthread = new Thread(new ThreadStart(cause));
                newthread.Start();
            }
        }
        private void stopwatch()
        {
            string exz_ms = "0";
            string exz_s = "0";
            string exz_m = "0";
            for (int m = 0; m < 60; m++)
            {
                for (int s = 0; s < 60; s++)
                {
                    for (int ms = 0; ms < 60; ms++)
                    {
                        if (ms.ToString().Length == 1)
                        {
                            exz_ms = "0";
                        }
                        else
                        {
                            exz_ms = "";
                        }
                        if (s.ToString().Length == 1)
                        {
                            exz_s = "0";
                        }
                        else
                        {
                            exz_s = "";
                        }
                        if (m.ToString().Length == 1)
                        {
                            exz_m = "0";
                        }
                        else
                        {
                            exz_m = "";
                        }
                        Invoke(new Action(() => label32.Text = "verstrichene zeit: " + exz_m + m + ":" + exz_s + s + ":" + exz_ms + ms));
                        Thread.Sleep(16);
                    }
                }
            }
            label32.Text = "verstrichene zeit: ";
        }

        private void circle()
        {
            int dx = 120;
            int dy = 120;
            int radii = 80;
            Point origin = new Point(dx, dy);
            Point cosine;
            Point rightangle;
            Point hyp;
            double rad2;
            int speed;
            try
            {
                speed = (int)Math.Floor(1000 / Math.Log(Convert.ToInt32(textBox3.Text), Math.E)) / 5;
            }
            catch
            {
                speed = 100;
            }
            a = 0;
            if (checkBox3.Checked)
            {
                int size = 6;
                int cycles = nodefrequency(id + 1);
                while (true)
                {
                    Invoke(new Action(() => label4.Text = "θ = " + (a % 360) + "°"));
                    rad2 = (Math.PI / 180) * (a % 360);
                    //angle
                    rightangle = new Point((int)(Math.Cos(rad2) * radii) + dx, dy);
                    //hyp
                    hyp = new Point((int)(Math.Cos(rad2) * radii) + dx, (int)(Math.Sin(-rad2) * radii) + dy);
                    pictureBox2.CreateGraphics().DrawLine(new Pen(hypc, size), origin, hyp);
                    //cosine
                    pictureBox2.CreateGraphics().DrawLine(new Pen(adjc, size), origin, rightangle);
                    //sine
                    pictureBox2.CreateGraphics().DrawLine(new Pen(oppc, size), rightangle, hyp);
                    Thread.Sleep(speed);
                    //delhyp
                    pictureBox2.CreateGraphics().DrawLine(new Pen(Brushes.WhiteSmoke, size), origin, hyp);
                    //delsin
                    pictureBox2.CreateGraphics().DrawLine(new Pen(Brushes.WhiteSmoke, size), rightangle, hyp);
                    //delcos
                    pictureBox2.CreateGraphics().DrawLine(new Pen(Brushes.WhiteSmoke, size), origin, rightangle);
                    a += (int)Math.Ceiling(resistance / (2 *Math.Log(resistance)));
                }
            }
        }
        private void cause()
        {
            Thread coolcircle = new Thread(new ThreadStart(circle));
            Thread timer = new Thread(new ThreadStart(stopwatch));
            if (checkBox15.Checked)
            {
                timer.Start();
            }
            if (checkBox2.Checked)
            {
                coolcircle.Start();
            }
            if (checkBox17.Checked)
            {
                for (int i = 0; i < frequencies.Length; i++)
                {
                    Invoke(new Action(() => chart1.Series[frequencies[i]].Points.Clear()));
                }
            }
            int choice = ran.Next(4);
            int duration = (int)numericUpDown1.Value;
            switch (0)
            {
                case 0:
                    {
                        clock = 0;
                        Invoke(new Action(() => timer1.Start()));
                        int fin = ran.Next(10, 50);
                        int i = 0;
                        while(true)
                        {
                            b = ran.Next(2, 1000);
                            if (b < 100)
                            {
                                oppc = Color.Lime;
                                photonamp = "med";
                            }
                            else
                            {
                                oppc = Color.Green;
                                photonamp = "low";
                            }
                            float rad = (float)(Math.PI / 180) * (i * 4);
                            if (checkBox1.Checked)
                            {
                                Invoke(new Action(() => chart1.Series["SINE"].Points.AddXY("", Math.Sin(rad * ran.Next(1, 5)) * b)));
                            }
                            if (checkBox10.Checked)
                            {
                                Invoke(new Action(() => chart1.Series["COSINE"].Points.AddXY("", Math.Cos(rad * ran.Next(1, 5)) * b)));
                            }
                            if (checkBox1.Checked == false && checkBox10.Checked == false)
                            {
                                Invoke(new Action(() => chart1.Series[frequencies[id % 7]].Points.AddXY("", Math.Cos(rad * ran.Next(1, 5)) * b)));
                            }
                            Thread.Sleep((int)((1000f / Math.Log(hz , 1.8f))));
                            resistance = Math.Round((Convert.ToInt32(textBox3.Text) / Math.Log(Convert.ToInt32(textBox3.Text) , Math.E)) * Math.Abs(Math.Cos((Math.Abs(Math.Round((Math.PI / 180), 3) * i)))) + i + Math.Cos(i / 2), 4);
                            Invoke(new Action(() => progressBar1.Value = (int)(Math.Ceiling((((double)clock / (duration)) * 100f)))));
                            Invoke(new Action(() => label9.Text = "air density: " + (10 * Math.Round(Math.Sin(Math.PI / 180 * (i * 3)), 5) + 64) + "μ"));
                            Invoke(new Action(() => label12.Text = "photon amplification: " + photonamp));
                            Invoke(new Action(() => label7.Text = "h/λ = " + textBox3.Text + "/λ'*cos" + (Math.Round((Math.PI / 180), 3) * i) + "pcosΦ = " + resistance + "Ω"));
                            Invoke(new Action(() => label11.Text = "coloric density: " + (2 + Math.Round(Math.Abs(Math.Cos(i)  + Math.Log(Convert.ToInt32(textBox4.Text), Math.E)), 3) + "J")));
                            //Invoke(new Action(() => label11.Text = "coloric density: " + (2 + Math.Round(Math.Abs(Math.Cos(i) + Math.Log(Convert.ToInt32(textBox4.Text), Math.E)), 3) + "J")));
                            if (act == false)
                            {
                                break;
                            }
                            if (clock >= duration)
                            {
                                break;
                            }
                            i++;
                        }
                        coolcircle.Abort();
                        timer.Abort();
                        timer1.Stop();
                        break;
                    }
                case 1:
                    {
                        /*
                        for (int i = 0; i < ran.Next(100, 500); i++)
                        {
                            int b = ran.Next(50, 75);
                            float rad = (float)(Math.PI / 180) * (i * 4);
                            Invoke(new Action(() => chart1.Series["SINE"].Points.AddXY("", Math.Sin(rad * ran.Next(1, 5)) * b)));
                            Thread.Sleep(300);
                        }
                        break;
                        */
                    }
                case 2:
                    {
                        /*
                        MessageBox.Show("VORAUSSETZUNGSSTATISTIKEN ZEIGEN POTENZIELLE STRAHLUNGSREFORM DURCH DIÄTETISCHE ELEMENTE WIE KOHLENDIOXID UND SAUERSTOFFGEHALT VON CO2.");
                        for (int i = 0; i < ran.Next(100, 500); i++)
                        {
                            int b = ran.Next(10, 20);
                            float rad = (float)(Math.PI / 180) * (i * 10);
                            Invoke(new Action(() => chart1.Series["COSINE"].Points.AddXY("", Math.Tan(rad * ran.Next(1, 10)) * b)));
                            Thread.Sleep(300);
                            
                        }
                        break;
                        */
                    }
            }
        }

        private int nodefrequency(int n)
        {
            decimal value = 0;
            for (int i = n; i <= n + (int)Math.Ceiling(Math.Sqrt(n)); i++)
            {
                value += (decimal)Math.Abs(Math.Sin(n * Math.Abs((Math.Acos(Math.Pow(i + 1, 0.19f) - 2)) / ((n % 6) + 1)) * 100));
            }
            string number = "";
            for (int i = 3; i <= 7 + (id % 3); i++)
            {
                number += value.ToString()[i];
            }
            return Convert.ToInt32(number);
        }

        private void Per_Click(object sender, EventArgs e)
        {
            Form form = new Form2();
            form.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Thread.Sleep(700);
            MessageBox.Show("Sie haben keine aktuellen Ausführungen");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kann die .3ds-Bibliothek nicht finden");
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                panel5.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
            }
            else
            {
                panel5.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                pictureBox2.Visible = true;
            }
            else
            {
                pictureBox2.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Text = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Desktop\\lukasarts.log";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form website = new Form3();
            website.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Thread.Sleep(ran.Next(100, 1000));
            MessageBox.Show("Derzeit gibt es keine elektromagnetischen Umwandlungen.");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string[] lines = { "hello", "test" };
            File.WriteAllLines(textBox5.Text, lines);
            byte[] hi = File.ReadAllBytes(textBox5.Text);
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked)
            {
                label32.Visible = true;
            }
            else
            {
                label32.Visible = false;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            act = false;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (checkBox1.Checked == false || checkBox10.Checked == false)
            {
                string selected = treeView1.SelectedNode.Text;
                textBox6.Text = selected + " : " + treeView1.SelectedNode.Name;
                string num = "";
                for (int i = 4; i < treeView1.SelectedNode.Name.Length; i++)
                {
                    num += treeView1.SelectedNode.Name[i];
                }
                id = Convert.ToInt32(num);
                frequencytype = frequencies[id % 7];
                textBox3.Text = nodefrequency(id + 1).ToString();
            }
            else
            {
                MessageBox.Show("Sie müssen den linken und rechten Lautsprecher-Brennpunkt deaktivieren, bevor Sie Funktionsprofile verwenden.");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form form = new Form5();
            form.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clock += 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string logindir = (Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Desktop\\lukasartsTracer.login").ToString();
            byte[] loginbytes = File.ReadAllBytes(logindir);
            string username = "";
            for (int i = 1; i < loginbytes.Length; i++)
            {
                if (loginbytes[i] == 0)
                {
                    break;
                }
                username += Convert.ToChar(loginbytes[i]);
            }
            this.Text = "lukasartsTracer " + version + " Logged in as " + username;
        }
    }
}
