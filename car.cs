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
using System.Security.Cryptography;
using System.Xml.Linq;

namespace CarRental
{
    public partial class car : Form
    {
        public car()
        {
            InitializeComponent();
        }


        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection(@"Data Source=MEHEDI-HASAN-SH;Initial Catalog=CarRentingDB;Integrated Security=True;Encrypt=False;Connect Timeout=30");
        void populated()
        {
            con.Open();
            string query = "select * from CarTable1";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);

            //UserDGV.DataSource = ds.Tables[0];
            cardataGridView1.DataSource = ds.Tables[0];

            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (regnum.Text == "" || brand.Text == "" || model.Text == "" || price.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into CarTable1 values(" + regnum.Text + ",'" + brand.Text + "','" + model.Text + "','"+comboBox1.SelectedItem.ToString() + "','" + price.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Successfully Added");
                    con.Close();
                    populated();

                }
                catch (Exception Myexp)
                {
                    MessageBox.Show(Myexp.Message);
                }



            }
        }

        private void car_Load(object sender, EventArgs e)
        {
            populated();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (regnum.Text == "")
            {
                MessageBox.Show("missing information");
            }
            else
            {
                try
                {

                    con.Open();
                    String query = "Delete from CarTable1 where RegNumber='" + regnum.Text + "';";
                    SqlCommand command = new SqlCommand(query, con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Car Deleted succesfully");
                    con.Close();
                    populated();
                }
                catch (Exception mymehedi)
                {
                    MessageBox.Show($"{mymehedi.Message}");
                }
            }
        }

        private void cardataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            regnum.Text = cardataGridView1.SelectedRows[0].Cells[0].Value?.ToString();
            brand.Text = cardataGridView1.SelectedRows[0].Cells[1].Value?.ToString();
            model.Text = cardataGridView1.SelectedRows[0].Cells[2].Value?.ToString();
            comboBox1.SelectedItem = cardataGridView1.SelectedRows[0].Cells[3].Value?.ToString();
            price.Text = cardataGridView1.SelectedRows[0].Cells[4].Value?.ToString();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            
            if (regnum.Text == "" || brand.Text == "" || model.Text == "" || price.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update CarTable1 set brand='" + brand.Text + "', Model='" + model.Text + "',ComboBox1='" + comboBox1.SelectedItem.ToString() + "', price='" + price.Text + " where regnum=" + regnum.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Successfully updated");
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

        private void regnum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

