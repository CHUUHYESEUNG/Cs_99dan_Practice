using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace gugudan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input_number = Regex.Replace(textBox1.Text, @"\D", "");
            if (input_number == null || input_number == "")
            {
                MessageBox.Show("숫자를 입력해주세요");
                return;
            }

            if (listBox1.Items.Count != 0)
            {
                listBox1.Items.Clear();
            }
            
            for (int i = 1; i < 10; i++)
            {
                listBox1.Items.Add(string.Format("{0} X {1} = {2}", input_number, i, Convert.ToInt32(input_number) * i));
            }

        }

    }
}
