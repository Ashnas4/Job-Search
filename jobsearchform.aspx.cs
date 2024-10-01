using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Assignment2
{
    public partial class jobsearchform : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"server=LAPTOP-1NL8389O\SQLEXPRESS;database=Job search;integrated security=true");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = "1=1 ";
            if (!string.IsNullOrWhiteSpace(TextBox1.Text))
            {
                str += " and Company_Name like '%" + TextBox1.Text + "%'";
            }
            if (!string.IsNullOrWhiteSpace(TextBox2.Text))
            {
                str += " and Skills like '%" + TextBox2.Text + "%'";
            }
            if (!string.IsNullOrWhiteSpace(TextBox3.Text))
            {
                str += " and Experience  like '%" + TextBox3.Text + "%' ";
            }
            string str1 = "select * from search_job where  " + str;
            SqlDataAdapter da = new SqlDataAdapter(str1, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }
    }
}