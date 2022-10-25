using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SGM_Mangement_System
{
    public partial class Frm_Search_Student_Details : Form
    {
        public Frm_Search_Student_Details()
        {
            InitializeComponent();
        }

        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            Frm_Add_New_Student obj = new Frm_Add_New_Student();
            obj.Show();
            this.Hide();
        }

        private void btn_View_Student_List_Click(object sender, EventArgs e)
        {
            Frm_View_All_Student_List obj = new Frm_View_All_Student_List();
            obj.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are  You Want to Logout???", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Res == DialogResult.Yes)
            {
                frm_Login_Form obj = new frm_Login_Form();
                obj.Show();
                this.Hide();
            }
        }

    }
}
    

