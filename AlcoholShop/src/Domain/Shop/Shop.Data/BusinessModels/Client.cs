using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Data.BusinessModels
{
   public class Client : Person
    {
        public Client(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
        }
    }
}
