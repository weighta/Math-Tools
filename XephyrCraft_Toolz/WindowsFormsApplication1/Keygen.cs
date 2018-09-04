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
using System.IO;
using System.Speech.Synthesis;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Random ran = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ks;
            ks = textBoxks.Text;
            textBox1.Text = "" + ran.Next(0, 9) + ran.Next(0, 9) + ran.Next(0, 9) + ran.Next(0, 9) + ran.Next(0, 9) + ks;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string storelist;
            storelist = listBox1.Text;
            string ks;
            ks = textBoxks.Text;
            string kvs;
            kvs = textBoxkvs.Text;
            string date;
            date = textBoxdate.Text;
            string time;
            time = textBoxtime.Text;
            string cost;
            cost = textBoxcost.Text;
            string cost2;
            cost2 = textBoxcost2.Text;
            textBox2.Text = storelist + "-" + ks + kvs + "0-" + date + "-" + time + ran.Next(0, 9) + "-00" + cost + "-" + cost2;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string store;
            store = textBox5.Text;
            listBox1.Items.Add(store);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            for(int i = 0; i < Convert.ToInt32(textBox11.Text) + 0; i++)
            {
                textBox3.AppendText(ran.Next(10).ToString());
            }
            richTextBox1.AppendText(textBox3.Text);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            for (int i = 0; i < Convert.ToInt32(textBox11.Text) + 0; i++)
            {
                textBox4.AppendText(Convert.ToChar(ran.Next(65, 91)).ToString());
            }
            richTextBox1.AppendText(textBox4.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {
            // ^Creates the ran ability
            // Amount Of Times To Generate ran Word Check;
            for (int i = 0; i < Convert.ToInt32(textBox11.Text); i++)
            {
                //string s1 = "aeiouaeiouaeiouaeiou";
                //int num1 = ran.Next(1, s.Length - 1);
                //string s2 = "abcdefghijklmnopqrstuvwxyz";
                //int num2 = ran.Next(1, s.Length - 1);
                //string s3 = "aeiouaeiouaeiouaeiou";
                //int num3 = ran.Next(1, s.Length - 1);
                //string s4 = "abcdefghijklmnopqrstuvwxyz";
                //int num4 = ran.Next(1, s.Length - 1);
                //string s5 = "aeiouaeiouaeiouaeiou";
                //int num5 = ran.Next(1, s.Length - 1);
                //string s6 = "abcdefghijklmnopqrstuvwxyz";
                //int num6 = ran.Next(1, s.Length - 1);

                // creating ran letter variables

                //variable ran suffix array

                string[] startindex = "Ch|Th|Sh|Wh|St|B|C|D|F|G|H|J|K|L|M|N|P|Qu|R|S|T|V|W|X|Y|Z".Split('|');
                string one = startindex[ran.Next(startindex.Length)];
                //⚗
                string s = "aeiouaeiouaeiouaeio";
                int num = ran.Next(1, s.Length - 1);
                //⚗
                string[] secondindex = "ch|th|sh|st|ck|b|c|d|f|g|h|k|l|m|n|p|r|s|t|v|w|x|z".Split('|');
                string three = secondindex[ran.Next(secondindex.Length)];
                //⚗
                string[] thirdindex = "a|e|i|o|u|ee|ou".Split('|');
                string five = thirdindex[ran.Next(thirdindex.Length)];
                //⚗
                string[] forthindex = "ch|th|sh|st|ck|tion|b|c|d|f|g|h|k|l|m|n|p|r|s|t|v|w|x|y|z".Split('|');
                string six = forthindex[ran.Next(forthindex.Length)];
                //⚗
                string word = (one + (s[num].ToString()) + three + five + six);
                textBox6.Text = "" + word;
                richTextBox1.AppendText("" + word + " ");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                textBox9.Text = Math.Sqrt(Convert.ToDouble(textBox7.Text) * Convert.ToDouble(textBox7.Text) + Convert.ToDouble(textBox8.Text) * Convert.ToDouble(textBox8.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("You have entered invalid ints or the textfeilds are blank");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files lol (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter SW = new System.IO.StreamWriter(
                    saveFileDialog1.FileName, false, Encoding.ASCII);
                SW.Write(richTextBox1.Text);
                SW.Close();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                int amount = Convert.ToInt32(textBox17.Text);
                textBox10.Text = ("" + ran.Next(0, amount));
            }
            catch
            {
                MessageBox.Show("Enter A Value, The Value Will Be Between 0 And Your Value");
            }
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < Convert.ToInt32(textBox11.Text); i++)
            {
                //The word

                string[] startindex = "Ch|Th|Sh|Wh|St|B|C|D|F|G|H|J|K|L|M|N|P|Qu|R|S|T|V|W|X|Y|Z".Split('|');
                string one = startindex[ran.Next(startindex.Length)];
                //⚗
                string[] vowelindex = "a|e|i|o|u|en|er|es".Split('|');
                string two = vowelindex[ran.Next(vowelindex.Length)];
                //⚗
                string[] secondindex = "ch|th|sh|st|ck|b|c|d|f|g|h|k|l|m|n|p|r|s|t|v|w|x|z".Split('|');
                string three = secondindex[ran.Next(secondindex.Length)];
                //⚗
                string[] thirdindex = "a|e|i|o|u|ee|ou".Split('|');
                string five = thirdindex[ran.Next(thirdindex.Length)];
                //⚗
                string[] forthindex = "ch|th|sh|st|ck|tion|b|c|d|f|g|h|k|l|m|n|p|r|s|t|v|w|x|y|z".Split('|');
                string six = forthindex[ran.Next(forthindex.Length)];
                //⚗
                string word = (one + two + three + five + six);

                //Article

                string[] articleindex = "The|An|A|Did|No|Yes|Would|Can|Will|Has|Doing|Thee|Dumb|So|That|All|What|Both|Could|Does".Split('|');
                string article = articleindex[ran.Next(articleindex.Length)];

                //Ranword

                //Verb

                string[] extraindex = "fly|win|loose|happen|sense|read|talk|teach|agree|add|act|balance|amuse|appeal|fall|collect|end|deal|decide|choose|clean|fit|grip|see|sow|rely|spray".Split('|');
                string verb = extraindex[ran.Next(extraindex.Length)];

                //Prepositions

                string[] prepositionindex = "in|to|next|from|above|below|after|since|one of|before|along|following|across|behind|upon|towards|beyond|plus|concerning|off|near|with|at|with".Split('|');
                string preposition = prepositionindex[ran.Next(prepositionindex.Length)];

                //Article2

                string[] article2index = "the|a|that|all".Split('|');
                string article2 = article2index[ran.Next(article2index.Length)];

                //Randword2

                string[] start1index = "ch|th|sh|wh|st|b|c|d|f|g|h|j|k|l|m|n|p|qu|r|s|t|v|w|x|y|z".Split('|');
                string one1 = start1index[ran.Next(start1index.Length)];
                //⚗
                string[] vowel1index = "a|e|i|o|u|en|er|es".Split('|');
                string two1 = vowel1index[ran.Next(vowel1index.Length)];
                //⚗
                string[] second1index = "ch|th|sh|st|ck|b|c|d|f|g|h|k|l|m|n|p|r|s|t|v|w|x|z".Split('|');
                string three1 = second1index[ran.Next(second1index.Length)];
                //⚗
                string[] third1index = "a|e|i|o|u|ee|ou".Split('|');
                string five1 = third1index[ran.Next(third1index.Length)];
                //⚗
                string[] forth1index = "ch|th|sh|st|ck|tion|b|c|d|f|g|h|k|l|m|n|p|r|s|t|v|w|x|y|z".Split('|');
                string six1 = forth1index[ran.Next(forth1index.Length)];
                //⚗
                string word2 = (one1 + two1 + three1 + five1 + six1);

                //Punctuation

                string[] punctuationindex = ".|!|?|.|?".Split('|');
                string punctuation = punctuationindex[ran.Next(punctuationindex.Length)];

                //Sentence & Textbox

                textBox14.Text = "" + article + " " + word + " " + verb + " " + preposition + " " + article2 + " " + word2 + punctuation;
                richTextBox1.AppendText(" " + textBox14.Text);
                if (textBox3.Text == "666")
                {
                    MessageBox.Show(word);
                }
            }
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            try
            {
                BinaryReader br = new BinaryReader(File.OpenRead(ofd.FileName));

                string madeby = null;
                string mapmodifiedby = null;
                string mapid = null;
                string madebyprofid = null;
                string modifiedbyprofid = null;
                string mapdesc = null;

                // Get Address Of Whatever

                for (int i = 0x88; i <= 0x96; i++)
                {
                    br.BaseStream.Position = i;
                    madeby += br.ReadChar().ToString();
                }
                for (int i = 0xAC; i <= 0xBA; i++)
                {
                    br.BaseStream.Position = i;
                    mapmodifiedby += br.ReadChar().ToString();
                }
                for (int i = 0x329; i <= 0x341; i++)
                {
                    br.BaseStream.Position = i;
                    mapid += br.ReadByte().ToString("X2");
                }
                for (int i = 0x1C0; i <= 0x2EF; i++)
                {
                    br.BaseStream.Position = i;
                    mapdesc += br.ReadByte().ToString("X2");
                }
                for (int i = 0x82; i <= 0x87; i++)
                {
                    br.BaseStream.Position = i;
                    madebyprofid += br.ReadByte().ToString("X2");
                }
                for (int i = 0xA6; i <= 0xAB; i++)
                {
                    br.BaseStream.Position = i;
                    modifiedbyprofid += br.ReadByte().ToString("X2");
                }

                // Close Binary Reader

                br.Close();

                // Convert The Hex In Map Desc To ASCII



                // Write The Variables Created From Addresses, To TextBoxes

                label20.Text = ("Made By: " + madeby);
                label21.Text = ("Modified By: " + mapmodifiedby);
                label19.Text = ("" + mapid);
                textBox16.Text = ("" + madebyprofid);
                textBox15.Text = ("" + modifiedbyprofid);
                richTextBox1.Text = ("" + mapdesc);

                // Arguements Of Map Names

                if (label19.Text == "5D2AE4419B35E620000000000000000AC000005DF7F8000000")
                {
                    label19.Text = "MAP: FORGE WORLD";
                }
                else if (label19.Text == "11C01D1C3322E260000000000000000AC0000020FFF8000000")
                {
                    label19.Text = "MAP: POWERHOUSE";
                }
                else if (label19.Text == "E52A3E1E6CE64650000000000000000AC0000023F7F8000000")
                {
                    label19.Text = "MAP: REFLECTION";
                }
                else if (label19.Text == "580E4C95A82E0D40000000000000000AC000002587F8000000")
                {
                    label19.Text = "MAP: SPIRE";
                }
                else if (label19.Text == "536A8CF5D1822D00000000000000000AC000001F47F8000000")
                {
                    label19.Text = "MAP: SWORD BASE";
                }
                else if (label19.Text == "59FD4C8AF3C532C0000000000000000AC000001FE7F8000000")
                {
                    label19.Text = "MAP: COUNTDOWN";
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox10.Text = ("");
            textBox17.Text = ("");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            foreach(char i in textBox11.Text)
            {
                string posint = "" + i;
                int valid = 0;
                for(int j = 48; j < 58; j++)
                {
                    if(posint.Contains(Convert.ToChar(j)) == true)
                    {
                        valid = 1;
                    }
                }
                if (valid > 0)
                {

                }
                else
                {
                    textBox11.Clear();
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SelectVoice("Microsoft Zira Desktop");
            if (richTextBox1.Text != "")
            {
                synth.SelectVoice("Microsoft Zira Desktop");
                synth.Speak(richTextBox1.Text);
            }
            if (richTextBox2.Text != "")
            {
                synth.SelectVoice("Microsoft Mike");
                synth.Speak(richTextBox1.Text);
            }
            synth.Speak(richTextBox2.Text);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int x = ran.Next(250, 350);
            int y = ran.Next(70, 100);
            int z = ran.Next(30, 75);
            richTextBox1.Text = ("tellraw @a {'text':'','color':'aqua','extra':[{'text':'InvictusTheArrow is near a portable radar (at X:-" + x + " Y:" + y + " Z:" + z + ")','color':'white'}]}");
        }
        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                float PI = 3.14f;
                int rx2 = Convert.ToInt32(textBox22.Text);
                int area = rx2 * 2 * 2;
                float areafull = area / PI;
                int squarewall = rx2 * 2;
                int wallsquared = squarewall * squarewall * 2 ;
                textBox23.Text = ("" + areafull);
                textBox24.Text = (""+ Math.Sqrt(wallsquared).ToString());

                //int a = Convert.ToInt32(textBox7.Text);
                //int b = Convert.ToInt32(textBox8.Text);
                //int c = a * a + b * b;
                //textBox9.Text = Math.Sqrt(c).ToString();
            }
            catch
            {
                MessageBox.Show("You have entered an invalid radius or the textfeild is blank");
            }
        }

        private void button17_Click_1(object sender, EventArgs e)
        {

        }

        private void button17_Click_2(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox19.Clear();
            {
                for(int i = 0; i < Convert.ToInt32(textBox11.Text) * 8; i++)
                {
                    textBox19.AppendText(Convert.ToChar(ran.Next(0x30, 0x32)).ToString());
                }
            }
            richTextBox1.AppendText(textBox19.Text);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox18.Clear();
            for(int i = 0; i < Convert.ToInt32(textBox11.Text) * 2; i++)
            {
                int hexintran = ran.Next(17);
                if (hexintran < 11)
                {
                    textBox18.AppendText(Convert.ToChar(ran.Next(0x30, 0x3A)).ToString());
                }
                else
                {
                    textBox18.AppendText(Convert.ToChar(ran.Next(0x41, 0x47)).ToString());
                }
            }
            richTextBox1.AppendText(textBox18.Text);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                int j = Convert.ToInt32(textBox21.Text);
                float endingpoint = Convert.ToInt32(textBox20.Text);
                float answer = 0;
                for (float i = j;  i <= endingpoint; i++)
                {
                    answer += (float)(1/(Math.Pow(i, 2) + 1));
                }
                textBox26.Text = answer.ToString();
            }
            catch
            {
                MessageBox.Show("Starting and Ending points are blank or the value is too high.");
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox13.Text = Math.Sqrt(Convert.ToDouble(textBox12.Text)).ToString();
            }
            catch
            {

            }
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            xor();
        }
        private void xor()
        {
            try
            {
                textBox29.Text = (Convert.ToInt32(textBox27.Text) ^ Convert.ToInt32(textBox28.Text)).ToString();
            }
            catch
            {

            }
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            xor();
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox31.Text = Math.Ceiling(((decimal)(5f / 4f) * Convert.ToInt32(textBox30.Text))).ToString();
            }
            catch
            {

            }
        }
    }
}
