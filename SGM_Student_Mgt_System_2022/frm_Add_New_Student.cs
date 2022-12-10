using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SGM_Student_Mgt_System_2022
{
    public partial class frm_Add_New_Student : Form
    {
        public frm_Add_New_Student()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=SGM_Student_App_2022_DB;Integrated Security=True");

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


        int Auto_Incr()
        {
            int Cnt = 0;

            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(*) From Student_Details";

           
                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());
                if (Cnt > 0)
                {
                    Cmd.CommandText = "Select Max(Roll_NO)from Student_Details";
                    Cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;
                }
                else
                {
                    Cnt = 101;
                }
                Con_Close();
                return Cnt;
            }
        
        void Bind_ComboBox()
        {
            Con_Open();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "Select Distinct(Name)From tbl_Course";
            SqlDataReader Dr = Cmd.ExecuteReader();
            while (Dr.Read())
            {
                cmb_Course.Items.Add(Dr.GetString(Dr.GetOrdinal("Name")));
            }
            Con_Close();
        }
         void Clear_Controls()
        {
            txt_Roll_No.Text = Convert.ToString(Auto_Incr());
            txt_Name.Clear();
            txt_Mobile_No.Clear();
            cmb_Course.SelectedIndex = -1;
            dtp_DOB.Text = "16/06/2004";
        }
        private void frm_Add_New_Student_Load(object sender, EventArgs e)
        {
            Clear_Controls();
            txt_Roll_No.Focus();
            Bind_ComboBox();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
             Con_Open();

            if (txt_Roll_No.Text != "" && txt_Name.Text != "" && txt_Mobile_No.Text != "" && txt_Mobile_No.Text != "" && cmb_Course.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;

                Cmd.CommandText = "Insert Into SGM_Student_Details(Roll_No,Name,DOB,Mob_No,Course) values (@Roll_No,@Name,@DOB,@Mobile_No,@Course)";
                Cmd.Parameters.Add("Roll_No", SqlDbType.Int).Value = txt_Roll_No.Text;
                Cmd.Parameters.Add("Name", SqlDbType.VarChar).Value = txt_Name.Text;
                Cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_DOB.Value.Date;
                Cmd.Parameters.Add("Mobile_No", SqlDbType.Decimal).Value = txt_Mobile_No.Text;
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

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (Char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }

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

