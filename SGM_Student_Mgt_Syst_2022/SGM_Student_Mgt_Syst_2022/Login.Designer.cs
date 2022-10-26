namespace SGM_Student_Mgt_Syst_2022
{
    partial class Frm_Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login_Form));
            this.PB_Login_Student = new System.Windows.Forms.PictureBox();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_Error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Login_Student)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_Login_Student
            // 
            this.PB_Login_Student.BackColor = System.Drawing.Color.White;
            this.PB_Login_Student.Image = ((System.Drawing.Image)(resources.GetObject("PB_Login_Student.Image")));
            this.PB_Login_Student.InitialImage = null;
            this.PB_Login_Student.Location = new System.Drawing.Point(2, 21);
            this.PB_Login_Student.Name = "PB_Login_Student";
            this.PB_Login_Student.Size = new System.Drawing.Size(935, 634);
            this.PB_Login_Student.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Login_Student.TabIndex = 0;
            this.PB_Login_Student.TabStop = false;
            
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Login.Font = new System.Drawing.Font("Cambria", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Login.Location = new System.Drawing.Point(518, 76);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(274, 57);
            this.lbl_Login.TabIndex = 1;
            this.lbl_Login.Text = "Login Form";
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.Lime;
            this.btn_Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Submit.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.Black;
            this.btn_Submit.Location = new System.Drawing.Point(528, 666);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(251, 56);
            this.btn_Submit.TabIndex = 6;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.BackColor = System.Drawing.Color.Gray;
            this.lbl_Username.Font = new System.Drawing.Font("Cambria", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.Black;
            this.lbl_Username.Location = new System.Drawing.Point(419, 267);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(187, 44);
            this.lbl_Username.TabIndex = 1;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.Color.Gray;
            this.lbl_Password.Font = new System.Drawing.Font("Cambria", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.Black;
            this.lbl_Password.Location = new System.Drawing.Point(429, 452);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(177, 44);
            this.lbl_Password.TabIndex = 3;
            this.lbl_Password.Text = "Password";
            // 
            // txt_Username
            // 
            this.txt_Username.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.ForeColor = System.Drawing.Color.Black;
            this.txt_Username.Location = new System.Drawing.Point(633, 267);
            this.txt_Username.MaxLength = 12;
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(280, 46);
            this.txt_Username.TabIndex = 2;
            this.txt_Username.TextChanged += new System.EventHandler(this.txt_Username_TextChanged);
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.ForeColor = System.Drawing.Color.Black;
            this.txt_Password.Location = new System.Drawing.Point(633, 452);
            this.txt_Password.MaxLength = 8;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '$';
            this.txt_Password.Size = new System.Drawing.Size(280, 46);
            this.txt_Password.TabIndex = 4;
            this.txt_Password.TextChanged += new System.EventHandler(this.txt_Password_TextChanged);
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.BackColor = System.Drawing.Color.Gray;
            this.lbl_Error.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error.Location = new System.Drawing.Point(510, 589);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(328, 28);
            this.lbl_Error.TabIndex = 5;
            this.lbl_Error.Text = "Enter Username and Password";
            // 
            // Frm_Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(940, 734);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.lbl_Login);
            this.Controls.Add(this.PB_Login_Student);
            this.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Login_Form";
            this.Text = "Login Form";
            ((System.ComponentModel.ISupportInitialize)(this.PB_Login_Student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Login_Student;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lbl_Error;
    }
}

