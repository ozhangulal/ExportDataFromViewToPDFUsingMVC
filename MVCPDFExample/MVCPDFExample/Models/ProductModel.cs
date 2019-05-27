using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCPDFExample.Models
{
    public class ProductModel
    {
        public List<Product> findAll()
        {
            List<Product> result = new List<Product>();
            result.Add(new Product { Id = "MJ01", Name = "Jordan 12", Price = 200, Photo = "jordan1.jpg" });
            result.Add(new Product { Id = "MJ02", Name = "Jordan 1", Price = 1200, Photo = "jordan2.jpg" });
            result.Add(new Product { Id = "MJ03", Name = "Jordan 14", Price = 400, Photo = "jordan3.jpg" });
            return result;
        }
    }
}