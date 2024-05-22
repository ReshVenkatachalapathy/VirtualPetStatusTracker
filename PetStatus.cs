using System;
using System.Xml.Linq;
namespace VirtualPetStatusTracker
{
    // internal class PetStatus
    // {


    public class PetStatus
    {

        public string Name { get; set; }
        public string Type { get; set; }
        public int Hunger { get; set; }
        public int Happiness { get; set; }
        public int Health { get; set; }


        public PetStatus(string petName, string petType)
        {
            Name = petName;
            Type = petType;
            Hunger = 5;
            Happiness = 5;
            Health = 5;
        }

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
                Console.WriteLine($"{Name} has been fed fully. Hunger decreased and the health is increased.");
            }
            else
            {
                Health += 1;
                Console.WriteLine($"{Name} has been fed. Hunger decreased to {Hunger} and the health is increased to {Health}.");

            }


        }

        public void Play()
        {
            Happiness += 2;

            /* if (Happiness > 10)
             {
                 Happiness = 10; 
             }*/


            Hunger += 1;
            if (Hunger > 10)
            {
                Hunger = 10;
            }

            Console.WriteLine($"{Name} is excited after playing. Happiness increased which slightly increased in hunger.");
        }

        public void Rest()
        {
            Health += 2;
            if (Health > 10)
            {
                Health = 10;
            }

            Happiness -= 1;
            if (Happiness < 0)
            {
                Happiness = 1;
            }

            Console.WriteLine($"{Name} rested. Health improved but decrease in happiness slightly.");
        }


        public void CheckStatus()
        {
            Console.WriteLine($"Please find the status of {Name} ({Type}) below: ");
            Console.WriteLine($"Hunger: {Hunger} out of 10 \nHappiness: {Happiness} out of 10 \nHealth: {Health} out of 10");



        }
    }



}
//}