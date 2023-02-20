using System;

namespace EXERCISES_2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Dog myDog = new Dog("Buddy", "Collie");
            Console.WriteLine(myDog.Sound());
            Console.WriteLine(myDog.GetInfo());

            Cat myCat = new Cat("Whiskers");
            Console.WriteLine(myCat.Sound());
            Console.WriteLine(myCat.GetInfo());

            Duck myDuck = new Duck("Donald");
            Console.WriteLine(myDuck.Sound());
            Console.WriteLine(myDuck.GetInfo());
            myDuck.Swim("pond");
        }
    }
}
