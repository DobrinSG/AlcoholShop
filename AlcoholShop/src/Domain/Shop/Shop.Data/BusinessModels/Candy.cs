using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Data.BusinessModels
{
   public class Candy : Good
    {
        public Candy(string name, decimal price) : base(name, price)
        {
        }
    }
}
