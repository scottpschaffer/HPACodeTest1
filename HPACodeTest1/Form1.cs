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
            List<int> firstRow = new List<int>();
            List<int> n = new List<int> { 2, 2, 6 };
            List<List<int>> L0 = new List<List<int>>();
            L0.Add(new List<int> { 2, 2, 6 });
            L0.Add(new List<int> { 2, 6, 2 });
            string[] testy1 = input.Split('\n');
            for (var a = 0; a < testy1.Length; a++)
            {
                char[] split1 = testy1[a].ToCharArray();
                firstRow = GetChars(split1);
                bool qq = firstRow.SequenceEqual(L0[a]);
                MessageBox.Show(qq.ToString());

                

                //MessageBox.Show(testy1[a]);
            }
            return (firstRow[0].ToString() + "*" + firstRow[1].ToString() + "*" + firstRow[2].ToString()) ;
        }

        // Get arrangement of colons (non-letters) and spaces (parts that make up letters)
        public List<int> GetChars(char[] lineOfChars)
        {
            List<int> row = new List<int>();
            int which1 = 0;
            char c = ':';
            int charNum = 0;
            while (charNum < 10)
            {
                var count = 0;

                c = ((which1 % 2) == 0) ? ':' : ' ';
                while ((charNum < 10) && (lineOfChars[charNum] == c))
                {
                    count++;
                    charNum++;
                }
                which1++;
                row.Add(count);
            }

            return row;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rtbInput = richTextBox1.Text;
            string result = Process(rtbInput);
            textBox1.Text = result;
        }
    }
}
