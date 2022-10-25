namespace Student_Management_System
{
    partial class frm_View_Student_List
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_View_Student_List));
            this.lbl_View_Student_List = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Add_New_Student = new System.Windows.Forms.Button();
            this.studentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_Management_System_DBDataSet = new Student_Management_System.Student_Management_System_DBDataSet();
            this.student_DetailsTableAdapter = new Student_Management_System.Student_Management_System_DBDataSetTableAdapters.Student_DetailsTableAdapter();
            this.student_Details_DBDataSet = new Student_Management_System.Student_Details_DBDataSet();
            this.studentDetailsDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.student_Management_System_DBDataSet1 = new Student_Management_System.Student_Management_System_DBDataSet1();
            this.student_Details_DBDataSet1 = new Student_Management_System.Student_Details_DBDataSet1();
            this.studentDetailsDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_DetailsTableAdapter1 = new Student_Management_System.Student_Management_System_DBDataSet1TableAdapters.Student_DetailsTableAdapter();
            this.dgv_View_Student_List = new System.Windows.Forms.DataGridView();
            this.rollNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDetailsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.student_Management_System_DBDataSet4 = new Student_Management_System.Student_Management_System_DBDataSet4();
            this.studentDetailsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.student_Management_System_DBDataSet2 = new Student_Management_System.Student_Management_System_DBDataSet2();
            this.student_DetailsTableAdapter2 = new Student_Management_System.Student_Management_System_DBDataSet2TableAdapters.Student_DetailsTableAdapter();
            this.student_DetailsTableAdapter3 = new Student_Management_System.Student_Management_System_DBDataSet4TableAdapters.Student_DetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Management_System_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Details_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Management_System_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Details_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsDBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Student_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Management_System_DBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Management_System_DBDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_View_Student_List
            // 
            this.lbl_View_Student_List.AutoSize = true;
            this.lbl_View_Student_List.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Student_List.ForeColor = System.Drawing.Color.Blue;
            this.lbl_View_Student_List.Location = new System.Drawing.Point(201, 42);
            this.lbl_View_Student_List.Name = "lbl_View_Student_List";
            this.lbl_View_Student_List.Size = new System.Drawing.Size(460, 68);
            this.lbl_View_Student_List.TabIndex = 0;
            this.lbl_View_Student_List.Text = "View Student List";
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.White;
            this.btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Logout.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Red;
            this.btn_Logout.Location = new System.Drawing.Point(796, 12);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(116, 44);
            this.btn_Logout.TabIndex = 1;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Add_New_Student
            // 
            this.btn_Add_New_Student.BackColor = System.Drawing.Color.Pink;
            this.btn_Add_New_Student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add_New_Student.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Student.ForeColor = System.Drawing.Color.Black;
            this.btn_Add_New_Student.Location = new System.Drawing.Point(266, 635);
            this.btn_Add_New_Student.Name = "btn_Add_New_Student";
            this.btn_Add_New_Student.Size = new System.Drawing.Size(395, 56);
            this.btn_Add_New_Student.TabIndex = 2;
            this.btn_Add_New_Student.Text = "Add New Student";
            this.btn_Add_New_Student.UseVisualStyleBackColor = false;
            this.btn_Add_New_Student.Click += new System.EventHandler(this.btn_Add_New_Student_Click);
            // 
            // studentDetailsBindingSource
            // 
            this.studentDetailsBindingSource.DataMember = "Student_Details";
            this.studentDetailsBindingSource.DataSource = this.student_Management_System_DBDataSet;
            // 
            // student_Management_System_DBDataSet
            // 
            this.student_Management_System_DBDataSet.DataSetName = "Student_Management_System_DBDataSet";
            this.student_Management_System_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // student_DetailsTableAdapter
            // 
            this.student_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // student_Details_DBDataSet
            // 
            this.student_Details_DBDataSet.DataSetName = "Student_Details_DBDataSet";
            this.student_Details_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDetailsDBDataSetBindingSource
            // 
            this.studentDetailsDBDataSetBindingSource.DataSource = this.student_Details_DBDataSet;
            this.studentDetailsDBDataSetBindingSource.Position = 0;
            // 
            // studentDetailsBindingSource1
            // 
            this.studentDetailsBindingSource1.DataMember = "Student_Details";
            this.studentDetailsBindingSource1.DataSource = this.student_Management_System_DBDataSet1;
            // 
            // student_Management_System_DBDataSet1
            // 
            this.student_Management_System_DBDataSet1.DataSetName = "Student_Management_System_DBDataSet1";
            this.student_Management_System_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // student_Details_DBDataSet1
            // 
            this.student_Details_DBDataSet1.DataSetName = "Student_Details_DBDataSet1";
            this.student_Details_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDetailsDBDataSet1BindingSource
            // 
            this.studentDetailsDBDataSet1BindingSource.DataSource = this.student_Details_DBDataSet1;
            this.studentDetailsDBDataSet1BindingSource.Position = 0;
            // 
            // student_DetailsTableAdapter1
            // 
            this.student_DetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // dgv_View_Student_List
            // 
            this.dgv_View_Student_List.AutoGenerateColumns = false;
            this.dgv_View_Student_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_Student_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Student_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollNumberDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn});
            this.dgv_View_Student_List.DataSource = this.studentDetailsBindingSource3;
            this.dgv_View_Student_List.Location = new System.Drawing.Point(12, 113);
            this.dgv_View_Student_List.Name = "dgv_View_Student_List";
            this.dgv_View_Student_List.RowTemplate.Height = 24;
            this.dgv_View_Student_List.Size = new System.Drawing.Size(908, 493);
            this.dgv_View_Student_List.TabIndex = 3;
            // 
            // rollNumberDataGridViewTextBoxColumn
            // 
            this.rollNumberDataGridViewTextBoxColumn.DataPropertyName = "Roll_Number";
            this.rollNumberDataGridViewTextBoxColumn.HeaderText = "Roll_Number";
            this.rollNumberDataGridViewTextBoxColumn.Name = "rollNumberDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            // 
            // studentDetailsBindingSource3
            // 
            this.studentDetailsBindingSource3.DataMember = "Student_Details";
            this.studentDetailsBindingSource3.DataSource = this.student_Management_System_DBDataSet4;
            // 
            // student_Management_System_DBDataSet4
            // 
            this.student_Management_System_DBDataSet4.DataSetName = "Student_Management_System_DBDataSet4";
            this.student_Management_System_DBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDetailsBindingSource2
            // 
            this.studentDetailsBindingSource2.DataMember = "Student_Details";
            this.studentDetailsBindingSource2.DataSource = this.student_Management_System_DBDataSet2;
            // 
            // student_Management_System_DBDataSet2
            // 
            this.student_Management_System_DBDataSet2.DataSetName = "Student_Management_System_DBDataSet2";
            this.student_Management_System_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // student_DetailsTableAdapter2
            // 
            this.student_DetailsTableAdapter2.ClearBeforeFill = true;
            // 
            // student_DetailsTableAdapter3
            // 
            this.student_DetailsTableAdapter3.ClearBeforeFill = true;
            // 
            // frm_View_Student_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(932, 703);
            this.Controls.Add(this.dgv_View_Student_List);
            this.Controls.Add(this.btn_Add_New_Student);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.lbl_View_Student_List);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_View_Student_List";
            this.Text = "View Student List";
            this.Load += new System.EventHandler(this.frm_View_Student_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Management_System_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Details_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Management_System_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Details_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsDBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Student_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Management_System_DBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Management_System_DBDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_View_Student_List;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Add_New_Student;
        private System.Windows.Forms.BindingSource studentDetailsDBDataSetBindingSource;
        private Student_Details_DBDataSet student_Details_DBDataSet;
        private Student_Management_System_DBDataSet student_Management_System_DBDataSet;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource;
        private Student_Management_System_DBDataSetTableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter;
        private System.Windows.Forms.BindingSource studentDetailsDBDataSet1BindingSource;
        private Student_Details_DBDataSet1 student_Details_DBDataSet1;
        private Student_Management_System_DBDataSet1 student_Management_System_DBDataSet1;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource1;
        private Student_Management_System_DBDataSet1TableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter1;
        private System.Windows.Forms.DataGridView dgv_View_Student_List;
        private Student_Management_System_DBDataSet2 student_Management_System_DBDataSet2;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource2;
        private Student_Management_System_DBDataSet2TableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private Student_Management_System_DBDataSet4 student_Management_System_DBDataSet4;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource3;
        private Student_Management_System_DBDataSet4TableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter3;
    }
}