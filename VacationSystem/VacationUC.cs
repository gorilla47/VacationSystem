using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Summary: This is the object for the vacation information to be displayed correctly in each row of the main screen
 */
namespace VacationSystem
{
    public partial class VacationUC : UserControl
    {
        public VacationUC()
        {
            InitializeComponent();
        }

        public string NameLabel
        {
            get { return nameLbl.Text; }
            set { nameLbl.Text = value; }
        }

        public string TagLabel
        {
            get { return tagLbl.Text; }
            set { tagLbl.Text = value; }
        }

        public string RankLabel
        {
            get { return rankLbl.Text; }
            set { rankLbl.Text = value; }
        }

        public string DescLabel
        {
            get { return descLbl.Text; }
            set { descLbl.Text = value; }
        }

        public string TypeLabel
        {
            get { return typeLbl.Text; }
            set { typeLbl.Text = value; }
        }

        public string ImageSource
        {
            get { return imageSourceLbl.Text; }
            set { imageSourceLbl.Text = value; }
        }

        //opens a new booking screen and passes relavent information to that screen
        private void bookButton_Click(object sender, EventArgs e)
        {
            this.ParentForm.Hide();

            Booking booking = new Booking();
            booking.VacationName = NameLabel;
            booking.PictureBoxImage = ImageSource;
            booking.Show();

        }
    }
}
