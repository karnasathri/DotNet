using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlsDemo
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Hello world");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write(" <br/> Button1 is clicked.");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Write(" <br/> Button2 is clicked.");
        }
    }
}