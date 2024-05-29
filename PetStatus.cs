/* Developer: Reshma Venkatachalapathy
 * Date:27-05-2024
 * Description: This task is used for calculating the hunger, happiness and health using the feed,play, and rest methods*/


using System;
using System.Threading;
using System.Xml.Linq;
namespace VirtualPetStatusTracker
{
 
    public class PetStatus
    {

        public string Name { get; set; }
        public string Type { get; set; }
        public int Hunger { get; set; }
        public int Happiness { get; set; }
        public int Health { get; set; }

        private Timer timer;


        // Passing the pet details and initializing the hunger, happiness and health
        public PetStatus(string petName, string petType)
        {
            Name = petName;
            Type = petType;
            Hunger = 5;
            Happiness = 5;
            Health = 5;

            // Initialize the timer to calculate the timing 
            timer = new Timer(PassTime, this, TimeSpan.Zero, TimeSpan.FromHours(1));
        
    }

        // Method to invoke the timer to increase the happiness and hunger as the time pass by
        private void PassTime(object state)
        {
            if (state is PetStatus pet)
            {
                // Increase hunger over time
                pet.Hunger += 1;

                // Decrease happiness slightly over time
                pet.Happiness -= 1;

                Console.WriteLine($"One hour has passed. {pet.Name} got hungrier and slightly less happy.");
            }
        }

        // This method will be used for feeding the pet which will increase the health and decrease the hunger
        public void Feed()
        {
            Hunger -= 2;
            String strHunger = Hunger.ToString();
            /* if (Hunger < 0)
             {
                 Hunger = 1; 
             } */
            if (strHunger.Contains("-"))
            {
                Hunger = 1;
                Console.WriteLine($"{Name} has been fed fully and cannot be fed anymore further. Please try the other options in the application. Try play or rest your pet. \n Hunger decreased to {Hunger} and the health is increased to {Health}.");
            }
            else
            {
                if (Health > 10)
                {
                    Console.WriteLine($"{Name} has been fed. Hunger decreased to {Hunger} and the health is increased to {Health}.");
                }
                else
                {
                    Health += 1;
                    Console.WriteLine($"{Name} has been fed. Hunger decreased to {Hunger} and the health is increased to {Health}.");
                }
                

            }


        }

        // This method will be used for playing the pet which will increase the happiness and increase the hunger
        public void Play()
        {
            Happiness += 2;
            Hunger += 1;

            if ((Happiness > 10) ||  (Hunger > 10))
            {
                 Happiness = 10;
                 Hunger = 10;
                 Console.WriteLine($"{Name} is exhausted from playing and cannot play any futher. Please try the other options in the application. Try feed or rest your pet. \n Happiness increased to {Happiness} and hunger to {Hunger}.");
            }
            else
            {
                Console.WriteLine($"{Name} is excited after playing. Happiness increased to {Happiness} which slightly increased in hunger to {Hunger}.");
            }

            
        }

        // This method will be used for resting the pet which will increase the health and decrease the hunger
        public void Rest()
        {
            Health += 2;
            Happiness -= 1;

            if ((Health > 10) || (Happiness > 10))
            {
                Health = 10;
                Happiness = 10;
                Console.WriteLine($"{Name} is fully rested. Please try the other options in the application. Try feed or play with your pet. \n  Health is {Health} and happiness is {Happiness}.");
            }
            else
            {
                Console.WriteLine($"{Name} rested. Health improved to {Health} but decrease in happiness slightly to {Happiness}.");
            }


        }

        // This method will be used for displaying all the status of the pet like happiness, health, and hunger
        public void CheckStatus()
        {
            Console.WriteLine($"Please find the status of {Name} ({Type}) below: ");
            Console.WriteLine($"Hunger: {Hunger} out of 10 \nHappiness: {Happiness} out of 10 \nHealth: {Health} out of 10");



        }
    }



}
//}