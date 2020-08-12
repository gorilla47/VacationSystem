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
    public partial class LookUpBooking : Form
    {
        public LookUpBooking()
        {
            InitializeComponent();
        }

        /*
         * Summary looks up the booking by the user's option, confirmation number or email
         */
        private void submitButton_Click(object sender, EventArgs e)
        {
            if (termSearchBox.Text == "" || termTextbox.Text == "")
            {
                MessageBox.Show("All fields are required");
            }
            else
            {
                if(termSearchBox.Text == "Email")
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M4F8K4I;Initial Catalog=vacationdb;Integrated Security=TRUE");
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM bookings WHERE email='" + termTextbox.Text + "'", con);
                    DataTable ds = new DataTable();
                    sda.Fill(ds);

                    var bindingSource = new BindingSource();
                    bindingSource.DataSource = ds;
                    dataGridView.DataSource = bindingSource;                   
                    dataGridView.AutoResizeColumns();
                    bindingSource.ResetBindings(true);



                }
                else if(termSearchBox.Text == "Confirmation Number")
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M4F8K4I;Initial Catalog=vacationdb;Integrated Security=TRUE");
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM bookings WHERE email='" + termTextbox.Text + "'", con);
                    DataTable ds = new DataTable();
                    sda.Fill(ds);

                    var bindingSource = new BindingSource();
                    bindingSource.DataSource = ds;
                    dataGridView.DataSource = bindingSource;
                    dataGridView.AutoResizeColumns();
                    bindingSource.ResetBindings(true);
                }

            }
        }
        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            new LoginForm().Show();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            new CancelBooking().Show();
            this.Hide();
        }
    }
}
