using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;
using System.Data;

public partial class main_forget_Password : System.Web.UI.Page
{
    Class1 c1 = new Class1();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public void bind()
    {
        try
        {


            //Random rn = new Random();
            //int pas1 = rn.Next(012345);
            //Session["rpas"] = pas1.ToString();
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("praveen.trylogic310@gmail.com");
            msg.IsBodyHtml = true;
            msg.To.Add(new MailAddress(TextBox1.Text));
            msg.Subject = "A Mail Regarding  Your Password";
            msg.Body = "A Mail Regarding  Your Password Is:" + Session["Password"].ToString() + "";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            NetworkCredential nc = new NetworkCredential("praveen.trylogic310@gmail.com", "praveen310");
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = nc;
            smtp.EnableSsl = true;
            smtp.Send(msg);
        }
        catch (Exception)
        {

            Response.Write("<script>alert('Connect with Internet')</script>");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string qry = "select * from addemployee where Email='" + TextBox1.Text + "' ";
        DataSet ds = c1.select(qry);
        if (ds.Tables[0].Rows.Count > 0)
        {
            bind();
            Response.Write("<script>alert('Password Is Sent Your MailId....!')</script>");
        }
        else
        {

            Response.Write("<script>alert('Enter Correct MailId....!')</script>");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
    }
}