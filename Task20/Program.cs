using System;
using ClassLibrary;

namespace Task20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            
            do
            {
                Console.WriteLine("Product elave etmey isteyirsiniz ? : ");
                string ans= Console.ReadLine();
                if (ans=="y")
                {
                    Console.WriteLine("Adi yazin : ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Qiymeti yazin:");
                    double price = double.Parse(Console.ReadLine());
                    Console.WriteLine("Type-i yazin: ");
                    string type = Console.ReadLine();
                    Product product = new Product()
                    {
                        Name = name,
                        Price = price,
                        Type = type
                    };

                    store.AddProduct(product);
                }
                else if (ans == "n")
                {
                    break;
                }
            }while (true);
            
            bool check = true;
            while (check)
            {
                Console.WriteLine("Ne etmek isteyirsiniz ? : \n1. Nomre deyerine gore product silmey \n2.Type-a gore filterlemek \n3. Ada gore filterlemk\n4.Productlari ekrana ver ve prosesi bitir ");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "1":
                        Console.WriteLine("Nomreni daxil edin : ");
                        int no = int.Parse(Console.ReadLine());
                        store.RemoveProductByName(no);
                        break;
                    case "2":
                        Console.WriteLine("Type-i daxil edin : ");
                        string type= Console.ReadLine();    
                        store.FilterProductByType(type);
                        break;
                    case "3":
                        Console.WriteLine("Adi daxil edin : ");
                        string name = Console.ReadLine();
                        break;
                    case "4":
                        store.GetInfo();
                        check = false;
                        break;
                    default:
                        break;
                }
            }
            

        }
    }
}
