using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class mainapplicationfrom : Form
    {
        public mainapplicationfrom()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer customerr = new Customer();
            customerr.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            car carr = new car();
            carr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rental rentall = new Rental();
            rentall.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Return rentall = new Return();
            rentall.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            User rentall = new User();
            rentall.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            DaahBoard board = new DaahBoard();
            board.Show();
        }
    }
}
