using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ClubSandwich:ISandwiches
    {

        public void Description()
        {
            Console.WriteLine("Turkey, ham and bacon.");
        }
    }
}
