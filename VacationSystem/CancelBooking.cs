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

namespace VacationSystem
{
    public partial class CancelBooking : Form
    {
        public CancelBooking()
        {
            InitializeComponent();
        }
        /*
         * Gets the information from the user to cancel the booking then deletes it from the SQL database
         */
        private void submitButton_Click(object sender, EventArgs e)
        {
            if (confirmationNTB.Text == "" || emailTextbox.Text == "" || lastNameTextBox.Text == "")
            {
                MessageBox.Show("All fields required to be entered");
            }
            else if (confirmationNTB.Text.Length != 12)
            {
                MessageBox.Show("Invalid Confirmation Number");
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M4F8K4I;Initial Catalog=vacationdb;Integrated Security=TRUE");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM bookings WHERE confirmationnumber='" + confirmationNTB.Text + "' AND email='" + emailTextbox.Text +"' AND lastname='" + lastNameTextBox.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if(dt.Rows.Count != 1)
                {
                    MessageBox.Show("Booking Not Found");
                }
                else
                {
                    //Deletes the booking by the confirmation number from the database
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM bookings WHERE confirmationnumber='" + confirmationNTB.Text + "'", con);
                    int n;
                    n = cmd.ExecuteNonQuery();
                    if(n == 1)
                    {
                        confirmationLabel.Text = "Booking " + confirmationNTB.Text + " Cancelled";
                        confirmationLabel.Visible = true;
                    }
                }
            } 
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
