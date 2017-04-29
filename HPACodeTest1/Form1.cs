using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPACodeTest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public string Process(string input)
        {
            string[] testy1 = input.Split('\n');
            for (var a = 0; a < testy1.Length; a++)
            {
                MessageBox.Show(testy1[a]);
            }
            return input;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rtbInput = richTextBox1.Text;
            string result = Process(rtbInput);
            textBox1.Text = result;
        }
    }
}
