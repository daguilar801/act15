using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace act15cst150
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();

        int luckynumber;

        // lucky number calculation
        public int CalculateLuckyNumber()
        {
            int luckycomponentyear = birthyearcombobox.SelectedIndex;
            int luckycomponentmonth = birthmonthcomboBox.SelectedIndex + 1;
            int luckycomponentday = birthdaycomboBox.SelectedIndex + 1;
            int luckycomponentcolor = favoritecolorcombobox.SelectedIndex * 2;

            luckynumber = luckycomponentyear + luckycomponentmonth + luckycomponentday + luckycomponentcolor * random.Next(25,50);

            return luckynumber;
        }

        // adds years to combobox years on load
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int x = 1915; x < 2023; x++) {birthyearcombobox.Items.Add(x); }
        }

        private void birthmonthcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // clears the current birth days to select from when month is changed
            birthdaycomboBox.Items.Clear();

            // grabs teh month and year selected and converts it a usable format
            int month = Convert.ToInt32(birthmonthcomboBox.SelectedIndex);
            int days = 0;
            // here we are taking the index of the year, since the index starts at zero we are adding the starting number 1915 to all values to give the proper year
            int year = Convert.ToInt32(birthyearcombobox.SelectedIndex);
            year = year + 1915;

            // using index of month selected to calculate the appropriate number of days.
            if (month == 0) { days = 32; };
            if (month == 1) { days = 29; };
            if (month == 2) { days = 32; };
            if (month == 3) { days = 31; };
            if (month == 4) { days = 32; };
            if (month == 5) { days = 31; };
            if (month == 6) { days = 32; };
            if (month == 7) { days = 32; };
            if (month == 8) { days = 31; };
            if (month == 9) { days = 32; };
            if (month == 10) { days = 31; };
            if (month == 11) { days = 32; };

            // accounting for leap years
            if (month == 1 && year % 4 == 0 && year % 100 != 0) { days = 30; }

            // for loop to display number of days
            for (int i = 1; i < days; i++) { birthdaycomboBox.Items.Add(i); }
        }

        // on button click grabs lucky number pops up second form
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalculateLuckyNumber();
            LuckyNumberForm luckyform = new LuckyNumberForm();
            luckyform.LuckynumbertoLabel(luckynumber);
            luckyform.Show();
        }
    }
}
