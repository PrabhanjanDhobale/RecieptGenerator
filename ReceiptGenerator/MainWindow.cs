using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Threading;


namespace ReceiptGenerator
{
  
    public partial class MainWindow : Form
    {
        
        DB db;
        long id;

        public void t_Tick(object sender, EventArgs e){
            lblTodaysDate.Text = lblTodaysFeesDate.Text = DateTime.Now.ToString();
        }

        public MainWindow()
        {
            InitializeComponent();
            this.db = new DB();
            this.id = this.db.generateID();

            loadCourseData();


            cmbCourses.Text = "Select";
            cmbFeesCourse.Text = "Select";
            foreach (String cr in this.db.getAllCourses()) {
                cmbCourses.Items.Add(cr);
                cmbFeesCourse.Items.Add(cr);
            }

            AutoCompleteStringCollection namecollections = this.db.namesofStudents();
            txtFullName.AutoCompleteCustomSource = namecollections;
            txtFeesFullName.AutoCompleteCustomSource = namecollections;
            

            txtID.Text = this.id.ToString();

            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(t_Tick);
            t.Enabled = true;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            lblExperience.Visible = true;
            txtYearOfExperience.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lblExperience.Visible = false;
            txtYearOfExperience.Visible = false;
        }

        private void rdoOneTimeInstallment_CheckedChanged(object sender, EventArgs e)
        {
            lblNextInstallment.Visible = false;
            dtNextInstallment.Visible = false;
            lblRemainingFees.Visible = false;
            txtRemainingFees.Visible = false;
        }

        private void rdoInstallment_CheckedChanged(object sender, EventArgs e)
        {
            lblTotalFees.Visible = true;
            txtFees.Visible = true;
            lblFeesPaid.Visible = true;
            txtPaidFees.Visible = true;
            lblNextInstallment.Visible = true;
            dtNextInstallment.Visible = true;
            lblRemainingFees.Visible = true;
            txtRemainingFees.Visible = true;
        }

        public void resetWindow() {
            txtFullName.Text = "";
            txtAddress.Text = "";
            txtSkills.Text = "";
            txtReference.Text = "";
            txtQuanlification.Text = "";
            txtYearOfPassing.Text = "";
            txtPrimaryContactNumber.Text = "";
            txtAnotherContactNumber.Text = "";
            txtEmailID.Text = "";
            cmbCourses.Text = "Select";
            rdoInstallment.Checked = false;
            rdoNo.Checked = false;
            rdoOffline.Checked = false;
            rdoRegistered.Checked = false;
            rdoWorkYes.Checked = false;
            rdoWorkNo.Checked = false;
            rdoYes.Checked = false;
            rdoNo.Checked = false;
            txtYearOfExperience.Text = "";
            lstPreference.ClearSelected();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fullname = txtFullName.Text;
            string address = txtAddress.Text;
            string skills = txtSkills.Text;
            string reference = txtReference.Text;
            string qualification = txtQuanlification.Text;
            string yearofpassing = txtYearOfPassing.Text;
            string mode = "";
            if (rdoOffline.Checked)
            {
                mode = rdoOffline.Text;
            }
            else {
                mode = rdoOnline.Text;
            }
            string primary_contact_number = txtPrimaryContactNumber.Text;
            string alternate_contact_number = txtAnotherContactNumber.Text;
            string email = txtEmailID.Text;
            string isAdmitted = "";

            if (rdoYes.Checked) {
                isAdmitted = rdoYes.Text;
            }
            else if (rdoNo.Checked)
            {
                isAdmitted = rdoNo.Text;
            }
            else {
                isAdmitted = rdoRegistered.Text;
            }

            string workExperience = "";
            string year_of_experience = "";

            if (rdoWorkYes.Checked) {
                workExperience = rdoWorkYes.Text;
                year_of_experience = txtYearOfExperience.Text;
            }
            else {
                workExperience = rdoWorkNo.Text;
            }

            string course = cmbCourses.Text;
            string timePreference = "";
            foreach (Object obj in lstPreference.SelectedItems) {
                timePreference += obj.ToString() + ",";
            }

            if (fullname.Equals("") || fullname.Equals(" ")) {
                MessageBox.Show("Please enter fullname.");
                return;
            }
            else if (address.Equals("") || address.Equals(" ")) {
                MessageBox.Show("Please enter address.");
                return;
            }
            else if (skills.Equals("") || skills.Equals(" "))
            {
                MessageBox.Show("Enter skills.");
                return;
            }
            else if (reference.Equals("") || reference.Equals(" ")) {
                MessageBox.Show("Enter References");
                return;
            }
            else if (qualification.Equals("") || qualification.Equals(" ")) {
                MessageBox.Show("Enter Qualification.");
                return;
            }
            else if (yearofpassing.Equals("") || yearofpassing.Equals(" ")) {
                MessageBox.Show("Enter year of passing.");
                return;
            } else if(mode.Equals("") || mode.Equals(" ")) {
                MessageBox.Show("Enter mode of class.");
                return;
            }
            else if (primary_contact_number.Equals("") || primary_contact_number.Equals(" "))
            {
                MessageBox.Show("Enter Contact Number.");
                return;
            }
            else if (email.Equals("") || email.Equals(" "))
            {
                MessageBox.Show("Enter Contact Number.");
                return;
            }
            else if (isAdmitted.Equals("") || isAdmitted.Equals(" ")) {
                MessageBox.Show("Select Addmission is done or not.");
                return;
            }else if(workExperience.Equals("") || workExperience.Equals(" ")){
                MessageBox.Show("Select Work Experience");
                return;
            }
            else if (course.Equals("Select")) {
                MessageBox.Show("Select Course");
                return;
            }
            else if (timePreference.Equals("") || timePreference.Equals(" "))
            {
                MessageBox.Show("Select Time Preference");
                return;
            }
            else {
                ArrayList studentData = new ArrayList();

                studentData.Add(this.id);
                studentData.Add(fullname);
                studentData.Add(address);
                studentData.Add(skills);
                studentData.Add(reference);
                studentData.Add(qualification);
                studentData.Add(yearofpassing);
                studentData.Add(mode);
                studentData.Add(primary_contact_number);
                studentData.Add(alternate_contact_number);
                studentData.Add(email);
                studentData.Add(isAdmitted);
                studentData.Add(workExperience);
                studentData.Add(year_of_experience);
                studentData.Add(course);
                studentData.Add(timePreference);
                studentData.Add(lblTodaysDate.Text);

                if (this.db.insertintoStudentDetails(studentData))
                {
                    MessageBox.Show("Data Inserted Successfully");
                    resetWindow();
                }
                else
                {
                    MessageBox.Show("ERROR: Data not inserted");
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetWindow();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void btnStudentDetails_Click(object sender, EventArgs e)
        {
            new ShowStudentRecords().ShowDialog();
        }

        private void tbStudentDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbSeeRecords_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = this.db.getSpecificRow(txtFullName.Text);
            if (dt != null) {
                foreach (DataRow dr in dt.Rows) {
                    txtID.Text = dr[0].ToString();
                    txtFullName.Text = dr[1].ToString();
                    txtAddress.Text = dr[2].ToString();
                    txtSkills.Text = dr[3].ToString();
                    txtReference.Text = dr[4].ToString();
                    txtQuanlification.Text = dr[5].ToString();
                    txtYearOfPassing.Text = dr[6].ToString();
                    if (dr[7].ToString() == "Online")
                    {
                        rdoOnline.Checked = true;
                    }
                    else
                    {
                        rdoOffline.Checked = true;
                    }
                    txtPrimaryContactNumber.Text = dr[8].ToString();
                    txtAnotherContactNumber.Text = dr[9].ToString();
                    txtEmailID.Text = dr[10].ToString();
                    if(dr[11].ToString() == "Yes")
                        rdoYes.Checked = true;
                    else if(dr[11].ToString() == "No")
                        rdoNo.Checked = true;
                    else
                        rdoRegistered.Checked = true;

                    if(dr[12].ToString() == "Yes"){
                        rdoWorkYes.Checked = true;
                        txtYearOfExperience.Text += dr[13].ToString();                        
                    }
                    else
                        rdoWorkNo.Checked = true;

                    cmbCourses.Text = dr[14].ToString();
                    
                    

                    rdoInstallment.Checked = false;
                    rdoOffline.Checked = false;
                    rdoRegistered.Checked = false;
                    
                    
                    
                    rdoNo.Checked = false;
                    txtYearOfExperience.Text = "";
                    lstPreference.ClearSelected();
                }
            }
        }

        private void btnFeesSave_Click(object sender, EventArgs e)
        {
            String date = lblFeesDate.Text;
            //long id = this.db.getSpecificRow(txtFeesFullName.Text);
            String course = cmbFeesCourse.Text;

        }

        public void resetCourseDetails() {
            txtCourseName.Text = "";
            txtCourseFees.Text = "";
        }

        public void loadCourseData()
        {

            dgCourseDetails.Rows.Clear();
            dgCourseDetails.Refresh();
            DataTable dt = this.db.getAllCourseDetails();
            foreach (DataRow dr in dt.Rows)
            {
                dgCourseDetails.Rows.Add(dr[0], dr[1], dr[2]);
            }
        }

        private void btnSaveCourseDetails_Click(object sender, EventArgs e)
        {
            String name = txtCourseName.Text;
            String fees = txtCourseFees.Text;

            if (name.Equals("") || name.Equals(" ")) {
                MessageBox.Show("Enter Course Name");
                return;
            }
            else if (fees.Equals("") || fees.Equals(" "))
            {
                MessageBox.Show("PLease Enter Course Fees");
                return;
            }
            else {
                if (this.db.insertCourseDetails(name, Convert.ToInt32(fees))) {
                    MessageBox.Show("Data Inserted Successfully");
                    resetCourseDetails();
                    loadCourseData();
                }
            }
        }

        private void btnResetFeesDetails_Click(object sender, EventArgs e)
        {
            resetCourseDetails();
        }

        private void dgCourseDetails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                long id = Convert.ToInt32(dgCourseDetails.Rows[e.RowIndex].Cells["courseid"].Value.ToString());
                ArrayList courseDetail = new ArrayList();

                courseDetail.Add(id);
                courseDetail.Add(dgCourseDetails.Rows[e.RowIndex].Cells["course_name"].Value.ToString());
                courseDetail.Add(Convert.ToInt32(dgCourseDetails.Rows[e.RowIndex].Cells["course_fees"].Value.ToString()));

               
                this.db.updateCourseDetails(courseDetail);
            }
        }

        private void btnFeesReset_Click(object sender, EventArgs e)
        {

        }

        
    }
}
