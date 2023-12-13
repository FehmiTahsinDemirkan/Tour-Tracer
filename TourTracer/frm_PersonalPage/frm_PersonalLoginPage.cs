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
    public partial class frm_PersonalLoginPage : Form
    {
        public frm_PersonalLoginPage()
        {
            InitializeComponent();
        }

        private void frm_PersonalPage_Load(object sender, EventArgs e)
        {

        }

        private void checkbox_SifreyiGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_SifreyiGoster.Checked)
            {
                txt_PersoMail.PasswordChar = '\0';
                txt_PersoPassword.PasswordChar = '\0';

            }
            else
            {

                txt_PersoPassword.PasswordChar = '•';

            }
        }

        private void btn_GirisYap_Click(object sender, EventArgs e)
        {
            new frm_PersonalControlPage().Show();
            this.Hide();
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            txt_PersoMail.Text = "";
            txt_PersoPassword.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frm_BaslangicEkrani().Show();
            this.Hide();
        }
    }
}
