using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Student_Management_System
{
    public partial class frm_Add_New_Student : Form
    {
        public frm_Add_New_Student()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Student_Management_System_DB;Integrated Security=True");

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

     

        private void frm_Add_New_Student_Load(object sender, EventArgs e)
        {
            Clear_Controls();
            txt_Roll_Number.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con.Open();

            if (txt_Roll_Number.Text != "" && txt_Mobile_No.Text != "" && txt_Mobile_No.Text != "" && cmb_Course.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Insert into Student_Details (Roll_Number, Name ,DOB ,Mobile_No , Course) Values (@RNO,@Name,@DOB,@MobNo,@Course)";

                Cmd.Parameters.Add("RNO",SqlDbType.Int).Value = txt_Roll_Number.Text;
                Cmd.Parameters.Add("Name",SqlDbType.VarChar).Value = txt_Name.Text;
                Cmd.Parameters.Add("DOB",SqlDbType.Date).Value = dtp_DOB.Value.Date;
                Cmd.Parameters.Add("MobNo",SqlDbType.Decimal).Value = txt_Mobile_No.Text;
                Cmd.Parameters.Add("Course",SqlDbType.NVarChar).Value = cmb_Course.Text;


                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Saved");

                Clear_Controls();
                
            }
            else
            {
                MessageBox.Show("Fill All Fields");
            }
            Con.Close();
        }

        private void btn_View_Student_List_Click(object sender, EventArgs e)
        {
           frm_View_Student_List obj = new frm_View_Student_List();
            obj.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();
            obj.Show();
            this.Hide();
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (Char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if(!(Char.IsLetter(e.KeyChar)|| (e.KeyChar == (Char)Keys.Back)||(e.KeyChar ==(Char)Keys.Space)))
            {
                e.Handled = true;
            }
        }
        void Clear_Controls()
        {
            txt_Roll_Number.Text = "";
            txt_Name.Clear();
            txt_Mobile_No.Clear();
            cmb_Course.SelectedIndex = -1;
            dtp_DOB.Text = "16-06-2018";
            
            
        }
    }

   }

