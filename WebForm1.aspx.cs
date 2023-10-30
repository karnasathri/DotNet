using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlsDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String str1 = TextBox1.Text;
            Response.Write(str1);
            Response.Write("<br/>");
            string str2 = Request.Form["TextBox2"];
            Response.Write(str2);
        }
    }
}