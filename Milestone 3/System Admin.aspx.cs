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
    public partial class System_Admin : System.Web.UI.Page
    {
        protected void blockfan_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["M2"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            int national = Int16.Parse(nationalid.Text);

            SqlCommand blockfan = new SqlCommand("blockFan", conn);
            blockfan.CommandType = CommandType.StoredProcedure;
            blockfan.Parameters.Add(new SqlParameter("@NationalID",national));

            conn.Open();
            blockfan.ExecuteNonQuery();
            conn.Close();
        }

        protected void addclub_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["M2"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            String clubname = cname.Text; // we get it from the textbox ID
            String clublocation = clocation.Text;

            SqlCommand newclub = new SqlCommand("addClub", conn);
            newclub.CommandType = CommandType.StoredProcedure;
            newclub.Parameters.Add(new SqlParameter("@ClubName", clubname));
            newclub.Parameters.Add(new SqlParameter("@Location", clublocation));

            conn.Open();
            newclub.ExecuteNonQuery();
            conn.Close();
        }

        protected void delete_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["M2"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            String deleteclubname = dclub.Text;


            SqlCommand deleteclub = new SqlCommand("deleteClub", conn);
            deleteclub.CommandType = CommandType.StoredProcedure;
            deleteclub.Parameters.Add(new SqlParameter("@clubName", deleteclubname));

            conn.Open();
            deleteclub.ExecuteNonQuery();
            conn.Close();
        }

        protected void addstadium_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["M2"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            String stadiumname = sname.Text;
            String stadiumlocation = stadlocation.Text;
            int cap = Int16.Parse(capacity.Text);

            SqlCommand addstadium = new SqlCommand("addStadium", conn);
            addstadium.CommandType = CommandType.StoredProcedure;
            addstadium.Parameters.Add(new SqlParameter("@StadiumName", stadiumname));
            addstadium.Parameters.Add(new SqlParameter("@Location", stadiumlocation));
            addstadium.Parameters.Add(new SqlParameter("@Capacity", cap));

            conn.Open();
            addstadium.ExecuteNonQuery();
            conn.Close();

        }

        protected void deletestad_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["M2"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            String deletestadiumname = dstadium.Text;

            SqlCommand deletestadium = new SqlCommand("deleteStadium", conn);
            deletestadium.CommandType = CommandType.StoredProcedure;
            deletestadium.Parameters.Add(new SqlParameter("@Stadium_Name", deletestadiumname));

            conn.Open();
            deletestadium.ExecuteNonQuery();
            conn.Close();
        }

        
    }
}