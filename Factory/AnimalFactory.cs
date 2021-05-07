using Factory.classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public static class AnimalFactory
    {
        public static IAnimal Build(int animal)
        {
            switch(animal)
            {
                case 1:
                    return new Dog();
                case 2:
                    return new Cat();
                case 3:
                    return new Cow();
                default:
                    return new Dog();
            }
        }
    }
}
