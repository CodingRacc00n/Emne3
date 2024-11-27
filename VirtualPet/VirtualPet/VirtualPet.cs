using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    internal class Pet
    {
        private string PetName { get; set; }
        private int PetAge { get; set; }
        private int Hunger { get; set; }
        private int Happiness { get; set; }
        private int Bladder { get; set; }
        private int Fun { get; set; }

        public Pet(string petName, int petAge)
        {
            PetName = petName;
            PetAge = petAge;
            Hunger = 5;
            Happiness = 5;
            Bladder = 5;
            Fun = 5;
        }

        public void displayStats()
        {
           // Console.Write(PetName + " " + PetAge + " " + Hunger + " " + Happiness + " " + Bladder + " " + Fun);
           Console.Write($"Pet name: {PetName} Pet age: {PetAge}  Hunger: {Hunger}  Happiness: {Happiness}  Bladder: {Bladder}  Fun: {Fun}\n" );
            
        }

        public void FeedPet()
        {
            Hunger += 3;
            Happiness += 2;
            Bladder -= 1;

            Hunger = Math.Min(Hunger, 10);
            Happiness = Math.Min(Happiness, 10);
            Bladder = Math.Min(Bladder, 10);
        }
        public void PlayWithPet()
        {
            Hunger -= 3;
            Happiness += 3;
            Bladder -= 3;
            Fun += 4;

            Hunger = Math.Min(Hunger, 10);
            Happiness = Math.Min(Happiness, 10);
            Bladder = Math.Min(Bladder, 10);
            Fun = Math.Min(Fun, 10);
        }
        public void TakePetToilet()
        {
            Hunger -= 2;
            Happiness += 2;
            Bladder += 10;

            Hunger = Math.Min(Hunger, 10);
            Happiness = Math.Min(Happiness, 10);
            Bladder = Math.Min(Bladder, 10);
        }
    }
}
