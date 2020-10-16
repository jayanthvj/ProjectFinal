using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class employee_changepassword : System.Web.UI.Page
{
    Class1 c1 = new Class1();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string qry = "update addemployee set Password='" + TextBox2.Text + "' where Password='" + TextBox1.Text + "'";
        int i = c1.inpudel(qry);
        if (i > 0)
        {

            Response.Write("<script>alert('Password Change Successfully...!!!!')</script>");
            TextBox1.Text = TextBox2.Text = TextBox3.Text = "";
        }
        else
        {
            Response.Write("<script>alert('Password Not Yet  Change ...!!!!')</script>");
            TextBox1.Text = TextBox2.Text = TextBox3.Text = "";
        }
    }
}