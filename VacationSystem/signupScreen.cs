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

/*
 * Summary The signup screen where a new user can be created and entered in the database
 */
namespace VacationSystem
{
    public partial class signupScreen : Form
    {
        public signupScreen()
        {
            InitializeComponent();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            //Checks to see if the username is already in the database or not. And then checks to make sure all fields are entered
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M4F8K4I;Initial Catalog=vacationdb;Integrated Security=TRUE");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM login WHERE username='" + usernameInput.Text + "'", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Username Already Taken");
            }
            else if (passwordInput.Text != confPasswordInput.Text)
            {
                MessageBox.Show("Passwords do not match");
            }
            else if (usernameInput.Text == "" || passwordInput.Text == "" || confPasswordInput.Text == "" || emailInput.Text == "")
            {
                MessageBox.Show("Please enter all fields");
            }
            else
            {
                //Hashs the password and querys the database to enter the username password and email
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO login VALUES(@username,@password,@email)", con);
                cmd.Parameters.AddWithValue("username", usernameInput.Text);
                cmd.Parameters.AddWithValue("password", Hash.HashPassword(passwordInput.Text));
                cmd.Parameters.AddWithValue("email", emailInput.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Success!");
                this.Hide();
                new LoginForm().Show();
            }
        }

        private void signupScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
