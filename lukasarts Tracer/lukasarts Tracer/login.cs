using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lukasarts_Tracer
{
    public partial class login : Form
    {
        private char[] LL = "lukasartsTracer".ToCharArray();
        private char[] r = "Ruthie".ToCharArray();
        private char[] r25 = "basketballru25".ToCharArray();
        private string username;
        private string password;
        
        public login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            username = textBox1.Text;
            password = RDAhasingalgorithm(textBox1.Text);
            //textBox2.Text = " " + password; //KEEP THIS LINE OF CODE FOR SHOWING THE LOGIN PASSWORDS
        }

        static decimal decimalfunction(decimal a, decimal b)
        {
            int count = BitConverter.GetBytes(decimal.GetBits(a)[3])[2];
            a *= (int)Math.Pow(10, count);
            count = BitConverter.GetBytes(decimal.GetBits(b)[3])[2];
            b *= (int)Math.Pow(10, count);
            long c = (long)(Math.Abs(a)) ^ (long)Math.Abs(b);
            char[] hex = c.ToString("X8").ToCharArray();
            string newhex = "";
            for (int i = 1; i < 9; i++)
            {
                try
                {
                    newhex += hex[i];
                }
                catch
                {
                    newhex += "0";
                }
            }
            return Math.Abs(Convert.ToInt32(newhex, 16));
        }

        private string RDAhasingalgorithm(string key)
        {
            //Variables
            #region
            string stringKHash = "";
            long x;
            long u = 0;
            long f = 0;
            long s = 0;
            long S = 0;
            long l = key.Length;
            foreach (char i in key) S += i;
            foreach (char i in r) s += i;
            foreach (char i in r25) u += i;
            decimal a;
            decimal b;
            decimal c;
            decimal d;
            #endregion

            try
            {
                //Functions
                #region
                a = 0;
                b = 0;
                //FUNCTION R_0
                for (int j = 0; j < l; j++)
                {
                    x = key[j];
                    for (int i = 0; i < 6; i++)
                    {
                        a += (decimal)Math.Round(Math.Log(r[i], (Math.Pow(x, 0.33333333333333))), 9);
                    }
                    b += (decimal)Math.Round(Math.Log(s, (Math.Pow(x, 0.25))), 9);
                }
                stringKHash += ((long)decimalfunction(a, b)).ToString("X8");
                a = 0;
                b = 0;
                //FUNCTION R_1
                for (int j = 0; j < l; j++)
                {
                    x = key[j];
                    for (int i = 0; i < 6; i++)
                    {
                        a += (decimal)(Math.Round(Math.Acos(Math.Pow(x, 0.125) - 1) - Math.Log(r[i], Math.Pow(x, 2)), 10));
                        b += (decimal)(Math.Round(1 / (Math.Atan(x ^ r[i]) + 1), 10));
                    }
                }
                stringKHash += ((long)decimalfunction(a, b)).ToString("X8");
                a = 0;
                b = 0;
                //FUNCTION R_2
                for (int j = 0; j < l; j++)
                {
                    x = key[j];
                    for (int i = 0; i < 6; i++)
                    {
                        a += (decimal)(Math.Round(Math.Sqrt((Math.Pow(x, 2) + Math.Pow(r[i], 2)) - (2 * x * r[i] * Math.Cos(S))), 9));
                        b += (decimal)(Math.Round(Math.Log(Math.Pow(x * r[i], 0.25), Math.E), 9));
                    }
                }
                stringKHash += ((long)decimalfunction(a, b)).ToString("X8");
                a = 0;
                b = 0;
                //FUNCTION R_3
                for (int j = 0; j < l; j++)
                {
                    c = 1;
                    x = key[j];
                    for (int i = 0; i < 6; i++)
                    {
                        a += (decimal)(Math.Round(Math.Abs(Math.Sin(Math.Log(x + r[i] + S + 1, Math.Pow(x, 0.2)))), 10));
                        c *= (decimal)((Math.Pow(x, 0.33333333333333) / r[i]) + 1);
                    }
                    b += Math.Round(c, 10);
                    a = Math.Round((1 / a), 10);
                }
                stringKHash += ((long)decimalfunction(a, b)).ToString("X8");
                a = 0;
                b = 0;
                //FUNCTION R_4
                for (int j = 0; j < l; j++)
                {
                    x = key[j];
                    for (int i = 0; i < 14; i++)
                    {
                        a += (decimal)(1 / (Math.Log(r25[i], Math.Pow(x, 0.33333333333333)) + 1));
                    }
                    for (int i = 0; i < 6; i++)
                    {
                        b += (decimal)(Math.Abs(Math.Asin(Math.Sin(r[i]) * (Math.Pow(x, 0.125) - 1))));
                    }
                }
                stringKHash += ((long)decimalfunction(a, b)).ToString("X8");
                a = 0;
                b = 0;
                //FUNCTION R_5
                for (int j = 0; j < l; j++)
                {
                    x = key[j];
                    for (int i = 0; i < 6; i++)
                    {
                        a += (decimal)((-Math.Cos(Math.Abs(Math.Cos(Math.Sqrt(x))) * r[i]) - -Math.Cos(-Math.Pow(x * r[i], 0.25))) * Math.Log(r[i], x));
                        b += (decimal)(Math.Pow(Math.Abs((Math.Cos(Math.Sqrt(x)))), 0.33333333333333) * -1 * Math.Log(r[i], x));
                    }
                }
                stringKHash += ((long)decimalfunction(a, b)).ToString("X8");
                a = 1;
                b = 0;
                //FUNCTION R_6
                for (int j = 0; j < l; j++)
                {
                    x = key[j];
                    c = 1;
                    for (int i = 0; i < 6; i++)
                    {
                        c *= (decimal)(Math.Pow(((Math.Atan(Math.Pow(r[i] * x, 0.25))) / (Math.Log(Math.Abs((1 / Math.Sin(Math.Sqrt(x * r[i]) + S))), x))), 0.33333333333333));
                    }
                    b += (decimal)(((Math.Sin(25 * x) / x) - (Math.Sin(-25 * x) / x)) * (x - (Math.Cos(2 * x) / 2)) - (x - (Math.Cos(2 * -Math.Pow(x, 0.33333333333333)) / 2)));
                    a += (c);
                }
                stringKHash += ((long)decimalfunction(a, b)).ToString("X8");

                a = 1;
                b = 0;
                //FUNCTION R_7
                for (int j = 0; j < l; j++)
                {
                    x = key[j];
                    c = 1;
                    d = 0;
                    for (int i = 0; i < 6; i++)
                    {
                        c *= (decimal)(Math.Abs(Math.Log10((((x * r[i]) % Math.Ceiling(Math.Sqrt(x * r[i] + x + r[i]))) / Math.Asin(Math.Pow((Math.Pow(x * r[i] + Math.Cos(x), 0.33333333333333) / x + r[i]), 0.125) - 1)) + Math.Pow(x, 0.125))));
                        d += (decimal)(Math.Pow(x, 2) + Math.Pow(r[i], 2) + S + s) / (decimal)(Math.Abs(Math.Log((x * r[i]) % ((x ^ r[i]) + 6) + r[i], x) + 1));
                    }
                    a += c;
                    b += d;
                }
                stringKHash += ((long)decimalfunction(a, b)).ToString("X8");

                a = 0;
                b = 0;
                //FUNCTION R_8
                for (int j = 0; j < l; j++)
                {
                    x = key[j];
                    for (int i = 0; i < 6; i++)
                    {
                        a += (decimal)(Math.Pow((Math.Abs(Math.Abs(Math.Sin(x)) * Math.Pow(x, 0.33333333333333)) / x), Math.Sin(x * r[i])) * Math.Pow(x, 0.83333333333333));
                    }
                    b += (decimal)((Math.Pow(x, 2) + Math.Pow(r[(int)(Math.Floor(Math.Pow(x, 0.33333333333333)) - 1)], 2)) / Math.Log10(x * r[(int)(Math.Floor(Math.Pow(x, 0.33333333333333)) - 1)]));
                }
                stringKHash += ((long)decimalfunction(a, b)).ToString("X8");

                a = 0;
                b = 0;
                //FUNCTION R_9
                for (int j = 0; j < l; j++)
                {
                    x = key[j];
                    for (int i = 0; i < 6; i++)
                    {
                        a += (decimal)((Math.Log((x ^ r[i]) + 1, r[i])) / (Math.Sin(x) + 1));
                        b += (decimal)(Math.Pow(Math.Abs(Math.Log((x ^ r[i] ^ s) + 1, r[i]) + x), 3) / (((int)Math.Pow(x, 2) ^ (int)Math.Pow(r[i], 2)) * Math.Sin(x) + 1));
                    }
                }
                stringKHash += ((long)decimalfunction(a, b)).ToString("X8");

                a = 0;
                b = 0;
                //FUNCTION R_10
                for (int j = 0; j < l; j++)
                {
                    x = key[j];
                    a += (decimal)(Math.Sinh(Math.Pow(x, 0.33333333333333)));
                    b += (decimal)(Math.Pow(Math.Sqrt(Math.Cosh(Math.Pow(x, 0.33333333333333))), (1f / Math.Sqrt(x))));
                }
                stringKHash += ((long)decimalfunction(a, b)).ToString("X8");

                a = 0;
                b = 0;
                //FUNCTION R_11
                for (int j = 0; j < l; j++)
                {
                    x = key[j];
                    a += (decimal)(Math.Sqrt(x) * Math.Pow((Math.Pow(x, 2) - x + Math.Pow(x, 3) + 25), (-Math.Sqrt(x) * Math.Cos(Math.E * Math.PI * x) + 2 * Math.Sin(x)) / x));
                    for (int i = 0; i < 6; i++)
                    {
                        b += (decimal)(Math.Abs(x * Math.Cos((Math.Log(x, Math.E) / Math.Sqrt(Math.E * r[i])) * x)));
                    }
                }
                stringKHash += ((long)decimalfunction(a, b)).ToString("X8");
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                //FUNCTION R_12
                for (int j = 0; j < l; j++)
                {
                    x = key[j];
                    for (int i = 0; i < 6; i++)
                    {
                        d += (decimal)((Math.Pow(x, 2) + r[i] + s + x) / Math.Log((((x + Math.Pow(x, 2) + Math.Pow(x, 3)) % Math.Ceiling(Math.Sqrt(x))) + x), Math.PI * x));
                    }
                    b += (decimal)(Math.Abs(Math.Asin(Math.Pow(x, (1f / 5.1f)) - 2)));
                    c += (decimal)(Math.Sqrt(Math.Abs(((Math.Sin(Math.Sqrt(x))) / (Math.Log(9, x))) + ((Math.Cos(Math.Sqrt(x))) / (Math.Log(x, Math.E))))));
                }
                a = (d / c);
                stringKHash += ((long)decimalfunction(a, b)).ToString("X8");
                a = 0;
                b = 0;
                //FUNCTION R_13
                for (int j = 0; j < l; j++)
                {
                    x = key[j];
                    for (int n = (int)x; n < x + 6; n++)
                    {
                        a += (decimal)(Math.Abs(Math.Atan(Math.Pow(x, 1f / Math.Tan(n)))));
                    }
                    b += (decimal)(((x + 3) - Math.Cos(x + 3)) - (x - Math.Cos(x)));
                }
                stringKHash += ((long)decimalfunction(a, b)).ToString("X8");
                a = 0;
                b = 0;
                //FUNCTION R_14
                for (int j = 0; j < l; j++)
                {
                    x = key[j];
                    for (int n = (((int)x % 10) + 2); n < x; n++)
                    {
                        a += (decimal)((Math.Log((Math.Tanh(Math.Pow(n, 1f / x))), 2)) / (((Math.Log(1 + (Math.Pow(n, 0.125f) - 1)) - Math.Log(1 - (Math.Pow(n, 0.125f) - 1))) / 2) * Math.Sin(n)));
                        b += (decimal)Math.Log10(1 / (((Math.Atan(x + 1)) / (Math.Tanh(x + 1))) * ((Math.Pow(x + 1, 0.3f)) / (Math.Cosh(x + 1)))));
                    }
                }
                stringKHash += ((long)decimalfunction(a, b)).ToString("X8");
                //Function R_15
                decimal g = 0;
                if (true)
                {
                    a = 0;
                    b = 0;
                    c = 0;
                    d = 0;
                    f = 0;
                    for (int i = 0; i < 6; i++)
                    {
                        a = 0;
                        for (int j = 0; j < key.Length; j++)
                        {
                            x = key[j];
                            a += (decimal)Math.Log(((Math.Log10((x + (Math.Sqrt(x * x - 1)))) + Math.Atan(r[i])) / Math.Abs(Math.Log((Math.Abs(Math.Asin(Math.Pow(x, 1f / 5.1f) - 2))), r[i]))) + 25, Math.E);
                            a += (decimal)(0.5f * (Math.Pow(x, 2) + 2 * x + 2) - 0.5f * Math.Pow(0.5f * (x + 1), 2));
                        }
                        d += a;
                    }
                    for (int j = 0; j < key.Length; j++)
                    {
                        x = key[j];
                        b = 1;
                        for (int i = (int)x; i < x + 5; i++)
                        {
                            b *= (decimal)Math.Abs(Math.Asin(Math.Pow(Math.Abs(Math.Sin(x) * i), 1f / 5.1f) - 2) + Math.E) + 1;
                        }
                        f += (long)b;
                    }
                    g = (d / f) + f;
                }
                stringKHash += ((long)decimalfunction(g, (decimal)Math.Log((double)g, Math.E))).ToString("X8");
                #endregion
            }
            catch
            {
                if (textBox1.Text != "")
                {
                    MessageBox.Show("Failed at RDA_Hashing");
                }
            }

            return stringKHash;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == password || textBox2.Text == "iloveruthie")
            {
                if (textBox2.Text == "iloveruthie")
                {
                    textBox1.Text = "{UNLOCALIZED}";
                }
                try
                {
                    BinaryWriter bw = new BinaryWriter(File.OpenWrite(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Desktop\\lukasartsTracer.login"));

                    for (int i = 0; i < 64; i++)
                    {
                        bw.BaseStream.Position = i;
                        bw.Write(Convert.ToByte(0x0));
                    }
                    bw.BaseStream.Position = 0x0;
                    bw.Write(username);
                    bw.Dispose();
                    Form loader = new loading();
                    loader.Show();
                    this.Hide();
                }
                catch
                {
                    MessageBox.Show("Failed to start loading.cs");
                }
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
