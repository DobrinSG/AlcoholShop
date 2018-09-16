using System;
using System.Collections.Generic;

namespace Shop.Data.BusinessModels
{
    public class AlcoholShop : BaseShop
    {
        public AlcoholShop()
        {
            this.Tables = new List<Table>();
        }

        private string name;

        public string Name { get { return name; } set { name = value; } }

        public List<Table> Tables { get; set; }

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
