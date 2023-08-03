using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Milestone3
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
        }

        protected void login(object sender, EventArgs e)
        {

            string connStr = WebConfigurationManager.ConnectionStrings["M2"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            String name = username.Text;
            Session["user"] = name;
            String pass = password.Text;

            SqlCommand loginproc = new SqlCommand("userLogin", conn); //give him the name of the procedure u want to use
            loginproc.CommandType = System.Data.CommandType.StoredProcedure;
            loginproc.Parameters.Add(new SqlParameter("@username", name));
            loginproc.Parameters.Add(new SqlParameter("@password", pass));
            SqlParameter type = loginproc.Parameters.Add("@type", SqlDbType.Int);
            type.Direction = ParameterDirection.Output;
            
            conn.Open();
            loginproc.ExecuteNonQuery();
            conn.Close();

            if(type.Value.ToString() =="1")
            {
                Response.Redirect("System Admin.aspx");
            }
            else if (type.Value.ToString() == "5")
            {
                Response.Redirect("Fan.aspx");
            }
            else if (type.Value.ToString() == "2")
            {
                Response.Redirect("Stadium Manager.aspx");
            }
            else if (type.Value.ToString() == "3")
            {
                Response.Redirect("Club Representative.aspx");
            }
            else if (type.Value.ToString() == "4")
            {
                Response.Redirect("Sports Association Manager.aspx");
            }
            else
            {
                Response.Write("Incorrect UserName or Password");
            }

        }

        protected void registerassportsassociationmanager_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["M2"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            Response.Redirect("registersportsassociationmanager.aspx");
            conn.Close();
             

        }

        protected void registerasclubrepresentative_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["M2"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            Response.Redirect("registerclubrepresentative.aspx");
            conn.Close();
        }

        protected void registerasstadiummanager_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["M2"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            Response.Redirect("registerstadiummanager.aspx");
            conn.Close();
        }

        protected void registerasfan_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["M2"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            Response.Redirect("registerfan.aspx");
            conn.Close();
        }
    }
}