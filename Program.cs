using System;
using Microsoft.Data.SqlClient;

namespace EfDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Change the following connection string value as required to connect to your SQL Server instance and DB
            //var connectionString = "Server=(localhost:1433);Database=EfDemo;Trusted_Connection=True;";
            var connectionString = "Data Source=localhost,1433;Initial Catalog=EfDemo;Database=EfDemo; User=sa;Password=P@$$w0rd;TrustServerCertificate=True";


            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the database connection
                    connection.Open();

                    // TODO: Add your database operations here

                    Console.WriteLine("Connected to the database successfully.");

                    // Close the connection when done
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            Console.WriteLine("---------- Program started ----------");
            using (var context = new EfDemoDbContext(connectionString))
            {
                foreach (var product in context.Products)
                {
                    Console.WriteLine($"{product.Name} (#{product.Id}): {product.Desc}");
                }
            }
            Console.WriteLine("---------- Program Ended ----------");
        }
    }
}
