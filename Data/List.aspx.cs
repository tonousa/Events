using Data.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Data
{
    public partial class List : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                List<string> selected = new List<string>();
                foreach (ListItem item in list.Items)
                {
                    if (item.Selected)
                    {
                        selected.Add(item.Value);
                    }
                }
                selection.InnerText = string.Join(", ", selected.ToArray());
            }
        }

        public IEnumerable<string> GetProducts()
        {
            return new Repository().Products.Select(p => p.Name);
        }
    }
}