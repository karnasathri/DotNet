using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlsDemo
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(this.IsPostBack + "<br/>");
            if(this.IsPostBack == true)
                Response.Write("Value of TextBox:" + TextBox1.Text); 

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}