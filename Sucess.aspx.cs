using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlsDemo
{
    public partial class Sucess : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Control ctrl = PreviousPage.FindControl("txtName");
            //TextBox tb = (TextBox)PreviousPage.FindControl("txtName");
            string Name = ((TextBox)PreviousPage.FindControl("txtName")).Text;

            Response.Write("Hello "+Name+", Have a nice day");

        }
    }
}