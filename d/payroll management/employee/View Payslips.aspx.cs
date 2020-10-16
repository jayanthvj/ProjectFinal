using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;


public partial class employee_View_Payslips : System.Web.UI.Page
{
    Class1 c1 = new Class1();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) 
        {
            bind();
        }
        Control ctrl = (Control)Session["ctrl"];
    }
    public void bind() 
    {
        string qry = "Select * From payslip where EmpName='" + Session["Name"].ToString()+"'";
        DataSet ds = c1.select(qry);
        if (ds.Tables[0].Rows.Count > 0)
        {
            DataList1.DataSource = ds;
            DataList1.DataBind();
        }
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}