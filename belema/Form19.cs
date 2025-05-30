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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12(); // Create an instance of Form3
            form12.Show(); // Show Form3
            this.Hide(); // Hide the current form
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
