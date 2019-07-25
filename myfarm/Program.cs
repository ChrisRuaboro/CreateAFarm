using System;

namespace myfarm
{
    class Program
    {
        static Dog[] puppy = new Dog[4];
        static void CreateNewFarm()
        {
            Console.WriteLine("Chris R. is Cool.");
            puppy[0] = new Dog("Beagle", "Snoopy");
            puppy[1] = new Dog("Collie", "Lassie");
            puppy[2] = new Dog("Chihuahua", "Gidget");
            puppy[3] = new Dog("Mutt", "Yeller");
        }

        static void VisitFarm()
        {
            for (int i = 0; i < puppy.Length; i++)
            {
                Console.WriteLine($"(#{i}) {puppy[i].name} " +
                                  $"is a {puppy[i].breed} " +
                                  $"and is {puppy[i].age} years old.");
                puppy[i].Bark(i);
                puppy[i].RollOver();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("myfarm.Program.Main()");
            CreateNewFarm();
            VisitFarm();
        }
    }
}
