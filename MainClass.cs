using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetStatusTracker
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            String[] petTypes = { "Dog", "Cat", "Rabbit" };

            String petType;

            int getPetType;
            Console.WriteLine("Please choose a type of pet (Input the respective number): \n 1. Dog \n 2. Cat \n 3. Rabbit");
            //inputPetType = Console.WriteLine("User Input:" ,Console.ReadLine());
            String inputPetType = Console.ReadLine();
            Console.WriteLine("User input: " + inputPetType);
            getPetType = (Convert.ToInt32(inputPetType)) - 1;
            petType = petTypes[getPetType];
            Console.WriteLine("You have chosen " + petType + ". What would you like to name your pet?");
            String petName = Console.ReadLine();
            Console.WriteLine("User input: " + petName);
            Console.WriteLine("Welcome " + petName + "!" + " Let's take good care of your " + petType.ToLower() + ".");

            Console.WriteLine("Main Menu: \n 1. Feed " + petName + " \n 2. Play With " + petName + " \n 3. Let " + petName + " Rest \n 4. Check " + petName + "'s Status \n 5. Exit  ");
            String userResponse = Console.ReadLine();
            Console.WriteLine("User Input is " + userResponse);

            switch (Convert.ToInt32(userResponse))
            {
                case 1:



                case 5:
                    Console.WriteLine("Thank you for playing with " + petName + "Goodbye!");
                    break;

                default:
                    Console.WriteLine("Please input a valid value");
                    break;
            }



        }


    }
}
