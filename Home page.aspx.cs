using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Assignment2
{
    public partial class Home_page : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"server=LAPTOP-1NL8389O\SQLEXPRESS;database=Job search;integrated security=true");
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = "insert into search_job values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')";
            SqlCommand cmd = new SqlCommand(str, con);
            con.Open();
            int j = cmd.ExecuteNonQuery();
            con.Close();
            if (j != 0)
            {

                Label1.Text = "Inserted";
                Label1.Visible = true;

            }

        }
    }
}