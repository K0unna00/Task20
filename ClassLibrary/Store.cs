using System;
using System.Collections.Generic;
using System.Text;
using Enums;

namespace ClassLibrary
{
    public class Store
    {
        public Product[] Products = new Product[0];
        public void AddProduct(Product product)
        {
            Array.Resize(ref Products, Products.Length + 1);
            Products[Products.Length - 1] = product;
        }
        public void RemoveProductByName(int no)
        {
            Product[] NewProducts = new Product[0];
            foreach (var item in Products)
            {
                if (item.GetNo() != no)
                {
                    Array.Resize(ref NewProducts, NewProducts.Length + 1);
                    NewProducts[NewProducts.Length - 1] = item;
                }
            }
            Products = NewProducts;
        }
        public void FilterProductByType(string type)
        {
            int typeInt=int.Parse(type);
            Product[] NewProducts = new Product[0];
            foreach (var item in Products)
            {
                if (item.Type == (TypeEnums)typeInt)
                {
                    Array.Resize(ref NewProducts, NewProducts.Length + 1);
                    NewProducts[NewProducts.Length - 1] = item;
                }
            }
            Products = NewProducts;
        }
        public void FilterProductByName(string name)
        {
            Product[] NewProducts = new Product[0];
            foreach (var item in Products)
            {
                if (item.Name == name)
                {
                    Array.Resize(ref NewProducts, NewProducts.Length + 1);
                    NewProducts[NewProducts.Length - 1] = item;
                }
            }
            Products = NewProducts;
        }
        public void GetInfo()
        {
            foreach (var item in Products)
            {
                Console.WriteLine($"Name : {item.Name} Price : {item.Price}  Type : {item.Type} ");
            }
        }
    }
}
