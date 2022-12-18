namespace act15cst150
{
    partial class LuckyNumberForm
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
            this.LuckyNumberLabel = new System.Windows.Forms.Label();
            this.Form2LuckyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LuckyNumberLabel
            // 
            this.LuckyNumberLabel.AutoSize = true;
            this.LuckyNumberLabel.Font = new System.Drawing.Font("Mongolian Baiti", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LuckyNumberLabel.Location = new System.Drawing.Point(386, 189);
            this.LuckyNumberLabel.Name = "LuckyNumberLabel";
            this.LuckyNumberLabel.Size = new System.Drawing.Size(49, 69);
            this.LuckyNumberLabel.TabIndex = 0;
            this.LuckyNumberLabel.Text = "i";
            // 
            // Form2LuckyLabel
            // 
            this.Form2LuckyLabel.AutoSize = true;
            this.Form2LuckyLabel.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Form2LuckyLabel.Location = new System.Drawing.Point(208, 49);
            this.Form2LuckyLabel.Name = "Form2LuckyLabel";
            this.Form2LuckyLabel.Size = new System.Drawing.Size(427, 65);
            this.Form2LuckyLabel.TabIndex = 1;
            this.Form2LuckyLabel.Text = "Your Lucky Number";
            // 
            // LuckyNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Form2LuckyLabel);
            this.Controls.Add(this.LuckyNumberLabel);
            this.Name = "LuckyNumberForm";
            this.Text = "Lucky Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LuckyNumberLabel;
        private System.Windows.Forms.Label Form2LuckyLabel;
    }
}