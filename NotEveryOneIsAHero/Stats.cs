using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotEveryOneIsAHero
{
    class Stats
    {
        Random random = new Random();
        int strength;
        int dexterity;
        int constitution;
        int intelligence;
        int wisdom;
        int charisma;

        public void GetStats()
        {
            Strength();
            Dexterity();
            Constitution();
            Intelligence();
            Wisdom();
            Charisma();
        }
        public void Strength()
        {
            strength = (random.Next(17) + 1);
            if (strength <4)
            {
                Strength();
            }
            else
            {

            }
            Console.WriteLine("Your Strength is: {0}", strength);
        }
        public void Dexterity()
        {
            dexterity = (random.Next(17) + 1);
            if (dexterity < 4)
            {
                Dexterity();
            }
            else
            {

            }
            Console.WriteLine("Your Dexterity is: {0}", dexterity);
        }
        public void Constitution()
        {
            constitution = (random.Next(17) + 1);
            if (constitution < 4)
            {
                Constitution();
            }
            else
            {
            }
            Console.WriteLine("Your Constitution is: {0}", constitution);
        }
        public void Intelligence()
        {
            intelligence = (random.Next(17) + 1);
            if (intelligence < 4)
            {
                Intelligence();
            }
            else
            {
            }
            Console.WriteLine("Your Intelligence is: {0}", intelligence);
        }
        public void Wisdom()
        {
            wisdom = (random.Next(17) + 1);
            if (wisdom < 4)
            {
                Wisdom();
            }
            else
            {
            }
            Console.WriteLine("Your Wisdom is: {0}", wisdom);
        }
        public void Charisma()
        {
            charisma = (random.Next(17) + 1);
            if (charisma < 4)
            {
                Charisma();
            }
            else
            {
            }
            Console.WriteLine("Your Charisma is: {0}", charisma);
        }
    }
}
