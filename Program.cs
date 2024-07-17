using MultilevelInheritance.Models;
namespace MultilevelInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.Name = "Raj";   //Property from Animal is excessed by object of Human class,
                                  //Humen class extends Mammal and Mammal extends Animal .
                                  //It is type of multi inheritance

            Console.WriteLine($"My name is {human.Name} .");
            human.About();
                
        }
    }
   
    
}
