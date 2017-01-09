using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotEveryOneIsAHero
{
    class Classes
    {
        int classNumber;
        Random random = new Random();
        public void SelectClass()
        {
            classNumber = (random.Next(8) + 1);
            switch(classNumber)
            {
                case 1:
                    Barbarian();
                    break;
                case 2:
                    Bard();
                    break;
                case 3:
                    Druid();
                    break;
                case 4:
                    Monk();
                    break;
                case 5:
                    Paladin();
                    break;
                case 6:
                    Ranger();
                    break;
                case 7:
                    Sorcerer();
                    break;
                case 8:
                    Warlock();
                    break;
            }
        }
        public int Barbarian()
        {
            Console.WriteLine("Your Class is: Barbarian");
            int i=0;
            return i;
        }
        public int Bard()
        {
            Console.WriteLine("Your Class is: Bard");
            int i = 0;
            return i;
        }
        public int Druid()
        {
            Console.WriteLine("Your Class is: Druid");
            int i = 0;
            return i;
        }
        public int Monk()
        {
            Console.WriteLine("Your Class is: Monk");
            int i = 0;
            return i;
        }
        public int Paladin()
        {
            Console.WriteLine("Your Class is: Paladin");
            int i = 0;
            return i;
        }
        public int Ranger()
        {
            Console.WriteLine("Your Class is: Ranger");
            int i = 0;
            return i;
        }
        public int Sorcerer()
        {
            Console.WriteLine("Your Class is: Sorcerer");
            int i = 0;
            return i;
        }
        public int Warlock()
        {
            Console.WriteLine("Your Class is: Warlock ");
            int i = 0;
            return i;
        }

    }
}
