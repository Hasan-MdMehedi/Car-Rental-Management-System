using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class Return : Form
    {
        public Return()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=MEHEDI-HASAN-SH;Initial Catalog=CarRentingDB;Integrated Security=True;Encrypt=False;Connect Timeout=30");
        void populated()
        {
            con.Open();
            string query = "select * from RentalTable1";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);

            //UserDGV.DataSource = ds.Tables[0];
            rentdgv.DataSource = ds.Tables[0];

            con.Close();
        }
        void populatedrent()
        {
            con.Open();
            string query = "select * from ReturnTable1";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);

            //UserDGV.DataSource = ds.Tables[0];
            returndgv.DataSource = ds.Tables[0];

            con.Close();
        }
        private void Deleteonreturn()
        {

            int rentid;
            rentid = Convert.ToInt32( rentdgv.SelectedRows[0].Cells[0].Value?.ToString());
            con.Open();
            String query = "Delete from rentalTable1 where RentId=" + rentid + ";";
            SqlCommand command = new SqlCommand(query, con);
            command.ExecuteNonQuery();
            //MessageBox.Show("Rental Deleted succesfully");
            con.Close();
            populated();
            //updaterentdelete();
        }


        private void Return_Load(object sender, EventArgs e)
        {
            populated();
            populatedrent();


        }

        private void available_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rentdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            caridtb.Text = rentdgv.SelectedRows[0].Cells[1].Value?.ToString();
            custmrnametb.Text = rentdgv.SelectedRows[0].Cells[2].Value?.ToString();
            returndate.Text = rentdgv.SelectedRows[0].Cells[4].Value?.ToString();
            DateTime d1 = returndate.Value.Date;
            DateTime d2 = DateTime.Now;
            TimeSpan t = d2 - d1;
            int NrOfDays = Convert.ToInt32(t.TotalDays);
            
            if (NrOfDays < 0)
            {
                feestb.Text = "No Delay";
                finetb.Text = "0";
            }
            else
            {
                delaytb.Text = "" + NrOfDays;
                finetb.Text = "" + (NrOfDays * 250);
            }
            //if (NrOfDays < 0)
           /* {
                feestb.Text = "No Delay";
                finetb.Text = "0";
            }
            else
            {
                delaytb.Text = NrOfDays.ToString();
                finetb.Text = (NrOfDays * 250).ToString();
            }*/


        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainapplicationfrom main = new mainapplicationfrom();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (idtb.Text == "" || custmrnametb.Text == "" || finetb.Text == "" || delaytb.Text == "" || delaytb.Text == "")
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

                    string query = "insert into ReturnTable1 values(@id, @carReg, @customerName, @rentDate, @returnDate, @fees)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    /* cmd.Parameters.AddWithValue("@id", idtb.Text);
                     cmd.Parameters.AddWithValue("@carReg", caridtb.ToString());
                     cmd.Parameters.AddWithValue("@customerName", custmrnametb.Text);
                     cmd.Parameters.AddWithValue("@returnDate", returndate.Value.ToString("yyyy-MM-dd")); // Format rentdate to string
                     cmd.Parameters.AddWithValue("@returnDate", feestb); // Format returndate to string
                     cmd.Parameters.AddWithValue("@fees", finetb.Text);*/
                    cmd.Parameters.AddWithValue("@id", idtb.Text);
                    cmd.Parameters.AddWithValue("@carReg", caridtb.Text); // Use Text property to get the text
                    cmd.Parameters.AddWithValue("@customerName", custmrnametb.Text);
                    cmd.Parameters.AddWithValue("@returnDate", returndate.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@rentDate", returndate.Value.ToString("yyyy-MM-dd")); // Format rentdate to string
                    cmd.Parameters.AddWithValue("@fees", feestb.Text); // Use Text property to get the text
                    cmd.Parameters.AddWithValue("@fine", finetb.Text);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car delay Returned");

                    // No need to close the connection here, 
                    // as it will be closed when the method exits.
                    //updaterent();
                    populatedrent();
                    Deleteonreturn();
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

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}

