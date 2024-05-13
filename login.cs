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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {
          

        }

        private void label1_Click(object sender, EventArgs e)
        {
            id.Text = "";
            password.Text = " ";
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection(@"Data Source=MEHEDI-HASAN-SH;Initial Catalog=CarRentingDB;Integrated Security=True;Encrypt=False;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
            String query = "select count (*) from userTable11 where Id='" +id.Text + "'and userPass='" + password.Text + "'";
            con.Open();
            SqlDataAdapter sda= new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();  
            sda.Fill(dataTable);
            if (dataTable.Rows[0][0].ToString() == "1")
            {
                mainapplicationfrom mainf = new mainapplicationfrom();
                mainf.ShowDialog(); 
                this.Hide();}
            else
            {
                MessageBox.Show("Wrong Username or password");

            }
            //con.Close();

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
}
