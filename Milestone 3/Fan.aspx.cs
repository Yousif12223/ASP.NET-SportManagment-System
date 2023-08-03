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
    public partial class Fan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Hello User: " + "<b>" + Session["user"] + "</b>");

        }


        protected void purchase_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["M2"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int nationalid = Int16.Parse(fannational.Text);
            String host = fanhost.Text;
            String guest = fanguest.Text;
            String datetime = datetimee.Text;
            SqlCommand purchase = new SqlCommand("purchaseTicket", conn);
            purchase.CommandType = CommandType.StoredProcedure;
            purchase.Parameters.Add(new SqlParameter("@nationalid", nationalid));
            purchase.Parameters.Add(new SqlParameter("@hostclub", host));
            purchase.Parameters.Add(new SqlParameter("@guestclub", guest));
            purchase.Parameters.Add(new SqlParameter("@starttime", datetime));

            conn.Open();
            purchase.ExecuteNonQuery();
            conn.Close();

        }

        protected void viewmatches(object sender, EventArgs e)
        {
            string constr = WebConfigurationManager.ConnectionStrings["M2"].ToString();
            SqlConnection conn = new SqlConnection(constr);
            String datet = upcoming.Text;
            SqlCommand cmd = new SqlCommand("select * from dbo.availableMatchesToAttend(@date)", conn);
            cmd.Parameters.AddWithValue("@date", datet);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1forupcomingmatches.DataSource = dt;
            GridView1forupcomingmatches.DataBind();

        }

        protected void GridView1forupcomingmatches_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}