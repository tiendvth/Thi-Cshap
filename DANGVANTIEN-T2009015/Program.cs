using System;
using System.Collections.Generic;

namespace DANGVANTIEN_T2009015
{
    internal class Program
    {
        private List<Product> _products = new List<Product>();

        public static void Main(string[] args)
        {
            new Program().ShowMenu();
        }


        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\n1. Add product records");
                Console.WriteLine("2. Display product records");
                Console.WriteLine("3. Delete product by Id");
                Console.WriteLine("4. Exit\n");
                var choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddProduct();
                        break;
                    case 2:
                        Display();
                        break;
                    case 3:
                        Delete();
                        break;
                    case 4:
                        Console.WriteLine("good bye");
                        break;
                }

                if (choice == 4)
                {
                    break;
                }
            }
        }


        public void AddProduct()
        {
            Console.WriteLine("please enter the product id");
            var id = Console.ReadLine();
            Console.WriteLine("Please enter the product name");
            var name = Console.ReadLine();
            Console.WriteLine("Please enter the price of the product");
            var price = double.Parse(Console.ReadLine());
            _products.Add(new Product(id, name, price));
            Console.WriteLine("more successful products\n");
        }


        public void Display()
        {
            if (_products.Count > 0)
            {
                for (var i = 0; i < _products.Count; i++)
                {
                    Console.WriteLine(_products[i].ToString());
                }
            }
            else
            {
                Console.WriteLine("You don't have any products yet\n");
            }
        }


        public void Delete()
        {
            if (_products.Count < 1)
            {
                Console.WriteLine("You don't have any products yet");
            }
            else
            {
                Console.WriteLine("Enter the id of the product you want to delete");
                var id = Console.ReadLine();
                var deleted = 1;
                for (var i = 0; i < _products.Count; i++)
                {
                    if (_products[i].Id.Equals(id))
                    {
                        deleted = 2;
                        _products.RemoveAt(i);
                    }
                }

                if (deleted == 1)
                {
                    Console.WriteLine($"No products found with ID = {id}");
                }
                else
                {
                    Console.WriteLine("successful delete");
                }
            }
        }
    }
}