using System;
using System.Text;

namespace Shop.Data.BusinessModels
{
  public class Table 
    {
        public Table(string tableNumber, string tableStatus)
        {
           TableNumber = tableNumber;
            TableStatus = tableStatus;
        }

        public string TableNumber { get; set; }

        public string TableStatus { get; set; }
    }
}
