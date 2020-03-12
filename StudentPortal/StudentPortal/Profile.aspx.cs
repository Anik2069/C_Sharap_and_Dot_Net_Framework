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
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session Lagbo
            if (Session["UserName"] == null)
            {
                Response.Redirect("Home.aspx");
            } 
            else
            {
                string strcon = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

                SqlConnection con = new SqlConnection(strcon);

                con.Open();
                String a = Convert.ToString(Session["UserName"]);
                string str = "select * from StudentInfo where StudentID = @StudentID";

                SqlCommand com = new SqlCommand(str, con);
                com.Parameters.AddWithValue("@StudentID", a);
                SqlDataReader reader = com.ExecuteReader();

                if (reader.Read())

                {

                    tb11.Text = reader["StudentID"].ToString();

                    Tb12.Text = reader["StudentName"].ToString();

                    TextBox2.Text = reader["Department"].ToString();

                    TextBox3.Text = reader["HomeTown"].ToString();

                    TextBox5.Text = reader["Religion"].ToString();

                    reader.Close();

                    con.Close();

                }
            }
        }

        protected void Buttonsubmit2_Click(object sender, EventArgs e)
        {

        }
    }
}