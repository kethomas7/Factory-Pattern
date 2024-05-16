using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class SandwichFactory
    {
        public static ISandwiches MakeSandwiches(string order)
        {
            switch (order.ToLower())
            {
                case "club sandwich":
                case "club":
                    return new ClubSandwich();
                case "grilled cheese sandwich":
                case "grilled cheese":
                    return new GrilledCheeseSandwich();
                default: return new ClubSandwich();
            }

          
        }

    }
}
