using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Stock
{
    public partial class UpIncome : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\New\New.mdf';Integrated Security=True;Connect Timeout=30");
        public UpIncome()
        {
            InitializeComponent();
        }

        private void UpIncome_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'newDataSet14.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter3.Fill(this.newDataSet14.Items);
            // TODO: This line of code loads data into the 'newDataSet13.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter2.Fill(this.newDataSet13.Items);
            // TODO: This line of code loads data into the 'newDataSet10.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter1.Fill(this.newDataSet10.Items);
            // TODO: This line of code loads data into the 'newDataSet7.Income' table. You can move, or remove it, as needed.
            this.incomeTableAdapter.Fill(this.newDataSet7.Income);
            // TODO: This line of code loads data into the 'newDataSet5.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.newDataSet5.Items);
            // TODO: This line of code loads data into the 'stock_DBDataSet4.Items' table. You can move, or remove it, as needed.
            //this.itemsTableAdapter4.Fill(this.stock_DBDataSet4.Items);
            // TODO: This line of code loads data into the 'stock_DBDataSet3.Items' table. You can move, or remove it, as needed.
            //this.itemsTableAdapter3.Fill(this.stock_DBDataSet3.Items);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //string query = "INSERT INTO Test(Id) SELECT Id FROM Items WHERE Name ='" + cmb.SelectedValue.ToString() + "'";
            string query1 = "INSERT INTO Income(Id,Quantity,Date) VALUES('" + int.Parse(cmb.Text) + "','" + int.Parse(txtqu.Text) + "',getdate())";
            string up = "UPDATE Income SET Name=(SELECT Name FROM Items WHERE Id = '" + int.Parse(cmb.Text) + "') WHERE Id='" + int.Parse(cmb.Text) + "'";
            string stock = "UPDATE Stock SET Quantity=Quantity+'" + int.Parse(txtqu.Text) + "' WHERE Id= '" + int.Parse(cmb.Text) + "'";
            //SqlCommand cmd = new SqlCommand(query, con);
            SqlCommand cmd1 = new SqlCommand(query1, con);
            SqlCommand cmd2 = new SqlCommand(up, con);
            SqlCommand cmd3 = new SqlCommand(stock, con);
            try
            {
                con.Open();
                //cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                MessageBox.Show("Item Added Successfully!");
            }
            catch (SqlException e1)
            {
                MessageBox.Show("Error\n" + e1.ToString());
            }
            finally
            {
                con.Close();
                txtqu.Clear();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Main ob = new Main();
            ob.Show();
            this.Hide();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\New\New.mdf';Integrated Security=True;Connect Timeout=30");
            string q = "SELECT * FROM Items";
            SqlDataAdapter adapter = new SqlDataAdapter(q, con);
            DataSet set = new DataSet();
            adapter.Fill(set, "Items");
            dataGridView1.DataSource = set.Tables["Items"];
        }
    }
}
