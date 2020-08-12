namespace VacationSystem
{
    partial class CancelBooking
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.confirmationNTB = new System.Windows.Forms.TextBox();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.confirmationLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Confirmation Number: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Email: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Enter Last Name: ";
            // 
            // confirmationNTB
            // 
            this.confirmationNTB.Location = new System.Drawing.Point(157, 44);
            this.confirmationNTB.Name = "confirmationNTB";
            this.confirmationNTB.Size = new System.Drawing.Size(152, 20);
            this.confirmationNTB.TabIndex = 2;
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(157, 76);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(152, 20);
            this.emailTextbox.TabIndex = 2;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(157, 109);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(152, 20);
            this.lastNameTextBox.TabIndex = 2;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(153, 135);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // confirmationLabel
            // 
            this.confirmationLabel.AutoSize = true;
            this.confirmationLabel.Location = new System.Drawing.Point(12, 207);
            this.confirmationLabel.Name = "confirmationLabel";
            this.confirmationLabel.Size = new System.Drawing.Size(35, 13);
            this.confirmationLabel.TabIndex = 4;
            this.confirmationLabel.Text = "label4";
            this.confirmationLabel.Visible = false;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(234, 135);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Exit";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // CancelBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 229);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.confirmationLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.confirmationNTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CancelBooking";
            this.Text = "Cancel Booking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox confirmationNTB;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label confirmationLabel;
        private System.Windows.Forms.Button closeButton;
    }
}