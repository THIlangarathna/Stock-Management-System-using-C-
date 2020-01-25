using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Stock
{
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
        }

        private void Display_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'newDataSet11.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter1.Fill(this.newDataSet11.Items);
            // TODO: This line of code loads data into the 'newDataSet1.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.newDataSet1.Items);
            // TODO: This line of code loads data into the 'stock_DBDataSet14.Items' table. You can move, or remove it, as needed.
            //this.itemsTableAdapter.Fill(this.stock_DBDataSet14.Items);

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
            string q = "SELECT * FROM Items";
            SqlDataAdapter adapter = new SqlDataAdapter(q, con);
            DataSet set = new DataSet();
            adapter.Fill(set, "Items");
            dataGridView1.DataSource = set.Tables["Items"];
        }
    }
}
