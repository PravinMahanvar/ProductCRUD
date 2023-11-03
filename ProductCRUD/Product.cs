using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCRUD
{
    public  class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int price { get; set; }
        public string Company { get; set; }
    }

    public class GetCRUD
    {
        private List<Product> productlist;
        public GetCRUD()
        {
            productlist = new List<Product>()
            {
                new Product{ Id= 1, Name="Loptop", price= 36000, Company="HP"},
                new Product{ Id= 2, Name="Loptop", price= 38000,Company="DELL" }
            };
        }
        public List<Product> GetProductList()
        {
            return productlist;
        }

        public Product GetproductbyeID(int id)
        {
            Product product = new Product();
            foreach (Product p in productlist)
            {
                if(p.Id == id)
                {
                    product= p;
                    break;
                }
            }
            return product;
        }
        public void AddProduct(Product p)
        {
            productlist.Add(p);
        }

        public void Updateproduct(Product p)
        {
            foreach(Product iteam in productlist)
            {
                if(iteam.Id == p.Id)
                {
                    iteam.Name = p.Name;
                    iteam.price= p.price;
                    iteam.Company = p.Company;
                    break;
                }
            }
        }
        
        public void DeleteProduct(int id) 
        {
            foreach (Product iteam in productlist)
            {
                if(iteam.Id ==id)
                {
                    productlist.Remove(iteam);
                    break;
                }
                
            }
               
        }
       
    }
}
