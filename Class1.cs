/* Developer: Reshma Venkatachalapathy
 * Date:27-05-2024
 * Description: This task is used for creating a fun application to play with your pet. To calculate health, happiness and hunger of your pet by playing, resting and feeding them */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VirtualPetStatusTracker
{
    public class Class1
    {
      

        public static void Main(string[] args)
        {
            //Initializing the pet related variables
            String[] petTypes = { "Dog", "Cat", "Rabbit" };
            String petType, inputPetType, petName;
            int getPetType;
            int input;


            // Error handling to check if valid input given by the user
            while (true)
            {
                //Get the pet details from the user and display the details
                Console.WriteLine("Please choose a type of pet (Input the respective number): \n 1. Dog \n 2. Cat \n 3. Rabbit");
                inputPetType = Console.ReadLine();
                Console.WriteLine("User input: " + inputPetType);

                if (!int.TryParse(inputPetType, out input))
                {
                    Console.WriteLine("Please input a number");
                    continue;
                }
                break;
            }
            getPetType = (Convert.ToInt32(inputPetType)) - 1;
            petType = petTypes[getPetType];

            while (true)
            {
                Console.WriteLine("You have chosen " + petType + ". What would you like to name your pet?");
                petName = Console.ReadLine();
                    if (string.IsNullOrEmpty(petName))
                    {
                        Console.WriteLine("Please give a name to your pet. It cannot be empty");
                        continue;
                    }
                    break;
                Console.WriteLine("User input: " + petName);
                Console.WriteLine("Welcome " + petName + "!" + " Let's take good care of your " + petType.ToLower() + ".");
            
            }

            // Get thee user option and call the respective methods
            PetStatus pet = new PetStatus(petName, petType);
            bool appStatus = true;
            while (appStatus)
            {
                Console.WriteLine("Main Menu: \n 1. Feed " + petName + " \n 2. Play With " + petName + " \n 3. Let " + petName + " Rest \n 4. Check " + petName + "'s Status \n 5. Exit  ");
                String userResponse = Console.ReadLine();
                Console.WriteLine("User Input is " + userResponse);

                int choice;
                if(!int.TryParse(userResponse, out choice))
                    {
                        Console.WriteLine("Please insert a valid integer value");
                        continue;
                    }

                switch (Convert.ToInt32(userResponse))
                {
                    case 1:
                        pet.Feed();
                        break;

                    case 2:
                        pet.Play();
                        break;

                    case 3:
                        pet.Rest();
                        break;

                    case 4:
                        pet.CheckStatus();
                        break;

                    case 5:
                        Console.WriteLine("Thank you for playing with " + petName + "Goodbye!");
                        appStatus = false;
                        break;

                    default:
                        Console.WriteLine("Please input a valid value");
                        break;
                }

            }

        }


    }
}
