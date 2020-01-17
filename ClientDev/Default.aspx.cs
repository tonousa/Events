﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClientDev
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string selectedColor;
            if (IsPostBack && (selectedColor = Request.Form["color"]) != null)
            {
                selectedValue.InnerText = selectedColor;
            }
        }
    }
}