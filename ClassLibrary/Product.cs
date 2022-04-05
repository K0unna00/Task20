using System;

namespace ClassLibrary
{
    public class Product
    {
        public Product()
        {
            TotalCount++;
            No = TotalCount;
        }
        public static int TotalCount;
        public string Name { get; set; }   
        private int No { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public int GetNo()
        {
            return No;
        }
         
    }
}
