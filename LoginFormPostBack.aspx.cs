using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlsDemo
{
    public partial class LoginFormPostBack : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
                txtName.Focus();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "admin" && txtPwd.Text == "admin")
                Response.Write("Valied User.");
            else
                Response.Write("Invakied User.");
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtName.Focus();
        }
    }
}