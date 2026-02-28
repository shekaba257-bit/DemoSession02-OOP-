using System;
using System.Collections.Generic;
using System.Text;

namespace DemoSession02_OOP_
{
    internal class Product
    {
        //Static Variable
        public static int TotalProducts = 0;
        //Properties
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Price { get; set; }  


        //Static CTOR

        static Product()
        {
            Console.WriteLine("<<< Static Constructor Inside Product Class >>>");
            TotalProducts = 0;
        }

        public Product( string name, decimal price)
        {
             Name = name;
            Price = price;
            Id = TotalProducts;
            TotalProducts++;
        }

        public override string ToString() => $"<< Id : {Id} - Name :{Name} - Price : {Price}";
        
        
    }
}
