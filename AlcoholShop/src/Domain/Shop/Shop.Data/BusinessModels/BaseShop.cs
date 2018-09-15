using Shop.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Data.BusinessModels
{
    public abstract class BaseShop : ISellable
    {
        public BaseShop()
        {
            this.Goods = new List<Good>();
        }

        public Company Company { get; set; }

        public Address Address { get; set; }

        public List<Good> Goods { get; set; }

        public decimal Income { get; set; }

        public void AddGood(Good good)
        {
            if (CheckGoods(good))
            {
                Goods.Add(good);
            }
            else
            {
                throw new Exception("Check for good type failed!");
            }
        }

        public abstract bool CheckGoods(Good good);

        public void Sell(Good goodToSell)
        {
            var list = Goods.ToList();

            foreach (var good in Goods)
            {
                if (goodToSell == good)
                {
                    list.Remove(goodToSell);
                    Income += goodToSell.Price;
                }
            }

            Goods = list;
        }

        public override string ToString()
        {
            var goods = string.Empty;

            foreach (var good in Goods)
            {
                goods += good.ToString();
            }

            return goods;
        }
    }
}
