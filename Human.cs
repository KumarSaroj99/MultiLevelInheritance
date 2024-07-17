using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritance.Models
{
    internal class Human:Mammal
    {
        public void About()
        {
            Console.WriteLine("I am a Human .");
        }
    }
}
