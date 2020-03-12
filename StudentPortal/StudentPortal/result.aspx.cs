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
    public partial class result : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] == null)
            {
                Response.Redirect("Home.aspx");
            }
        }

        protected void TtBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
           // string a = "abc";
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            string str = "select * from Course where StudentID=@id";

            SqlCommand com = new SqlCommand(str, con);
            com.Parameters.AddWithValue("@id", TtBox1.Text);
            SqlDataReader reader = com.ExecuteReader();

            if (reader.Read())

            {

                l3.Text = "Your Result is"+reader["Result"].ToString();
            }

            }
        }
}