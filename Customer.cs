using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarRental
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=MEHEDI-HASAN-SH;Initial Catalog=CarRentingDB;Integrated Security=True;Encrypt=False;Connect Timeout=30");
        void populated()
        {
            con.Open();
            string query = "select * from CustomerTable1";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);

            //UserDGV.DataSource = ds.Tables[0];
            cardataGridView1.DataSource = ds.Tables[0];

            con.Close();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainapplicationfrom main = new mainapplicationfrom();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idtb.Text == "" || nametb.Text == "" || addresstb.Text == "" || phonetb.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into CustomerTable1 values(" + idtb.Text + ",'" + nametb.Text + "','" + addresstb.Text + "','"+ phonetb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Successfully Added");
                    con.Close();
                    populated();

                }
                catch (Exception Myexp)
                {
                    MessageBox.Show(Myexp.Message);
                }



            }
        }

        private void cardataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idtb.Text = cardataGridView1.SelectedRows[0].Cells[0].Value?.ToString();
            nametb.Text = cardataGridView1.SelectedRows[0].Cells[1].Value?.ToString();
            addresstb.Text = cardataGridView1.SelectedRows[0].Cells[2].Value?.ToString();
            //comboBox1.SelectedItem = cardataGridView1.SelectedRows[0].Cells[3].Value?.ToString();
            phonetb.Text = cardataGridView1.SelectedRows[0].Cells[3].Value?.ToString();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            populated();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (idtb.Text == "")
            {
                MessageBox.Show("missing information");
            }
            else
            {
                try
                {

                    con.Open();
                    String query = "Delete from CustomerTable1 where custmrId=" + idtb.Text + ";";
                    SqlCommand command = new SqlCommand(query, con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Customer Deleted succesfully");
                    con.Close();
                    populated();
                }
                catch (Exception mymehedi)
                {
                    MessageBox.Show($"{mymehedi.Message}");
                }
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {

            if (idtb.Text == "" || nametb.Text == "" || addresstb.Text == "" || phonetb.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update  CustomerTable1 set CustmrName='"+ nametb.Text +"', Custmradd='" + addresstb.Text + "',Phone='" + phonetb.Text + " 'where custmrId=" + idtb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Successfully updated");
                    con.Close();
                    populated();

                }
                catch (Exception Myexp)
                {
                    MessageBox.Show(Myexp.Message);
                }

            }
        }
    }
}
