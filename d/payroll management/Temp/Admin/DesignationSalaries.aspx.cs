using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_DesignationSalaries : System.Web.UI.Page
{
    Class1 c1 = new Class1();
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.Text = Session["Name"].ToString();
        TextBox2.Text = Session["Designation"].ToString();
        TextBox3.Text = Session["BasicSalary"].ToString();

        int i1 = int.Parse(Session["BasicSalary"].ToString());
        int i2 = i1 / 30;
        TextBox4.Text = i2.ToString();

        float f11 = float.Parse(Session["BasicSalary"].ToString());
        float f2 = 20 * f11 / 100;
        TextBox5.Text = f2.ToString();


        float f12 = 10 * f11 / 100;
        TextBox6.Text = f12.ToString();

        float f13 = 2 * f11 / 100;
        TextBox7.Text = f13.ToString();

        float f14 = 1 * f11 / 100;
        TextBox8.Text = f14.ToString();

        float f15 = 3 * f11 / 100;
        TextBox10.Text = f15.ToString();

        float f16 = 4 * f11 / 100;
        TextBox11.Text = f16.ToString();

        float f17 = f2 + f12 + f13 + f14;
        TextBox13.Text = f17.ToString();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int i3 = int.Parse(TextBox12.Text);

        float i1 = float.Parse(Session["BasicSalary"].ToString());
        float i2 = i1 / 31;
        TextBox4.Text = i2.ToString();

        float i4 = i2 * i3;

        float f11 = float.Parse(Session["BasicSalary"].ToString());
        float f2 = 20 * f11 / 100;
        TextBox5.Text = f2.ToString();


        float f12 = 10 * f11 / 100;
        TextBox6.Text = f12.ToString();

        float f13 = 2 * f11 / 100;
        TextBox7.Text = f13.ToString();

        float f14 = 1 * f11 / 100;
        TextBox8.Text = f14.ToString();

        float f15 = 3 * f11 / 100;
        TextBox10.Text = f15.ToString();

        float f16 = 4 * f11 / 100;
        TextBox11.Text = f16.ToString();

        float f17 = f2 + f12 + f13 + f14;
        TextBox13.Text = f17.ToString();

        float f18 = i4 + f15 + f16;

        float f19 = (f2 + f12 + f13 + f14) - (f18 = i4 + f15 + f16);
        TextBox14.Text = f19.ToString();

        float f20 = (i1 + f17) - (f19);
        TextBox15.Text = f20.ToString();





        string qry = "Insert into DesignationSalaries values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + DropDownList1.SelectedItem.Text + "','" + TextBox16.Text + "','" + TextBox10.Text + "','" + TextBox11.Text + "','" + TextBox12.Text + "','" + TextBox13.Text + "','" + TextBox14.Text + "','" + TextBox15.Text + "')";
        int i = c1.inpudel(qry);
        if (i > 0)
        {
            Session["SalaryPerDay"] = TextBox4.Text.ToString();
            Session["Deductions"] = TextBox14.Text.ToString();
            Session["Netsalary"] = TextBox15.Text.ToString();
            Session["Earnings"] = TextBox13.Text.ToString();
            Session["NoOfLeaves"] = TextBox12.Text.ToString();
            Session["month"] = DropDownList1.SelectedItem.ToString();
            Session["year"] = TextBox16.Text.ToString();
            Response.Write("<script>alert('Salary Calculated succesfully')</script>");
            Response.Redirect("Payslips.aspx");
        }
        else
        {
            Response.Write("<script>alert('Salary Not Yet Calculated ')</script>");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = TextBox2.Text = TextBox3.Text = TextBox4.Text = TextBox5.Text = TextBox6.Text = TextBox7.Text = TextBox8.Text = TextBox16.Text = TextBox10.Text = TextBox11.Text = TextBox12.Text = TextBox13.Text = TextBox14.Text = TextBox15.Text = "";
    }
}