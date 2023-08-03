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
    public partial class registersportsassociationmanager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void create_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["M2"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            String name = samname.Text;
            String username = samusername.Text;
            String password = sampassword.Text;

            SqlCommand register = new SqlCommand("addAssociationManager", conn);
            register.CommandType = System.Data.CommandType.StoredProcedure;
            register.Parameters.Add(new SqlParameter("@UserName", username));
            register.Parameters.Add(new SqlParameter("@Password ", password));
            register.Parameters.Add(new SqlParameter("@Name", name));

            conn.Open();
            register.ExecuteNonQuery();
            Response.Redirect("Login.aspx");
            conn.Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["M2"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            Response.Redirect("Login.aspx");
            conn.Close();
        }
    }
}