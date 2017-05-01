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
        List<List<int>> L0 = new List<List<int>>();
        List<List<List<int>>> Alpha = new List<List<List<int>>>();
        List<List<List<int>>> Beta = new List<List<List<int>>>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            L0.Add(new List<int> { 2, 2, 6 }); L0.Add(new List<int> { 2, 2, 6 }); L0.Add(new List<int> { 2, 2, 6 });
            L0.Add(new List<int> { 2, 2, 6 }); L0.Add(new List<int> { 2, 2, 6 }); L0.Add(new List<int> { 2, 2, 6 });
            L0.Add(new List<int> { 2, 2, 6 }); L0.Add(new List<int> { 2, 2, 6 }); L0.Add(new List<int> { 2, 2, 6 });
            L0.Add(new List<int> { 2, 2, 6 }); L0.Add(new List<int> { 2, 6, 2 }); L0.Add(new List<int> { 2, 6, 2 });
            Alpha.Add(L0);
        }

        public string Process(string input)
        {
            List<int> firstRow = new List<int>();
            List<List<int>> allRows = new List<List<int>>();
            List<bool> answer1 = new List<bool>();

            string[] testy1 = input.Split('\n');
            if (testy1.Length == 12)
            {
                for (var a = 0; a < testy1.Length; a++)
                {
                    char[] splity = testy1[a].ToCharArray();
                    Beta.Add(GetChars(splity));
                }

                
                for (var b1 = 0; b1 < 12; b1++)
                {
                    for (var b2 = 0; b2 < Beta[b1].Count; b2++)
                    {
                        answer1.Add(Beta[b1][b2].SequenceEqual(Alpha[b1][b2]));
                    }
                }

                //MessageBox.Show(testy1[a]);
            }
            return (answer1.Contains(false).ToString()) ;
        }

        // Get arrangement of colons (non-letters) and spaces (parts that make up letters)
        public List<List<int>> GetChars(char[] lineOfChars)
        {
            List<List<int>> row0 = new List<List<int>>();

            if ((lineOfChars.Length % 12) == 0)
            {
                for (var aa = 0; aa < (lineOfChars.Length / 12); aa++)
                {
                    List<int> row1 = new List<int>();
                    int which1 = 0;

                    for (var bb = (aa * 12); bb < ((aa * 12) + 10); bb++)
                    {
                        var count = 0;
                        var charNum = 0;
                        var c = ((which1 % 2) == 0) ? ':' : ' ';
                        if ((charNum < 10) && (lineOfChars[aa] == c))
                        {
                            count++;
                            charNum++;
                        }
                        which1++;
                        row1.Add(count);
                    }
                    row0.Add(row1);
                }
            }

            return row0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rtbInput = richTextBox1.Text;
            string result = Process(rtbInput);
            textBox1.Text = result;
        }
    }
}
