using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Data.BusinessModels
{
  public class Table : AlcoholShop
    {
        public Table(string tableNumber)
        {
           TableNumber = tableNumber;
        }

        public string TableNumber { get; set; }
    }
}
