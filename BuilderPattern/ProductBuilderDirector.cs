namespace BuilderPattern
{
    public interface IProductBuilderDirector
    {
        Product Build();
    }
    public class ProductBuilderDirector : IProductBuilderDirector
    {
        private readonly IProductBuilder _productBuilder;
        public ProductBuilderDirector()
        {
            _productBuilder = new ProductBuilder();
        }
        public Product Build()
        {
            _productBuilder.StartNew();
            _productBuilder.BuildProductId();
            _productBuilder.BuildProductCode();
            _productBuilder.BuildProductTitle();
            _productBuilder.BuildProductDescription();
            _productBuilder.BuildProductCategories();
            _productBuilder.BuildProductProviders();

            return _productBuilder.GetValue();
        }
    }
}
