using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace belema
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(); // Create an instance of Form3
            form3.Show(); // Show Form3
            this.Hide(); // Hide the current form


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form17 form17 = new Form17(); // Create an instance of Form3
            form17.Show(); // Show Form3
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form19 form19 = new Form19(); // Create an instance of Form3
            form19.Show(); // Show Form3
            this.Hide(); // Hide the current form

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form18 form18 = new Form18(); // Create an instance of Form3
            form18.Show(); // Show Form3
            this.Hide(); // Hide the current form
        }
    }
}
