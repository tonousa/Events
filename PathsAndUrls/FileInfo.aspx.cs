using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace PathsAndUrls
{
    public partial class FileInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string GetFileContent()
        {
            string path = "/Colors.html";
            string file = Request.MapPath(path);
            return File.ReadAllText(file);
        }
    }
}