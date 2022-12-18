namespace act15cst150
{
    partial class Form1
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
            this.SubmitButton = new System.Windows.Forms.Button();
            this.birthyearcombobox = new System.Windows.Forms.ComboBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.BirthYearLabel = new System.Windows.Forms.Label();
            this.birthmonthlabel = new System.Windows.Forms.Label();
            this.birthmonthcomboBox = new System.Windows.Forms.ComboBox();
            this.birthdaycomboBox = new System.Windows.Forms.ComboBox();
            this.birthdaylabel = new System.Windows.Forms.Label();
            this.FavoriteColorLabel = new System.Windows.Forms.Label();
            this.favoritecolorcombobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(263, 400);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(158, 36);
            this.SubmitButton.TabIndex = 0;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseMnemonic = false;
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // birthyearcombobox
            // 
            this.birthyearcombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.birthyearcombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthyearcombobox.FormattingEnabled = true;
            this.birthyearcombobox.Location = new System.Drawing.Point(305, 132);
            this.birthyearcombobox.Name = "birthyearcombobox";
            this.birthyearcombobox.Size = new System.Drawing.Size(287, 33);
            this.birthyearcombobox.TabIndex = 1;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(121, 22);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(469, 46);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "What\'s My Lucky Number";
            // 
            // BirthYearLabel
            // 
            this.BirthYearLabel.AutoSize = true;
            this.BirthYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthYearLabel.Location = new System.Drawing.Point(131, 135);
            this.BirthYearLabel.Name = "BirthYearLabel";
            this.BirthYearLabel.Size = new System.Drawing.Size(108, 25);
            this.BirthYearLabel.TabIndex = 3;
            this.BirthYearLabel.Text = "Birth Year";
            // 
            // birthmonthlabel
            // 
            this.birthmonthlabel.AutoSize = true;
            this.birthmonthlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthmonthlabel.Location = new System.Drawing.Point(131, 190);
            this.birthmonthlabel.Name = "birthmonthlabel";
            this.birthmonthlabel.Size = new System.Drawing.Size(122, 25);
            this.birthmonthlabel.TabIndex = 4;
            this.birthmonthlabel.Text = "Birth Month";
            // 
            // birthmonthcomboBox
            // 
            this.birthmonthcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.birthmonthcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthmonthcomboBox.FormattingEnabled = true;
            this.birthmonthcomboBox.Items.AddRange(new object[] {
            "January",
            "Feburay",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.birthmonthcomboBox.Location = new System.Drawing.Point(305, 187);
            this.birthmonthcomboBox.Name = "birthmonthcomboBox";
            this.birthmonthcomboBox.Size = new System.Drawing.Size(287, 33);
            this.birthmonthcomboBox.TabIndex = 5;
            this.birthmonthcomboBox.SelectedIndexChanged += new System.EventHandler(this.birthmonthcomboBox_SelectedIndexChanged);
            // 
            // birthdaycomboBox
            // 
            this.birthdaycomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.birthdaycomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdaycomboBox.FormattingEnabled = true;
            this.birthdaycomboBox.Location = new System.Drawing.Point(305, 242);
            this.birthdaycomboBox.Name = "birthdaycomboBox";
            this.birthdaycomboBox.Size = new System.Drawing.Size(287, 33);
            this.birthdaycomboBox.TabIndex = 6;
            // 
            // birthdaylabel
            // 
            this.birthdaylabel.AutoSize = true;
            this.birthdaylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdaylabel.Location = new System.Drawing.Point(131, 242);
            this.birthdaylabel.Name = "birthdaylabel";
            this.birthdaylabel.Size = new System.Drawing.Size(91, 25);
            this.birthdaylabel.TabIndex = 7;
            this.birthdaylabel.Text = "Birthday";
            // 
            // FavoriteColorLabel
            // 
            this.FavoriteColorLabel.AutoSize = true;
            this.FavoriteColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FavoriteColorLabel.Location = new System.Drawing.Point(131, 301);
            this.FavoriteColorLabel.Name = "FavoriteColorLabel";
            this.FavoriteColorLabel.Size = new System.Drawing.Size(147, 25);
            this.FavoriteColorLabel.TabIndex = 8;
            this.FavoriteColorLabel.Text = "Favorite Color";
            // 
            // favoritecolorcombobox
            // 
            this.favoritecolorcombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.favoritecolorcombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favoritecolorcombobox.FormattingEnabled = true;
            this.favoritecolorcombobox.Items.AddRange(new object[] {
            "Green",
            "Yellow",
            "Purple",
            "Orange",
            "Black",
            "Rainbow",
            "Red"});
            this.favoritecolorcombobox.Location = new System.Drawing.Point(305, 293);
            this.favoritecolorcombobox.Name = "favoritecolorcombobox";
            this.favoritecolorcombobox.Size = new System.Drawing.Size(287, 33);
            this.favoritecolorcombobox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(676, 531);
            this.Controls.Add(this.favoritecolorcombobox);
            this.Controls.Add(this.FavoriteColorLabel);
            this.Controls.Add(this.birthdaylabel);
            this.Controls.Add(this.birthdaycomboBox);
            this.Controls.Add(this.birthmonthcomboBox);
            this.Controls.Add(this.birthmonthlabel);
            this.Controls.Add(this.BirthYearLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.birthyearcombobox);
            this.Controls.Add(this.SubmitButton);
            this.Name = "Form1";
            this.Text = "Lucky Number Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.ComboBox birthyearcombobox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label BirthYearLabel;
        private System.Windows.Forms.Label birthmonthlabel;
        private System.Windows.Forms.ComboBox birthmonthcomboBox;
        private System.Windows.Forms.ComboBox birthdaycomboBox;
        private System.Windows.Forms.Label birthdaylabel;
        private System.Windows.Forms.Label FavoriteColorLabel;
        private System.Windows.Forms.ComboBox favoritecolorcombobox;
    }
}

