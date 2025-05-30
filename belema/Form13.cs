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
    public partial class Form13 : Form
    {
        public Form13()
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
            Form14 form14 = new Form14(); // Create an instance of Form3
            form14.Show(); // Show Form3
            this.Hide(); // Hide the current form

        }

        private void button5_Click(object sender, EventArgs e)
        {

            Form15 form15 = new Form15(); // Create an instance of Form3
            form15.Show(); // Show Form3
            this.Hide(); // Hide the current form
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form16 form16 = new Form16(); // Create an instance of Form3
            form16.Show(); // Show Form3
            this.Hide(); //
        }
    }
}
