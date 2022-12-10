using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace My_Controls
{
    public partial class frm_My_Controls : Form
    {
        public frm_My_Controls()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string Output = "";

            if (txt_Student_Name.Text != "" && (rbtn_Male.Checked == true) || (rbtn_Female.Checked == true) && (rbtn_Morning.Checked == true || rbtn_Afternoon.Checked == true || rbtn_Evening.Checked)) ;
            {
                lbl_Error1.Visible = false;
                lbl_Error2.Visible = false;
                lbl_Error3.Visible = false;
            }
            if (txt_Student_Name.Text != "")
            {
                if (rbtn_Female.Checked == true)
                {
                    Output = txt_Student_Name.Text + " is " + rbtn_Female.Text + ", ";
                }
                else if (rbtn_Male.Checked == true)
                {
                    Output = txt_Student_Name.Text + " is " + rbtn_Male.Text + " , ";
                }
                else
                {
                    lbl_Error2.Text = "Select Gender";
                    lbl_Error2.Visible = true;
                }
            }
            else
            {
                lbl_Error1.Text = "Fill Student Name";
                lbl_Error1.Visible = true;
            }
            if (rbtn_Morning.Checked == true)
            {
                Output += "wants batch time at " + rbtn_Morning.Text + " , ";
            }
            else if (rbtn_Afternoon.Checked == true)
            {
                Output += "wants batch time at " + rbtn_Afternoon.Text + " , ";
            }
            else if (rbtn_Evening.Checked == true)
            {
                Output += "wants  batch time at " + rbtn_Evening.Text + " , ";
            }
            else
            {
                lbl_Error3.Text = "Select Prefered Batch Time";
                lbl_Error3.Visible = true;
            }
            txt_Output.Text = Output;
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            string Prog = txt_Student_Name.Text + "Knows";

            if (chb_C.Checked == true)
            {
                if (chb_CPP.Checked == false && chb_Dotnet.Checked == false && chb_Java.Checked == false)
                {
                    Prog += " " + chb_C.Text + " , ";
                }
                else
                {
                    Prog += " , " + chb_C.Text + " , ";
                }
            }
            if (chb_CPP.Checked == true)
            {
                if (chb_Dotnet.Checked == false && chb_Java.Checked == false)
                {
                    Prog += " " + chb_CPP.Text + " , ";
                }
                else
                {
                    Prog += " , " + chb_CPP.Text + " , ";
                }
            }
            if (chb_Java.Checked == true)
            {
                Prog += " " + chb_Java.Text + " , ";
            }
            if (chb_C.Checked == false && chb_CPP.Checked == false && chb_Dotnet.Checked == false && chb_Java.Checked == false)
            {
                Prog += txt_Student_Name.Text + " Donot Have Knowledge Of Any Programming Skills";
            }
            if (rbtn_Female.Checked == true)
            {
                Prog += "And She Wants To be";
            }
            else if (rbtn_Male.Checked == true)
            {
                Prog += "And He Wants To be";
            }
            else
            {
                Prog += "Wants To be";
            }
            for (int i = 0; i <= (chlb_Choices.Items.Count - 1); i++)
            {
                if (chlb_Choices.GetItemChecked(i))
                {
                    Prog += " " + chlb_Choices.Items[i].ToString();
                }
            }
            txt_Show_Technical_Skills.Text = Prog;

        }
    }
}
         
        

      
    