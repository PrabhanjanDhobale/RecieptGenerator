using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReceiptGenerator
{
    public partial class ShowStudentRecords : Form
    {
        DB db;
        public ShowStudentRecords()
        {
            InitializeComponent();


            this.db = new DB();
            AutoCompleteStringCollection namecollections = this.db.namesofStudents();
            txtFullName.AutoCompleteCustomSource = namecollections;
        }

        public void loadData() {

            dgStudentDetails.Rows.Clear();
            dgStudentDetails.Refresh();
            DataTable dt = this.db.getAllStudentData();
            foreach (DataRow dr in dt.Rows)
            {
                dgStudentDetails.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6], dr[7], dr[8], dr[9], dr[10], dr[11], dr[12], dr[13], dr[14], dr[15], dr[16]);
            }
        }

        private void ShowStudentRecords_Load(object sender, EventArgs e)
        {
            dgStudentDetails.AutoGenerateColumns = false;
            //dgStudentDetails.DataSource = this.db.getAllStudentData();
            loadData();
            
        }

        private void btnLoadAllData_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = this.db.getSpecificRow(txtFullName.Text);
            dgStudentDetails.Rows.Clear();
            dgStudentDetails.Refresh();
            foreach (DataRow dr in dt.Rows)
            {
                dgStudentDetails.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6], dr[7], dr[8], dr[9], dr[10], dr[11], dr[12], dr[13], dr[14], dr[15], dr[16]);
            }
        }
    }
}
