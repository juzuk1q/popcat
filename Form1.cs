using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace owned_by_juzuk1q
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            count++;
            textBox1.Text = count.ToString();
        }
    }
}
