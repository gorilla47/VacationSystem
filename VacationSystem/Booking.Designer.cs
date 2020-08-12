namespace VacationSystem
{
    partial class Booking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.submitButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.middleNameLbl = new System.Windows.Forms.Label();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.addressLbl = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.cityLbl = new System.Windows.Forms.Label();
            this.stateLbl = new System.Windows.Forms.Label();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.zipLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vacationNameLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(713, 415);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(12, 25);
            this.dateTimePicker.MinDate = new System.DateTime(2020, 7, 19, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a Vacation Start Date";
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Location = new System.Drawing.Point(12, 65);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(60, 13);
            this.firstNameLbl.TabIndex = 3;
            this.firstNameLbl.Text = "First Name:";
            // 
            // middleNameLbl
            // 
            this.middleNameLbl.AutoSize = true;
            this.middleNameLbl.Location = new System.Drawing.Point(-2, 94);
            this.middleNameLbl.Name = "middleNameLbl";
            this.middleNameLbl.Size = new System.Drawing.Size(75, 13);
            this.middleNameLbl.TabIndex = 4;
            this.middleNameLbl.Text = "Middle Name: ";
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Location = new System.Drawing.Point(8, 120);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(64, 13);
            this.lastNameLbl.TabIndex = 5;
            this.lastNameLbl.Text = "Last Name: ";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(79, 65);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 6;
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Location = new System.Drawing.Point(79, 91);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.middleNameTextBox.TabIndex = 6;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(79, 120);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Location = new System.Drawing.Point(21, 153);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(51, 13);
            this.addressLbl.TabIndex = 7;
            this.addressLbl.Text = "Address: ";
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(79, 146);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(100, 20);
            this.addressBox.TabIndex = 6;
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(79, 172);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(100, 20);
            this.cityBox.TabIndex = 6;
            // 
            // stateComboBox
            // 
            this.stateComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.stateComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Items.AddRange(new object[] {
            "ALABAMA",
            "ALASKA",
            "ARIZONA",
            "ARKANSAS",
            "CALIFORNIA",
            "COLORADO",
            "CONNECTICUT",
            "DELAWARE",
            "D.C.",
            "FLORIDA",
            "GEORGIA",
            "HAWAII",
            "IDAHO",
            "ILLINOIS",
            "INDIANA",
            "IOWA",
            "KANSAS",
            "KENTUCKY",
            "LOUISIANA",
            "MAINE",
            "MARYLAND",
            "MASSACHUSETTS",
            "MICHIGAN",
            "MINNESOTA",
            "MISSISSIPPI",
            "MISSOURI",
            "MONTANA",
            "NEBRASKA",
            "NEVADA",
            "NEW HAMPSHIRE",
            "NEW JERSEY",
            "NEW MEXICO",
            "NEW YORK",
            "NORTH CAROLINA",
            "NORTH DAKOTA",
            "OHIO",
            "OKLAHOMA",
            "OREGON",
            "PENNSYLVANIA",
            "RHODE ISLAND",
            "SOUTH CAROLINA",
            "SOUTH DAKOTA",
            "TENNESSEE",
            "TEXAS",
            "UTAH",
            "VERMONT",
            "VIRGINIA",
            "WASHINGTON",
            "WEST VIRGINIA",
            "WISCONSIN",
            "WYOMING"});
            this.stateComboBox.Location = new System.Drawing.Point(79, 199);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(100, 21);
            this.stateComboBox.TabIndex = 8;
            // 
            // cityLbl
            // 
            this.cityLbl.AutoSize = true;
            this.cityLbl.Location = new System.Drawing.Point(42, 175);
            this.cityLbl.Name = "cityLbl";
            this.cityLbl.Size = new System.Drawing.Size(30, 13);
            this.cityLbl.TabIndex = 7;
            this.cityLbl.Text = "City: ";
            // 
            // stateLbl
            // 
            this.stateLbl.AutoSize = true;
            this.stateLbl.Location = new System.Drawing.Point(34, 202);
            this.stateLbl.Name = "stateLbl";
            this.stateLbl.Size = new System.Drawing.Size(38, 13);
            this.stateLbl.TabIndex = 7;
            this.stateLbl.Text = "State: ";
            // 
            // zipTextBox
            // 
            this.zipTextBox.Location = new System.Drawing.Point(79, 226);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(100, 20);
            this.zipTextBox.TabIndex = 6;
            // 
            // zipLbl
            // 
            this.zipLbl.AutoSize = true;
            this.zipLbl.Location = new System.Drawing.Point(17, 229);
            this.zipLbl.Name = "zipLbl";
            this.zipLbl.Size = new System.Drawing.Size(56, 13);
            this.zipLbl.TabIndex = 7;
            this.zipLbl.Text = "Zip Code: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(488, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // vacationNameLbl
            // 
            this.vacationNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vacationNameLbl.Location = new System.Drawing.Point(488, 319);
            this.vacationNameLbl.Name = "vacationNameLbl";
            this.vacationNameLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.vacationNameLbl.Size = new System.Drawing.Size(300, 47);
            this.vacationNameLbl.TabIndex = 10;
            this.vacationNameLbl.Text = "vacation";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(35, 255);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(38, 13);
            this.emailLbl.TabIndex = 11;
            this.emailLbl.Text = "Email: ";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(79, 252);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 6;
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.vacationNameLbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.zipLbl);
            this.Controls.Add(this.stateLbl);
            this.Controls.Add(this.cityLbl);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.addressLbl);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.middleNameLbl);
            this.Controls.Add(this.firstNameLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.submitButton);
            this.Name = "Booking";
            this.Text = "Booking";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Booking_FormClosed);
            this.Load += new System.EventHandler(this.Booking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.Label middleNameLbl;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.Label cityLbl;
        private System.Windows.Forms.Label stateLbl;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.Label zipLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label vacationNameLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.TextBox emailTextBox;
    }
}