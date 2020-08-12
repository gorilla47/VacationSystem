namespace VacationSystem
{
    partial class VacationUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameLbl = new System.Windows.Forms.Label();
            this.rankLbl = new System.Windows.Forms.Label();
            this.descLbl = new System.Windows.Forms.Label();
            this.bookButton = new System.Windows.Forms.Button();
            this.tagLbl = new System.Windows.Forms.Label();
            this.typeLbl = new System.Windows.Forms.Label();
            this.imageSourceLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLbl
            // 
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(4, 4);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(409, 37);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "label1";
            // 
            // rankLbl
            // 
            this.rankLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rankLbl.AutoSize = true;
            this.rankLbl.Location = new System.Drawing.Point(452, 41);
            this.rankLbl.Name = "rankLbl";
            this.rankLbl.Size = new System.Drawing.Size(35, 13);
            this.rankLbl.TabIndex = 1;
            this.rankLbl.Text = "label1";
            // 
            // descLbl
            // 
            this.descLbl.Location = new System.Drawing.Point(8, 41);
            this.descLbl.Name = "descLbl";
            this.descLbl.Size = new System.Drawing.Size(360, 28);
            this.descLbl.TabIndex = 2;
            this.descLbl.Text = "label1";
            // 
            // bookButton
            // 
            this.bookButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bookButton.Location = new System.Drawing.Point(398, 269);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(75, 23);
            this.bookButton.TabIndex = 3;
            this.bookButton.Text = "Book Now!";
            this.bookButton.UseVisualStyleBackColor = true;
            this.bookButton.Click += new System.EventHandler(this.bookButton_Click);
            // 
            // tagLbl
            // 
            this.tagLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tagLbl.AutoSize = true;
            this.tagLbl.Location = new System.Drawing.Point(8, 92);
            this.tagLbl.Name = "tagLbl";
            this.tagLbl.Size = new System.Drawing.Size(35, 13);
            this.tagLbl.TabIndex = 4;
            this.tagLbl.Text = "label1";
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Location = new System.Drawing.Point(8, 69);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(35, 13);
            this.typeLbl.TabIndex = 5;
            this.typeLbl.Text = "label1";
            // 
            // imageSourceLbl
            // 
            this.imageSourceLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.imageSourceLbl.Location = new System.Drawing.Point(11, 269);
            this.imageSourceLbl.Name = "imageSourceLbl";
            this.imageSourceLbl.Size = new System.Drawing.Size(381, 23);
            this.imageSourceLbl.TabIndex = 4;
            this.imageSourceLbl.Text = "label1";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Image Source";
            // 
            // VacationUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.typeLbl);
            this.Controls.Add(this.imageSourceLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tagLbl);
            this.Controls.Add(this.bookButton);
            this.Controls.Add(this.descLbl);
            this.Controls.Add(this.rankLbl);
            this.Controls.Add(this.nameLbl);
            this.Name = "VacationUC";
            this.Size = new System.Drawing.Size(490, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label rankLbl;
        private System.Windows.Forms.Label descLbl;
        private System.Windows.Forms.Button bookButton;
        private System.Windows.Forms.Label tagLbl;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.Label imageSourceLbl;
        private System.Windows.Forms.Label label2;
    }
}
