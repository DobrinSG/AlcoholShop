using Shop.Data.BusinessModels;
using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var company = new Company();

            company.Name = "Sweet and Drunk";

            var alcoholShop = new AlcoholShop();

            alcoholShop.Name = "Once Upon a Bottle";

            alcoholShop.Address = new Address("Stara Zagora", "Tsar Simeon Veliki", "123");

            alcoholShop.Fridge = new Fridge();

            var candyShop = new CandyShop();

            candyShop.Name = "Candy Heaven";

            candyShop.Address = new Address("Stara Zagora", "Tsar Simeon Veliki", "102");

            candyShop.AirConditioner = new AirConditioner();

            var whiskeyJack = new Alcohol("Jack Daniels", 190);

            var vodkaSmirnoff = new Alcohol("Smirnoff", 70);

            var table1 = new Table("Table №1", "Free");

            var table2 = new Table("Тable №2", "Free");

            var skittles = new Candy("Skittles", 2);

            var snickers = new Candy("Snickers", 2.5m);

            var nina = new Waitress("Nina", "Dimova", 24);

            var slaveia = new Waitress("Slaveia", "Todorova", 30);

            var petur = new Client("Petur", "Petrov", 42);

            var neli = new Client("Neli", "Kirilova", 25);

            var todor = new Seller("Todor", "Petrov", 27);

            var dimo = new Seller("Dimitar", "Dimitrov,", 32);

            alcoholShop.AddGood(whiskeyJack);

            alcoholShop.AddGood(vodkaSmirnoff);

            alcoholShop.Tables.Add(table1);

            alcoholShop.Tables.Add(table2);

            candyShop.AddGood(skittles);

            candyShop.AddGood(snickers);

            alcoholShop.Waitress.Add(nina);

            alcoholShop.Waitress.Add(slaveia);

            alcoholShop.Clients.Add(petur);

            candyShop.Clients.Add(neli);

            alcoholShop.Sellers.Add(dimo);

            candyShop.Sellers.Add(todor);

            alcoholShop.Reserve(table1);

            Console.WriteLine($"Income before sell---> {alcoholShop.Income} " +
                $"Count: {alcoholShop.Goods.Count()}");

            alcoholShop.Sell(whiskeyJack);

            Console.WriteLine($"Display table1---> {table1.TableNumber}");

            Console.WriteLine($"Income after sell---> {alcoholShop.Income} " +
                $"Count: {alcoholShop.Goods.Count()}");

            Console.Write("List of goods in alcoholShop--->");

            foreach (var good in alcoholShop.Goods)
            {
                Console.WriteLine(good.Name);
            }

            Console.WriteLine($"Count of tables in alcoholShop---> { alcoholShop.Tables.Count}");

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
            Console.WriteLine();
            Console.Write("List of candies in candyShop--->");

            foreach (var candy in candyShop.Goods)
            {
                if (candy == candyShop.Goods[0])
                {
                    Console.Write($"{candy.Name}, ");
                }
                else
                {
                    Console.Write(candy.Name);
                }
            }
            Console.WriteLine();

            Console.WriteLine($"{table1.TableNumber}" + $": {table1.TableStatus}");

            Console.WriteLine($"{table2.TableNumber}" + $": {table2.TableStatus}");

            Console.WriteLine($"candyShop seller---> {candyShop.Sellers[0].FirstName}");

            Console.WriteLine($"alcoholShop seller--->{alcoholShop.Sellers[0].FirstName}");

            Console.ReadLine();
        }
    }
}
