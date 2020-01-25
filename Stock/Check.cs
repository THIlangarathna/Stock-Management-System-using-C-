using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Stock
{
    public partial class Check : Form
    {
        public Check()
        {
            InitializeComponent();
        }

        private void Check_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'newDataSet.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.newDataSet.Stock);
            // TODO: This line of code loads data into the 'stock_DBDataSet10.Stock' table. You can move, or remove it, as needed.
            //this.stockTableAdapter3.Fill(this.stock_DBDataSet10.Stock);
            // TODO: This line of code loads data into the 'stock_DBDataSet9.Stock' table. You can move, or remove it, as needed.
            //this.stockTableAdapter2.Fill(this.stock_DBDataSet9.Stock);
            // TODO: This line of code loads data into the 'stock_DBDataSet6.Stock' table. You can move, or remove it, as needed.
            //this.stockTableAdapter.Fill(this.stock_DBDataSet6.Stock);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Main ob = new Main();
            ob.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\New\New.mdf';Integrated Security=True;Connect Timeout=30");
            string q = "SELECT * FROM Stock";
            SqlDataAdapter adapter = new SqlDataAdapter(q, con);
            DataSet set = new DataSet();
            adapter.Fill(set, "Stock");
            dataGridView1.DataSource = set.Tables["Stock"];
        }
    }
}
