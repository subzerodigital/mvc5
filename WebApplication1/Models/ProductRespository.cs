using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace WebApplication1.Models
{
    public class ProductRespository
    {
        internal Product create() {

            Product product = new Product
            {
                ReleaseDate = DateTime.Now
            };
            return product;
        }

        internal List<Product> Retrieve() {
            var filePath = HostingEnvironment.MapPath(@"~/App_Data/product.json");
            var json = System.IO.File.ReadAllText(filePath);
            var products = JsonConvert.DeserializeObject<List<Product>>(json);
            return products;
        }

    }
}