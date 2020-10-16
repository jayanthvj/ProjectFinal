using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Payslips : System.Web.UI.Page
{
    Class1 c1 = new Class1();
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox13.Text = Session["Name"].ToString();
        TextBox1.Text = Session["Email"].ToString();
        TextBox7.Text = Session["SalaryPerDay"].ToString();
        TextBox10.Text = Session["Deductions"].ToString();
        TextBox11.Text = Session["Netsalary"].ToString();
        TextBox8.Text = Session["Earnings"].ToString();
        TextBox9.Text = Session["NoOfLeaves"].ToString();
        TextBox6.Text = Session["BasicSalary"].ToString();
        TextBox12.Text = Session["Designation"].ToString();
        TextBox2.Text = Session["month"].ToString();
        TextBox3.Text = Session["year"].ToString();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string qry = "insert into payslip values('" + TextBox1.Text + "','"+TextBox13.Text+"','" + TextBox12.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + DateTime.Now.ToString() + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "','" + TextBox11.Text + "')";
        int i = c1.inpudel(qry);
        if (i > 0)
        {
            Response.Write("<script>alert('Payslips genrated succesfully.........')</script>");
        }
        else
        {
            Response.Write("<script>alert('Payslips Not Yet genrated.........')</script>");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = TextBox12.Text = TextBox2.Text = TextBox3.Text = TextBox4.Text = TextBox6.Text = TextBox7.Text = TextBox8.Text = TextBox9.Text = TextBox10.Text = TextBox11.Text = "";
    }
}