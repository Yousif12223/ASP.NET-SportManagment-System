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
    public partial class registerfan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void fcreate_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["M2"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            String name = fname.Text;
            String username = fusername.Text;
            String password = fpassword.Text;
            int id = Int16.Parse(fnational.Text);
            String birth = fbirthdate.Text;
            int phone = Int16.Parse(fphone.Text);
            String address = faddress.Text;

            SqlCommand fanregister = new SqlCommand("addFan", conn);
            fanregister.CommandType = System.Data.CommandType.StoredProcedure;
            fanregister.Parameters.Add(new SqlParameter("@name", name));
            fanregister.Parameters.Add(new SqlParameter("@Username", username));
            fanregister.Parameters.Add(new SqlParameter("@Password ", password));
            fanregister.Parameters.Add(new SqlParameter("@address", address));
            fanregister.Parameters.Add(new SqlParameter("@BirthDate", birth));
            fanregister.Parameters.Add(new SqlParameter("@PhoneNumber", phone));
            fanregister.Parameters.Add(new SqlParameter("@NationalID_Number", id));

            conn.Open();
            fanregister.ExecuteNonQuery();
            Response.Redirect("Login.aspx");
            conn.Close();
        }

        protected void fback_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["M2"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            Response.Redirect("Login.aspx");
            conn.Close();
        }
    }
}