﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlsDemo
{
    public partial class Validate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Name = Request.Form["txtName"];
            string Pwd = Request.Form["txtPwd"];

            if (Name == "admin" && Pwd == "admin")
                Response.Write("Valied User.");
            else
                Response.Write("Invalied User.");
        }
    }
}