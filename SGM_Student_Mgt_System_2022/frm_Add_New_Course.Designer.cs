namespace SGM_Student_Mgt_System_2022
{
    partial class frm_Add_New_Course
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
            this.lbl_Add_New_Course = new System.Windows.Forms.Label();
            this.lbl_Course_ID = new System.Windows.Forms.Label();
            this.lbl_Course_Name = new System.Windows.Forms.Label();
            this.txt_Course_ID = new System.Windows.Forms.TextBox();
            this.txt_Course_Name = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Add_New_Course
            // 
            this.lbl_Add_New_Course.AutoSize = true;
            this.lbl_Add_New_Course.BackColor = System.Drawing.Color.White;
            this.lbl_Add_New_Course.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_New_Course.ForeColor = System.Drawing.Color.Red;
            this.lbl_Add_New_Course.Location = new System.Drawing.Point(221, 33);
            this.lbl_Add_New_Course.Name = "lbl_Add_New_Course";
            this.lbl_Add_New_Course.Size = new System.Drawing.Size(463, 68);
            this.lbl_Add_New_Course.TabIndex = 0;
            this.lbl_Add_New_Course.Text = "Add New Course";
            // 
            // lbl_Course_ID
            // 
            this.lbl_Course_ID.AutoSize = true;
            this.lbl_Course_ID.BackColor = System.Drawing.Color.White;
            this.lbl_Course_ID.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course_ID.ForeColor = System.Drawing.Color.DeepPink;
            this.lbl_Course_ID.Location = new System.Drawing.Point(136, 214);
            this.lbl_Course_ID.Name = "lbl_Course_ID";
            this.lbl_Course_ID.Size = new System.Drawing.Size(194, 46);
            this.lbl_Course_ID.TabIndex = 1;
            this.lbl_Course_ID.Text = "Course ID ";
            // 
            // lbl_Course_Name
            // 
            this.lbl_Course_Name.AutoSize = true;
            this.lbl_Course_Name.BackColor = System.Drawing.Color.White;
            this.lbl_Course_Name.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course_Name.ForeColor = System.Drawing.Color.DeepPink;
            this.lbl_Course_Name.Location = new System.Drawing.Point(136, 416);
            this.lbl_Course_Name.Name = "lbl_Course_Name";
            this.lbl_Course_Name.Size = new System.Drawing.Size(237, 46);
            this.lbl_Course_Name.TabIndex = 2;
            this.lbl_Course_Name.Text = "Course Name";
            // 
            // txt_Course_ID
            // 
            this.txt_Course_ID.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Course_ID.Location = new System.Drawing.Point(516, 211);
            this.txt_Course_ID.Name = "txt_Course_ID";
            this.txt_Course_ID.Size = new System.Drawing.Size(331, 53);
            this.txt_Course_ID.TabIndex = 3;
            // 
            // txt_Course_Name
            // 
            this.txt_Course_Name.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Course_Name.Location = new System.Drawing.Point(516, 387);
            this.txt_Course_Name.Name = "txt_Course_Name";
            this.txt_Course_Name.Size = new System.Drawing.Size(331, 53);
            this.txt_Course_Name.TabIndex = 4;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Lime;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Black;
            this.btn_Save.Location = new System.Drawing.Point(373, 565);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(174, 65);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frm_Add_New_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 717);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_Course_Name);
            this.Controls.Add(this.txt_Course_ID);
            this.Controls.Add(this.lbl_Course_Name);
            this.Controls.Add(this.lbl_Course_ID);
            this.Controls.Add(this.lbl_Add_New_Course);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_New_Course";
            this.Text = "Add New Course";
            this.Load += new System.EventHandler(this.frm_Add_New_Course_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Add_New_Course;
        private System.Windows.Forms.Label lbl_Course_ID;
        private System.Windows.Forms.Label lbl_Course_Name;
        private System.Windows.Forms.TextBox txt_Course_ID;
        private System.Windows.Forms.TextBox txt_Course_Name;
        private System.Windows.Forms.Button btn_Save;
    }
}