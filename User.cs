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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=MEHEDI-HASAN-SH;Initial Catalog=CarRentingDB;Integrated Security=True;Encrypt=False;Connect Timeout=30");
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            uid.Text = dataGridView1.SelectedRows[0].Cells[0].Value?.ToString();
            uname.Text = dataGridView1.SelectedRows[0].Cells[1].Value?.ToString();
            upassword.Text = dataGridView1.SelectedRows[0].Cells[2].Value?.ToString();
        }
            void populated()
            {
                con.Open();
                string query = "select * from userTable11";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);

            //UserDGV.DataSource = ds.Tables[0];
            dataGridView1.DataSource = ds.Tables[0];

            con.Close();
            }
        
      

        private void button1_Click(object sender, EventArgs e)
        {
            if (uid.Text == "" || uname.Text == "" || upassword.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                 con.Open();
                    string query="insert into userTable11 values("+uid.Text+",'"+uname.Text+"','"+upassword.Text+"')";
                    SqlCommand cmd = new SqlCommand(query,con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("user Successfully Added");
                    con.Close();
                    populated();

                }
                catch (Exception Myexp) { 
                    MessageBox.Show(Myexp.Message);
                }



            }
        }

        private void User_Load(object sender, EventArgs e)
        {
            populated();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (uid.Text == "")
            {
                MessageBox.Show("missing information");
            }
            else
            {
                try
                {

                    con.Open();
                    String query = "Delete from userTable11 where id=" + uid.Text + ";";
                    SqlCommand command = new SqlCommand(query,con); 
                    command.ExecuteNonQuery();
                    MessageBox.Show("User Deleted succesfully");
                    con.Close();
                    populated() ;
                }catch(Exception mymehedi)
                {
                    MessageBox.Show($"{mymehedi.Message}");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             if (uid.Text == "" || uname.Text == "" || upassword.Text == "")
             {
                 MessageBox.Show("Missing information");
             }
             else
             {
                 try
                 {
                     con.Open();
                     string query = "update userTable11 set uname'"+uname.Text+"' upass='"+upassword.Text+"'where Id="+uid.Text;
                     SqlCommand cmd = new SqlCommand(query, con);
                     cmd.ExecuteNonQuery();
                     MessageBox.Show("user Successfully updated");
                     con.Close();
                     populated();

                 }
                 catch (Exception Myexp)
                 {
                     MessageBox.Show(Myexp.Message);
                 }



             }
           
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainapplicationfrom main = new mainapplicationfrom();
            main.Show();    
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("I am here");
            if (dataGridView1.SelectedRows.Count > 0)
            {
                uid.Text = dataGridView1.SelectedRows[0].Cells[0].Value?.ToString();
                uname.Text = dataGridView1.SelectedRows[0].Cells[1].Value?.ToString();
                upassword.Text = dataGridView1.SelectedRows[0].Cells[2].Value?.ToString();
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void uname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
