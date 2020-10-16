using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class employee_View_Details : System.Web.UI.Page
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
        string qry = "Select * From addemployee where Name='" + Session["Name"].ToString()+ "'";
        DataSet ds = c1.select(qry);
        if (ds.Tables[0].Rows.Count > 0)
        {
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }  
}