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
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
            DataTable payment = new DataTable();
            payment.Columns.Add("ID", typeof(int));
            payment.Columns.Add("Date", typeof(String));
            payment.Columns.Add("Name", typeof(String));
            payment.Columns.Add("Registration Date", typeof(String));
            payment.Columns.Add("Fees", typeof(int));
            payment.Columns.Add("Paid Fees", typeof(int));
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
           
        }
    }
}
