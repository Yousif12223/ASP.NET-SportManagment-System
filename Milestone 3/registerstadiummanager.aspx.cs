using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Milestone3
{
    public partial class registerstadiummanager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void create_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["M2"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            String username = smusername.Text;
            String password = smpassword.Text;
            String name = smname.Text;
            String stadium = Stadiumname.Text;
            SqlCommand smregister = new SqlCommand("addStadiumManager", conn);
            smregister.CommandType = System.Data.CommandType.StoredProcedure;
            smregister.Parameters.Add(new SqlParameter("@Username", username));
            smregister.Parameters.Add(new SqlParameter("@Password", password));
            smregister.Parameters.Add(new SqlParameter("@name", name));
            smregister.Parameters.Add(new SqlParameter("@Stadium_Name", stadium));
            conn.Open();
            smregister.ExecuteNonQuery();
            Response.Redirect("Login.aspx");
            conn.Close();


        }

        protected void returnbackcr_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["M2"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            Response.Redirect("Login.aspx");
            conn.Close();
        }
    }
}