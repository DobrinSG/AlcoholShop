using System;

namespace Shop.Data.BusinessModels
{
    public class AlcoholShop : BaseShop
    {
        private string name;

        public string Name { get { return name; } set { name = value; } }

        public override bool CheckGoods(Good good)
        {
            if (!(good is Alcohol))
            {
                return false;
            }
            return true;
        }
    }
}
