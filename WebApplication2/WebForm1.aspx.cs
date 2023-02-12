using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "welcome";
            Label2.Text = DateTime.Now.ToString();
          /*  TextBox3.Text =Convert.ToString(Convert.Toint32(TextBox1.Text) + TextBox2.Text;*/

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}