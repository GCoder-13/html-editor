﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            
            Window start = new Window(this);
            start.Show();
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
