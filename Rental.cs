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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using System.Reflection;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace CarRental
{
    public partial class Rental : Form
    {
        public Rental()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=MEHEDI-HASAN-SH;Initial Catalog=CarRentingDB;Integrated Security=True;Encrypt=False;Connect Timeout=30");

        private void fillcombo()
        {
            con.Open();
            string query = "select RegNumber from CarTable1 where  Available='"+"Yes"+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("RegNumber", typeof(string));
            dt.Load(reader);
            carregcb.ValueMember = "RegNumber";
            carregcb.DataSource = dt;
            con.Close();
        }

            private void fillCustomer()
        {
           con.Open();
            string query = "select  custmrid from CustomerTable1";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("custmrid", typeof(int));
            dt.Load(reader);
            custcb.ValueMember = "custmrid";
            custcb.DataSource = dt;



            con.Close();
        }
        void populated()
        {
            con.Open();
            string query = "select * from RentalTable1";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);

            //UserDGV.DataSource = ds.Tables[0];
            rentdataGridView1.DataSource = ds.Tables[0];

            con.Close();
        }
        private void fetchCustmrname()
        {
            con.Open(); 
            string query ="select * from CustomerTable1 where  CustmrId="+custcb.SelectedValue.ToString()+"";
            SqlCommand cmd = new SqlCommand(query,con);   
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows) {
                custmrnametb.Text = dr["custmrName"].ToString();
            }
        }
        private void updaterent()
        {
            con.Open();
            string query = "update CarTable1 set ComboBox1='" + "No"+ "' where regnum ='" + carregcb.SelectedValue.ToString() + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            //MessageBox.Show("Car Successfully updated");
            con.Close();
        }
        private void updaterentdelete()
        {
            con.Open();
            string query = "update CarTable1 set ComboBox1='" + "Yes" + "' where regnum ='" + carregcb.SelectedValue.ToString() + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            //MessageBox.Show("Car Successfully updated");
            con.Close();
        }
        private void Rental_Load(object sender, EventArgs e)
        {
            fillcombo();
            fillCustomer();
           populated();
        }
        private void carregcb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void carregcb_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void custcb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchCustmrname();

        }

        /* private void button1_Click(object sender, EventArgs e)
         {
             if (idtb.Text == "" || custmrnametb.Text == "" || carregcb.Text == "" )
             {
                 MessageBox.Show("Missing information");
             }
             else
             {
                 try
                 {
                     con.Open();
                     string query = "insert into RentalTable1 values('" + idtb.Text + "','" + carregcb.SelectedValue.ToString() + "','" + custmrnametb.Text + "','" + rentdate.Text + "','"+returndate.Text+"','"+feestb.Text+"')";
                     SqlCommand cmd = new SqlCommand(query, con);
                     cmd.ExecuteNonQuery();
                     MessageBox.Show("Car Successfully Rented");
                     con.Close();
                     populated();

                 }
                 catch (Exception Myexp)
                 {
                     MessageBox.Show(Myexp.Message);
                 }



             }
         }*/
        private void button1_Click(object sender, EventArgs e)
        {
            if (idtb.Text == "" || custmrnametb.Text == "" || carregcb.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }

                    string query = "insert into RentalTable1 values(@id, @carReg, @customerName, @rentDate, @returnDate, @fees)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", idtb.Text);
                    cmd.Parameters.AddWithValue("@carReg", carregcb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@customerName", custmrnametb.Text);
                    cmd.Parameters.AddWithValue("@rentDate", rentdate.Value.ToString("yyyy-MM-dd")); // Format rentdate to string
                    cmd.Parameters.AddWithValue("@returnDate", returndate.Value.ToString("yyyy-MM-dd")); // Format returndate to string
                    cmd.Parameters.AddWithValue("@fees", feestb.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Successfully Rented");

                    // No need to close the connection here, 
                    // as it will be closed when the method exits.
                    updaterent();
                    populated();
                }
                catch (Exception Myexp)
                {
                    MessageBox.Show(Myexp.Message);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
        }



        private void custmrnametb_TextChanged(object sender, EventArgs e)
        {

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
                    String query = "Delete from rentalTable1 where RentId=" + idtb.Text + ";";
                    SqlCommand command = new SqlCommand(query, con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Rental Deleted succesfully");
                    con.Close();
                    populated();
                    updaterentdelete();
                }
                catch (Exception mymehedi)
                {
                    MessageBox.Show($"{mymehedi.Message}");
                }
            }
        }

        private void rentdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idtb.Text = rentdataGridView1.SelectedRows[0].Cells[0].Value?.ToString();
            carregcb.Text = rentdataGridView1.SelectedRows[0].Cells[1].Value?.ToString();
           // custmrnametb.Text = rentdataGridView1.SelectedRows[0].Cells[3].Value?.ToString();
            feestb.Text= rentdataGridView1.SelectedRows[0].Cells[5].Value?.ToString();
        }
    }

        //private void Rental_Load(object sender, EventArgs e)

    
}
