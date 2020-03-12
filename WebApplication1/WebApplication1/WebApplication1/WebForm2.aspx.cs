using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Loadgrid();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Loadgrid();
        }
        SqlConnection con = null;
        protected void Dbcon()
        {
            try
            {
                String strcon = "Data Source=DESKTOP-3R4I38T;Initial Catalog=Student;Integrated Security=True";
                con = new SqlConnection(strcon);
                con.Open();
            }

            catch (Exception)
            {
                throw;
            }

        }
        private void Loadgrid()
        {
            Dbcon();
            String r = "select * from studentinfo";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(r, con);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            con.Close();

        }

    }
}