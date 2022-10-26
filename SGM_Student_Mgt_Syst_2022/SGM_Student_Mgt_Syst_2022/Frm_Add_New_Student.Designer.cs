namespace SGM_Student_Mgt_Syst_2022
{
    partial class Frm_Add_New_Student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Add_New_Student));
            this.lbl_Add_New_Student = new System.Windows.Forms.Label();
            this.lbl_Roll_No = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_Mob_No = new System.Windows.Forms.Label();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.txt_Roll_No = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.txt_Mob_No = new System.Windows.Forms.TextBox();
            this.cmb_Course = new System.Windows.Forms.ComboBox();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Search_Student_Details = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_View_Student_List = new System.Windows.Forms.Button();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Add_New_Student
            // 
            this.lbl_Add_New_Student.AutoSize = true;
            this.lbl_Add_New_Student.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_Add_New_Student.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_New_Student.ForeColor = System.Drawing.Color.White;
            this.lbl_Add_New_Student.Location = new System.Drawing.Point(224, 40);
            this.lbl_Add_New_Student.Name = "lbl_Add_New_Student";
            this.lbl_Add_New_Student.Size = new System.Drawing.Size(464, 73);
            this.lbl_Add_New_Student.TabIndex = 0;
            this.lbl_Add_New_Student.Text = "Add New Student";
            // 
            // lbl_Roll_No
            // 
            this.lbl_Roll_No.AutoSize = true;
            this.lbl_Roll_No.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Roll_No.Location = new System.Drawing.Point(87, 182);
            this.lbl_Roll_No.Name = "lbl_Roll_No";
            this.lbl_Roll_No.Size = new System.Drawing.Size(132, 46);
            this.lbl_Roll_No.TabIndex = 1;
            this.lbl_Roll_No.Text = "Roll No";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(107, 274);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(112, 46);
            this.lbl_Name.TabIndex = 3;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.Location = new System.Drawing.Point(107, 385);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(89, 46);
            this.lbl_DOB.TabIndex = 5;
            this.lbl_DOB.Text = "DOB";
            // 
            // lbl_Mob_No
            // 
            this.lbl_Mob_No.AutoSize = true;
            this.lbl_Mob_No.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mob_No.Location = new System.Drawing.Point(87, 491);
            this.lbl_Mob_No.Name = "lbl_Mob_No";
            this.lbl_Mob_No.Size = new System.Drawing.Size(146, 46);
            this.lbl_Mob_No.TabIndex = 7;
            this.lbl_Mob_No.Text = "Mob No";
            // 
            // lbl_Course
            // 
            this.lbl_Course.AutoSize = true;
            this.lbl_Course.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course.Location = new System.Drawing.Point(93, 589);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(126, 46);
            this.lbl_Course.TabIndex = 9;
            this.lbl_Course.Text = "Course";
            // 
            // txt_Roll_No
            // 
            this.txt_Roll_No.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Roll_No.ForeColor = System.Drawing.Color.Black;
            this.txt_Roll_No.Location = new System.Drawing.Point(396, 182);
            this.txt_Roll_No.MaxLength = 2000;
            this.txt_Roll_No.Name = "txt_Roll_No";
            this.txt_Roll_No.Size = new System.Drawing.Size(374, 53);
            this.txt_Roll_No.TabIndex = 2;
            this.txt_Roll_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.ForeColor = System.Drawing.Color.Black;
            this.txt_Name.Location = new System.Drawing.Point(396, 287);
            this.txt_Name.MaxLength = 80;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(374, 53);
            this.txt_Name.TabIndex = 4;
            this.txt_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Location = new System.Drawing.Point(396, 385);
            this.dtp_DOB.MaxDate = new System.DateTime(2004, 6, 16, 0, 0, 0, 0);
            this.dtp_DOB.MinDate = new System.DateTime(1997, 6, 16, 0, 0, 0, 0);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(374, 53);
            this.dtp_DOB.TabIndex = 6;
            this.dtp_DOB.Value = new System.DateTime(2004, 6, 16, 0, 0, 0, 0);
            // 
            // txt_Mob_No
            // 
            this.txt_Mob_No.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Mob_No.Location = new System.Drawing.Point(396, 491);
            this.txt_Mob_No.MaxLength = 10;
            this.txt_Mob_No.Name = "txt_Mob_No";
            this.txt_Mob_No.Size = new System.Drawing.Size(374, 53);
            this.txt_Mob_No.TabIndex = 8;
            // 
            // cmb_Course
            // 
            this.cmb_Course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Course.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Course.ForeColor = System.Drawing.Color.Black;
            this.cmb_Course.FormattingEnabled = true;
            this.cmb_Course.Items.AddRange(new object[] {
            "BCS",
            "BCA",
            "MCA",
            "MCS",
            "B.Com.IT"});
            this.cmb_Course.Location = new System.Drawing.Point(401, 589);
            this.cmb_Course.Name = "cmb_Course";
            this.cmb_Course.Size = new System.Drawing.Size(369, 53);
            this.cmb_Course.TabIndex = 10;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.Red;
            this.btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Logout.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.White;
            this.btn_Logout.Location = new System.Drawing.Point(802, 3);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(120, 49);
            this.btn_Logout.TabIndex = 14;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Search_Student_Details
            // 
            this.btn_Search_Student_Details.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_Search_Student_Details.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search_Student_Details.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Student_Details.ForeColor = System.Drawing.Color.White;
            this.btn_Search_Student_Details.Location = new System.Drawing.Point(12, 669);
            this.btn_Search_Student_Details.Name = "btn_Search_Student_Details";
            this.btn_Search_Student_Details.Size = new System.Drawing.Size(358, 62);
            this.btn_Search_Student_Details.TabIndex = 13;
            this.btn_Search_Student_Details.Text = "Search Student Details";
            this.btn_Search_Student_Details.UseVisualStyleBackColor = false;
            this.btn_Search_Student_Details.Click += new System.EventHandler(this.btn_Search_Student_Details_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(396, 669);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(138, 62);
            this.btn_Save.TabIndex = 11;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_View_Student_List
            // 
            this.btn_View_Student_List.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_View_Student_List.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_View_Student_List.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_Student_List.ForeColor = System.Drawing.Color.White;
            this.btn_View_Student_List.Location = new System.Drawing.Point(555, 669);
            this.btn_View_Student_List.Name = "btn_View_Student_List";
            this.btn_View_Student_List.Size = new System.Drawing.Size(342, 62);
            this.btn_View_Student_List.TabIndex = 12;
            this.btn_View_Student_List.Text = "View Student List";
            this.btn_View_Student_List.UseVisualStyleBackColor = false;
            this.btn_View_Student_List.Click += new System.EventHandler(this.btn_View_Student_List_Click);
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.AutoSize = true;
            this.lbl_Welcome.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Welcome.Location = new System.Drawing.Point(2, 5);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(154, 37);
            this.lbl_Welcome.TabIndex = 15;
            this.lbl_Welcome.Text = "Welcome   ";
            // 
            // Frm_Add_New_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 743);
            this.Controls.Add(this.lbl_Welcome);
            this.Controls.Add(this.btn_View_Student_List);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Search_Student_Details);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.cmb_Course);
            this.Controls.Add(this.txt_Mob_No);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_Roll_No);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.lbl_Mob_No);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Roll_No);
            this.Controls.Add(this.lbl_Add_New_Student);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Add_New_Student";
            this.Text = "Add New Student";
            this.Load += new System.EventHandler(this.Frm_Add_New_Student_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Add_New_Student;
        private System.Windows.Forms.Label lbl_Roll_No;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_Mob_No;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.TextBox txt_Roll_No;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.TextBox txt_Mob_No;
        private System.Windows.Forms.ComboBox cmb_Course;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Search_Student_Details;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_View_Student_List;
        private System.Windows.Forms.Label lbl_Welcome;
    }
}