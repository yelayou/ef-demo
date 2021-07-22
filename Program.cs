using System;

namespace EfDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program started");
            using (var context = new EfDemoDbContext("Server=(local);Database=EfDemo;Trusted_Connection=True;"))
            {
                foreach (var product in context.Products)
                {
                    Console.WriteLine($"#{product.Id}: {product.Name}");
                }
            }
            Console.WriteLine("Program started");
        }
    }
}
