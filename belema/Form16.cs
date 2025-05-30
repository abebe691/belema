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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form13 form13 = new Form13(); // Create an instance of Form3
            form13.Show(); // Show Form3
            this.Hide(); // Hide the current form
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
