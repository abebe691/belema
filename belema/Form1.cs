using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace belema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-KVN6DT2\\SQLEXPRESS; Initial Catalog=belema; Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("sP_login", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@username", SqlDbType.NVarChar, 20).Value = txtuser.Text;
                cmd.Parameters.Add("@password", SqlDbType.NVarChar, 20).Value = txtpass.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Login successful!");
                    Form3 form3 = new Form3();
                    form3.Show();
                    this.Hide();




                }
                else
                {
                    MessageBox.Show("Login failed!");
                }

                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            con.Close();
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }
    }    }
   
