/* Developer: Reshma Venkatachalapathy
 * Date:27-05-2024
 * Description: This task is used for creating a fun application to play with your pet. To calculate health, happiness and hunger of your pet by playing, resting and feeding them */

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
            //Initializing the pet related variables
            String[] petTypes = { "Dog", "Cat", "Rabbit" };
            String petType;
            int getPetType;

            //Get the pet details from the user and display the details
            Console.WriteLine("Please choose a type of pet (Input the respective number): \n 1. Dog \n 2. Cat \n 3. Rabbit");
            String inputPetType = Console.ReadLine();
            Console.WriteLine("User input: " + inputPetType);
            getPetType = (Convert.ToInt32(inputPetType)) - 1;
            petType = petTypes[getPetType];
            Console.WriteLine("You have chosen " + petType + ". What would you like to name your pet?");
            String petName = Console.ReadLine();
            Console.WriteLine("User input: " + petName);
            Console.WriteLine("Welcome " + petName + "!" + " Let's take good care of your " + petType.ToLower() + ".");

            // Get thee user option and call the respective methods
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
