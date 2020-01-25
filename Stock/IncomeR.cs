using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Stock
{
    public partial class IncomeR : Form
    {
        public IncomeR()
        {
            InitializeComponent();
        }

        private void IncomeR_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'newDataSet17.Income' table. You can move, or remove it, as needed.
            this.incomeTableAdapter2.Fill(this.newDataSet17.Income);
            // TODO: This line of code loads data into the 'newDataSet16.Income' table. You can move, or remove it, as needed.
            this.incomeTableAdapter1.Fill(this.newDataSet16.Income);
            // TODO: This line of code loads data into the 'newDataSet2.Income' table. You can move, or remove it, as needed.
            this.incomeTableAdapter.Fill(this.newDataSet2.Income);
            // TODO: This line of code loads data into the 'stock_DBDataSet11.Income' table. You can move, or remove it, as needed.
            //this.incomeTableAdapter.Fill(this.stock_DBDataSet11.Income);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Report ob = new Report();
            ob.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Main ob1 = new Main();
            ob1.Show();
            this.Hide();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\New\New.mdf';Integrated Security=True;Connect Timeout=30");
            string q = "SELECT * FROM Income";
            SqlDataAdapter adapter = new SqlDataAdapter(q, con);
            DataSet set = new DataSet();
            adapter.Fill(set, "Income");
            dataGridView1.DataSource = set.Tables["Income"];
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\New\New.mdf';Integrated Security=True;Connect Timeout=30");
            string q = "SELECT * FROM Income";
            SqlDataAdapter adapter = new SqlDataAdapter(q, con);
            DataSet set = new DataSet();
            adapter.Fill(set, "Income");
            dataGridView1.DataSource = set.Tables["Income"];
        }
    }
}
