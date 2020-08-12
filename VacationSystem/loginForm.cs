using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VacationSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void loginButton_Click(object sender, EventArgs e)
        {
            //Creates the SQL connection
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M4F8K4I;Initial Catalog=vacationdb;Integrated Security=TRUE");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT password FROM login WHERE username='" + usernameInput.Text + "'", con);
            DataTable dt = new DataTable();

            try
            {  
                sda.Fill(dt);
            }
            catch (System.IO.IOException ex)
            {
                MessageBox.Show("Invalid username or password");
            }

            //looks to see if the username was found and if it is compares the password entered to the hashed password in the database and shows the mainscreen
            if (dt.Rows.Count == 1)
            {
                if (Hash.Verify(passwordInput.Text, dt.Rows[0][0].ToString()) == true)
                {
                    this.Hide();
                    new mainScreen().Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                    usernameInput.Text = ("");
                    passwordInput.Text = ("");
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password");
                usernameInput.Text = ("");
                passwordInput.Text = ("");
            }
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new signupScreen().Show();
        }

        private void bookingButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LookUpBooking().Show();
        }
    }
}