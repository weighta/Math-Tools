using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string externalip = null;
            string ip2 = null;
            try
            {
                externalip = new WebClient().DownloadString("http://icanhazip.com");
            }
            catch
            {

            }
            try
            {
                ip2 = new WebClient().DownloadString("https://whatismyipaddress.com");
            }
            catch
            {

            }
            textBox1.Text = (externalip);
            textBox2.Text = (ip2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            string ip = ("" + ran.Next(10, 255) + "." + ran.Next(10, 255) + "." + ran.Next(10, 255) + "." + ran.Next(10, 255));
            textBox1.Text = ip;
        }
    }
}
