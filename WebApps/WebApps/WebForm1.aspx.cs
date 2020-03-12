using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApps
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loaddropdownlist();
        }
        void loaddropdownlist()
        {
            dbcon();
            string q = "select * from dr";
            DataSet dt = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(q,con);
            da.Fill(dt);  // fill dataset
            d1.DataTextField = dt.Tables[0].Columns["Name"].ToString(); // text field name of table dispalyed in dropdown
            d1.DataValueField = dt.Tables[0].Columns["Number"].ToString();             // to retrive specific  textfield name 
            d1.DataSource = dt.Tables[0];
            d1.DataBind();
            con.Close();

        }
        SqlConnection con = null;
        void dbcon()
        {
            try
            {
                string strcon = "Data Source=DESKTOP-8D55Q9I\\SQLEXPRESS;Initial Catalog=test;Integrated Security=True";
                con = new SqlConnection(strcon);
                con.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }
        protected void btn_Click(object sender, EventArgs e)
        {
            dbcon();
            string q = "insert into Table_1 (Name,Password,City) values (@a,@b,@c)";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@a",T1.Text);
            cmd.Parameters.AddWithValue("@b", TextBOX1.Text);
            cmd.Parameters.AddWithValue("@c", d1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            loadgrid();
        }
        void loadgrid()
        {
            dbcon();
            
            string q = "select Name,Password,dr.Name from Table_1,dr where Table_1.city=dr.Name";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(q, con);
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}