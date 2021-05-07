using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.classes
{
    public class Dog : IAnimal
    {
        public string MakeSound()
        {
            return "woof";
        }
    }
}
