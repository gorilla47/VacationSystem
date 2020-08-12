using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

/*
 * The booking form that the user submit information and books the vacation.
 */

namespace VacationSystem
{
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }

        public string PictureBoxImage
        {
            get { return pictureBox1.ImageLocation; }
            set { pictureBox1.ImageLocation = value; }
        }

        public string VacationName
        {
            get { return vacationNameLbl.Text; }
            set { vacationNameLbl.Text = value; }
        }

        private void Booking_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            //Sets the min date of the date time picker so past dates can't be chosen
            dateTimePicker.MinDate = DateTime.Now;
        }

        //Function that creates the random confirmation number
        public string RandomDigits()
        {
            var random = new Random();
            string s = "";
            for (int i = 0; i < 12; i++)
                s = String.Concat(s, random.Next(10).ToString());
            return s;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {   //Checks to make sure all fields are filled out
            if(firstNameTextBox.Text == "" ||
                middleNameTextBox.Text =="" ||
                lastNameTextBox.Text == "" ||
                addressBox.Text == "" ||
                cityBox.Text == "" ||
                stateComboBox.Text == "" ||
                zipTextBox.Text == "" ||
                emailTextBox.Text == "")
            {
                MessageBox.Show("All Fields Required");
            }
            else
            {   //Creates a random digit confirmation number
                string confirmationNumber = RandomDigits();

                //Sumbits the SQL query to the database
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M4F8K4I;Initial Catalog=vacationdb;Integrated Security=TRUE");
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO bookings VALUES(@firstname,@middlename,@lastname,@address,@city,@state,@zipcode,@email,@date,@confirmationnumber)", con);
                cmd.Parameters.AddWithValue("firstname", firstNameTextBox.Text);
                cmd.Parameters.AddWithValue("middlename", middleNameTextBox.Text);
                cmd.Parameters.AddWithValue("lastname", lastNameTextBox.Text);
                cmd.Parameters.AddWithValue("address", addressBox.Text);
                cmd.Parameters.AddWithValue("city", cityBox.Text);
                cmd.Parameters.AddWithValue("state", stateComboBox.Text);
                cmd.Parameters.AddWithValue("zipcode", zipTextBox.Text);
                cmd.Parameters.AddWithValue("date", dateTimePicker.Text);
                cmd.Parameters.AddWithValue("email", emailTextBox.Text);
                cmd.Parameters.AddWithValue("confirmationnumber", confirmationNumber);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Success! Confirmation Number is: " + confirmationNumber);

                //Closes the application once booking is completed
                Application.Exit();

            }
        }
    }
}
