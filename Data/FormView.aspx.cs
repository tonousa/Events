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
    public partial class FormView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Product> GetProducts()
        {
            return new Repository().Products.AsQueryable<Product>();
        }

        public void UpdateProduct() { }
        public void DeleteProduct() { }
        public void InsertProduct() { }
    }
}