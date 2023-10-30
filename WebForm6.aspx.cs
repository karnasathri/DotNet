using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlsDemo
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Page Load Event Fired <br/>");
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Response.Write("Cached Event Of TextBox Fired <br/> " );
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Post Back Event of button Fired <br/>");
        }
    }
}