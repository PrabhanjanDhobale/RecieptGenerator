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

        public void loadCourses() {
            cmbCourses.Text = "Select";
            cmbFeesCourse.Items.Add("Select");
            foreach (String cr in this.db.getAllCourses())
            {
                if (!cmbCourses.Items.Contains(cr))
                {
                    cmbCourses.Items.Add(cr);
                    cmbFeesCourse.Items.Add(cr);
                }
            }
        }

        public void autoIntell() {
            AutoCompleteStringCollection namecollections = this.db.namesofStudents();
            txtFullName.AutoCompleteCustomSource = namecollections;
            txtFeesFullName.AutoCompleteCustomSource = namecollections;
            txtFullNameGen.AutoCompleteCustomSource = namecollections;
        }

        ArrayList data = new ArrayList();
        public ArrayList getOtherDetails(String sid, String cid) {
            
            String name = this.db.getSpecificNameById(Convert.ToInt64(sid));
            String course = this.db.getSpecificCourseByID(Convert.ToInt32(cid));
            data.Clear();
            Console.WriteLine(course);
            data.Add(name);
            data.Add(course);
            return data;
        }

        public void loadPaymentDetails() {
            dgGenerateReciept.Rows.Clear();
            dgGenerateReciept.Refresh();
            DataTable dt = this.db.getPaymentData();
            ArrayList data = new ArrayList();

            dgGenerateReciept.ForeColor = System.Drawing.Color.Black;
            foreach (DataRow dr in dt.Rows)
            {
                data = this.getOtherDetails(dr[1].ToString(), dr[2].ToString());

                dgGenerateReciept.Rows.Add(dr[0].ToString(), data[0].ToString(), data[1].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            
        }

        public MainWindow()
        {
            InitializeComponent();
            this.db = new DB();
            this.id = this.db.generateID();

            loadCourseData();

            loadPaymentDetails();

            loadCourses();

            autoIntell();
            
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
            rdofirstInstallment.Checked = false;
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

                int courseID = 0;
                ArrayList payment = new ArrayList();
                if (isAdmitted.Equals("Registered")) {
                    ArrayList cou = this.db.getSpecificCourseDetail(cmbCourses.Text);
                    courseID = Convert.ToInt32(cou[0].ToString());
                    int fees = Convert.ToInt32(cou[2].ToString());

                    payment.Add(id);
                    payment.Add(courseID);
                    payment.Add(isAdmitted);
                    payment.Add(fees);
                    payment.Add(500);
                    payment.Add(lblTodaysDate.Text);

                }

                if (this.db.insertintoStudentDetails(studentData))
                {
                    MessageBox.Show("Data Inserted Successfully");
                    if (this.db.insertPaymentDetails(payment))
                    {
                        MessageBox.Show("Payment Updated You can download receipt.");

                    }
                    resetWindow();
                    autoIntell();
                    txtID.Text = this.db.generateID().ToString();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = this.db.getSpecificRow(txtFullName.Text);
            if (dt != null)
            {
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("Data does not exist.");
                    return;
                }
                foreach (DataRow dr in dt.Rows)
                {
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
                    if (dr[11].ToString() == "Yes")
                        rdoYes.Checked = true;
                    else if (dr[11].ToString() == "No")
                        rdoNo.Checked = true;
                    else
                        rdoRegistered.Checked = true;

                    if (dr[12].ToString() == "Yes")
                    {
                        rdoWorkYes.Checked = true;
                        txtYearOfExperience.Text += dr[13].ToString();
                    }
                    else
                        rdoWorkNo.Checked = true;

                    cmbCourses.Text = dr[14].ToString();



                    rdofirstInstallment.Checked = false;
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
            
            String date = lblTodaysFeesDate.Text;
            long id=0;
            int courseID = 0;
            DataTable dt = this.db.getSpecificRow(txtFeesFullName.Text);
            DataTable dc = this.db.getAllCourseDetails();

            if(dc != null) {
                if(dc.Rows.Count <= 0){
                    MessageBox.Show("Course Data does not exist.");
                    return;
                }
                courseID = Convert.ToInt32(dc.Rows[0][0].ToString());
            }

            if (dt != null)
            {
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("Student Data does not exist.");
                    return;
                }
                id = Convert.ToInt64(dt.Rows[0][0].ToString());
               
            }
            String course = cmbFeesCourse.Text;



            if (course.Equals("Select"))
            {
                MessageBox.Show("Please Select Course.");
                return;
            }
            else if (txtFeesFullName.Text.Equals("") || txtFeesFullName.Text.Equals(" ")) {
                MessageBox.Show("Please enter Full Name.");
                return;
            }
            else if (txtPaidFees.Text.Equals("") || txtPaidFees.Text.Equals(" ")) {
                MessageBox.Show("Please enter Paid Fees.");
                return;
            }
            else if (!rdofirstInstallment.Checked && !rdoOneTimeInstallment.Checked && !rdoSecondInstallment.Checked)
            {
                MessageBox.Show("Please Select Installment Type.");
                return;
            }
            else {
                String name;
                int fees;
                int paidfees;
                String installment;

                ArrayList payment = new ArrayList(); 

                //if (rdoOneTimeInstallment.Checked) {
                    name = txtFeesFullName.Text;
                    fees = Convert.ToInt32(txtFees.Text);
                    paidfees = Convert.ToInt32(txtPaidFees.Text);

                    if (rdoOneTimeInstallment.Checked)
                        installment = "One Time";
                    else if (rdoSecondInstallment.Checked)
                        installment = "2nd Installment";
                    else
                        installment = "1st Installment";

                    payment.Add(id);
                    payment.Add(courseID);
                    payment.Add(installment);
                    payment.Add(fees);
                    payment.Add(paidfees);
                    payment.Add(date);
                    
                   
                    if (this.db.insertPaymentDetails(payment))
                    {
                        MessageBox.Show("Payment Updated You can download receipt.");
                        this.loadPaymentDetails();
                        this.resetPaymentWindow();
                        return;
                    }
               // }else if()
            }

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
                    loadCourses();
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
            this.resetPaymentWindow();
        }

       

        private void btnStudentDetails_Click_1(object sender, EventArgs e)
        {
            new ShowStudentRecords().ShowDialog();
        }

        private void cmbFeesCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cmbFeesCourse.Text.Equals("Select"))
            {
                ArrayList course = this.db.getSpecificCourseDetail(cmbFeesCourse.Text);
                txtFees.Text = course[2].ToString();
            }
            else
            {
                if(r==0)
                    MessageBox.Show("Please Select Course");
            }
        }


        private void txtPaidFees_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPaidFees.Text.Trim().ToString()))
            {
                int remeainigfees = 0;
                if (Convert.ToInt32(temp) > 0)
                {
                    remeainigfees = Convert.ToInt32(temp) - Convert.ToInt32(txtPaidFees.Text);
                }
                else {
                    remeainigfees = Convert.ToInt32(txtFees.Text) - Convert.ToInt32(txtPaidFees.Text);
                }
                
                txtRemainingFees.Text = remeainigfees.ToString();
            }
            else {
                if (Convert.ToInt32(temp) > 0)
                {
                    txtRemainingFees.Text = temp.ToString();
                }
                else {
                    txtRemainingFees.Text = txtFees.Text;
                }
            }
            
        }
        long id_for_fees = 0;
        String temp = "";
        private void btnFeesPaid_Click_1(object sender, EventArgs e)
        {
             DataTable dt = this.db.getSpecificRow(txtFeesFullName.Text);

             if (dt.Rows.Count <= 0) {
                 MessageBox.Show("Data not Exist");
                 return;
             }

             if (dt != null)
             {
                 
                 this.id_for_fees = Convert.ToInt64(dt.Rows[0][0].ToString());
                 if (dt.Rows.Count <= 0)
                 {
                     MessageBox.Show("Data does not exist.");
                     return;
                 }
                 foreach (DataRow dr in dt.Rows)
                 {
                     cmbFeesCourse.Text = dr[14].ToString();
                     txtRemainingFees.Text = temp.ToString();
                 }
             }

             
             if (!rdoOneTimeInstallment.Checked) {
                 txtRemainingFees.Text = this.db.getPaymentDetailsbyId(Convert.ToInt64(dt.Rows[0][0].ToString())).ToString();
             }

             temp = txtRemainingFees.Text;
        }

        private void rdoOneTimeInstallment_CheckedChanged(object sender, EventArgs e)
        {
            txtPaidFees.Text = txtFees.Text;
            txtRemainingFees.Text = (Convert.ToInt32(txtFees.Text) - Convert.ToInt32(txtPaidFees.Text)).ToString();
        }

        int r = 0;
        public void resetPaymentWindow() {
            txtRemainingFees.Text = "";
            txtPaidFees.Text = "";
            txtFeesFullName.Text = "";
            cmbFeesCourse.Text = "select";
            rdoOneTimeInstallment.Checked = false;
            rdofirstInstallment.Checked = false;
            rdoSecondInstallment.Checked = false;
            txtPaidFees.Text = "";
            txtFees.Text = "";
            temp = "";

            r = 1;
        }

        private void rdofirstInstallment_CheckedChanged(object sender, EventArgs e)
        {
            txtRemainingFees.Text = "";
            
            String fees = this.db.getPaymentDetailsbyId(id_for_fees).ToString();
            txtRemainingFees.Text = fees;
            txtPaidFees.Text = "";
        }

        private void rdoSecondInstallment_CheckedChanged(object sender, EventArgs e)
        {
            txtRemainingFees.Text = "";
            txtRemainingFees.Text = this.db.getPaymentDetailsbyId(id_for_fees).ToString();
            txtPaidFees.Text = "";
        }

        private void btnSearchGen_Click(object sender, EventArgs e)
        {
            dgGenerateReciept.Rows.Clear();
            dgGenerateReciept.Refresh();
            DataTable stu = this.db.getSpecificRow(txtFullNameGen.Text);
            if (stu.Rows.Count <= 0) {
                MessageBox.Show("Student Data not exist");
                return;
            }
            DataTable dt = this.db.getSpecificPaymentDetails(Convert.ToInt64(stu.Rows[0][0].ToString()));

            if (dt.Rows.Count <= 0) {
                MessageBox.Show("Data not Found");
                return;
            }
            ArrayList data = new ArrayList();

            //dgGenerateReciept.ForeColor = System.Drawing.Color.Black;
            foreach (DataRow dr in dt.Rows)
            {
                data = this.getOtherDetails(dr[1].ToString(), dr[2].ToString());

                dgGenerateReciept.Rows.Add(dr[0].ToString(), data[0].ToString(), data[1].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
        }

        private void btnLoadAllDataGen_Click(object sender, EventArgs e)
        {
            this.loadPaymentDetails();
        }

        
    }
}
