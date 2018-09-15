using Shop.Data.BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var alcoholShop = new AlcoholShop();

            var alcohol = new Alcohol("da", 190);

            var alcohol2 = new Alcohol("ne", 70);

         
            alcoholShop.AddGood(alcohol);

            alcoholShop.AddGood(alcohol2);
           
            Console.WriteLine($"Income before---> {alcoholShop.Income} " +
                $"Count: {alcoholShop.Goods.Count()}");

            alcoholShop.Sell(alcohol);


            Console.WriteLine($"Income after---> {alcoholShop.Income} " +
                $"Count: {alcoholShop.Goods.Count()}");
            //Console.WriteLine($"Alcohol 2 ---> {alcohol2.Price}");

            Console.ReadLine();
        }
    }
}
