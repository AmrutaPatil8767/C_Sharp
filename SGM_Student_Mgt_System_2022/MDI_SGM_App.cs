using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SGM_Student_Mgt_System_2022
{
    public partial class MDI_SGM_App : Form
    {
        public MDI_SGM_App()
        {
            InitializeComponent();
        }

        private void MDI_SGM_App_Load(object sender, EventArgs e)
        {

            lbl_UName.Text = "Welcome " + Shared_Class.Username;

            if (Shared_Class.Username != "Admin")
            {
                courseToolStripMenuItem.Visible = false;
                userManagementToolStripMenuItem.Visible = false;
                addCourseToolStripMenuItem.Visible = false;

            }
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student obj = new frm_Add_New_Student();
            obj.MdiParent = this;

            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void updateStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Update_Student_Details obj = new frm_Update_Student_Details();
            obj.MdiParent = this;
            obj.Show();
            obj.WindowState = FormWindowState.Maximized;
            //obj.FormBoarderStyle = System.Windows.Forms.FormBorderStyle.None;
            //obj.Text = String.Empty; 
        }

        private void searchSingleStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Search_Student obj = new frm_Search_Student();
            obj.MdiParent = this;
            obj.Show();
            obj.WindowState = FormWindowState.Maximized;
        }

        private void viewAllStudentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_View_All_Students_List obj = new frm_View_All_Students_List();
            obj.MdiParent = this;
            obj.Show();
            obj.WindowState = FormWindowState.Maximized;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Text = String.Empty;
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SGM_Student_Mgt_System_2022.frm_Add_New_Course obj = new SGM_Student_Mgt_System_2022.frm_Add_New_Course();
            obj.MdiParent = this;
            obj.Show();

        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad.exe");
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure You Want To Logout??", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Res == DialogResult.Yes)
            {
                frm_Login obj = new frm_Login();
                obj.Show();
                this.Hide();
            }
        }
    }
}



      
        

        

       

      
    