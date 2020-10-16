using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Admin_Payslip_Genrate : System.Web.UI.Page
{
    Class1 c1 = new Class1();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string qry = "Select Designation,Username,Password,Fathername,DOB,Address,MobileNo,Name,BasicSalary,DOJ From addemployee where Email like '%" + TextBox1.Text + "%'";
        DataSet ds = c1.select(qry);
        if (ds.Tables[0].Rows.Count > 0)
        {
            TextBox2.Text = ds.Tables[0].Rows[0]["Designation"].ToString();
            TextBox3.Text = ds.Tables[0].Rows[0]["Username"].ToString();
            TextBox4.Text = ds.Tables[0].Rows[0]["Password"].ToString();
            TextBox5.Text = ds.Tables[0].Rows[0]["Fathername"].ToString();
            TextBox6.Text = ds.Tables[0].Rows[0]["DOB"].ToString();
            TextBox7.Text = ds.Tables[0].Rows[0]["Address"].ToString();
            TextBox8.Text = ds.Tables[0].Rows[0]["MobileNo"].ToString();
            TextBox9.Text = ds.Tables[0].Rows[0]["Name"].ToString();
            TextBox10.Text = ds.Tables[0].Rows[0]["BasicSalary"].ToString();
            TextBox11.Text = ds.Tables[0].Rows[0]["DOJ"].ToString();

            Session["Email"] = TextBox1.Text.ToString();
            Session["Designation"] = TextBox2.Text.ToString();
            Session["BasicSalary"] = TextBox10.Text.ToString();
            Session["Name"] = TextBox9.Text.ToString();
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("DesignationSalaries.aspx");
    }
}