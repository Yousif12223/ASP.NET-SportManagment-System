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
    public partial class Club_Representative : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Hello User: " + "<b>" + Session["user"] + "</b>");

        }

        protected void clubinfo_Click(object sender, EventArgs e)
        {
            string constr = WebConfigurationManager.ConnectionStrings["M2"].ToString();
            SqlConnection conn = new SqlConnection(constr);
            String repname = clubrepname.Text;
            SqlCommand cmd = new SqlCommand("select * from dbo.clubinfo(@clubrepresentativename)", conn);
            cmd.Parameters.AddWithValue("@clubrepresentativename", repname);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            

        }




        protected void viewmatches_Click(object sender, EventArgs e)
        {
            string constr = WebConfigurationManager.ConnectionStrings["M2"].ToString();
            SqlConnection conn = new SqlConnection(constr);
            String clubname = upcomingmatches.Text;
            SqlCommand cmd = new SqlCommand("select * from dbo.upcomingMatchesOfClubupdated(@Club_Name)", conn);
            cmd.Parameters.AddWithValue("@Club_Name", clubname);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView3.DataSource = dt;
            GridView3.DataBind();

        }

        protected void viewstadiums_Click(object sender, EventArgs e)
        {
            string constr = WebConfigurationManager.ConnectionStrings["M2"].ToString();
            SqlConnection conn = new SqlConnection(constr);
            String datet = dateandtime.Text;
            SqlCommand cmd = new SqlCommand("select * from dbo.viewAvailableStadiumsOn(@date)", conn);
            cmd.Parameters.AddWithValue("@date", datet);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView2.DataSource = dt;
            GridView2.DataBind();

        }

        protected void hostrequest_Click(object sender, EventArgs e)
        {
            string constr = WebConfigurationManager.ConnectionStrings["M2"].ToString();
            SqlConnection conn = new SqlConnection(constr);
            String clubname = hostclubname.Text;
            String stadiumname = hoststadiumname.Text;
            String datetime = hostdatetime.Text;

            SqlCommand hostrequest = new SqlCommand("addHostRequest", conn);
            hostrequest.Parameters.Add(new SqlParameter("@Club_Name", clubname));
            hostrequest.Parameters.Add(new SqlParameter("@Stadium_Name", stadiumname));
            hostrequest.Parameters.Add(new SqlParameter("@StartTime", datetime));

            conn.Open();
            hostrequest.ExecuteNonQuery();
            conn.Close();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }
    }
}