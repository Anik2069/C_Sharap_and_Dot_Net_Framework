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
    public partial class Forget : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            String a = DropDownList1.Text;
            String b = Byn1.Text;
            string strcon = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            if (a == "Student")
            {
                SqlCommand cmd = new SqlCommand("Select * from StudentInfo where StudentID=@id", con);
                cmd.Parameters.AddWithValue("@id", Byn1.Text);
                var dataReader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dataReader);
                if (dt.Rows.Count > 0)
                {
                    TextBox2.Text = dt.Rows[0]["StudentName"].ToString();

                }
                else
                {

                }
            }
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Byn1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand("update StudentInfo set Password=@pass where StudentID=@id and StudentName=@pass1", con);
                cmd.Parameters.AddWithValue("@id", Byn1.Text);
                cmd.Parameters.AddWithValue("@pass1", TextBox2.Text);
                //cmd.Parameters.AddWithValue("@pass1", tb1.Text);
                if (TextBox1.Text == tb1.Text)
                {
                    cmd.Parameters.AddWithValue("@pass", tb1.Text);
                    cmd.ExecuteNonQuery();
                    l1.Text = "Password Changed Successfully";
                }
                else
                {
                l1.Text = "Password Not Matched";
            }

        }

        protected void Btn2_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}