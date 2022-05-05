using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Football
{
    public partial class foot : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connectStr = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

            WinTeam(connectStr);

            JapanMatch(connectStr);
        }

        public void WinTeam(String connectStr)
        {
            using (SqlConnection conn = new SqlConnection(connectStr))
            {

                conn.Open();

                SqlCommand cmd = new SqlCommand("Select * from FootballLeague where Status = 'Win'", conn);
                SqlDataReader datareader = cmd.ExecuteReader();

                GridView1.DataSource = datareader;
                GridView1.DataBind();
            }
        }

        public void JapanMatch(String connectStr)
        {
            using (SqlConnection conn = new SqlConnection(connectStr))
            {

                conn.Open();

                SqlCommand cmd = new SqlCommand("Select * from FootballLeague where TeamnName1 = 'Japan' or TeamName2 = 'Japan'", conn);
                SqlDataReader datareader = cmd.ExecuteReader();

                GridView2.DataSource = datareader;
                GridView2.DataBind();
            }
        }
    }
}
        
    
