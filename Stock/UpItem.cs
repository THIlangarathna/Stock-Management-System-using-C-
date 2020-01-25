using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Stock
{
    public partial class UpItem : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\New\New.mdf';Integrated Security=True;Connect Timeout=30");
        public UpItem()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Items(Id,Name) VALUES('" + int.Parse(txtID.Text) + "','" + txtName.Text + "')";
            string query1 = "INSERT INTO Stock(Id,Name) VALUES('" + int.Parse(txtID.Text) + "','" + txtName.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlCommand cmd1 = new SqlCommand(query1, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Item Added Successfully!");
            }
            catch (SqlException e1)
            {
                MessageBox.Show("Error\n" + e1.ToString());
            }
            finally
            {
                con.Close();
                txtID.Clear();
                txtName.Clear();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Items WHERE Id='" + txtID.Text + "'";
            string query1 = "DELETE FROM Stock WHERE Id='" + txtID.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlCommand cmd1 = new SqlCommand(query1, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Item Removed Successfully!");
            }
            catch (SqlException e1)
            {
                MessageBox.Show("Error\n" + e1.ToString());
            }
            finally
            {
                con.Close();
                txtID.Clear();
                txtName.Clear();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Main ob = new Main();
            ob.Show();
            this.Hide();
        }
    }
}
