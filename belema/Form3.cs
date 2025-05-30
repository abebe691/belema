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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12(); 
            form12.Show(); 
            this.Hide(); 


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12(); // Create an instance of Form3
            form12.Show(); // Show Form3
            this.Hide(); // Hide the current form


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13(); // Create an instance of Form3
            form13.Show(); // Show Form3
            this.Hide(); // Hide the current form


        }

        private void button4_Click(object sender, EventArgs e)
        {
           Form1 form1 = new Form1(); // Create an instance of Form3
            form1.Show(); // Show Form3
            this.Hide(); // Hide the current form


        }
    }
}
