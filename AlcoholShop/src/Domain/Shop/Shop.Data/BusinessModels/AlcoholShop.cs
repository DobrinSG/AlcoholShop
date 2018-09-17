using System;
using System.Collections.Generic;

namespace Shop.Data.BusinessModels
{
    public class AlcoholShop : BaseShop
    {
        public AlcoholShop()
        {
            this.Tables = new List<Table>();
            this.Waitress = new List<Person>();
        }

        private string name;

        public string Name { get { return name; } set { name = value; } }

        public List<Table> Tables { get; set; }

        public List<Person> Waitress { get; set; }

        public Fridge Fridge { get; set; }

        public override bool CheckGoods(Good good)
        {
            if (!(good is Alcohol))
            {
                return false;
            }
            return true;
        }

        public void Reserve(Table table)
        {
            if (table.TableStatus == "Free")
            {
                table.TableStatus = "Reserved";
            }
        }
    }
}
