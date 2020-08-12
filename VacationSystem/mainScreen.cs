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
using System.Net;
using System.IO;
using System.Drawing.Imaging;
using System.Security.Cryptography;

namespace VacationSystem
{
    public partial class mainScreen : Form
    {
        public mainScreen()
        {
            InitializeComponent();
        }

        //Gets all vacations from the database and lays them out using a tablepanellayout, usercontrol and a panel.
        private void mainScreen_Load(object sender, EventArgs e)
        {
            //Creates a SQL connection
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M4F8K4I;Initial Catalog=vacationdb;Integrated Security=TRUE");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM vacations", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            int X = 0;
            int Y = 0;
            int i = 0;
            foreach (DataRow row in dt.Rows)
            {

                Panel pnl = new Panel();
                pnl.SuspendLayout();
                pnl.Location = new Point(X, Y);
                pnl.Name = "pnl" + i;
                pnl.Size = new Size(200, 57);
                pnl.AutoSize = true;
                pnl.Dock = DockStyle.Fill;
                pnl.BorderStyle = BorderStyle.FixedSingle;

                //Creates new usercontrol for each vacation
                VacationUC uc = new VacationUC();
                uc.NameLabel = dt.Rows[i][0].ToString();
                uc.RankLabel = dt.Rows[i][4].ToString();
                uc.TagLabel = dt.Rows[i][3].ToString();
                uc.DescLabel = dt.Rows[i][5].ToString();
                uc.TypeLabel = dt.Rows[i][1].ToString();
                uc.ImageSource = dt.Rows[i][2].ToString();

                //Creates the picture box that is in the first column of the tablelayoutpanel
                PictureBox pictureBox = new PictureBox();
                pictureBox.Name = "pictureBox" + i;
                pictureBox.Size = new Size(300, 300);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.LoadAsync(dt.Rows[i][2].ToString());

                //adds the uc to the panel
                pnl.Controls.Add(uc);

                pnl.ResumeLayout(false);

                //adds the panel and picture box to the tablelayoutpanel
                tableLayoutPanel1.Controls.Add(pnl, 1, i);
                tableLayoutPanel1.Controls.Add(pictureBox, 0, i);

                i++;
            }
        }

        private void mainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
