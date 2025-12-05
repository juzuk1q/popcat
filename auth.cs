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
    public partial class auth : Form
    {
        public auth()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "12345")
            {
                MessageBox.Show("welcome. //");

                this.Hide();
                new Form1().ShowDialog();
            }
            else { MessageBox.Show("incorrect.."); }
        }
    }
}
