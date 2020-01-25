using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Stock
{
    public partial class OutgoingR : Form
    {
        public OutgoingR()
        {
            InitializeComponent();
        }

        private void OutgoingR_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'newDataSet4.Outgoing' table. You can move, or remove it, as needed.
            this.outgoingTableAdapter.Fill(this.newDataSet4.Outgoing);
            // TODO: This line of code loads data into the 'stock_DBDataSet12.Outgoing' table. You can move, or remove it, as needed.
            //this.outgoingTableAdapter.Fill(this.stock_DBDataSet12.Outgoing);

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

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\New\New.mdf';Integrated Security=True;Connect Timeout=30");
            string q = "SELECT * FROM Outgoing";
            SqlDataAdapter adapter = new SqlDataAdapter(q, con);
            DataSet set = new DataSet();
            adapter.Fill(set, "Outgoing");
            dataGridView1.DataSource = set.Tables["Outgoing"];
        }
    }
}
