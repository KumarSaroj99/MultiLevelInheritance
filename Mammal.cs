using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritance.Models
{
    internal class Mammal:Animal
    {
        public void About()
        {
            Console.WriteLine("I am from class Mammal .");
        }
    }
}
