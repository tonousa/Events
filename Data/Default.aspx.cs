using Data.Models;
using Data.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.ModelBinding;

namespace Data
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<Product> GetProductData(
            [Control("ddList", "SelectedValue")] string filterSelect)
        {
            var productData = new Repository().Products;
            return (filterSelect ?? "All") == "All" ? productData
                : productData.Where(p => p.Category == filterSelect);
        }

        public IEnumerable<string> GetCategories()
        {
            return new string[] { "All" }.Concat(new Repository().Products
                .Select(p => p.Category).Distinct().OrderBy(c => c));
        }
    }
}