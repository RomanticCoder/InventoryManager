using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace InventoryManager
{
    public partial class frmLogin : Form
    {
        private frmInventory frmInventory;

        public frmLogin()
        {
            InitializeComponent();
        }

        // Create the connection
        SqlCommand cmd;
        SqlDataAdapter sda;


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtPassword.Text != "")
            {
                login();
            }
            else
            {
                MessageBox.Show("Enter your user name and password");
            }
        }

        private void login()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString))
            {
                try
                {
                    con.Open();
                    // Create the command
                    cmd = new SqlCommand("SELECT password FROM tbl_loginInfo WHERE userName = '" + txtUserName.Text + "'", con);
                    string output = "";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            output = output + reader.GetValue(0);
                        }

                        if (output == txtPassword.Text)
                        {
                            MessageBox.Show("login success");
                            frmInventory = new frmInventory();
                            frmInventory.Show();
                            this.Hide();
                        }
                        else if (output == "")
                        {
                            MessageBox.Show("Invalid user name.\nTry again.");
                            txtUserName.Text = "";
                            txtPassword.Text = "";

                        }
                        else
                        {
                            MessageBox.Show("Password is not correct.\nTry again.");
                            txtPassword.Text = "";
                        }
                    }

                }
                catch(Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
                Console.ReadLine();

            }
        }
    }
}
