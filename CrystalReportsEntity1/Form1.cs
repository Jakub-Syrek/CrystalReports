using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CrystalReportsEntity1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CrystalReportDataSet crystalReport = new CrystalReportDataSet();
            var path = @"C:\Users\jaqbs\source\repos\CrystalReportsSolution\CrystalReportsEntity1\CrystalReportDataSet.rpt";
            crystalReport.Load(path);
            crystalReportViewer2.ReportSource = crystalReport;
            crystalReportViewer2.Refresh();

        }

       

       



        //private void crystalReportViewer1_Load(object sender, EventArgs e)
        //{
            

        //    CrystalReport4 rpt = new CrystalReport4();

            
        //    DataSet1 db = new DataSet1();

        //    rpt.SetDataSource(from employee in db.Employees.Take(100)
        //                                select employee.FirstName );


        //    //rpt.SetDataSource(db);

        //    //rpt.SetDataSource(from u in db.Employees
        //    //                      select new
        //    //                      {
        //    //                          u.EmployeeID,
        //    //                          u.FirstName,
        //    //                          u.LastName
        //    //                      });
            
        //   // crystalReportViewer1.ReportSource = rpt;
        //    crystalReportViewer1.RefreshReport();        
        //}

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {
            DataSet1 db = new DataSet1();

            DataSet dsReport = new DataSet();

            var EmployeeTable = db.Employees.Copy();
            var OrdersTable = db.Orders.Copy();


            dsReport.Tables.Add(EmployeeTable);
            dsReport.Tables.Add(OrdersTable);

            CrystalReportDataSet crystalReport = new CrystalReportDataSet();
            //var path = @"C:\Users\jaqbs\source\repos\CrystalReportsSolution\CrystalReportsEntity1\CrystalReportDataSet.rpt";
            //crystalReport.Load(path);
            crystalReport.SetDataSource(dsReport);
            CrystalReportViewer rv = new CrystalReportViewer();
            rv.ReportSource = crystalReport;
            crystalReportViewer2.ReportSource = crystalReport;
            crystalReportViewer2.Refresh();

            //rpt.SetDataSource(from employee in db.Employees.Take(100)
            //                  select employee.FirstName);


        }
    }
}
