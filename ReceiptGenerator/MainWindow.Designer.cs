namespace ReceiptGenerator
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbStudentDetails = new System.Windows.Forms.TabControl();
            this.tbAddStudentDetailsPage = new System.Windows.Forms.TabPage();
            this.grpStudentDetails = new System.Windows.Forms.GroupBox();
            this.lblTodaysDate = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lstPreference = new System.Windows.Forms.ListBox();
            this.lblTimePReference = new System.Windows.Forms.Label();
            this.grpMode = new System.Windows.Forms.GroupBox();
            this.rdoOffline = new System.Windows.Forms.RadioButton();
            this.rdoOnline = new System.Windows.Forms.RadioButton();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtYearOfPassing = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuanlification = new System.Windows.Forms.TextBox();
            this.lblQualification = new System.Windows.Forms.Label();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.lblReference = new System.Windows.Forms.Label();
            this.txtEmailID = new System.Windows.Forms.TextBox();
            this.lblEmailID = new System.Windows.Forms.Label();
            this.grpWorkExperience = new System.Windows.Forms.GroupBox();
            this.txtYearOfExperience = new System.Windows.Forms.TextBox();
            this.lblExperience = new System.Windows.Forms.Label();
            this.rdoWorkNo = new System.Windows.Forms.RadioButton();
            this.rdoWorkYes = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoRegistered = new System.Windows.Forms.RadioButton();
            this.rdoNo = new System.Windows.Forms.RadioButton();
            this.rdoYes = new System.Windows.Forms.RadioButton();
            this.txtSkills = new System.Windows.Forms.TextBox();
            this.lblSkills = new System.Windows.Forms.Label();
            this.txtAnotherContactNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrimaryContactNumber = new System.Windows.Forms.TextBox();
            this.lblPrimaryContactNumber = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.tbFeesPage = new System.Windows.Forms.TabPage();
            this.grpFees = new System.Windows.Forms.GroupBox();
            this.lblTodaysFeesDate = new System.Windows.Forms.Label();
            this.lblFeesDate = new System.Windows.Forms.Label();
            this.btnFeesReset = new System.Windows.Forms.Button();
            this.btnFeesSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoInstallment = new System.Windows.Forms.RadioButton();
            this.rdoOneTimeInstallment = new System.Windows.Forms.RadioButton();
            this.dtNextInstallment = new System.Windows.Forms.DateTimePicker();
            this.lblNextInstallment = new System.Windows.Forms.Label();
            this.txtRemainingFees = new System.Windows.Forms.TextBox();
            this.lblRemainingFees = new System.Windows.Forms.Label();
            this.txtPaidFees = new System.Windows.Forms.TextBox();
            this.lblFeesPaid = new System.Windows.Forms.Label();
            this.txtFees = new System.Windows.Forms.TextBox();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.txtFeesCourse = new System.Windows.Forms.TextBox();
            this.lblFeesCourse = new System.Windows.Forms.Label();
            this.btnFeesPaid = new System.Windows.Forms.Button();
            this.txtFeesFullName = new System.Windows.Forms.TextBox();
            this.lnlFeesFullName = new System.Windows.Forms.Label();
            this.tbGenerateReceipt = new System.Windows.Forms.TabPage();
            this.grpGenerateReceipt = new System.Windows.Forms.GroupBox();
            this.tbSeeRecords = new System.Windows.Forms.TabPage();
            this.btnStudentDetails = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tbStudentDetails.SuspendLayout();
            this.tbAddStudentDetailsPage.SuspendLayout();
            this.grpStudentDetails.SuspendLayout();
            this.grpMode.SuspendLayout();
            this.grpWorkExperience.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbFeesPage.SuspendLayout();
            this.grpFees.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tbGenerateReceipt.SuspendLayout();
            this.tbSeeRecords.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.tbStudentDetails);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1321, 946);
            this.panel1.TabIndex = 0;
            // 
            // tbStudentDetails
            // 
            this.tbStudentDetails.Controls.Add(this.tbAddStudentDetailsPage);
            this.tbStudentDetails.Controls.Add(this.tbFeesPage);
            this.tbStudentDetails.Controls.Add(this.tbGenerateReceipt);
            this.tbStudentDetails.Controls.Add(this.tbSeeRecords);
            this.tbStudentDetails.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStudentDetails.Location = new System.Drawing.Point(3, 12);
            this.tbStudentDetails.Name = "tbStudentDetails";
            this.tbStudentDetails.SelectedIndex = 0;
            this.tbStudentDetails.Size = new System.Drawing.Size(1306, 922);
            this.tbStudentDetails.TabIndex = 0;
            this.tbStudentDetails.SelectedIndexChanged += new System.EventHandler(this.tbStudentDetails_SelectedIndexChanged);
            // 
            // tbAddStudentDetailsPage
            // 
            this.tbAddStudentDetailsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.tbAddStudentDetailsPage.Controls.Add(this.grpStudentDetails);
            this.tbAddStudentDetailsPage.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddStudentDetailsPage.Location = new System.Drawing.Point(4, 42);
            this.tbAddStudentDetailsPage.Name = "tbAddStudentDetailsPage";
            this.tbAddStudentDetailsPage.Padding = new System.Windows.Forms.Padding(3);
            this.tbAddStudentDetailsPage.Size = new System.Drawing.Size(1298, 876);
            this.tbAddStudentDetailsPage.TabIndex = 0;
            this.tbAddStudentDetailsPage.Text = "Add Student Details";
            // 
            // grpStudentDetails
            // 
            this.grpStudentDetails.Controls.Add(this.lblTodaysDate);
            this.grpStudentDetails.Controls.Add(this.lblDate);
            this.grpStudentDetails.Controls.Add(this.txtID);
            this.grpStudentDetails.Controls.Add(this.lblId);
            this.grpStudentDetails.Controls.Add(this.lstPreference);
            this.grpStudentDetails.Controls.Add(this.lblTimePReference);
            this.grpStudentDetails.Controls.Add(this.grpMode);
            this.grpStudentDetails.Controls.Add(this.txtCourse);
            this.grpStudentDetails.Controls.Add(this.lblCourse);
            this.grpStudentDetails.Controls.Add(this.btnSearch);
            this.grpStudentDetails.Controls.Add(this.btnReset);
            this.grpStudentDetails.Controls.Add(this.btnSave);
            this.grpStudentDetails.Controls.Add(this.txtYearOfPassing);
            this.grpStudentDetails.Controls.Add(this.label2);
            this.grpStudentDetails.Controls.Add(this.txtQuanlification);
            this.grpStudentDetails.Controls.Add(this.lblQualification);
            this.grpStudentDetails.Controls.Add(this.txtReference);
            this.grpStudentDetails.Controls.Add(this.lblReference);
            this.grpStudentDetails.Controls.Add(this.txtEmailID);
            this.grpStudentDetails.Controls.Add(this.lblEmailID);
            this.grpStudentDetails.Controls.Add(this.grpWorkExperience);
            this.grpStudentDetails.Controls.Add(this.groupBox1);
            this.grpStudentDetails.Controls.Add(this.txtSkills);
            this.grpStudentDetails.Controls.Add(this.lblSkills);
            this.grpStudentDetails.Controls.Add(this.txtAnotherContactNumber);
            this.grpStudentDetails.Controls.Add(this.label1);
            this.grpStudentDetails.Controls.Add(this.txtPrimaryContactNumber);
            this.grpStudentDetails.Controls.Add(this.lblPrimaryContactNumber);
            this.grpStudentDetails.Controls.Add(this.txtAddress);
            this.grpStudentDetails.Controls.Add(this.lblAddress);
            this.grpStudentDetails.Controls.Add(this.txtFullName);
            this.grpStudentDetails.Controls.Add(this.lblFullName);
            this.grpStudentDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpStudentDetails.Location = new System.Drawing.Point(6, 6);
            this.grpStudentDetails.Name = "grpStudentDetails";
            this.grpStudentDetails.Size = new System.Drawing.Size(1486, 864);
            this.grpStudentDetails.TabIndex = 0;
            this.grpStudentDetails.TabStop = false;
            this.grpStudentDetails.Text = "Add Student Details";
            // 
            // lblTodaysDate
            // 
            this.lblTodaysDate.AutoSize = true;
            this.lblTodaysDate.Location = new System.Drawing.Point(216, 42);
            this.lblTodaysDate.Name = "lblTodaysDate";
            this.lblTodaysDate.Size = new System.Drawing.Size(0, 29);
            this.lblTodaysDate.TabIndex = 33;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(37, 42);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(61, 29);
            this.lblDate.TabIndex = 32;
            this.lblDate.Text = "Date";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(888, 35);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(290, 36);
            this.txtID.TabIndex = 31;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(603, 38);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(35, 29);
            this.lblId.TabIndex = 30;
            this.lblId.Text = "ID";
            // 
            // lstPreference
            // 
            this.lstPreference.FormattingEnabled = true;
            this.lstPreference.ItemHeight = 28;
            this.lstPreference.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Evening",
            "Night"});
            this.lstPreference.Location = new System.Drawing.Point(887, 686);
            this.lstPreference.Name = "lstPreference";
            this.lstPreference.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstPreference.Size = new System.Drawing.Size(291, 88);
            this.lstPreference.TabIndex = 29;
            // 
            // lblTimePReference
            // 
            this.lblTimePReference.AutoSize = true;
            this.lblTimePReference.Location = new System.Drawing.Point(603, 709);
            this.lblTimePReference.Name = "lblTimePReference";
            this.lblTimePReference.Size = new System.Drawing.Size(181, 29);
            this.lblTimePReference.TabIndex = 28;
            this.lblTimePReference.Text = "Time Preference";
            // 
            // grpMode
            // 
            this.grpMode.Controls.Add(this.rdoOffline);
            this.grpMode.Controls.Add(this.rdoOnline);
            this.grpMode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpMode.Location = new System.Drawing.Point(40, 731);
            this.grpMode.Name = "grpMode";
            this.grpMode.Size = new System.Drawing.Size(462, 100);
            this.grpMode.TabIndex = 27;
            this.grpMode.TabStop = false;
            this.grpMode.Text = "Mode Of Class";
            // 
            // rdoOffline
            // 
            this.rdoOffline.AutoSize = true;
            this.rdoOffline.Location = new System.Drawing.Point(202, 35);
            this.rdoOffline.Name = "rdoOffline";
            this.rdoOffline.Size = new System.Drawing.Size(103, 33);
            this.rdoOffline.TabIndex = 1;
            this.rdoOffline.TabStop = true;
            this.rdoOffline.Text = "Offline";
            this.rdoOffline.UseVisualStyleBackColor = true;
            // 
            // rdoOnline
            // 
            this.rdoOnline.AutoSize = true;
            this.rdoOnline.Location = new System.Drawing.Point(51, 36);
            this.rdoOnline.Name = "rdoOnline";
            this.rdoOnline.Size = new System.Drawing.Size(101, 33);
            this.rdoOnline.TabIndex = 0;
            this.rdoOnline.TabStop = true;
            this.rdoOnline.Text = "Online";
            this.rdoOnline.UseVisualStyleBackColor = true;
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(887, 624);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(290, 36);
            this.txtCourse.TabIndex = 26;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(603, 627);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(83, 29);
            this.lblCourse.TabIndex = 25;
            this.lblCourse.Text = "Course";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(332, 185);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(170, 63);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(703, 793);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(135, 43);
            this.btnReset.TabIndex = 23;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(1008, 793);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 43);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtYearOfPassing
            // 
            this.txtYearOfPassing.Location = new System.Drawing.Point(212, 663);
            this.txtYearOfPassing.Name = "txtYearOfPassing";
            this.txtYearOfPassing.Size = new System.Drawing.Size(290, 36);
            this.txtYearOfPassing.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 666);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "Year Of Passing";
            // 
            // txtQuanlification
            // 
            this.txtQuanlification.Location = new System.Drawing.Point(212, 604);
            this.txtQuanlification.Name = "txtQuanlification";
            this.txtQuanlification.Size = new System.Drawing.Size(290, 36);
            this.txtQuanlification.TabIndex = 19;
            // 
            // lblQualification
            // 
            this.lblQualification.AutoSize = true;
            this.lblQualification.Location = new System.Drawing.Point(35, 604);
            this.lblQualification.Name = "lblQualification";
            this.lblQualification.Size = new System.Drawing.Size(145, 29);
            this.lblQualification.TabIndex = 18;
            this.lblQualification.Text = "Qualification";
            // 
            // txtReference
            // 
            this.txtReference.Location = new System.Drawing.Point(212, 545);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(290, 36);
            this.txtReference.TabIndex = 17;
            // 
            // lblReference
            // 
            this.lblReference.AutoSize = true;
            this.lblReference.Location = new System.Drawing.Point(35, 545);
            this.lblReference.Name = "lblReference";
            this.lblReference.Size = new System.Drawing.Size(117, 29);
            this.lblReference.TabIndex = 16;
            this.lblReference.Text = "Reference";
            // 
            // txtEmailID
            // 
            this.txtEmailID.Location = new System.Drawing.Point(888, 238);
            this.txtEmailID.Name = "txtEmailID";
            this.txtEmailID.Size = new System.Drawing.Size(290, 36);
            this.txtEmailID.TabIndex = 15;
            // 
            // lblEmailID
            // 
            this.lblEmailID.AutoSize = true;
            this.lblEmailID.Location = new System.Drawing.Point(603, 241);
            this.lblEmailID.Name = "lblEmailID";
            this.lblEmailID.Size = new System.Drawing.Size(97, 29);
            this.lblEmailID.TabIndex = 14;
            this.lblEmailID.Text = "Email ID";
            // 
            // grpWorkExperience
            // 
            this.grpWorkExperience.Controls.Add(this.txtYearOfExperience);
            this.grpWorkExperience.Controls.Add(this.lblExperience);
            this.grpWorkExperience.Controls.Add(this.rdoWorkNo);
            this.grpWorkExperience.Controls.Add(this.rdoWorkYes);
            this.grpWorkExperience.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpWorkExperience.Location = new System.Drawing.Point(608, 433);
            this.grpWorkExperience.Name = "grpWorkExperience";
            this.grpWorkExperience.Size = new System.Drawing.Size(569, 167);
            this.grpWorkExperience.TabIndex = 11;
            this.grpWorkExperience.TabStop = false;
            this.grpWorkExperience.Text = "Work Experience";
            // 
            // txtYearOfExperience
            // 
            this.txtYearOfExperience.Location = new System.Drawing.Point(280, 101);
            this.txtYearOfExperience.Name = "txtYearOfExperience";
            this.txtYearOfExperience.Size = new System.Drawing.Size(179, 36);
            this.txtYearOfExperience.TabIndex = 17;
            this.txtYearOfExperience.Visible = false;
            // 
            // lblExperience
            // 
            this.lblExperience.AutoSize = true;
            this.lblExperience.Location = new System.Drawing.Point(55, 104);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(207, 29);
            this.lblExperience.TabIndex = 16;
            this.lblExperience.Text = "Year Of Experience";
            this.lblExperience.Visible = false;
            // 
            // rdoWorkNo
            // 
            this.rdoWorkNo.AutoSize = true;
            this.rdoWorkNo.Location = new System.Drawing.Point(355, 35);
            this.rdoWorkNo.Name = "rdoWorkNo";
            this.rdoWorkNo.Size = new System.Drawing.Size(63, 33);
            this.rdoWorkNo.TabIndex = 1;
            this.rdoWorkNo.TabStop = true;
            this.rdoWorkNo.Text = "No";
            this.rdoWorkNo.UseVisualStyleBackColor = true;
            this.rdoWorkNo.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdoWorkYes
            // 
            this.rdoWorkYes.AutoSize = true;
            this.rdoWorkYes.Location = new System.Drawing.Point(51, 36);
            this.rdoWorkYes.Name = "rdoWorkYes";
            this.rdoWorkYes.Size = new System.Drawing.Size(68, 33);
            this.rdoWorkYes.TabIndex = 0;
            this.rdoWorkYes.TabStop = true;
            this.rdoWorkYes.Text = "Yes";
            this.rdoWorkYes.UseVisualStyleBackColor = true;
            this.rdoWorkYes.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoRegistered);
            this.groupBox1.Controls.Add(this.rdoNo);
            this.groupBox1.Controls.Add(this.rdoYes);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(608, 313);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Is Admitted";
            // 
            // rdoRegistered
            // 
            this.rdoRegistered.AutoSize = true;
            this.rdoRegistered.Location = new System.Drawing.Point(346, 36);
            this.rdoRegistered.Name = "rdoRegistered";
            this.rdoRegistered.Size = new System.Drawing.Size(144, 33);
            this.rdoRegistered.TabIndex = 2;
            this.rdoRegistered.TabStop = true;
            this.rdoRegistered.Text = "Registered";
            this.rdoRegistered.UseVisualStyleBackColor = true;
            // 
            // rdoNo
            // 
            this.rdoNo.AutoSize = true;
            this.rdoNo.Location = new System.Drawing.Point(202, 35);
            this.rdoNo.Name = "rdoNo";
            this.rdoNo.Size = new System.Drawing.Size(63, 33);
            this.rdoNo.TabIndex = 1;
            this.rdoNo.TabStop = true;
            this.rdoNo.Text = "No";
            this.rdoNo.UseVisualStyleBackColor = true;
            // 
            // rdoYes
            // 
            this.rdoYes.AutoSize = true;
            this.rdoYes.Location = new System.Drawing.Point(51, 36);
            this.rdoYes.Name = "rdoYes";
            this.rdoYes.Size = new System.Drawing.Size(68, 33);
            this.rdoYes.TabIndex = 0;
            this.rdoYes.TabStop = true;
            this.rdoYes.Text = "Yes";
            this.rdoYes.UseVisualStyleBackColor = true;
            // 
            // txtSkills
            // 
            this.txtSkills.Location = new System.Drawing.Point(212, 411);
            this.txtSkills.Multiline = true;
            this.txtSkills.Name = "txtSkills";
            this.txtSkills.Size = new System.Drawing.Size(290, 113);
            this.txtSkills.TabIndex = 9;
            // 
            // lblSkills
            // 
            this.lblSkills.AutoSize = true;
            this.lblSkills.Location = new System.Drawing.Point(35, 411);
            this.lblSkills.Name = "lblSkills";
            this.lblSkills.Size = new System.Drawing.Size(66, 29);
            this.lblSkills.TabIndex = 8;
            this.lblSkills.Text = "Skills";
            // 
            // txtAnotherContactNumber
            // 
            this.txtAnotherContactNumber.Location = new System.Drawing.Point(888, 171);
            this.txtAnotherContactNumber.Name = "txtAnotherContactNumber";
            this.txtAnotherContactNumber.Size = new System.Drawing.Size(290, 36);
            this.txtAnotherContactNumber.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(601, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Another Contact Number";
            // 
            // txtPrimaryContactNumber
            // 
            this.txtPrimaryContactNumber.Location = new System.Drawing.Point(887, 103);
            this.txtPrimaryContactNumber.Name = "txtPrimaryContactNumber";
            this.txtPrimaryContactNumber.Size = new System.Drawing.Size(290, 36);
            this.txtPrimaryContactNumber.TabIndex = 5;
            // 
            // lblPrimaryContactNumber
            // 
            this.lblPrimaryContactNumber.AutoSize = true;
            this.lblPrimaryContactNumber.Location = new System.Drawing.Point(592, 106);
            this.lblPrimaryContactNumber.Name = "lblPrimaryContactNumber";
            this.lblPrimaryContactNumber.Size = new System.Drawing.Size(272, 29);
            this.lblPrimaryContactNumber.TabIndex = 4;
            this.lblPrimaryContactNumber.Text = " Primary Contact Number";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(212, 271);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(290, 117);
            this.txtAddress.TabIndex = 3;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(35, 271);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(95, 29);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address";
            // 
            // txtFullName
            // 
            this.txtFullName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtFullName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtFullName.Location = new System.Drawing.Point(212, 121);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(290, 36);
            this.txtFullName.TabIndex = 1;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(35, 121);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(115, 29);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Full Name";
            // 
            // tbFeesPage
            // 
            this.tbFeesPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.tbFeesPage.Controls.Add(this.grpFees);
            this.tbFeesPage.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFeesPage.Location = new System.Drawing.Point(4, 42);
            this.tbFeesPage.Name = "tbFeesPage";
            this.tbFeesPage.Padding = new System.Windows.Forms.Padding(3);
            this.tbFeesPage.Size = new System.Drawing.Size(1298, 876);
            this.tbFeesPage.TabIndex = 1;
            this.tbFeesPage.Text = "Fees";
            // 
            // grpFees
            // 
            this.grpFees.Controls.Add(this.lblTodaysFeesDate);
            this.grpFees.Controls.Add(this.lblFeesDate);
            this.grpFees.Controls.Add(this.btnFeesReset);
            this.grpFees.Controls.Add(this.btnFeesSave);
            this.grpFees.Controls.Add(this.groupBox2);
            this.grpFees.Controls.Add(this.dtNextInstallment);
            this.grpFees.Controls.Add(this.lblNextInstallment);
            this.grpFees.Controls.Add(this.txtRemainingFees);
            this.grpFees.Controls.Add(this.lblRemainingFees);
            this.grpFees.Controls.Add(this.txtPaidFees);
            this.grpFees.Controls.Add(this.lblFeesPaid);
            this.grpFees.Controls.Add(this.txtFees);
            this.grpFees.Controls.Add(this.lblTotalFees);
            this.grpFees.Controls.Add(this.txtFeesCourse);
            this.grpFees.Controls.Add(this.lblFeesCourse);
            this.grpFees.Controls.Add(this.btnFeesPaid);
            this.grpFees.Controls.Add(this.txtFeesFullName);
            this.grpFees.Controls.Add(this.lnlFeesFullName);
            this.grpFees.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpFees.Location = new System.Drawing.Point(19, 17);
            this.grpFees.Name = "grpFees";
            this.grpFees.Size = new System.Drawing.Size(1255, 792);
            this.grpFees.TabIndex = 0;
            this.grpFees.TabStop = false;
            this.grpFees.Text = "Fees";
            // 
            // lblTodaysFeesDate
            // 
            this.lblTodaysFeesDate.AutoSize = true;
            this.lblTodaysFeesDate.Location = new System.Drawing.Point(236, 43);
            this.lblTodaysFeesDate.Name = "lblTodaysFeesDate";
            this.lblTodaysFeesDate.Size = new System.Drawing.Size(0, 29);
            this.lblTodaysFeesDate.TabIndex = 42;
            // 
            // lblFeesDate
            // 
            this.lblFeesDate.AutoSize = true;
            this.lblFeesDate.Location = new System.Drawing.Point(40, 43);
            this.lblFeesDate.Name = "lblFeesDate";
            this.lblFeesDate.Size = new System.Drawing.Size(61, 29);
            this.lblFeesDate.TabIndex = 41;
            this.lblFeesDate.Text = "Date";
            // 
            // btnFeesReset
            // 
            this.btnFeesReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeesReset.Location = new System.Drawing.Point(660, 663);
            this.btnFeesReset.Name = "btnFeesReset";
            this.btnFeesReset.Size = new System.Drawing.Size(170, 63);
            this.btnFeesReset.TabIndex = 40;
            this.btnFeesReset.Text = "Reset";
            this.btnFeesReset.UseVisualStyleBackColor = true;
            // 
            // btnFeesSave
            // 
            this.btnFeesSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeesSave.Location = new System.Drawing.Point(965, 663);
            this.btnFeesSave.Name = "btnFeesSave";
            this.btnFeesSave.Size = new System.Drawing.Size(170, 63);
            this.btnFeesSave.TabIndex = 39;
            this.btnFeesSave.Text = "Save";
            this.btnFeesSave.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoInstallment);
            this.groupBox2.Controls.Add(this.rdoOneTimeInstallment);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(646, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 100);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Installment";
            // 
            // rdoInstallment
            // 
            this.rdoInstallment.AutoSize = true;
            this.rdoInstallment.Location = new System.Drawing.Point(229, 35);
            this.rdoInstallment.Name = "rdoInstallment";
            this.rdoInstallment.Size = new System.Drawing.Size(151, 33);
            this.rdoInstallment.TabIndex = 1;
            this.rdoInstallment.TabStop = true;
            this.rdoInstallment.Text = "Installment";
            this.rdoInstallment.UseVisualStyleBackColor = true;
            this.rdoInstallment.CheckedChanged += new System.EventHandler(this.rdoInstallment_CheckedChanged);
            // 
            // rdoOneTimeInstallment
            // 
            this.rdoOneTimeInstallment.AutoSize = true;
            this.rdoOneTimeInstallment.Location = new System.Drawing.Point(51, 36);
            this.rdoOneTimeInstallment.Name = "rdoOneTimeInstallment";
            this.rdoOneTimeInstallment.Size = new System.Drawing.Size(132, 33);
            this.rdoOneTimeInstallment.TabIndex = 0;
            this.rdoOneTimeInstallment.TabStop = true;
            this.rdoOneTimeInstallment.Text = "One Time";
            this.rdoOneTimeInstallment.UseVisualStyleBackColor = true;
            this.rdoOneTimeInstallment.CheckedChanged += new System.EventHandler(this.rdoOneTimeInstallment_CheckedChanged);
            // 
            // dtNextInstallment
            // 
            this.dtNextInstallment.Location = new System.Drawing.Point(241, 455);
            this.dtNextInstallment.Name = "dtNextInstallment";
            this.dtNextInstallment.Size = new System.Drawing.Size(290, 36);
            this.dtNextInstallment.TabIndex = 37;
            this.dtNextInstallment.Visible = false;
            // 
            // lblNextInstallment
            // 
            this.lblNextInstallment.AutoSize = true;
            this.lblNextInstallment.Location = new System.Drawing.Point(40, 455);
            this.lblNextInstallment.Name = "lblNextInstallment";
            this.lblNextInstallment.Size = new System.Drawing.Size(184, 29);
            this.lblNextInstallment.TabIndex = 36;
            this.lblNextInstallment.Text = "Next Installment";
            this.lblNextInstallment.Visible = false;
            // 
            // txtRemainingFees
            // 
            this.txtRemainingFees.Location = new System.Drawing.Point(848, 456);
            this.txtRemainingFees.Name = "txtRemainingFees";
            this.txtRemainingFees.ReadOnly = true;
            this.txtRemainingFees.Size = new System.Drawing.Size(290, 36);
            this.txtRemainingFees.TabIndex = 35;
            this.txtRemainingFees.Visible = false;
            // 
            // lblRemainingFees
            // 
            this.lblRemainingFees.AutoSize = true;
            this.lblRemainingFees.Location = new System.Drawing.Point(641, 456);
            this.lblRemainingFees.Name = "lblRemainingFees";
            this.lblRemainingFees.Size = new System.Drawing.Size(173, 29);
            this.lblRemainingFees.TabIndex = 34;
            this.lblRemainingFees.Text = "Remaining Fees";
            this.lblRemainingFees.Visible = false;
            // 
            // txtPaidFees
            // 
            this.txtPaidFees.Location = new System.Drawing.Point(845, 323);
            this.txtPaidFees.Name = "txtPaidFees";
            this.txtPaidFees.Size = new System.Drawing.Size(290, 36);
            this.txtPaidFees.TabIndex = 33;
            // 
            // lblFeesPaid
            // 
            this.lblFeesPaid.AutoSize = true;
            this.lblFeesPaid.Location = new System.Drawing.Point(641, 323);
            this.lblFeesPaid.Name = "lblFeesPaid";
            this.lblFeesPaid.Size = new System.Drawing.Size(108, 29);
            this.lblFeesPaid.TabIndex = 32;
            this.lblFeesPaid.Text = "Paid Fees";
            // 
            // txtFees
            // 
            this.txtFees.Location = new System.Drawing.Point(241, 323);
            this.txtFees.Name = "txtFees";
            this.txtFees.Size = new System.Drawing.Size(290, 36);
            this.txtFees.TabIndex = 31;
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Location = new System.Drawing.Point(40, 323);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(116, 29);
            this.lblTotalFees.TabIndex = 30;
            this.lblTotalFees.Text = "Total Fees";
            // 
            // txtFeesCourse
            // 
            this.txtFeesCourse.Location = new System.Drawing.Point(845, 63);
            this.txtFeesCourse.Name = "txtFeesCourse";
            this.txtFeesCourse.Size = new System.Drawing.Size(290, 36);
            this.txtFeesCourse.TabIndex = 29;
            // 
            // lblFeesCourse
            // 
            this.lblFeesCourse.AutoSize = true;
            this.lblFeesCourse.Location = new System.Drawing.Point(641, 63);
            this.lblFeesCourse.Name = "lblFeesCourse";
            this.lblFeesCourse.Size = new System.Drawing.Size(83, 29);
            this.lblFeesCourse.TabIndex = 28;
            this.lblFeesCourse.Text = "Course";
            // 
            // btnFeesPaid
            // 
            this.btnFeesPaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeesPaid.Location = new System.Drawing.Point(361, 192);
            this.btnFeesPaid.Name = "btnFeesPaid";
            this.btnFeesPaid.Size = new System.Drawing.Size(170, 63);
            this.btnFeesPaid.TabIndex = 27;
            this.btnFeesPaid.Text = "Search";
            this.btnFeesPaid.UseVisualStyleBackColor = true;
            // 
            // txtFeesFullName
            // 
            this.txtFeesFullName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtFeesFullName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtFeesFullName.Location = new System.Drawing.Point(241, 128);
            this.txtFeesFullName.Name = "txtFeesFullName";
            this.txtFeesFullName.Size = new System.Drawing.Size(290, 36);
            this.txtFeesFullName.TabIndex = 26;
            // 
            // lnlFeesFullName
            // 
            this.lnlFeesFullName.AutoSize = true;
            this.lnlFeesFullName.Location = new System.Drawing.Point(40, 128);
            this.lnlFeesFullName.Name = "lnlFeesFullName";
            this.lnlFeesFullName.Size = new System.Drawing.Size(115, 29);
            this.lnlFeesFullName.TabIndex = 25;
            this.lnlFeesFullName.Text = "Full Name";
            // 
            // tbGenerateReceipt
            // 
            this.tbGenerateReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.tbGenerateReceipt.Controls.Add(this.grpGenerateReceipt);
            this.tbGenerateReceipt.Location = new System.Drawing.Point(4, 42);
            this.tbGenerateReceipt.Name = "tbGenerateReceipt";
            this.tbGenerateReceipt.Padding = new System.Windows.Forms.Padding(3);
            this.tbGenerateReceipt.Size = new System.Drawing.Size(1298, 876);
            this.tbGenerateReceipt.TabIndex = 2;
            this.tbGenerateReceipt.Text = "Generate Receipt";
            // 
            // grpGenerateReceipt
            // 
            this.grpGenerateReceipt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpGenerateReceipt.Location = new System.Drawing.Point(6, 22);
            this.grpGenerateReceipt.Name = "grpGenerateReceipt";
            this.grpGenerateReceipt.Size = new System.Drawing.Size(1275, 830);
            this.grpGenerateReceipt.TabIndex = 0;
            this.grpGenerateReceipt.TabStop = false;
            this.grpGenerateReceipt.Text = "Generate Receipt";
            // 
            // tbSeeRecords
            // 
            this.tbSeeRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.tbSeeRecords.Controls.Add(this.btnStudentDetails);
            this.tbSeeRecords.Location = new System.Drawing.Point(4, 42);
            this.tbSeeRecords.Name = "tbSeeRecords";
            this.tbSeeRecords.Size = new System.Drawing.Size(1298, 876);
            this.tbSeeRecords.TabIndex = 3;
            this.tbSeeRecords.Text = "See Records";
            this.tbSeeRecords.Click += new System.EventHandler(this.tbSeeRecords_Click);
            // 
            // btnStudentDetails
            // 
            this.btnStudentDetails.FlatAppearance.BorderSize = 2;
            this.btnStudentDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStudentDetails.Location = new System.Drawing.Point(37, 57);
            this.btnStudentDetails.Name = "btnStudentDetails";
            this.btnStudentDetails.Size = new System.Drawing.Size(387, 80);
            this.btnStudentDetails.TabIndex = 0;
            this.btnStudentDetails.Text = "Show Student Details";
            this.btnStudentDetails.UseVisualStyleBackColor = true;
            this.btnStudentDetails.Click += new System.EventHandler(this.btnStudentDetails_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1321, 946);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gamaka AI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel1.ResumeLayout(false);
            this.tbStudentDetails.ResumeLayout(false);
            this.tbAddStudentDetailsPage.ResumeLayout(false);
            this.grpStudentDetails.ResumeLayout(false);
            this.grpStudentDetails.PerformLayout();
            this.grpMode.ResumeLayout(false);
            this.grpMode.PerformLayout();
            this.grpWorkExperience.ResumeLayout(false);
            this.grpWorkExperience.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbFeesPage.ResumeLayout(false);
            this.grpFees.ResumeLayout(false);
            this.grpFees.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tbGenerateReceipt.ResumeLayout(false);
            this.tbSeeRecords.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tbStudentDetails;
        private System.Windows.Forms.TabPage tbAddStudentDetailsPage;
        private System.Windows.Forms.TabPage tbFeesPage;
        private System.Windows.Forms.TabPage tbGenerateReceipt;
        private System.Windows.Forms.TabPage tbSeeRecords;
        private System.Windows.Forms.GroupBox grpStudentDetails;
        private System.Windows.Forms.TextBox txtSkills;
        private System.Windows.Forms.Label lblSkills;
        private System.Windows.Forms.TextBox txtAnotherContactNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrimaryContactNumber;
        private System.Windows.Forms.Label lblPrimaryContactNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoRegistered;
        private System.Windows.Forms.RadioButton rdoNo;
        private System.Windows.Forms.RadioButton rdoYes;
        private System.Windows.Forms.TextBox txtEmailID;
        private System.Windows.Forms.Label lblEmailID;
        private System.Windows.Forms.GroupBox grpWorkExperience;
        private System.Windows.Forms.RadioButton rdoWorkNo;
        private System.Windows.Forms.RadioButton rdoWorkYes;
        private System.Windows.Forms.TextBox txtReference;
        private System.Windows.Forms.Label lblReference;
        private System.Windows.Forms.TextBox txtYearOfExperience;
        private System.Windows.Forms.Label lblExperience;
        private System.Windows.Forms.TextBox txtYearOfPassing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuanlification;
        private System.Windows.Forms.Label lblQualification;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.GroupBox grpFees;
        private System.Windows.Forms.Button btnFeesPaid;
        private System.Windows.Forms.TextBox txtFeesFullName;
        private System.Windows.Forms.Label lnlFeesFullName;
        private System.Windows.Forms.TextBox txtFeesCourse;
        private System.Windows.Forms.Label lblFeesCourse;
        private System.Windows.Forms.TextBox txtRemainingFees;
        private System.Windows.Forms.Label lblRemainingFees;
        private System.Windows.Forms.TextBox txtPaidFees;
        private System.Windows.Forms.Label lblFeesPaid;
        private System.Windows.Forms.TextBox txtFees;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoInstallment;
        private System.Windows.Forms.RadioButton rdoOneTimeInstallment;
        private System.Windows.Forms.DateTimePicker dtNextInstallment;
        private System.Windows.Forms.Label lblNextInstallment;
        private System.Windows.Forms.Button btnFeesReset;
        private System.Windows.Forms.Button btnFeesSave;
        private System.Windows.Forms.GroupBox grpGenerateReceipt;
        private System.Windows.Forms.GroupBox grpMode;
        private System.Windows.Forms.RadioButton rdoOffline;
        private System.Windows.Forms.RadioButton rdoOnline;
        private System.Windows.Forms.Label lblTimePReference;
        private System.Windows.Forms.ListBox lstPreference;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTodaysDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblFeesDate;
        private System.Windows.Forms.Label lblTodaysFeesDate;
        private System.Windows.Forms.Button btnStudentDetails;

    }
}