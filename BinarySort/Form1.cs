using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinarySort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BinarySort bSort = new BinarySort();
        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            int[] num = bSort.Sort(BinarySort.Parse(str));
            label3.Text = Convert.ToString(bSort.Sort2(BinarySort.Parse(str)));
            for (int i = 0; i < num.Length; i++)
            {
                textBox2.Text += num[i] + " ";
            }
        }
    }
}
