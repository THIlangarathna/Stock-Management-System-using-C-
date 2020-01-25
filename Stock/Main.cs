using System;
using System.Windows.Forms;

namespace Stock
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            UpOut ob1 = new UpOut();
            ob1.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Check ob3 = new Check();
            ob3.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            UpItem ob4 = new UpItem();
            ob4.Show();
            this.Hide();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Report ob5 = new Report();
            ob5.Show();
            this.Hide();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Display ob6 = new Display();
            ob6.Show();
            this.Hide();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            UpIncome ob = new UpIncome();
            ob.Show();
            this.Hide();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Form1 obb = new Form1();
            obb.Show();
            this.Hide();
        }
    }
}
