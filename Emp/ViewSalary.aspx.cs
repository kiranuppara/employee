﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CrystalDecisions.CrystalReports.Engine;

public partial class Emp_ViewSalary : System.Web.UI.Page
{
      DS_SALARY.SALARY_SELECTDataTable SDT = new DS_SALARY.SALARY_SELECTDataTable();
    DS_SALARYTableAdapters.SALARY_SELECTTableAdapter SAdapter = new DS_SALARYTableAdapters.SALARY_SELECTTableAdapter();


    protected void Page_Load(object sender, EventArgs e)
    {
        CrystalReportViewer1.DisplayGroupTree = false;
        SDT=SAdapter.Select_By_SID(Convert.ToInt32(Session["vid"].ToString()));

             ReportDocument rept = new ReportDocument();
            string spath = "G:/PROJECT/PayRoll/Emp/ViewSalary.rpt";
            rept.Load(spath);
            rept.SetDataSource((DataTable)SDT);
        CrystalReportViewer1.ReportSource = rept;
    }
}