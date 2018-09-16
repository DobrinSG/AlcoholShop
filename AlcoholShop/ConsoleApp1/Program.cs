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

            var wiskeyJack = new Alcohol("Jack Daniels", 190);

            var vodkaSmirnoff = new Alcohol("Smirnoff", 70);

            var table1 = new Table("Table №1");

            var table2 = new Table("Тable №2");

            
            
         
            alcoholShop.AddGood(wiskeyJack);

            alcoholShop.AddGood(vodkaSmirnoff);


            alcoholShop.Tables.Add(table1);

            alcoholShop.Tables.Add(table2);
            
            Console.WriteLine($"Income before---> {alcoholShop.Income} " +
                $"Count: {alcoholShop.Goods.Count()}");

          //  alcoholShop.Sell(wiskeyJack);

            Console.WriteLine(table1.TableNumber);

            Console.WriteLine($"Income after---> {alcoholShop.Income} " +
                $"Count: {alcoholShop.Goods.Count()}");
            //Console.WriteLine($"Alcohol 2 ---> {alcohol2.Price}");

            foreach (var good in alcoholShop.Goods)
            {
                Console.WriteLine(good.Name);
            }

            Console.WriteLine(alcoholShop.Tables.Count);

            foreach (var table in alcoholShop.Tables)
            {
                Console.WriteLine(table.TableNumber);
            }

            Console.ReadLine();
        }
    }
}
