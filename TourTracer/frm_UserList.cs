﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourTracer
{
    public partial class frm_UserList : Form
    {
        public frm_UserList()
        {
            InitializeComponent();
        }

        private void btn_GeriDön_Click(object sender, EventArgs e)
        {
            new frm_CustomerMainPage().Show();
            this.Hide();
        }
    }
}
