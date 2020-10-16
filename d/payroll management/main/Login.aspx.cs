using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class main_Login : System.Web.UI.Page
{
    Class1 c1 = new Class1();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == "" || TextBox2.Text == "")
        {

            Response.Write("<script>alert('Fill Details...!')</script>");
        }
        else if (DropDownList1.SelectedValue == "Admin")
        {

            string qry = "select * from admin where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";

            DataSet ds = c1.select(qry);

            if (ds.Tables[0].Rows.Count > 0)
            {

                Response.Redirect("~/Admin/Home.aspx");
                TextBox1.Text = TextBox2.Text = "";
            }
            else
            {
                Response.Write("<script>alert('Login Faild...!')</script>");
                TextBox1.Text = TextBox2.Text = "";

            }

        }

        else if (DropDownList1.SelectedValue == "Employee")
        {


            string qry = "select * from addemployee where Email='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";

            DataSet ds = c1.select(qry);

            if (ds.Tables[0].Rows.Count > 0)
            {
                Session["UserId"] = ds.Tables[0].Rows[0][0].ToString();
                Session["Name"] = ds.Tables[0].Rows[0][1].ToString();
                Session["EmaiID"] = ds.Tables[0].Rows[0][9].ToString();
                Session["Usermobileno"] = ds.Tables[0].Rows[0][8].ToString();
                Session["Address"] = ds.Tables[0].Rows[0][7].ToString();
                Session["Password"] = ds.Tables[0].Rows[0][4].ToString();
                Response.Redirect("~/Employee/Home.aspx");
                TextBox1.Text = TextBox2.Text = "";
            }
            else
            {
                Response.Write("<script>alert('Login Faild...!')</script>");
                TextBox1.Text = TextBox2.Text = "";

            }

        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = TextBox2.Text = "";
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}