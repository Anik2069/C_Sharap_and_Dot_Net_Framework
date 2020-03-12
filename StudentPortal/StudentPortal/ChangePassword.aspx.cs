using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentPortal
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Bttn1_Click(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

            SqlConnection con = new SqlConnection(strcon);
            con.Open();

            SqlCommand cmd = new SqlCommand("update StudentInfo set Password=@pass where StudentID=@id and Password=@pass1", con);
            cmd.Parameters.AddWithValue("@id", tbox1.Text);
            cmd.Parameters.AddWithValue("@pass1", Tbox2.Text);
            if (Tbox3.Text==Tbox4.Text) {
                cmd.Parameters.AddWithValue("@pass", Tbox4.Text);
                cmd.ExecuteNonQuery();
                Message.Text = "Password Changed Successfully";
            }
            else
            {
                Message.Text = "Password Not Matched";
            }
        }
    }
}