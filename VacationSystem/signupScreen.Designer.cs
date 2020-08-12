namespace VacationSystem
{
    partial class signupScreen
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
            this.signupButton = new System.Windows.Forms.Button();
            this.usernameLB = new System.Windows.Forms.Label();
            this.confPasswordLB = new System.Windows.Forms.Label();
            this.passwordLB = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.confPasswordInput = new System.Windows.Forms.TextBox();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // signupButton
            // 
            this.signupButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.signupButton.Location = new System.Drawing.Point(366, 272);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(75, 23);
            this.signupButton.TabIndex = 0;
            this.signupButton.Text = "Sign Up";
            this.signupButton.UseVisualStyleBackColor = true;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // usernameLB
            // 
            this.usernameLB.AutoSize = true;
            this.usernameLB.Location = new System.Drawing.Point(277, 181);
            this.usernameLB.Name = "usernameLB";
            this.usernameLB.Size = new System.Drawing.Size(58, 13);
            this.usernameLB.TabIndex = 1;
            this.usernameLB.Text = "Username:";
            // 
            // confPasswordLB
            // 
            this.confPasswordLB.AutoSize = true;
            this.confPasswordLB.Location = new System.Drawing.Point(241, 226);
            this.confPasswordLB.Name = "confPasswordLB";
            this.confPasswordLB.Size = new System.Drawing.Size(94, 13);
            this.confPasswordLB.TabIndex = 2;
            this.confPasswordLB.Text = "Confirm Password:";
            // 
            // passwordLB
            // 
            this.passwordLB.AutoSize = true;
            this.passwordLB.Location = new System.Drawing.Point(277, 204);
            this.passwordLB.Name = "passwordLB";
            this.passwordLB.Size = new System.Drawing.Size(56, 13);
            this.passwordLB.TabIndex = 3;
            this.passwordLB.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email:";
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(354, 178);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(100, 20);
            this.usernameInput.TabIndex = 5;
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(354, 201);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(100, 20);
            this.passwordInput.TabIndex = 6;
            // 
            // confPasswordInput
            // 
            this.confPasswordInput.Location = new System.Drawing.Point(354, 223);
            this.confPasswordInput.Name = "confPasswordInput";
            this.confPasswordInput.Size = new System.Drawing.Size(100, 20);
            this.confPasswordInput.TabIndex = 6;
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(354, 246);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(100, 20);
            this.emailInput.TabIndex = 6;
            // 
            // signupScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.confPasswordInput);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordLB);
            this.Controls.Add(this.confPasswordLB);
            this.Controls.Add(this.usernameLB);
            this.Controls.Add(this.signupButton);
            this.Name = "signupScreen";
            this.Text = "Signup Screen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.signupScreen_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.Label usernameLB;
        private System.Windows.Forms.Label confPasswordLB;
        private System.Windows.Forms.Label passwordLB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.TextBox confPasswordInput;
        private System.Windows.Forms.TextBox emailInput;
    }
}