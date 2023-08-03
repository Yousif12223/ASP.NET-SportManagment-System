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
    public partial class Stadium_Manager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Hello User:" + "<b>" + Session["user"] + "</b>");

            
        }

        protected void Gridstadiuminfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Gridallrequests_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void stadiuminfo_Click(object sender, EventArgs e)
        {
            string constr = WebConfigurationManager.ConnectionStrings["M2"].ToString();
            SqlConnection conn = new SqlConnection(constr);

            String name = stadiumname.Text;

            SqlCommand cmd = new SqlCommand("select * from dbo.stadiuminfo(@stadiumname)", conn);

            cmd.Parameters.AddWithValue("@stadiumname", name);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Gridstadiuminfo.DataSource = dt;
            Gridstadiuminfo.DataBind();
        }

        protected void allrequest_Click(object sender, EventArgs e)
        {
            string constr = WebConfigurationManager.ConnectionStrings["M2"].ToString();
            SqlConnection conn = new SqlConnection(constr);

            SqlCommand cmd = new SqlCommand("select * from dbo.allRequests", conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Gridallrequests.DataSource = dt;
            Gridallrequests.DataBind();
        }

        protected void acceptbutton(object sender, EventArgs e)
        {
            string constr = WebConfigurationManager.ConnectionStrings["M2"].ToString();
            SqlConnection conn = new SqlConnection(constr);

            String smname = TextBox1.Text;
            String hostclub = TextBox2.Text;
            String guestclub = TextBox3.Text;
            String startime = TextBox4.Text;

            SqlCommand smregister = new SqlCommand("acceptRequest", conn);
            smregister.CommandType = System.Data.CommandType.StoredProcedure;
            smregister.Parameters.Add(new SqlParameter("@StadiumManagerUsername", smname));
            smregister.Parameters.Add(new SqlParameter("@HostClub_Name", hostclub));
            smregister.Parameters.Add(new SqlParameter("@GuestClub_Name", guestclub));
            smregister.Parameters.Add(new SqlParameter("@StartTime", startime));
            conn.Open();
            smregister.ExecuteNonQuery();
            Response.Write("Request has been Accepted");
            conn.Close();
        }

        protected void rejectbutton(object sender, EventArgs e)
        {
            string constr = WebConfigurationManager.ConnectionStrings["M2"].ToString();
            SqlConnection conn = new SqlConnection(constr);

            String smname = TextBox5.Text;
            String hostclub = TextBox6.Text;
            String guestclub = TextBox7.Text;
            String startime = TextBox8.Text;

            SqlCommand smregister = new SqlCommand("rejectRequest", conn);
            smregister.CommandType = System.Data.CommandType.StoredProcedure;
            smregister.Parameters.Add(new SqlParameter("@StadiumManagerUsername", smname));
            smregister.Parameters.Add(new SqlParameter("@HostClub_Name", hostclub));
            smregister.Parameters.Add(new SqlParameter("@GuestClub_Name", guestclub));
            smregister.Parameters.Add(new SqlParameter("@StartTime", startime));
            conn.Open();
            smregister.ExecuteNonQuery();
            Response.Write("Request has been Rejected");
            conn.Close();
        }
    }
}