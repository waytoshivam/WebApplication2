using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;      
using System.Configuration; 
using System.Data.SqlClient;


namespace WebApplication2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert emptb values(@id, @name, @add, @sal)";
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@id", TextBox1.Text);
            cmd.Parameters.AddWithValue("@name", TextBox2.Text);
            cmd.Parameters.AddWithValue("@add", TextBox3.Text);

            cmd.Parameters.AddWithValue("@sal", TextBox4.Text);


            cmd.ExecuteNonQuery();
        
            cmd.Dispose();
            con.Close();

            TextBox1.Text = string.Empty;
            TextBox2.Text = string.Empty;
            TextBox3.Text = string.Empty;
            TextBox4.Text = string.Empty;

            TextBox1.Focus();
        }
    }
}