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
    public partial class Sports_Association_Manager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Hello User: " + "<b>" + Session["user"] + "</b>");

        }



        protected void upcoming(object sender, EventArgs e)
        {
            string constr = WebConfigurationManager.ConnectionStrings["M2"].ToString();
            SqlConnection conn = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("select * from dbo.allMatches", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridviewupcoming.DataSource = dt;
            gridviewupcoming.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void alreadyplayed_Click(object sender, EventArgs e)
        {
            string constr = WebConfigurationManager.ConnectionStrings["M2"].ToString();
            SqlConnection conn = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("select * from dbo.MatchesRankedByAttendance", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            alreadyplayedgrid.DataSource = dt;
            alreadyplayedgrid.DataBind();
        }

        protected void alreadyplayedgrid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void neverplayedclubs_Click(object sender, EventArgs e)
        {
            string constr = WebConfigurationManager.ConnectionStrings["M2"].ToString();
            SqlConnection conn = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("select * from dbo.clubsNeverMatched", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Gridneverplayed.DataSource = dt;
            Gridneverplayed.DataBind();
        }

        protected void Gridneverplayed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string constr = WebConfigurationManager.ConnectionStrings["M2"].ToString();
            SqlConnection conn = new SqlConnection(constr);
            String hostname = TextBox1.Text;
            String guestname = TextBox2.Text;
            String startime = TextBox3.Text;
            String endtime = TextBox4.Text;
            SqlCommand newmatch = new SqlCommand("addNewMatch", conn);
            newmatch.CommandType = System.Data.CommandType.StoredProcedure;
            newmatch.Parameters.Add(new SqlParameter("@HostName", hostname));
            newmatch.Parameters.Add(new SqlParameter("@GuestName ", guestname));
            newmatch.Parameters.Add(new SqlParameter("@StartTime ", startime));
            newmatch.Parameters.Add(new SqlParameter("@EndTime ", endtime));
            conn.Open();
            newmatch.ExecuteNonQuery();
            conn.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string constr = WebConfigurationManager.ConnectionStrings["M2"].ToString();
            SqlConnection conn = new SqlConnection(constr);
            String hostname = TextBox5.Text;
            String guestname = TextBox6.Text;
            String startime = TextBox7.Text;
            String endtime = TextBox8.Text;
            SqlCommand deletematch = new SqlCommand("deleteMatch", conn);
            deletematch.CommandType = System.Data.CommandType.StoredProcedure;
            deletematch.Parameters.Add(new SqlParameter("@HostName", hostname));
            deletematch.Parameters.Add(new SqlParameter("@GuestName ", guestname));
            deletematch.Parameters.Add(new SqlParameter("@startime ", startime));
            deletematch.Parameters.Add(new SqlParameter("@endtime ", endtime));
            conn.Open();
            deletematch.ExecuteNonQuery();
            conn.Close();
        }
    }
}