using Shop.Data.Interfaces;
using System;

namespace Shop.Data.BusinessModels
{
    public abstract class Good : IEquatable<Good>
    {
        protected Good(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; }
        public decimal Price { get;}
        

        public override string ToString()
        {
            return Price.ToString();
        }
        
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public bool Equals(Good goodToCheckWith)
        {
            if (goodToCheckWith == null)
            {
                return false;
            }

            return this.Name.Equals(goodToCheckWith.Name)
                        && this.Price == goodToCheckWith.Price;
        }
    }
}