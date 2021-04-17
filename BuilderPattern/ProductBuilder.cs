using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    public interface IProductBuilder
    {
        void StartNew();
        void BuildProductId();
        void BuildProductCode();
        void BuildProductTitle();
        void BuildProductDescription();
        void BuildProductCategories();
        void BuildProductProviders();
        Product GetValue();
    }
    public class ProductBuilder : IProductBuilder
    {
        private Product _product;
        public void BuildProductCategories()
        {
            _product.Categories = new List<Category>
            {
                new Category { CategoryId = Guid.NewGuid(), Name = "Category 1"},
                new Category { CategoryId = Guid.NewGuid(), Name = "Category 2"}
            };
        }

        public void BuildProductCode()
        {
            _product.ProductCode = $"PC-{Guid.NewGuid()}";
        }

        public void BuildProductDescription()
        {
            _product.Description = $"Product Description - {Guid.NewGuid()}";
        }

        public void BuildProductId()
        {
            _product.ProductId = Guid.NewGuid();
        }

        public void BuildProductProviders()
        {
            _product.Providers = new List<Provider>
            {
                new Provider { ProviderId = Guid.NewGuid(), Name = "Provider 1" },
                new Provider { ProviderId = Guid.NewGuid(), Name = "Provider 2" }
            };
        }

        public void BuildProductTitle()
        {
            _product.Title = $"Product Title for {_product.ProductId}";
        }

        public Product GetValue()
        {
            return _product;
        }

        public void StartNew()
        {
            _product = new Product();
        }
    }
}
