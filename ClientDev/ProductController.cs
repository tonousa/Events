using ClientDev.Models;
using ClientDev.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ClientDev
{
    public class ProductView
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

        public ProductView() { }

        public ProductView(Product product)
        {
            this.ProductID = product.ProductID;
            this.Name = product.Name;
            this.Price = product.Price;
            this.Category = product.Category;
        }

        public Product ToProduct()
        {
            return new Product
            {
                ProductID = this.ProductID,
                Name = this.Name,
                Price = this.Price,
                Category = this.Category
            };
        }
    }

    public class ProductController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<ProductView> Get()
        {
            return new Repository().Products
                .Select(p => new ProductView(p));
        }

        // GET api/<controller>/5
        public ProductView Get(int id)
        {
            return new Repository().Products
                .Where(p => p.ProductID == id)
                .Select(p => new ProductView(p)).FirstOrDefault();
        }

        // POST api/<controller>
        public void Post([FromBody] ProductView value)
        {
            new Repository().SaveProduct(value.ToProduct());
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] ProductView value)
        {
            Repository repo = new Repository();
            Product current = repo.Products
                .Where(p => p.ProductID == id).FirstOrDefault();
            if (current != null)
            {
                current.Name = value.Name;
                current.Price = value.Price;
                current.Category = value.Category;
            }
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            Repository repo = new Repository();
            Product product = repo.Products
                .Where(p => p.ProductID == id).FirstOrDefault();
            if (product != null)
            {
                repo.DeleteProduct(product);
            }
        }
    }
}