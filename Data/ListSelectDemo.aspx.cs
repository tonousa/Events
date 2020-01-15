using Data.Models;
using Data.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Data
{
    public partial class ListSelectDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<Product> GetProducts(
            [Control("ls", "Value")] string category)
        {
            var data = new Repository().Products;
            return category == "All" ? data : data.Where(p => p.Category == category);
        }

        public IEnumerable<ListItem> GetCategories()
        {
            return new Product[] { new Product { Category = "All" } }
                .Concat((new Repository().Products
                .GroupBy(p => p.Category).Select(g => g.First())
                .OrderBy(c => c.Category)))
                .Select(c => {
                    return new ListItem
                    {
                        Text = c.Category,
                        Selected = (c.Category == "Chess")
                    };
                });
        }
    }
}