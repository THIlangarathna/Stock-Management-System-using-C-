using System;
using System.Windows.Forms;

namespace Stock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtpass.PasswordChar = '*';
        }

        private void Button1_Click(object sender, EventArgs e)
        {
             string name = txtname.Text;
            string password = txtpass.Text;
            if (name == "Admin" && password == "Password")
            {
                Main ob1 = new Main();
                ob1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username and Password :(");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Main ob1 = new Main();
            ob1.Show();
            this.Hide();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            Main ob1 = new Main();
            ob1.Show();
            this.Hide();
        }
    }
}
