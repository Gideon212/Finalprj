﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finalprj
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void panel_main_DoubleClick(object sender, EventArgs e)
        {
            myForm.Report child = new myForm.Report();
            AllUser.OpenChildForm(child, panel_main);
        }
    }
}
