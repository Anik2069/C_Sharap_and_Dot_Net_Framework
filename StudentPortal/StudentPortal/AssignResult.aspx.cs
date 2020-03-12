using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentPortal
{
    public partial class AssignResult : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] == null)
            {
                Response.Redirect("Home.aspx");
            }
        }

        protected void tb1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        protected void Search_Click(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

            SqlConnection con = new SqlConnection(strcon);
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from StudentInfo,Course where StudentInfo.StudentID=@id", con);
            cmd.Parameters.AddWithValue("@id", tb1.Text);
            var dataReader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dataReader);
            if (dt.Rows.Count > 0)
            {
                TextBox1.Text = dt.Rows[0]["StudentName"].ToString();
                String a = dt.Rows[0]["Result"].ToString();
                if (a !=null) {
                    TextBox2.Text = dt.Rows[0]["SemesterName"].ToString();
                  
                }
                else
                {
                    Label4.Text = "Result is Asssign";
                }
            }
            else
            {

            }
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand("update Course set Result=@Result where StudentID=@StudentID", con);
            cmd.Parameters.AddWithValue("@StudentID", tb1.Text);
            cmd.Parameters.AddWithValue("@Result", TextBox3.Text.ToString());
            
            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}