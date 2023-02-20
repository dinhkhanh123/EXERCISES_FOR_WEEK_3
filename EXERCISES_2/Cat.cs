using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCISES_2
{
     class Cat : Animal
    {
        public string Name;

        public Cat(string name) : base("mammal")
        {
            Name = name;
        }

        public override string GetInfo()
        {
            return "Meow!";
        }

        public override string Sound()
        {
            return $"This is a {Type} named {Name}.";
        }

        public void Climb(string thing)
        {
            Console.WriteLine($"{Name} is climbing {thing}.");
        }
    }
}
