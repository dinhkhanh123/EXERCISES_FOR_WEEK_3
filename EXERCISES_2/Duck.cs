using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCISES_2
{
    class Duck : Animal
    {
        public string Name;

        public Duck(string name): base("bird")
        {
            Name = name;
        }

        public override string GetInfo()
        {
            return "Quack";
        }

        public override string Sound()
        {
            return $"This is a {Type} named {Name}.";
        }

     

        public void Swim(string thing)
        {
            Console.WriteLine($"{Name} is swimming in the {thing}.");
        }
    }
}
