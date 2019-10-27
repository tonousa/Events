using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ErrorHandling
{
    public partial class MultipleErrors : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<string> GetErrorMessages()
        {
            return Context.AllErrors.Select(e => e.Message);
        }
    }
}