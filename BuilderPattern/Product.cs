using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string ProductCode { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Category> Categories { get; set; }
        public List<Provider> Providers { get; set; }      
    }
}
