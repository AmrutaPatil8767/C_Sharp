namespace Student_Management_System
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.lbl_Login_Form = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Login_Form
            // 
            this.lbl_Login_Form.AutoSize = true;
            this.lbl_Login_Form.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_Login_Form.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login_Form.Location = new System.Drawing.Point(299, 34);
            this.lbl_Login_Form.Name = "lbl_Login_Form";
            this.lbl_Login_Form.Size = new System.Drawing.Size(312, 68);
            this.lbl_Login_Form.TabIndex = 0;
            this.lbl_Login_Form.Text = "Login Form";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_Username.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.Black;
            this.lbl_Username.Location = new System.Drawing.Point(154, 179);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(173, 43);
            this.lbl_Username.TabIndex = 1;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.Black;
            this.lbl_Password.Location = new System.Drawing.Point(163, 349);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(164, 43);
            this.lbl_Password.TabIndex = 2;
            this.lbl_Password.Text = "Password";
            // 
            // txt_Username
            // 
            this.txt_Username.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.ForeColor = System.Drawing.Color.Black;
            this.txt_Username.Location = new System.Drawing.Point(513, 172);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(307, 50);
            this.txt_Username.TabIndex = 3;
            this.txt_Username.TextChanged += new System.EventHandler(this.txt_Username_TextChanged);
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.ForeColor = System.Drawing.Color.Black;
            this.txt_Password.Location = new System.Drawing.Point(513, 342);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '$';
            this.txt_Password.Size = new System.Drawing.Size(307, 50);
            this.txt_Password.TabIndex = 4;
            this.txt_Password.TextChanged += new System.EventHandler(this.txt_Password_TextChanged);
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error.Location = new System.Drawing.Point(299, 473);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(312, 27);
            this.lbl_Error.TabIndex = 5;
            this.lbl_Error.Text = "Enter Username and  Password";
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.Lime;
            this.btn_Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Submit.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.Black;
            this.btn_Submit.Location = new System.Drawing.Point(369, 577);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(173, 52);
            this.btn_Submit.TabIndex = 6;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(932, 703);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.lbl_Login_Form);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Login";
            this.Text = "Login_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Login_Form;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lbl_Error;
        private System.Windows.Forms.Button btn_Submit;
    }
}

