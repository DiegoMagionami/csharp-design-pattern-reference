using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.classes
{
    public class Cow : IAnimal
    {
        public string MakeSound()
        {
            return "Moo";
        }
    }
}
