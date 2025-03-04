﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if ((txt_Username.Text == "Admin") && (txt_Password.Text == "A123"))
            {
                MessageBox.Show("Login Successful", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_Add_New_Student obj = new frm_Add_New_Student();
                obj.Show();
                this.Hide();
            }
            else
            {
                lbl_Error.Text = "Invalid Username or Password";
                lbl_Error.ForeColor = Color.OrangeRed;
            }
            txt_Username.Clear();
            txt_Password.Clear();
            txt_Password.Enabled = false;
            btn_Submit.Enabled = false;

            txt_Username.Focus();
        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {
            lbl_Error.Visible = true;
            txt_Password.Enabled =true;
        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;
        }

       }

       
    }

