namespace SGM_Student_Mgt_Syst_2022
{
    partial class Frm_View_Student_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_View_Student_List));
            this.lbl_View_All_Student_List = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Add_New_Student = new System.Windows.Forms.Button();
            this.sGMMgtSystDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sGM_Student_Mgt_Syst_Details_DBDataSet = new SGM_Student_Mgt_Syst_2022.SGM_Student_Mgt_Syst_Details_DBDataSet();
            this.sGM_Mgt_Syst_DetailsTableAdapter = new SGM_Student_Mgt_Syst_2022.SGM_Student_Mgt_Syst_Details_DBDataSetTableAdapters.SGM_Mgt_Syst_DetailsTableAdapter();
            this.dvg_View_All_Student_Details = new System.Windows.Forms.DataGridView();
            this.sGM_Student_Mgt_Syst_Details_DBDataSet2 = new SGM_Student_Mgt_Syst_2022.SGM_Student_Mgt_Syst_Details_DBDataSet2();
            this.sGMMgtSystDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sGM_Mgt_Syst_DetailsTableAdapter1 = new SGM_Student_Mgt_Syst_2022.SGM_Student_Mgt_Syst_Details_DBDataSet2TableAdapters.SGM_Mgt_Syst_DetailsTableAdapter();
            this.rNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sGMMgtSystDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGM_Student_Mgt_Syst_Details_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_View_All_Student_Details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGM_Student_Mgt_Syst_Details_DBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGMMgtSystDetailsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_View_All_Student_List
            // 
            this.lbl_View_All_Student_List.AutoSize = true;
            this.lbl_View_All_Student_List.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_View_All_Student_List.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_All_Student_List.ForeColor = System.Drawing.Color.DeepPink;
            this.lbl_View_All_Student_List.Location = new System.Drawing.Point(151, 42);
            this.lbl_View_All_Student_List.Name = "lbl_View_All_Student_List";
            this.lbl_View_All_Student_List.Size = new System.Drawing.Size(544, 73);
            this.lbl_View_All_Student_List.TabIndex = 0;
            this.lbl_View_All_Student_List.Text = "View All Student List";
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.Red;
            this.btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Logout.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Black;
            this.btn_Logout.Location = new System.Drawing.Point(798, 12);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(130, 46);
            this.btn_Logout.TabIndex = 1;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Add_New_Student
            // 
            this.btn_Add_New_Student.BackColor = System.Drawing.Color.Lime;
            this.btn_Add_New_Student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add_New_Student.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Student.ForeColor = System.Drawing.Color.Black;
            this.btn_Add_New_Student.Location = new System.Drawing.Point(225, 679);
            this.btn_Add_New_Student.Name = "btn_Add_New_Student";
            this.btn_Add_New_Student.Size = new System.Drawing.Size(407, 54);
            this.btn_Add_New_Student.TabIndex = 2;
            this.btn_Add_New_Student.Text = "Add New Student";
            this.btn_Add_New_Student.UseVisualStyleBackColor = false;
            this.btn_Add_New_Student.Click += new System.EventHandler(this.btn_Add_New_Student_Click);
            // 
            // sGMMgtSystDetailsBindingSource
            // 
            this.sGMMgtSystDetailsBindingSource.DataMember = "SGM_Mgt_Syst_Details";
            this.sGMMgtSystDetailsBindingSource.DataSource = this.sGM_Student_Mgt_Syst_Details_DBDataSet;
            // 
            // sGM_Student_Mgt_Syst_Details_DBDataSet
            // 
            this.sGM_Student_Mgt_Syst_Details_DBDataSet.DataSetName = "SGM_Student_Mgt_Syst_Details_DBDataSet";
            this.sGM_Student_Mgt_Syst_Details_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sGM_Mgt_Syst_DetailsTableAdapter
            // 
            this.sGM_Mgt_Syst_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // dvg_View_All_Student_Details
            // 
            this.dvg_View_All_Student_Details.AutoGenerateColumns = false;
            this.dvg_View_All_Student_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvg_View_All_Student_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_View_All_Student_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rNoDataGridViewTextBoxColumn,
            this.nmDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.mNoDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn});
            this.dvg_View_All_Student_Details.DataSource = this.sGMMgtSystDetailsBindingSource1;
            this.dvg_View_All_Student_Details.Location = new System.Drawing.Point(9, 140);
            this.dvg_View_All_Student_Details.Name = "dvg_View_All_Student_Details";
            this.dvg_View_All_Student_Details.RowTemplate.Height = 24;
            this.dvg_View_All_Student_Details.Size = new System.Drawing.Size(918, 533);
            this.dvg_View_All_Student_Details.TabIndex = 3;
            // 
            // sGM_Student_Mgt_Syst_Details_DBDataSet2
            // 
            this.sGM_Student_Mgt_Syst_Details_DBDataSet2.DataSetName = "SGM_Student_Mgt_Syst_Details_DBDataSet2";
            this.sGM_Student_Mgt_Syst_Details_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sGMMgtSystDetailsBindingSource1
            // 
            this.sGMMgtSystDetailsBindingSource1.DataMember = "SGM_Mgt_Syst_Details";
            this.sGMMgtSystDetailsBindingSource1.DataSource = this.sGM_Student_Mgt_Syst_Details_DBDataSet2;
            // 
            // sGM_Mgt_Syst_DetailsTableAdapter1
            // 
            this.sGM_Mgt_Syst_DetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // rNoDataGridViewTextBoxColumn
            // 
            this.rNoDataGridViewTextBoxColumn.DataPropertyName = "RNo";
            this.rNoDataGridViewTextBoxColumn.HeaderText = "RNo";
            this.rNoDataGridViewTextBoxColumn.Name = "rNoDataGridViewTextBoxColumn";
            // 
            // nmDataGridViewTextBoxColumn
            // 
            this.nmDataGridViewTextBoxColumn.DataPropertyName = "Nm";
            this.nmDataGridViewTextBoxColumn.HeaderText = "Nm";
            this.nmDataGridViewTextBoxColumn.Name = "nmDataGridViewTextBoxColumn";
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            // 
            // mNoDataGridViewTextBoxColumn
            // 
            this.mNoDataGridViewTextBoxColumn.DataPropertyName = "MNo";
            this.mNoDataGridViewTextBoxColumn.HeaderText = "MNo";
            this.mNoDataGridViewTextBoxColumn.Name = "mNoDataGridViewTextBoxColumn";
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            // 
            // Frm_View_Student_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(933, 739);
            this.Controls.Add(this.dvg_View_All_Student_Details);
            this.Controls.Add(this.btn_Add_New_Student);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.lbl_View_All_Student_List);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_View_Student_List";
            this.Text = "View Student List";
            this.Load += new System.EventHandler(this.Frm_View_Student_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sGMMgtSystDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGM_Student_Mgt_Syst_Details_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_View_All_Student_Details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGM_Student_Mgt_Syst_Details_DBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGMMgtSystDetailsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_View_All_Student_List;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Add_New_Student;
        private SGM_Student_Mgt_Syst_Details_DBDataSet sGM_Student_Mgt_Syst_Details_DBDataSet;
        private System.Windows.Forms.BindingSource sGMMgtSystDetailsBindingSource;
        private SGM_Student_Mgt_Syst_Details_DBDataSetTableAdapters.SGM_Mgt_Syst_DetailsTableAdapter sGM_Mgt_Syst_DetailsTableAdapter;
        private System.Windows.Forms.DataGridView dvg_View_All_Student_Details;
        private SGM_Student_Mgt_Syst_Details_DBDataSet2 sGM_Student_Mgt_Syst_Details_DBDataSet2;
        private System.Windows.Forms.BindingSource sGMMgtSystDetailsBindingSource1;
        private SGM_Student_Mgt_Syst_Details_DBDataSet2TableAdapters.SGM_Mgt_Syst_DetailsTableAdapter sGM_Mgt_Syst_DetailsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
    }
}