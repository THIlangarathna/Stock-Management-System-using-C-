using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Stock
{
    public partial class UpOut : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\New\New.mdf';Integrated Security=True;Connect Timeout=30");
        public UpOut()
        {
            InitializeComponent();
        }

        private void UpOut_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'newDataSet15.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter3.Fill(this.newDataSet15.Items);
            // TODO: This line of code loads data into the 'newDataSet12.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter2.Fill(this.newDataSet12.Items);
            // TODO: This line of code loads data into the 'newDataSet9.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter1.Fill(this.newDataSet9.Items);
            // TODO: This line of code loads data into the 'newDataSet8.Outgoing' table. You can move, or remove it, as needed.
            this.outgoingTableAdapter.Fill(this.newDataSet8.Outgoing);
            // TODO: This line of code loads data into the 'newDataSet6.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.newDataSet6.Items);
            // TODO: This line of code loads data into the 'stock_DBDataSet5.Items' table. You can move, or remove it, as needed.
            //this.itemsTableAdapter.Fill(this.stock_DBDataSet5.Items);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //string query = "INSERT INTO Test(Id) SELECT Id FROM Items WHERE Name ='" + cmb.SelectedValue.ToString() + "'";
            string query1 = "INSERT INTO Outgoing(Id,Quantity,Date) VALUES('" + int.Parse(cmb.Text) + "','" + int.Parse(txtqu.Text) + "',getdate())";
            string up = "UPDATE Outgoing SET Name=(SELECT Name FROM Items WHERE Id = '" + int.Parse(cmb.Text) + "') WHERE Id='" + int.Parse(cmb.Text) + "'";
            string stock = "UPDATE Stock SET Quantity=Quantity-'" + int.Parse(txtqu.Text) + "' WHERE Id= '" + int.Parse(cmb.Text) + "'";
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
                MessageBox.Show("Successfully Updated!");
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
