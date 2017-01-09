using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotEveryOneIsAHero
{
    class Races
    {
        Random random = new Random();
        int raceNumber;
        int subRace;
        public void SelectRace()
        {
            raceNumber = (random.Next(18) + 1);
            switch (raceNumber)
            {
                case 1:
                    Aasimar();
                    break;
                case 2:
                    DeepGnome();
                    break;
                case 3:
                    Dragonborn();
                    break;
                case 4:
                    Dwarf();
                    break;
                case 5:
                    Elf();
                    break;
                case 6:
                    Firbolg();
                    break;
                case 7:
                    Genasi();
                    break;
                case 8:
                    Gnome();
                    break;
                case 9:
                    Goliath();
                    break;
                case 10:
                    Halfling();
                    break;
                case 11:
                    HalfElf();
                    break;
                case 12:
                    HalfOrc();
                    break;
                case 13:
                    Human();
                    break;
                case 14:
                    Kenku();
                    break;
                case 15:
                    LizardFolk();
                    break;
                case 16:
                    Tabaxi();
                    break;
                case 17:
                    Tiefling();
                    break;
                case 18:
                    Triton();
                    break;
            }
        }
        public int Aasimar()
        {
            subRace = random.Next(3);
            switch(subRace)
            {
                case 0:
                    Console.WriteLine("Your Race is: Aasimar, Protector");
                    break;
                case 1:
                    Console.WriteLine("Your Race is: Aasimar, Scourge");
                    break;
                case 2:
                    Console.WriteLine("Your Race is: Aasimar, Fallen");
                    break;
                default:
                    Console.WriteLine("Error");
                    Aasimar();
                    break;
            }
            
            int i = 0;
            return i;
        }
        public int DeepGnome()
        {
            Console.WriteLine("Your Race is: Deep Gnome");
            int i = 0;
            return i;
        }
        public int Dragonborn()
        {
            Console.WriteLine("Your Race is: Dragonborn");
            int i = 0;
            return i;
        }
        public int Dwarf()
        {
            subRace = random.Next(3);
            switch (subRace)
            {
                case 0:
                    Console.WriteLine("Your Race is: Dwarf, Mountain");
                    break;
                case 1:
                    Console.WriteLine("Your Race is: Dwarf, Hill");
                    break;
                case 2:
                    Console.WriteLine("Your Race is: Dwarf, Duergar");
                    break;
                default:
                    Console.WriteLine("Error");
                    Aasimar();
                    break;
            }

            int i = 0;
            return i;
        }
        public int Elf()
        {
            subRace = random.Next(3);
            switch (subRace)
            {
                case 0:
                    Console.WriteLine("Your Race is: Elf, High");
                    break;
                case 1:
                    Console.WriteLine("Your Race is: Elf, Wood");
                    break;
                case 2:
                    Console.WriteLine("Your Race is: Elf, Drow");
                    break;
                default:
                    Console.WriteLine("Error");
                    Aasimar();
                    break;
            }

            int i = 0;
            return i;
        }
        public int Firbolg()
        {
            Console.WriteLine("Your Race is: Firbolg");
            int i = 0;
            return i;
        }
        public int Genasi()
        {
            Console.WriteLine("Your Race is: Genasi");
            int i = 0;
            return i;
        }
        public int Gnome()
        {
            Console.WriteLine("Your Race is: Gnome");
            int i = 0;
            return i;
        }
        public int Goliath()
        {
            Console.WriteLine("Your Race is: Goliath");
            int i = 0;
            return i;
        }
        public int Halfling()
        {
            subRace = random.Next(3);
            switch (subRace)
            {
                case 0:
                    Console.WriteLine("Your Race is: Halfling, Lightfoot");
                    break;
                case 1:
                    Console.WriteLine("Your Race is: Halfling, Stout");
                    break;
                case 2:
                    Console.WriteLine("Your Race is: Halfling, Ghostwise");
                    break;
                default:
                    Console.WriteLine("Error");
                    Aasimar();
                    break;
            }

            int i = 0;
            return i;
        }
        public int HalfElf()
        {
            Console.WriteLine("Your Race is: Half Elf");
            int i = 0;
            return i;
        }
        public int HalfOrc()
        {
            Console.WriteLine("Your Race is: Half Orc");
            int i = 0;
            return i;
        }
        public int Human()
        {
            Console.WriteLine("Your Race is: Human");
            int i = 0;
            return i;
        }
        public int Kenku()
        {
            Console.WriteLine("Your Race is: Kenku");
            int i = 0;
            return i;
        }
        public int LizardFolk()
        {
            Console.WriteLine("Your Race is: Lizardfolk");
            int i = 0;
            return i;
        }
        public int Tabaxi()
        {
            Console.WriteLine("Your Race is: Tabaxi");
            int i = 0;
            return i;
        }
        public int Tiefling()
        {
            Console.WriteLine("Your Race is: Tiefling");
            int i = 0;
            return i;
        }
        public int Triton()
        {
            Console.WriteLine("Your Race is: Triton");
            int i = 0;
            return i;
        }

    }
}
