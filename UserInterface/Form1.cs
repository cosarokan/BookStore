﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTypeProcess_Click(object sender, EventArgs e)
        {
            FrmTypeProcess frmTypeProcess = new FrmTypeProcess();
            frmTypeProcess.Show();
        }
    }
}
