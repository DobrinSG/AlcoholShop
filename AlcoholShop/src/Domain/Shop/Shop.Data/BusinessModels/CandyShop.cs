using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Data.BusinessModels
{
   public class CandyShop : BaseShop
    {
        private string name;

        public string Name { get { return name; } set { name = value; } }

        public AirConditioner AirConditioner { get; set; }

        public override bool CheckGoods(Good good)
        {
            if (!(good is Candy))
            {
                return false;
            }
            return true;
        }
    }
}