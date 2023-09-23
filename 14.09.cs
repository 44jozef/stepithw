using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class Program
{
    static List<Product> products = new List<Product>();
    static string jsonFilePath = "products.json";

    static void Main()
    {
        LoadProductsFromJson();

        while (true)
        {
            Console.WriteLine("Barn Management System");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Edit Product");
            Console.WriteLine("3. Delete Product");
            Console.WriteLine("4. List Products");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        AddProduct();
                        break;
                    case 2:
                        EditProduct();
                        break;
                    case 3:
                        DeleteProduct();
                        break;
                    case 4:
                        ListProducts();
                        break;
                    case 5:
                        SaveProductsToJson();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }

    static void AddProduct()
    {
        Console.WriteLine("Enter Product Details:");
        Console.Write("ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Production Date (yyyy-MM-dd): ");
        DateTime productionDate = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", null);
        Console.Write("Expires On (yyyy-MM-dd): ");
        DateTime expiresOn = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", null);
        Console.Write("Gross Weight: ");
        double grossWeight = double.Parse(Console.ReadLine());
        Console.Write("Netto Weight: ");
        double nettoWeight = double.Parse(Console.ReadLine());

        var product = new Product
        {
            ID = id,
            Name = name,
            ProductionDate = productionDate,
            ExpiresOn = expiresOn,
            GrossWeight = grossWeight,
            NettoWeight = nettoWeight
        };

        products.Add(product);
        Console.WriteLine("Product added successfully.");
    }

    static void EditProduct()
    {
        Console.Write("Enter the ID of the product you want to edit: ");
        int id = int.Parse(Console.ReadLine());

        var product = products.Find(p => p.ID == id);
        if (product == null)
        {
            Console.WriteLine("Product not found.");
            return;
        }

        Console.WriteLine("Enter new Product Details:");
        Console.Write("Name: ");
        product.Name = Console.ReadLine();
        Console.Write("Production Date (yyyy-MM-dd): ");
        product.ProductionDate = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", null);
        Console.Write("Expires On (yyyy-MM-dd): ");
        product.ExpiresOn = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", null);
        Console.Write("Gross Weight: ");
        product.GrossWeight = double.Parse(Console.ReadLine());
        Console.Write("Netto Weight: ");
        product.NettoWeight = double.Parse(Console.ReadLine());

        Console.WriteLine("Product edited successfully.");
    }

    static void DeleteProduct()
    {
        Console.Write("Enter the ID of the product you want to delete: ");
        int id = int.Parse(Console.ReadLine());
        var product = products.Find(p => p.ID == id);
        if (product == null)
        {
            Console.WriteLine("Product not found.");
            return;
        }

        products.Remove(product);
        Console.WriteLine("Product deleted successfully.");
    }

    static void ListProducts()
    {
        Console.WriteLine("List of Products:");
        foreach (var product in products)
        {
            Console.WriteLine($"ID: {product.ID}, Name: {product.Name}, Production Date: {product.ProductionDate.ToString("yyyy-MM-dd")}, Expires On: {product.ExpiresOn.ToString("yyyy-MM-dd")}, Gross Weight: {product.GrossWeight}, Netto Weight: {product.NettoWeight}");
        }
    }

    static void LoadProductsFromJson()
    {
        if (File.Exists(jsonFilePath))
        {
            string json = File.ReadAllText(jsonFilePath);
            products = JsonConvert.DeserializeObject<List<Product>>(json);
        }
    }

    static void SaveProductsToJson()
    {
        string json = JsonConvert.SerializeObject(products, Formatting.Indented);
        File.WriteAllText(jsonFilePath, json);
    }
}

class Product
{
    public int ID { get; set; }
    public string Name { get; set; }
    public DateTime ProductionDate { get; set; }
    public DateTime ExpiresOn { get; set; }
    public double GrossWeight { get; set; }
    public double NettoWeight { get; set; }
}
