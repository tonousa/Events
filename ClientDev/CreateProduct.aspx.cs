﻿using ClientDev.Models;
using ClientDev.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClientDev
{
    public partial class CreateProduct : System.Web.UI.Page
    {
        private List<Product> CreatedProducts;

        protected void Page_Load(object sender, EventArgs e)
        {
            CreatedProducts = (List<Product>)ViewState["data"] ?? new List<Product>();

            if (IsPostBack)
            {
                Product newProd = new Product();
                TryUpdateModel<Product>(newProd,
                    new FormValueProvider(ModelBindingExecutionContext));
                if (ModelState.IsValid)
                {
                    new Repository().AddProduct(newProd);
                    CreatedProducts.Add(newProd);
                    ViewState["data"] = CreatedProducts;
                    DataBind();
                }
            }
        }

        public IEnumerable<Product> GetCreated()
        {
            return CreatedProducts;
        }
    }
}