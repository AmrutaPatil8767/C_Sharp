using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SGM_Student_Mgt_Syst_2022
{
    public partial class Frm_View_Student_List : Form
    {
        public Frm_View_Student_List()
        {
            InitializeComponent();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Frm_Login_Form obj = new Frm_Login_Form();
            obj.Show();
            this.Hide();
        }

        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            Frm_Add_New_Student obj = new Frm_Add_New_Student();
            obj.Show();
            this.Hide();
        }

        private void Frm_View_Student_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sGM_Student_Mgt_Syst_Details_DBDataSet2.SGM_Mgt_Syst_Details' table. You can move, or remove it, as needed.
            this.sGM_Mgt_Syst_DetailsTableAdapter1.Fill(this.sGM_Student_Mgt_Syst_Details_DBDataSet2.SGM_Mgt_Syst_Details);

        }


    }
}
