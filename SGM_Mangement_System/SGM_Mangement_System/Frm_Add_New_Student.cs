using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SGM_Mangement_System
{
    public partial class Frm_Add_New_Student : Form
    {
        public Frm_Add_New_Student()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=SGM_Student_Details_DB;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }
        void Con_Close()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (Char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        int Auto_Incr()
        {
            int Cnt = 0;

            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count (*) From SGM_Student_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());
            if (Cnt > 0)
            {
                Cmd.CommandText = "Select Max(Roll_No)From SGM_Student_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;
            }
            else
            {
                Cnt = 101;
            }
            Con_Close();

            return Cnt;
        }
        void Clear_Controls()
        {
            txt_Roll_No.Text = Convert.ToString(Auto_Incr());

            txt_Name.Clear();
            txt_Mob_No.Clear();
            cmb_Course.SelectedIndex = -1;
        }

        private void Frm_Add_New_Student_Load(object sender, EventArgs e)
        {
            Clear_Controls();
            txt_Roll_No.Focus();

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (txt_Roll_No.Text != "" && txt_Name.Text != "" && txt_Mob_No.Text != "" && txt_Mob_No.TextLength == 10 && cmb_Course.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;

                Cmd.CommandText = "Insert Into SGM_Student_Details(Roll_No,Name,DOB,Mob_No,Course) values (@RNo,@Nm,@DOB,@MNo,@Course)";
                Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = txt_Roll_No.Text;
                Cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = txt_Name.Text;
                Cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_DOB.Value.Date;
                Cmd.Parameters.Add("MNo", SqlDbType.Decimal).Value = txt_Mob_No.Text;
                Cmd.Parameters.Add("Course", SqlDbType.NChar).Value = cmb_Course.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Saved");

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("First Fill All Fields Compulsary");
            }
            Con_Close();
        }

        private void btn_View_Student_List_Click(object sender, EventArgs e)
        {
            Frm_View_All_Student_List obj = new Frm_View_All_Student_List();
            obj.Show();
            this.Hide();
        }

        private void btn_Search_Student_Details_Click(object sender, EventArgs e)
        {
            Frm_Search_Student_Details obj = new Frm_Search_Student_Details();
            obj.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are  You Sure Want To Logout???","Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            frm_Login_Form obj = new frm_Login_Form();
            obj.Show();
            this.Hide();
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (Char)Keys.Back) || (e.KeyChar == (Char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

       
        }
    }


