using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For
{
    public partial class Form1 : Form
    {
        private int num;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                listBox1.Items.Add($"{1} * {i}={1*i}");
            }
            for (int i = 1; i <=10; i++)
            {
                listBox2.Items.Add($"{2}* {i}={2*i}");
            }
            for (int i = 1; i <=10 ; i++)
            {
                listBox3.Items.Add($"{3}* {i}={3 * i}");
            }
            for (int i = 1; i <=10; i++)
            {
                listBox4.Items.Add($"{4}*{i}={4 * i}");
            }
            for (int i = 1; i <=10; i++)
            {
                listBox5.Items.Add($"{5}*{i}={5 * i}");
            }
        }
    }
}
