using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCISES_2
{
    abstract class Animal
    {
        protected string Type;

        public Animal(string type)
        {
            Type = type;
        }

        public abstract string Sound();

        public abstract string GetInfo();



    }
}
