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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
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

        
    }
}
