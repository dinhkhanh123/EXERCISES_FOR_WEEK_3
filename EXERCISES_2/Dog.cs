using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCISES_2
{
    class Dog : Animal
    {
        public string Name;
        public string Breed;

        public Dog(string name, string breed) : base("mammal")
        {
            Name = name;
            Breed = breed;
        }

        public override string GetInfo()
        {
            return "Woof!";
        }

        public override string Sound()
        {
            return $"This is a {Type} named {Name}. It is a {Breed} breed.";
        }
    }
}
