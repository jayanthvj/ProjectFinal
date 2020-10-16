using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Admin_Add_Employee : System.Web.UI.Page
{
    Class1 c1 = new Class1();
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox11.Text = DateTime.Now.ToShortDateString();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string qry1 = "select * from addemployee where Email='" + TextBox9.Text + "'";
        DataSet ds = c1.select(qry1);
        if (ds.Tables[0].Rows.Count > 0)
        {
            Response.Write("<script>alert('email already exist....please select another email.....')</script>");
        }
        else
        {

            string qry = "Insert Into addemployee values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "','" + TextBox11.Text + "')";
            int i = c1.inpudel(qry);
            if (i > 0)
            {
                Session["Name"] = TextBox1.Text.ToString();
                Session["Designation"] = TextBox2.Text.ToString();
                Session["BasicSalary"] = TextBox10.Text.ToString();
                Session["Email"] = TextBox9.Text.ToString();
                Response.Write("<script>alert('Employee Added Succesfully.....')</script>");
            }
            else
            {
                Response.Write("<script>alert('Employee Not Yet Added.....')</script>");
            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = TextBox2.Text = TextBox3.Text = TextBox4.Text = TextBox5.Text = TextBox6.Text = TextBox7.Text = TextBox8.Text = TextBox9.Text = TextBox10.Text = TextBox11.Text = " ";
    }
}