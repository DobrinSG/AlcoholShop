using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Data.BusinessModels
{
   public class CandyShop : BaseShop
    {
        public CandyShop()
        {
        }

        public override bool CheckGoods(Good good)
        {
            throw new NotImplementedException();
        }
    }
}
