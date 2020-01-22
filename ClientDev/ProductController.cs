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
    public class ProductController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Product> Get()
        {
            return new Repository().Products;
        }

        // GET api/<controller>/5
        public Product Get(int id)
        {
            return new Repository().Products
                .Where(p => p.ProductID == id).FirstOrDefault();
        }

        // POST api/<controller>
        public void Post([FromBody] Product value)
        {
            new Repository().SaveProduct(value);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] Product value)
        {
            new Repository().SaveProduct(value);
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