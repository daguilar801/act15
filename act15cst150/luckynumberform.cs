﻿using System;
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
    public partial class LuckyNumberForm : Form
    {
        public LuckyNumberForm()
        {
            InitializeComponent();
        }

        // method to update label to lucky number
        public void LuckynumbertoLabel(int luckynumber)
        {
            LuckyNumberLabel.Text = luckynumber.ToString();
        }

    }
}
