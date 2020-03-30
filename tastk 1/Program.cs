using System;

namespace tastk_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Insert dogs name");
            string aName = Console.ReadLine();



            Console.WriteLine("Insert dogs race");
            string aRace = Console.ReadLine();


            Console.WriteLine("Input dogs color");
            string aColor = Console.ReadLine();

           Dog userDogCreate = new Dog(aName, aRace, aColor);

            Console.WriteLine("You create this dog:");
            Console.WriteLine($"Your dog`s name is {userDogCreate.name}.Race of the dog is {userDogCreate.race}, and his color is {userDogCreate.color}");

            Console.WriteLine("What you want your dog to do:");
            Console.WriteLine("Enter 1 - if you whant dog to eat.");
            Console.WriteLine("Enter 2 - if ypu whant dog to play.");
            Console.WriteLine("Enter 3 - if you whant dog to chase his tail.");



            int userInput= Convert.ToInt32( Console.ReadLine());
          
            
            if (userInput== 1)
            {
                Console.WriteLine(userDogCreate.Eat());

            }
            else if (userInput ==2)
            {
                Console.WriteLine(userDogCreate.Play());
            }
            else if (userInput == 3)
            {
                Console.WriteLine(userDogCreate.ChaseTail());
            }
           
            





            Console.ReadLine();
        }
    }
}
