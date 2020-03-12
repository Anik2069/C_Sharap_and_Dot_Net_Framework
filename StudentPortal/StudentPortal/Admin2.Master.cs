using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentPortal
{
    public partial class Admin2 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("adminHome.aspx");
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            Response.Redirect("profile1.aspx");
        }

        protected void Unnamed3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Updatepayment.aspx");
        }

        protected void Unnamed4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Enrollstudent.aspx");
        }

        protected void Unnamed5_Click(object sender, EventArgs e)
        {
            Response.Redirect("teacherinfo.aspx");
        }

        protected void Unnamed6_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
            Session["UserName"] = null;
        }
    }
}