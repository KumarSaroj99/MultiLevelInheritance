using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritance.Models
{
    internal class Animal
    {
        public string Name { get; set; }
        public void About()
        {
            Console.WriteLine("I am from Kingdom Animal .");
        }
    }
}
