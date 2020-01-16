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

        public void UpdateProduct(int? productID) {
            Repository repo = new Repository();
            Product product = repo.Products
                .Where(p => p.ProductID == productID).FirstOrDefault();
            if (product != null && TryUpdateModel<Product>(product))
            {
                repo.SaveProduct(product);
            }
        }

        public void DeleteProduct(int? productID) {
            Repository repo = new Repository();
            Product product = repo.Products
                .Where(p => p.ProductID == productID).FirstOrDefault();
            if (product != null)
            {
                repo.DeleteProduct(product);
            }
        }

        public void InsertProduct() {
            Product product = new Product();
            if (TryUpdateModel<Product>(product))
            {
                new Repository().AddProduct(product);
            }
        }
    }
}