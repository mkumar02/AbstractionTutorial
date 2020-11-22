using System;

namespace AbstractionTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            //dog.Sound = "Bow Bow";
            Console.WriteLine("Dog is " + dog.AnimalType());
        }
    }
}
