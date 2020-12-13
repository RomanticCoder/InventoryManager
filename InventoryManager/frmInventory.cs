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
    public partial class frmInventory : Form
    {
        private frmLogin frmLogin;
        private frmManage frmManage;
        public frmInventory()
        {
            InitializeComponent();
        }

        // Create the connection
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
        SqlCommand cmd;
        SqlDataAdapter sda;
        int type_number = 0;

        private void frmInventory_Load(object sender, EventArgs e)
        {
            lbl_description.Text = "All items in your personal inventory";
            cmd = new SqlCommand("SELECT product_name as name, quantity,expiryDate as 'expiry date',location_name as location,type_name as type FROM tbl_stock, tbl_location, tbl_type WHERE  tbl_stock.location_number = tbl_location.location_number and tbl_stock.type_number = tbl_type.type_number;", con);
            fill_table();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_fresh1_Click(object sender, EventArgs e)
        {
            lbl_description.Text = "Fresh items (more than 30 days left)";
            cmd = new SqlCommand("SELECT product_name, quantity,expiryDate ,location_name,type_name FROM tbl_stock, tbl_location, tbl_type WHERE  tbl_stock.location_number = tbl_location.location_number and tbl_stock.type_number = tbl_type.type_number AND DATEDIFF(day, GETDATE(),expiryDate) > 30;", con);
            fill_table();

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            lbl_description.Text = "All items in your personal inventory";
            cmd = new SqlCommand("SELECT product_name as name, quantity,expiryDate as 'expiry date',location_name as location,type_name as type FROM tbl_stock, tbl_location, tbl_type WHERE  tbl_stock.location_number = tbl_location.location_number and tbl_stock.type_number = tbl_type.type_number;", con);
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

        private void btn_fresh2_Click(object sender, EventArgs e)
        {
            lbl_description.Text = "Items near expiry (less than 30 days left)";
            cmd = new SqlCommand("SELECT product_name, quantity,DATEDIFF(day, GETDATE(),expiryDate) as 'days left', location_name,type_name FROM tbl_stock, tbl_location, tbl_type WHERE  tbl_stock.location_number = tbl_location.location_number and tbl_stock.type_number = tbl_type.type_number AND DATEDIFF(day, GETDATE(),expiryDate) < 30 AND DATEDIFF(day, GETDATE(),expiryDate) > 0 ;", con);
            fill_table();
        }

        private void btn_fresh3_Click(object sender, EventArgs e)
        {
            lbl_description.Text = "Expired items";
            cmd = new SqlCommand("SELECT product_name, quantity,expiryDate, location_name,type_name FROM tbl_stock, tbl_location, tbl_type WHERE  tbl_stock.location_number = tbl_location.location_number and tbl_stock.type_number = tbl_type.type_number AND DATEDIFF(day, GETDATE(),expiryDate) < 0 ;", con);
            fill_table();
        }


        private void btn_type1_Click(object sender, EventArgs e)
        {
            type_number = 1;
            lbl_description.Text = "Type: Vegetables";
            makeCommand();
        }

    

        private void makeCommand()
        {
            cmd = new SqlCommand("SELECT product_name as name, quantity,expiryDate as 'expiry date',location_name as location FROM tbl_stock, tbl_location, tbl_type WHERE  tbl_stock.location_number = tbl_location.location_number and tbl_stock.type_number = tbl_type.type_number and tbl_type.type_number = @type_number;", con);
            cmd.Parameters.AddWithValue("@type_number", type_number);
            fill_table();
        }

        private void btn_type2_Click(object sender, EventArgs e)
        {
            type_number = 2;
            lbl_description.Text = "Type: Meat";
            makeCommand();

        }

        private void btn_type3_Click(object sender, EventArgs e)
        {
            type_number = 3;
            lbl_description.Text = "Type: Grains";
            makeCommand();
        }

        private void btn_type4_Click(object sender, EventArgs e)
        {
            type_number = 4;
            lbl_description.Text = "Type: Dairy";
            makeCommand();

        }

        private void btn_type5_Click(object sender, EventArgs e)
        {
            type_number = 5;
            lbl_description.Text = "Type: Fruits";
            makeCommand();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
           frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void btn_ouoOfStock_Click(object sender, EventArgs e)
        {
            lbl_description.Text = "Items out of stock";
            cmd = new SqlCommand("SELECT product_name as name, quantity,expiryDate as 'expiry date',location_name as location,type_name as type FROM tbl_stock, tbl_location, tbl_type WHERE  tbl_stock.location_number = tbl_location.location_number and tbl_stock.type_number = tbl_type.type_number and tbl_stock.quantity <= 0;", con);
            fill_table();
        }

        private void btn_inStock_Click(object sender, EventArgs e)
        {
            lbl_description.Text = "Items in stock";
            cmd = new SqlCommand("SELECT product_name as name, quantity,expiryDate as 'expiry date',location_name as location,type_name as type FROM tbl_stock, tbl_location, tbl_type WHERE  tbl_stock.location_number = tbl_location.location_number and tbl_stock.type_number = tbl_type.type_number and tbl_stock.quantity > 0;", con);
            fill_table();
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            try
            {
                // creating Excel Application  
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // creating new WorkBook within Excel application  
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // creating new Excelsheet in workbook  
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                // see the excel sheet behind the program  
                app.Visible = true;
                // get the reference of first sheet. By default its name is Sheet1.  
                // store its reference to worksheet  
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                // changing the name of active sheet  
                worksheet.Name = "Exported from gridview";    //current sheet name
                                                              // storing header part in Excel  
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet  
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)  //Row 
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++) //Column
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.ReadLine();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            lbl_description.Text = "Search by name: " +txt_search.Text;
            cmd = new SqlCommand("SELECT product_name as name, quantity,expiryDate as 'expiry date',location_name as location,type_name as type FROM tbl_stock, tbl_location, tbl_type WHERE  tbl_stock.location_number = tbl_location.location_number and tbl_stock.type_number = tbl_type.type_number AND tbl_stock.product_name LIKE '%"+ txt_search.Text + "%';", con);
            fill_table();
        }

        private void btn_manage_Click(object sender, EventArgs e)
        {
            frmManage = new frmManage();
            frmManage.Show();
        }
    }
}
