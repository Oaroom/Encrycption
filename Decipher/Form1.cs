using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String str = "hello";

            int cnt = str.Length;

            textBox1.Text = cnt.ToString();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            CEncrypt cencrypt = new CEncrypt();

            textBox2.Text = cencrypt.setKey();
            textBox3.Text = cencrypt.setTable().ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
