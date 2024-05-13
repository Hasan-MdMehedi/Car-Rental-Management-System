using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CarRental
{
    public partial class DaahBoard : Form
    {
        public DaahBoard()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=MEHEDI-HASAN-SH;Initial Catalog=CarRentingDB;Integrated Security=True;Encrypt=False;Connect Timeout=30");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DaahBoard_Load(object sender, EventArgs e)
        {
            String querycar = "select Count(*) from CarTable1";
            SqlDataAdapter sda = new SqlDataAdapter(querycar, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            textBox3.Text = dt.Rows[0][0].ToString();

            String querycust = "select Count(*) from CustomerTable1";
            SqlDataAdapter sda1 = new SqlDataAdapter(querycust, con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            textBox4.Text = dt1.Rows[0][0].ToString();


            String queryuser = "select Count(*) from CarTable1";
            SqlDataAdapter sda2 = new SqlDataAdapter(querycar, con);
            DataTable dt2 = new DataTable();
            sda.Fill(dt);
            textBox6.Text = dt.Rows[0][0].ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainapplicationfrom main = new mainapplicationfrom();
            main.Show();
        }
    }
}
