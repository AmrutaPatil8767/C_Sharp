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
    public partial class frm_Update_Student_Details : Form
    {
        public frm_Update_Student_Details()
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
        void Clear_Controls()
        {
            txt_Roll_No.Text = "";
            txt_Name.Clear();
            txt_Mobile_No.Clear();
            cmb_Course.SelectedIndex = -1;
            dtp_DOB.Text = "16/06/2004";
        }
        void Enable_Controls()
        {
            txt_Roll_No.Enabled = false;
        }
        void Disable_Controls()
        {
            txt_Name.Enabled = false;
            txt_Mobile_No.Enabled = false;
            dtp_DOB.Enabled = false;
            cmb_Course.Enabled = false;
            txt_Roll_No.Enabled = true;
        }

        private void frm_Update_Student_Details_Load(object sender, EventArgs e)
        {
            txt_Roll_No.Focus();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();
            SqlCommand Cmd = new SqlCommand("Select * From Student_Details Where Roll_No = @RNo", Con);

            Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = txt_Roll_No.Text;

            SqlDataReader Dr = Cmd.ExecuteReader();

            if (Dr.Read())
            {
                txt_Name.Text = Dr.GetString(Dr.GetOrdinal("Name"));
                txt_Mobile_No.Text = (Dr["Moblie_No"].ToString());
                cmb_Course.Text = Dr.GetString(Dr.GetOrdinal("Course"));
                dtp_DOB.Text = (Dr["DOB"].ToString());

                Enable_Controls();

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
            Disable_Controls();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Close();
            if (txt_Name.Text != "" && txt_Mobile_No.Text != "" && cmb_Course.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandText = "Update Student_Details Set Name = @Nm, DOB = @date, Moblie_No = @MobNo,Course = @Crs Where Roll_No = @RNo";
                Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = txt_Roll_No.Text;
                Cmd.Parameters.Add("Name", SqlDbType.VarChar).Value = txt_Name.Text;
                Cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_DOB.Value.Date;
                Cmd.Parameters.Add("MobNo", SqlDbType.Decimal).Value = txt_Mobile_No.Text;
                Cmd.Parameters.Add("Crs", SqlDbType.NChar).Value = cmb_Course.Text;

                Cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");

                Clear_Controls();
                Disable_Controls();
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
            txt_Name.Enabled = true;
            txt_Mobile_No.Enabled = true;
            dtp_DOB.Enabled = true;
            cmb_Course.Enabled = true;
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
