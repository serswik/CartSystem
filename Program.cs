using System;
using System.Collections.Generic;

namespace CartSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>
            {
                new Product("Laptop", 999m),
                new Product("Smartphone", 700m),
                new Product("Headphones", 400m),
                new Product("Keyboard", 350m),
                new Product("Mouse", 250m)
            };

            var cart = new Cart();

            Console.WriteLine("Welcome to Shopping Cart\n");

            Console.WriteLine("Avaliable products:");
            foreach(var product in products)
            {
                Console.WriteLine($"{product.Name} - ${product.Price}");
            }

            while (true)
            {
                Console.Write("\nEnter the name of the product to add to cart (or 'done' to finish): ");
                string input = Console.ReadLine()?.Trim();

                if (string.Equals(input, "done", StringComparison.OrdinalIgnoreCase))
                    break;

                var selectedProduct = products.Find(p => string.Equals(p.Name, input, StringComparison.OrdinalIgnoreCase));

                if (selectedProduct != null)
                {
                    cart.AddProduct(selectedProduct);
                    Console.WriteLine($"{selectedProduct.Name} added to cart.");
                }
                else
                {
                    Console.WriteLine("Product not found. Please try again.");
                }
            }

            Console.WriteLine("\nEnter your budget: $");
            if(decimal.TryParse(Console.ReadLine(), out decimal budget))
            {
                decimal total = cart.GetTotalAmount();
                Console.WriteLine($"\nTotal amount in cart: ${total}");

                if(total <= budget)
                {
                    Console.WriteLine("Success: Your cart total is within your budget!");
                }
                else
                {
                    Console.WriteLine("Warning: Your cart total exceeds your budget.");
                }
            }
            else
            {
                Console.WriteLine("Invalid budget input.");
            }

            Console.WriteLine("\nThank you for shopping with us!");
        }
    }
}