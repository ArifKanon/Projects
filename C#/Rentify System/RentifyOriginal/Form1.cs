﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentifyOriginal
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            LoginControl lc = new LoginControl(this.MainPanel);
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(lc);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginControl lc = new LoginControl(this.MainPanel);
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(lc);
        }
    }
}