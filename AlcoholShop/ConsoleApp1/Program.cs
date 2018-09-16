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
            
            Console.WriteLine($"Income before sell---> {alcoholShop.Income} " +
                $"Count: {alcoholShop.Goods.Count()}");

            alcoholShop.Sell(wiskeyJack);

            Console.WriteLine($"Display table1---> {table1.TableNumber}");

            Console.WriteLine($"Income after sell---> {alcoholShop.Income} " +
                $"Count: {alcoholShop.Goods.Count()}");

            Console.Write("List of goods in alcoholShop--->");

            foreach (var good in alcoholShop.Goods)
            {
                Console.WriteLine(good.Name);
            }

            Console.WriteLine($"Count of tables---> { alcoholShop.Tables.Count}");

            Console.Write("List of tables in alcoholShop--->");

            foreach (var table in alcoholShop.Tables)
            {
                if (table == alcoholShop.Tables[0])
                {

                Console.Write($"{ table.TableNumber}, ");
                }
                else
                {
                    Console.Write(table.TableNumber);
                }
            }

            Console.ReadLine();
        }
    }
}
