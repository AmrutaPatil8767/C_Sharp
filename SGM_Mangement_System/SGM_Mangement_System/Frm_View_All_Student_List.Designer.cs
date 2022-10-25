namespace SGM_Mangement_System
{
    partial class Frm_View_All_Student_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_View_All_Student_List));
            this.lbl_View_All_Student_List = new System.Windows.Forms.Label();
            this.btn_Add_New_Student = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.sGMStudentDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sGM_Student_Details_DBDataSet2 = new SGM_Mangement_System.SGM_Student_Details_DBDataSet2();
            this.sGM_Student_Details_DBDataSet = new SGM_Mangement_System.SGM_Student_Details_DBDataSet();
            this.sGMStudentDetailsDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sGM_Student_Details_DBDataSet1 = new SGM_Mangement_System.SGM_Student_Details_DBDataSet1();
            this.sGMStudentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sGM_Student_DetailsTableAdapter = new SGM_Mangement_System.SGM_Student_Details_DBDataSet1TableAdapters.SGM_Student_DetailsTableAdapter();
            this.sGM_Student_DetailsTableAdapter1 = new SGM_Mangement_System.SGM_Student_Details_DBDataSet2TableAdapters.SGM_Student_DetailsTableAdapter();
            this.dgv_View_All_Student = new System.Windows.Forms.DataGridView();
            this.sGM_Student_Details_DBDataSet3 = new SGM_Mangement_System.SGM_Student_Details_DBDataSet3();
            this.sGMStudentDetailsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sGM_Student_DetailsTableAdapter2 = new SGM_Mangement_System.SGM_Student_Details_DBDataSet3TableAdapters.SGM_Student_DetailsTableAdapter();
            this.rollNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sGMStudentDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGM_Student_Details_DBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGM_Student_Details_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGMStudentDetailsDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGM_Student_Details_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGMStudentDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_All_Student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGM_Student_Details_DBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGMStudentDetailsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_View_All_Student_List
            // 
            this.lbl_View_All_Student_List.AutoSize = true;
            this.lbl_View_All_Student_List.BackColor = System.Drawing.Color.White;
            this.lbl_View_All_Student_List.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_All_Student_List.ForeColor = System.Drawing.Color.BlueViolet;
            this.lbl_View_All_Student_List.Location = new System.Drawing.Point(184, 32);
            this.lbl_View_All_Student_List.Name = "lbl_View_All_Student_List";
            this.lbl_View_All_Student_List.Size = new System.Drawing.Size(532, 73);
            this.lbl_View_All_Student_List.TabIndex = 0;
            this.lbl_View_All_Student_List.Text = "View All Student List";
            // 
            // btn_Add_New_Student
            // 
            this.btn_Add_New_Student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Add_New_Student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add_New_Student.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Student.ForeColor = System.Drawing.Color.Black;
            this.btn_Add_New_Student.Location = new System.Drawing.Point(259, 651);
            this.btn_Add_New_Student.Name = "btn_Add_New_Student";
            this.btn_Add_New_Student.Size = new System.Drawing.Size(338, 57);
            this.btn_Add_New_Student.TabIndex = 1;
            this.btn_Add_New_Student.Text = "Add New Student";
            this.btn_Add_New_Student.UseVisualStyleBackColor = false;
            this.btn_Add_New_Student.Click += new System.EventHandler(this.btn_Add_New_Student_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.White;
            this.btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Logout.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Red;
            this.btn_Logout.Location = new System.Drawing.Point(749, 13);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(148, 48);
            this.btn_Logout.TabIndex = 2;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // sGMStudentDetailsBindingSource1
            // 
            this.sGMStudentDetailsBindingSource1.DataMember = "SGM_Student_Details";
            this.sGMStudentDetailsBindingSource1.DataSource = this.sGM_Student_Details_DBDataSet2;
            // 
            // sGM_Student_Details_DBDataSet2
            // 
            this.sGM_Student_Details_DBDataSet2.DataSetName = "SGM_Student_Details_DBDataSet2";
            this.sGM_Student_Details_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sGM_Student_Details_DBDataSet
            // 
            this.sGM_Student_Details_DBDataSet.DataSetName = "SGM_Student_Details_DBDataSet";
            this.sGM_Student_Details_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sGMStudentDetailsDBDataSetBindingSource
            // 
            this.sGMStudentDetailsDBDataSetBindingSource.DataSource = this.sGM_Student_Details_DBDataSet;
            this.sGMStudentDetailsDBDataSetBindingSource.Position = 0;
            // 
            // sGM_Student_Details_DBDataSet1
            // 
            this.sGM_Student_Details_DBDataSet1.DataSetName = "SGM_Student_Details_DBDataSet1";
            this.sGM_Student_Details_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sGMStudentDetailsBindingSource
            // 
            this.sGMStudentDetailsBindingSource.DataMember = "SGM_Student_Details";
            this.sGMStudentDetailsBindingSource.DataSource = this.sGM_Student_Details_DBDataSet1;
            // 
            // sGM_Student_DetailsTableAdapter
            // 
            this.sGM_Student_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // sGM_Student_DetailsTableAdapter1
            // 
            this.sGM_Student_DetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // dgv_View_All_Student
            // 
            this.dgv_View_All_Student.AutoGenerateColumns = false;
            this.dgv_View_All_Student.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_All_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_All_Student.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.mobNoDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn});
            this.dgv_View_All_Student.DataSource = this.sGMStudentDetailsBindingSource2;
            this.dgv_View_All_Student.Location = new System.Drawing.Point(11, 143);
            this.dgv_View_All_Student.Name = "dgv_View_All_Student";
            this.dgv_View_All_Student.RowTemplate.Height = 24;
            this.dgv_View_All_Student.Size = new System.Drawing.Size(885, 495);
            this.dgv_View_All_Student.TabIndex = 3;
            // 
            // sGM_Student_Details_DBDataSet3
            // 
            this.sGM_Student_Details_DBDataSet3.DataSetName = "SGM_Student_Details_DBDataSet3";
            this.sGM_Student_Details_DBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sGMStudentDetailsBindingSource2
            // 
            this.sGMStudentDetailsBindingSource2.DataMember = "SGM_Student_Details";
            this.sGMStudentDetailsBindingSource2.DataSource = this.sGM_Student_Details_DBDataSet3;
            // 
            // sGM_Student_DetailsTableAdapter2
            // 
            this.sGM_Student_DetailsTableAdapter2.ClearBeforeFill = true;
            // 
            // rollNoDataGridViewTextBoxColumn
            // 
            this.rollNoDataGridViewTextBoxColumn.DataPropertyName = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.HeaderText = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.Name = "rollNoDataGridViewTextBoxColumn";
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
            // mobNoDataGridViewTextBoxColumn
            // 
            this.mobNoDataGridViewTextBoxColumn.DataPropertyName = "Mob_No";
            this.mobNoDataGridViewTextBoxColumn.HeaderText = "Mob_No";
            this.mobNoDataGridViewTextBoxColumn.Name = "mobNoDataGridViewTextBoxColumn";
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            // 
            // Frm_View_All_Student_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(919, 736);
            this.Controls.Add(this.dgv_View_All_Student);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_Add_New_Student);
            this.Controls.Add(this.lbl_View_All_Student_List);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_View_All_Student_List";
            this.Text = "Frm_View_All_Student_List";
            this.Load += new System.EventHandler(this.Frm_View_All_Student_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sGMStudentDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGM_Student_Details_DBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGM_Student_Details_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGMStudentDetailsDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGM_Student_Details_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGMStudentDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_All_Student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGM_Student_Details_DBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGMStudentDetailsBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_View_All_Student_List;
        private System.Windows.Forms.Button btn_Add_New_Student;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.BindingSource sGMStudentDetailsDBDataSetBindingSource;
        private SGM_Student_Details_DBDataSet sGM_Student_Details_DBDataSet;
        private SGM_Student_Details_DBDataSet1 sGM_Student_Details_DBDataSet1;
        private System.Windows.Forms.BindingSource sGMStudentDetailsBindingSource;
        private SGM_Student_Details_DBDataSet1TableAdapters.SGM_Student_DetailsTableAdapter sGM_Student_DetailsTableAdapter;
        private SGM_Student_Details_DBDataSet2 sGM_Student_Details_DBDataSet2;
        private System.Windows.Forms.BindingSource sGMStudentDetailsBindingSource1;
        private SGM_Student_Details_DBDataSet2TableAdapters.SGM_Student_DetailsTableAdapter sGM_Student_DetailsTableAdapter1;
        private System.Windows.Forms.DataGridView dgv_View_All_Student;
        private SGM_Student_Details_DBDataSet3 sGM_Student_Details_DBDataSet3;
        private System.Windows.Forms.BindingSource sGMStudentDetailsBindingSource2;
        private SGM_Student_Details_DBDataSet3TableAdapters.SGM_Student_DetailsTableAdapter sGM_Student_DetailsTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
    }
}