using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_View_Employee : System.Web.UI.Page
{
    Class1 c1 = new Class1();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bind();
        }
    }
    public void bind()
    {
        string qry = "Select * From addemployee";
        DataSet ds = c1.select(qry);
        if (ds.Tables[0].Rows.Count > 0)
        {
            //Session["Empid"] = ds.Tables[0].Rows[0][0].ToString();
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        bind();
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        int index = e.RowIndex;
        GridViewRow row = (GridViewRow)GridView1.Rows[index];

        Label Uid = (Label)row.FindControl("Label1");
        TextBox Uname = (TextBox)row.FindControl("TextBox2");
        TextBox Designation = (TextBox)row.FindControl("TextBox3");
        TextBox Username = (TextBox)row.FindControl("TextBox4");
        TextBox Password = (TextBox)row.FindControl("TextBox5");
        TextBox Fathername = (TextBox)row.FindControl("TextBox6");
        TextBox Dob = (TextBox)row.FindControl("TextBox7");
        TextBox Address = (TextBox)row.FindControl("TextBox8");
        TextBox mobile = (TextBox)row.FindControl("TextBox9");
        TextBox email = (TextBox)row.FindControl("TextBox10");
        TextBox basicsalary = (TextBox)row.FindControl("TextBox11");
        TextBox Doj = (TextBox)row.FindControl("TextBox12");


        string qry = "Update addemployee set Name='" + Uname.Text + "',Designation='" + Designation.Text + "',Username='" + Username.Text + "',Password='" + Password.Text + "',Fathername='" + Fathername.Text + "',DOB='" + Dob.Text + "',Address='" + Address.Text + "',MobileNo='" + mobile.Text + "',Email='" + email.Text + "',BasicSalary='" + basicsalary.Text + "',DOJ='" + Doj.Text + "' where Id='" + Uid.Text + "'";
        int i = c1.inpudel(qry);
        if (i > 0)
        {

            Response.Write("<script>alert('Employee Datails Updated succesfully...........!')</script>");

        }
        GridView1.EditIndex = -1;
        bind();
    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        bind();
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int index = e.RowIndex;
        GridViewRow row = (GridViewRow)GridView1.Rows[index];

        Label Uid = (Label)row.FindControl("Label1");
        string qry = "Delete From addemployee where Id='" + Uid.Text + "'";
        int i = c1.inpudel(qry);
        if (i > 0)
        {

            Response.Write("<script>alert('Employee Deleted succesfully...........!')</script>");
        }
        bind();
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        bind(); 
    }
}