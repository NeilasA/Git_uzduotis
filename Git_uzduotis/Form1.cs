using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Git_uzduotis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        int i = 0;
        int[] myNum = new int[10];
        private void button1_Click(object sender, EventArgs e)
        {
            int y = Convert.ToInt32(textBox1.Text);
            if (i < 10)
                {
                    myNum[i] = y;
                i++;

                label1.Text += Environment.NewLine + "kelintas skaicius ivedamas " + i + " is 10, ivestas kaicius:" + myNum[i-1];
                textBox1.Text = String.Empty;
                if (i == 10)
                {
                    int sum = myNum.Sum();
                    richTextBox1.Text += Environment.NewLine + "visu ivestu skaiciu suma = " + sum.ToString();
                }
                }
                
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox2.Text);

            int i, j, k;
            for (i = 0; i < x; i++)
            {
                for (j = 0; j < x - i; j++)

                richTextBox2.Text +=  " ";

                for (k = 0; k < (2 * i + 1); k++)
                {

                    richTextBox2.Text += "*";

                }
                richTextBox2.Text += Environment.NewLine + "";
                
                
            }
            

        }

    }
   }

