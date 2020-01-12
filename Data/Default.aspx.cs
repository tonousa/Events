using Data.Models;
using Data.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Data
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<Product> GetProductData()
        {
            return new Repository().Products;
        }

        public IEnumerable<string> GetCategories()
        {
            return new Repository().Products
                .Select(p => p.Category).Distinct().OrderBy(c => c);
        }
    }
}