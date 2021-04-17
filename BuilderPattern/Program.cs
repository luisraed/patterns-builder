using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Building a product using the Builder Pattern");

            var productBuilderDirector = new ProductBuilderDirector();
            var productOne = productBuilderDirector.Build();

            Console.WriteLine($"Showing Product Info for {productOne.Description}");
            Console.WriteLine($"ProductId: {productOne.ProductId}");
            Console.WriteLine($"ProductCode: {productOne.ProductCode}");
            Console.WriteLine($"Title: {productOne.Title}");
            Console.WriteLine($"Description: {productOne.Description}");
            Console.WriteLine($"Product Categories");
            productOne.Categories.ForEach(c => Console.WriteLine($"{c.CategoryId} - {c.Name}"));
            Console.WriteLine($"Providers for this product");
            productOne.Providers.ForEach(p => Console.WriteLine($"{p.ProviderId} - {p.Name}"));
            Console.ReadKey();
        }
    }
}
