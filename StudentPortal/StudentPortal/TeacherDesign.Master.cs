using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentPortal
{
    public partial class TeacherDesign : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            Response.Redirect("teacherprofile1.aspx");
        }

        protected void Unnamed4_Click(object sender, EventArgs e)
        {
            Response.Redirect("AssignResult.aspx");
        }

        protected void Unnamed6_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void Unnamed5_Click(object sender, EventArgs e)
        {
            Response.Redirect("ChangePassword2.aspx");
        }

        protected void Unnamed2_Click1(object sender, EventArgs e)
        {
            Response.Redirect("CourseAssign.aspx");
        }
    }
}