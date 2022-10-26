using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SGM_Student_Mgt_Syst_2022
{
    public partial class Frm_Search_Student_Details : Form
    {
        public Frm_Search_Student_Details()
        {
            InitializeComponent();
        }


        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=SGM_Student_Mgt_Syst_Details_DB;Integrated Security=True");
        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }
        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }
             void Clear_Controls()
         {
            txt_Roll_No.Text = "";
            txt_Name.Clear();
            txt_Mob_No.Clear();
            cmb_Course.SelectedIndex = -1;
            dtp_DOB.Text = "16/06/2004";
        }

        private void Frm_Search_Student_Details_Load(object sender, EventArgs e)
        {
            lbl_Welcome.Text = Shared_Class.Username;
            txt_Roll_No.Focus();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();
            SqlCommand Cmd = new SqlCommand("Select * From SGM_Mgt_Syst_Details Where RNo = @RNo",Con);

            Cmd.Parameters.Add("RNo",SqlDbType.Int).Value = txt_Roll_No.Text;

            SqlDataReader Dr = Cmd.ExecuteReader();

            if(Dr.Read())
            {
                txt_Name.Text = Dr.GetString(Dr.GetOrdinal("Nm"));
                txt_Mob_No.Text = (Dr["MNo"].ToString());
                cmb_Course.Text = Dr.GetString(Dr.GetOrdinal("Course"));
                dtp_DOB.Text = (Dr["DOB"].ToString());

                txt_Name.Enabled = true;
                txt_Mob_No.Enabled = true;
                dtp_DOB.Enabled = true;
                cmb_Course.Enabled = true;
            }
            else
            {
                MessageBox.Show("No Record Found", "Invalid Roll No");
                txt_Roll_No.Clear();
            }
            Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            Frm_Add_New_Student obj = new Frm_Add_New_Student();
            obj.Show();
            this.Hide();

        }

        private void btn_View_Student_Details_Click(object sender, EventArgs e)
        {
            Frm_View_Student_List obj = new Frm_View_Student_List();
            obj.Show();
            this.Hide();

        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
        
            DialogResult Res = MessageBox.Show("Are  You Sure Want To Logout???","Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
             Frm_Login_Form obj = new Frm_Login_Form();
            obj.Show();
            this.Hide();
        }

        

       

    



        }
    }

