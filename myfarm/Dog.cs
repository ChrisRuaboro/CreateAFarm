using System;
using System.Collections.Generic;
using System.Text;

namespace myfarm
{
    public class Dog : Animal
    {
        static int MAX_DOG_AGE = 18;
        static Random R = new Random();
        public string breed;
        public string name;

        public Dog(string type, string name)
        {
            this.breed = type;
            this.name = name;
            this.age = R.Next(MAX_DOG_AGE);
        }

        public void Bark(int nrTimes)
        {
            for (int i = 0; i < nrTimes; i++)
            {
                Console.Write("Woof.");
            }
        }

        public void Sit()
        {

        }
        public void Stay()
        {

        }
        public void RollOver()
        {
            Console.WriteLine(" I can rollover.");
        }
    }
}
