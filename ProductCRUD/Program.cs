using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int no = 0;

            GetCRUD crud = new GetCRUD();

            do
            {

                Console.WriteLine("****************************************");
                Console.WriteLine("1. productList");
                Console.WriteLine("2 get productbye id");
                Console.WriteLine("3 Add product");
                Console.WriteLine("4 update product");
                Console.WriteLine("5 delete product");
                Console.WriteLine("Select the option");

                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        List<Product> list = crud.GetProductList();
                        Console.WriteLine("ID\t Name \t price \t Company");
                        foreach (Product p in list)
                        {
                            Console.WriteLine($"{p.Id} \t{p.Name} \t{p.price}\t{p.Company}");
                        }
                        break;
                    case 2:
                        Console.WriteLine(("Enter the ID want to display"));
                        int id = Convert.ToInt32(Console.ReadLine());
                        Product p1 = crud.GetproductbyeID(id);
                        Console.WriteLine("Id \t Name \t   Price \t   Company");
                        Console.WriteLine($"{p1.Id} \t{p1.Name} \t{p1.price} \t{p1.Company}");

                        break;
                    case 3:
                        Product P2 = new Product();
                        Console.WriteLine("Enter product id");
                        P2.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter product name");
                        P2.Name = Console.ReadLine();
                        Console.WriteLine("Enter product price");
                        P2.price = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter company name");
                        P2.Company = Console.ReadLine();

                        crud.AddProduct(P2);
                        Console.WriteLine("Product saved");
                        break;
                    case 4:
                        Product p2 = new Product();
                        Console.WriteLine("Enter product id");
                        p2.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter product name");
                        p2.Name = Console.ReadLine();
                        Console.WriteLine("Enter product price");
                        p2.price = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter company name");
                        p2.Company = Console.ReadLine();

                        crud.Updateproduct(p2);
                        Console.WriteLine("product update");
                        break;
                    case 5:

                        Console.WriteLine("Enter the product id");
                        int ID2 = Convert.ToInt32(Console.ReadLine());
                        crud.DeleteProduct(ID2);
                        Console.WriteLine($"{ID2} product deleted..");
                        break;













                }
                Console.WriteLine("press 1 for contious");
                no = Convert.ToInt32(Console.ReadLine());
            }
            while (no == 1);
        }
    }
}