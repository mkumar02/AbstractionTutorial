using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionTutorial
{
    class Dog : IAnimal
    {
        public string AnimalType()
        {
            return "Domestic";
        }
    }
}
