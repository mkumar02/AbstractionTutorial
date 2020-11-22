using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionTutorial
{
    interface IAnimal
    {
        public string ReturnSound(string sound)
        {
            return sound;
        }

        string AnimalType();
    }
}
