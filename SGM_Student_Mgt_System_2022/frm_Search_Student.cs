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
    public partial class frm_Search_Student : Form
    {
        public frm_Search_Student()
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

        private void frm_Search_Student_Load(object sender, EventArgs e)
        {
            txt_Roll_No.Focus();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();
            SqlCommand Cmd = new SqlCommand("Select * From Student_Details Where Roll_No = @RNo",Con);
                      
            Cmd.Parameters.Add("RNo",SqlDbType.Int).Value = txt_Roll_No.Text;

            SqlDataReader Dr = Cmd.ExecuteReader();

            if(Dr.Read())
            {
                txt_Name.Text = Dr.GetString(Dr.GetOrdinal("Name"));
                txt_Mobile_No.Text = (Dr["Moblie_No"].ToString());
                cmb_Course.Text = Dr.GetString(Dr.GetOrdinal("Course"));
                dtp_DOB.Text = (Dr["DOB"].ToString());

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

