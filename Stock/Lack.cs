using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Stock
{
    public partial class Lack : Form
    {
        public Lack()
        {
            InitializeComponent();
        }

        private void Lack_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'newDataSet3.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.newDataSet3.Stock);
            // TODO: This line of code loads data into the 'stock_DBDataSet13.Stock' table. You can move, or remove it, as needed.
            //this.stockTableAdapter.Fill(this.stock_DBDataSet13.Stock);

        }

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.stockTableAdapter.FillBy(this.stock_DBDataSet13.Stock);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }


        private void Button2_Click(object sender, EventArgs e)
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

        private void FillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.stockTableAdapter.FillBy(this.newDataSet3.Stock);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.stockTableAdapter.FillBy1(this.newDataSet3.Stock);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\New\New.mdf';Integrated Security=True;Connect Timeout=30");
            string q = "SELECT * FROM Stock WHERE Quantity<10";
            SqlDataAdapter adapter = new SqlDataAdapter(q, con);
            DataSet set = new DataSet();
            adapter.Fill(set, "Stock");
            dataGridView1.DataSource = set.Tables["Stock"];
        }
    }
}
