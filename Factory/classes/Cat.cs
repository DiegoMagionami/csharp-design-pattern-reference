using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.classes
{
    public class Cat : IAnimal
    {
        public string MakeSound()
        {
            return "meow";
        }
    }
}
