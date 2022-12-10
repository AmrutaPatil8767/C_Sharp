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
    public partial class frm_Login : Form
    {
        public frm_Login()
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

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            int Cnt = 0;
            Con_Open();

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "select count(*) From Login_Details Where Uname = @Uname And Pwd= @Pwd";
            Cmd.Parameters.Add("Uname", SqlDbType.NVarChar).Value = txt_Username.Text;
            Cmd.Parameters.Add("Pwd", SqlDbType.NVarChar).Value = txt_Password.Text;

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (Cnt > 0)
            {
                MessageBox.Show("Login Successful", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Shared_Class.Username = txt_Username.Text;
                MDI_SGM_App obj = new MDI_SGM_App();
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

            txt_Username.Focus();

            Con_Close();
        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {
            lbl_Error.Visible = true;
            txt_Password.Enabled = true;
        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;
        }

       

      
    }
}
