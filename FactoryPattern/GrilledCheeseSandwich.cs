using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class GrilledCheeseSandwich : ISandwiches
    {
        public void Description()
        {
            Console.WriteLine("Melted cheese and toasted bread");
        }
    }
}
