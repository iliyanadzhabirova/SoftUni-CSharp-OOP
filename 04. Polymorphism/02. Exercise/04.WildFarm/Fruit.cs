using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm
{
    public class Fruit : Food
    {
        public Fruit(int quantity)
            : base(quantity)
        {
            Quantity = quantity;
        }

        public override int Quantity { get; set; }
    }
}