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
    public partial class ShowStudentDetails1 : Form
    {
        DB db;
        public ShowStudentDetails1()
        {
            InitializeComponent();


            this.db = new DB();
            AutoCompleteStringCollection namecollections = this.db.namesofStudents();
            txtFullNameStudentDetails.AutoCompleteCustomSource = namecollections;
        }

        private void ShowStudentDetails1_Load(object sender, EventArgs e)
        {
            StudentDetailsDataGridView.DataSource = this.db.getAllStudentData();
        }
    }
}
