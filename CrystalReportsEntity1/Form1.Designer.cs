namespace CrystalReportsEntity1
{
    partial class Form1
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
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReportEntityV1 = new CrystalReportsEntity1.CrystalReportEntityV();
            this.SuspendLayout();
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = 0;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer2.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.ReportSource = "C:\\Users\\jaqbs\\source\\repos\\CrystalReportsSolution\\CrystalReportsEntity1\\CrystalR" +
    "eportDataSet.rpt";
            this.crystalReportViewer2.Size = new System.Drawing.Size(1317, 1070);
            this.crystalReportViewer2.TabIndex = 0;
            this.crystalReportViewer2.Load += new System.EventHandler(this.crystalReportViewer2_Load);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1317, 1070);
            this.Controls.Add(this.crystalReportViewer2);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        //private CrystalReport1 CrystalReport11;
        //private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        //private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        //private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        //private CrystalReportEntity CrystalReportEntity1;
        //private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer3;
        //private CrystalReportEntityV CrystalReportEntityV1;
        //private CrystalReportEntityV CrystalReportEntityV3;
        //private CrystalReportEntityV CrystalReportEntityV2;
        //private CrystalReport4 CrystalReport41;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
       // private CrystalReport4 crystalReport4;
        private CrystalReport4 CrystalReport41;
        private CrystalReportDataSet CrystalReportDataSet1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private CrystalReportEntityV CrystalReportEntityV1;
    }
}

