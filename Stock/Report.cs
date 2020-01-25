using System;
using System.Windows.Forms;

namespace Stock
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            IncomeR ob1 = new IncomeR();
            ob1.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            OutgoingR ob2 = new OutgoingR();
            ob2.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Lack ob3 = new Lack();
            ob3.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Main ob = new Main();
            ob.Show();
            this.Hide();
        }
    }
}
