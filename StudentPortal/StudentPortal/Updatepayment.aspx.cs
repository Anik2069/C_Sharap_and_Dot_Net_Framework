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
    public partial class Updatepayment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] == null)
                Response.Redirect("Home.aspx");
        }

        protected void boxx_Click(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

            SqlConnection con = new SqlConnection(strcon);
            con.Open();

            SqlCommand cmd = new SqlCommand("update AccountSchema set Payable=@p, Due=@d, Paid=@dd where StudentID=@id", con);
            cmd.Parameters.AddWithValue("@id", lw.Text);
            cmd.Parameters.AddWithValue("@p", ox1.Text);
            cmd.Parameters.AddWithValue("@d", TxtBx1.Text);
            cmd.Parameters.AddWithValue("@dd", TextBo1.Text);

            cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void lw_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Bt_Click(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

            SqlConnection con = new SqlConnection(strcon);
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from StudentInfo where StudentID=@id", con);
            cmd.Parameters.AddWithValue("@id", lw.Text);
            var dataReader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dataReader);
            if (dt.Rows.Count > 0)
            {
                Tex1.Text = dt.Rows[0]["StudentName"].ToString();

            }
            else
            {

            }


        }

        protected void Tex1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}