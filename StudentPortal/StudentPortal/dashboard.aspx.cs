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
    public partial class dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

            SqlConnection con = new SqlConnection(strcon);
            con.Open();

            //////Session Needed
            ///
            if (Session["UserName"] == null)
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                String a = Convert.ToString(Session["UserName"]);
                SqlCommand cmd = new SqlCommand("select * from AccountSchema where StudentID=@id", con);
                cmd.Parameters.AddWithValue("@id", a);
                var dataReader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dataReader);
                if (dt.Rows.Count > 0)
                {
                    tbxID.Text = dt.Rows[0]["Payable"].ToString();
                    TextBox1.Text = dt.Rows[0]["Due"].ToString();
                    TextBox2.Text = dt.Rows[0]["Paid"].ToString();
                }
                else
                {

                }
                con.Close();

            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void tbxID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}