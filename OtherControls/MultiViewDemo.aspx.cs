﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OtherControls
{
    public partial class MultiViewDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            mView.ActiveViewIndex = nameSelect.SelectedIndex;
        }
    }
}