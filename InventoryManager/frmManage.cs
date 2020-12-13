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
using System.Configuration;

namespace InventoryManager
{
    public partial class frmManage : Form
    {
        public frmManage()
        {
            InitializeComponent();
        }



        // Create the connection
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
        SqlCommand cmd;
        SqlDataAdapter sda;
        int ID = 0;
        string msg = "";

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            ID = int.Parse(row.Cells[0].Value.ToString());
            value_name.Text = row.Cells[1].Value.ToString();
            value_quantity.Value = int.Parse(row.Cells[2].Value.ToString());
            value_date.Value = DateTime.Parse(row.Cells[3].Value.ToString());
            value_location.Text = row.Cells[4].Value.ToString();
            value_type.Text = row.Cells[5].Value.ToString();

        }

        private void frmManage_Load(object sender, EventArgs e)
        {
            refresh_table();
            hide_controls();
            value_location.Items.Add("fridge");
            value_location.Items.Add("freeezer");
            value_location.Items.Add("kitchen cupboard");

            value_type.Items.Add("vegetables");
            value_type.Items.Add("meat");
            value_type.Items.Add("grains");
            value_type.Items.Add("dairy");
            value_type.Items.Add("fruits");

            value_date.Format = DateTimePickerFormat.Custom;
            value_date.CustomFormat = "yyyy-MMMM-dd";
        }

        private void refresh_table()
        {
            cmd = new SqlCommand("SELECT product_id as id,product_name as name, quantity,expiryDate as 'expiry date',location_name as location,type_name as type FROM tbl_stock, tbl_location, tbl_type WHERE  tbl_stock.location_number = tbl_location.location_number and tbl_stock.type_number = tbl_type.type_number;", con);
            fill_table();
        }
        private void fill_table()
        {
            con.Open();
            sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;
        }

        private void hide_controls()
        {
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            value_name.Visible = false;
            value_quantity.Visible = false;
            value_date.Visible = false;
            value_location.Visible = false;
            value_type.Visible = false;
            btn_submit.Visible = false;
        }

        private void display_controls()
        {
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            value_name.Visible = true;
            value_quantity.Visible = true;
            value_date.Visible = true;
            value_location.Visible = true;
            value_type.Visible = true;
            btn_submit.Visible = true;

        }



        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (value_name.Text == "" || value_location.Text == "" || value_type.Text == "")
            {
                MessageBox.Show("Please provide details.");
            }
            else
            {
                switch (btn_submit.Text)
                {
                    case "insert":
                        cmd = new SqlCommand("insert into tbl_stock(product_name,quantity,expiryDate,location_number, type_number) values(@name,@quantity,@date,@location,@type);", con);
                        msg = "record inserted successfully";
                        executeQuery();
                        break;
                    case "edit":
                        cmd = new SqlCommand("update tbl_stock SET quantity = @quantity, expiryDate = @date, location_number = @location, type_number = @type, product_name = @name WHERE product_id = @ID", con);
                        msg = "record updated successfully";
                        executeQuery();
                        break;
                    case "erase":
                        string message = "Are you sure you want to delete?";
                        string title = "Delete Record";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttons);
                        if (result == DialogResult.Yes)
                        {
                            cmd = new SqlCommand("delete tbl_stock WHERE product_id = @ID;", con);
                            msg = "record deleted successfully";
                            executeQuery();
                        }
                        break;
                    default:
                        break;
                }
            }

        }

        private void executeQuery()
        {
            con.Open();
            cmd.Parameters.AddWithValue("@name", value_name.Text);
            cmd.Parameters.AddWithValue("@quantity", value_quantity.Text);
            cmd.Parameters.AddWithValue("@date", value_date.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@location", value_location.SelectedIndex + 1);
            cmd.Parameters.AddWithValue("@type", value_type.SelectedIndex + 1);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(msg);
            refresh_table();
            refresh_values();
        }
        
        
        private void btn_add_Click(object sender, EventArgs e)
        {
            btn_submit.BackColor = btn_add.BackColor;
            btn_submit.Text = "insert";
            refresh_values();
            display_controls();
        }

        private void refresh_values()
        { 
            DateTime today = DateTime.Today;
            value_name.Text = "";
            value_quantity.Value = 1;
            value_date.Value = today;
            value_location.Text = "";
            value_type.Text = "";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            btn_submit.BackColor = btn_update.BackColor;
            btn_submit.Text = "edit";
            display_controls();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            btn_submit.BackColor = btn_delete.BackColor;
            btn_submit.Text = "erase";
            display_controls();

        }
    }
}
