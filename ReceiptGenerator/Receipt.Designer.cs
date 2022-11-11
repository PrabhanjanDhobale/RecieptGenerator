namespace ReceiptGenerator
{
    partial class Receipt
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
            this.RegisteredCrystalReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // RegisteredCrystalReport
            // 
            this.RegisteredCrystalReport.ActiveViewIndex = -1;
            this.RegisteredCrystalReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegisteredCrystalReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.RegisteredCrystalReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegisteredCrystalReport.Location = new System.Drawing.Point(0, 0);
            this.RegisteredCrystalReport.Name = "RegisteredCrystalReport";
            this.RegisteredCrystalReport.Size = new System.Drawing.Size(894, 793);
            this.RegisteredCrystalReport.TabIndex = 0;
            this.RegisteredCrystalReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 793);
            this.Controls.Add(this.RegisteredCrystalReport);
            this.Name = "Receipt";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.Receipt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer RegisteredCrystalReport;
    }
}