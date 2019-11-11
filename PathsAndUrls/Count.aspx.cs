using Microsoft.AspNet.FriendlyUrls.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PathsAndUrls
{
    public partial class Count : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<int> GetNumbers([FriendlyUrlSegments(0)] int? max)
        {
            for (int i = 0; i < (max ?? 5); i++)
            {
                yield return i;
            }
        }
    }
}