namespace ReceiptGenerator
{
    partial class ShowStudentRecords
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
            this.pnlShowStudentDetails = new System.Windows.Forms.Panel();
            this.dgStudentDetails = new System.Windows.Forms.DataGridView();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skills = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class_reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year_of_passing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mode_of_class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pri_contact_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.another_contact_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAdmitted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.work_experience = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year_of_exprience = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_preference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.todayDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoadAllData = new System.Windows.Forms.Button();
            this.pnlShowStudentDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudentDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlShowStudentDetails
            // 
            this.pnlShowStudentDetails.Controls.Add(this.dgStudentDetails);
            this.pnlShowStudentDetails.Location = new System.Drawing.Point(12, 108);
            this.pnlShowStudentDetails.Name = "pnlShowStudentDetails";
            this.pnlShowStudentDetails.Size = new System.Drawing.Size(1763, 770);
            this.pnlShowStudentDetails.TabIndex = 1;
            // 
            // dgStudentDetails
            // 
            this.dgStudentDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStudentDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.address,
            this.skills,
            this.class_reference,
            this.qualification,
            this.year_of_passing,
            this.mode_of_class,
            this.pri_contact_number,
            this.another_contact_number,
            this.emailid,
            this.isAdmitted,
            this.work_experience,
            this.year_of_exprience,
            this.course,
            this.time_preference,
            this.todayDate});
            this.dgStudentDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgStudentDetails.Location = new System.Drawing.Point(0, 0);
            this.dgStudentDetails.Name = "dgStudentDetails";
            this.dgStudentDetails.RowTemplate.Height = 24;
            this.dgStudentDetails.Size = new System.Drawing.Size(1763, 770);
            this.dgStudentDetails.TabIndex = 0;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFullName.Location = new System.Drawing.Point(22, 38);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(117, 28);
            this.lblFullName.TabIndex = 28;
            this.lblFullName.Text = "Full Name";
            // 
            // txtFullName
            // 
            this.txtFullName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtFullName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(158, 31);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(290, 38);
            this.txtFullName.TabIndex = 29;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(473, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(154, 38);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            // 
            // skills
            // 
            this.skills.HeaderText = "Skills";
            this.skills.Name = "skills";
            // 
            // class_reference
            // 
            this.class_reference.HeaderText = "Class Reference";
            this.class_reference.Name = "class_reference";
            // 
            // qualification
            // 
            this.qualification.HeaderText = "Qualification";
            this.qualification.Name = "qualification";
            // 
            // year_of_passing
            // 
            this.year_of_passing.HeaderText = "Year Of Passing";
            this.year_of_passing.Name = "year_of_passing";
            // 
            // mode_of_class
            // 
            this.mode_of_class.HeaderText = "Mode Of Class";
            this.mode_of_class.Name = "mode_of_class";
            // 
            // pri_contact_number
            // 
            this.pri_contact_number.HeaderText = "Primary Contact Number";
            this.pri_contact_number.Name = "pri_contact_number";
            // 
            // another_contact_number
            // 
            this.another_contact_number.HeaderText = "Another Contact Number";
            this.another_contact_number.Name = "another_contact_number";
            // 
            // emailid
            // 
            this.emailid.HeaderText = "Email ID";
            this.emailid.Name = "emailid";
            // 
            // isAdmitted
            // 
            this.isAdmitted.HeaderText = "IS Admitted";
            this.isAdmitted.Name = "isAdmitted";
            // 
            // work_experience
            // 
            this.work_experience.HeaderText = "Work Experience";
            this.work_experience.Name = "work_experience";
            // 
            // year_of_exprience
            // 
            this.year_of_exprience.HeaderText = "Year Of Exprience";
            this.year_of_exprience.Name = "year_of_exprience";
            // 
            // course
            // 
            this.course.HeaderText = "Course";
            this.course.Name = "course";
            // 
            // time_preference
            // 
            this.time_preference.HeaderText = "Time Preference";
            this.time_preference.Name = "time_preference";
            // 
            // todayDate
            // 
            this.todayDate.HeaderText = "Date";
            this.todayDate.Name = "todayDate";
            // 
            // btnLoadAllData
            // 
            this.btnLoadAllData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadAllData.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadAllData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLoadAllData.Location = new System.Drawing.Point(664, 32);
            this.btnLoadAllData.Name = "btnLoadAllData";
            this.btnLoadAllData.Size = new System.Drawing.Size(219, 38);
            this.btnLoadAllData.TabIndex = 31;
            this.btnLoadAllData.Text = "Load All Data";
            this.btnLoadAllData.UseVisualStyleBackColor = true;
            this.btnLoadAllData.Click += new System.EventHandler(this.btnLoadAllData_Click);
            // 
            // ShowStudentRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1787, 890);
            this.Controls.Add(this.btnLoadAllData);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.pnlShowStudentDetails);
            this.Name = "ShowStudentRecords";
            this.Text = "ShowStudentRecords";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ShowStudentRecords_Load);
            this.pnlShowStudentDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgStudentDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlShowStudentDetails;
        private System.Windows.Forms.DataGridView dgStudentDetails;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn skills;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualification;
        private System.Windows.Forms.DataGridViewTextBoxColumn year_of_passing;
        private System.Windows.Forms.DataGridViewTextBoxColumn mode_of_class;
        private System.Windows.Forms.DataGridViewTextBoxColumn pri_contact_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn another_contact_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailid;
        private System.Windows.Forms.DataGridViewTextBoxColumn isAdmitted;
        private System.Windows.Forms.DataGridViewTextBoxColumn work_experience;
        private System.Windows.Forms.DataGridViewTextBoxColumn year_of_exprience;
        private System.Windows.Forms.DataGridViewTextBoxColumn course;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_preference;
        private System.Windows.Forms.DataGridViewTextBoxColumn todayDate;
        private System.Windows.Forms.Button btnLoadAllData;

    }
}