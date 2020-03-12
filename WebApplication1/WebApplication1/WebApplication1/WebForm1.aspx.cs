using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Click(object sender, EventArgs e)
        {
            Dbcon();
            String a = tt.Text;
            String b = Textbox1.Text;
            String c = Textbox2.Text;
            SqlCommand cmd = new SqlCommand("insert into studentinfo(ID,name,email) values(@ID,@name,@email)",con);
            cmd.Parameters.AddWithValue("@ID", a);
            cmd.Parameters.AddWithValue("@name", b);
            cmd.Parameters.AddWithValue("@email", c);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("Webform2.aspx");
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

        protected void tt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}