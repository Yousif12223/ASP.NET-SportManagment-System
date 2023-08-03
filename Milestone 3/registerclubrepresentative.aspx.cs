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
    public partial class registerclubrepresentative : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void create_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["M2"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            String username = crusername.Text;
            String password = crpassword.Text;
            String name = crname.Text;
            String cname = clubname.Text;
            SqlCommand crregister = new SqlCommand("addRepresentative", conn);
            crregister.CommandType = System.Data.CommandType.StoredProcedure;
            crregister.Parameters.Add(new SqlParameter("@Username", username));
            crregister.Parameters.Add(new SqlParameter("@Password ", password));
            crregister.Parameters.Add(new SqlParameter("@name", name));
            crregister.Parameters.Add(new SqlParameter("@Club_Name", cname));
            conn.Open();
            crregister.ExecuteNonQuery();
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