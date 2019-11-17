using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Routing
{
    public partial class Loop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<int> getValues([RouteData("count")] int? count)
        {
            for (int i = 0; i < (count ?? 3); i++)
            {
                yield return i;
            }
        }
    }
}