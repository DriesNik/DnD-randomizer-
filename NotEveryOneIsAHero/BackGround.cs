using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotEveryOneIsAHero
{
    class BackGround
    {
        Random random = new Random();
        int subStory;
        public void SelectBackground()
        {
            subStory = (random.Next(26) + 1);
            switch(subStory)
            { 
                case 1:
                    Acolyte();
                    break;
                case 2:
                    Charlaton();
                    break;
                case 3:
                    Criminal();
                    break;
                case 4:
                    Entertainer();
                    break;
                case 5:
                    FolkHero();
                    break;
                case 6:
                    GuildArtisan();
                    break;
                case 7:
                    Hermit();
                    break;
                case 8:
                    Noble();
                    break;
                case 9:
                    Outlander();
                    break;
                case 10:
                    Sage();
                    break;
                case 11:
                    Sailor();
                    break;
                case 12:
                    Soldier();
                    break;
                case 13:
                    Urchin();
                    break;
                case 14:
                    HauntedOne();
                    break;
                case 15:
                    CityWatch();
                    break;
                case 16:
                    ClanCrafter();
                    break;
                case 17:
                    CloisteredScholar();
                    break;
                case 18:
                    Courtier();
                    break;
                case 19:
                    FactionAgent();
                    break;
                case 20:
                    FarTraveler();
                    break;
                case 21:
                    Inheritor();
                    break;
                case 22:
                    KnightOfTheOrder();
                    break;
                case 23:
                    MercenaryVeteran();
                    break;
                case 24:
                    UrbanBountyHunter();
                    break;
                case 25:
                    UthgardtTrideMember();
                    break;
                case 26:
                    WaterdhavianNoble();
                    break;
                default:
                    break;
        }
        }
        public void Acolyte()
        {
            Console.WriteLine("You are an Acolyte");
        }
        public void Charlaton()
        {
            Console.WriteLine("You are a Charlaton");
        }
        public void Criminal()
        {
            Console.WriteLine("You are a Criminal");
        }
        public void Entertainer()
        {
            Console.WriteLine("You are an Entertainer");
        }
        public void FolkHero()
        {
            Console.WriteLine("You are a Folk Hero");
        }
        public void GuildArtisan()
        {
            Console.WriteLine("You are a Guild Artisan");
        }
        public void Hermit()
        {
            Console.WriteLine("You are a Hermit");
        }
        public void Noble()
        {
            Console.WriteLine("You are a Noble");
        }
        public void Outlander()
        {
            Console.WriteLine("You are an Outlander");
        }
        public void Sage()
        {
            Console.WriteLine("You are a Sage");
        }
        public void Sailor()
        {
            Console.WriteLine("You are a Sailor");
        }
        public void Soldier()
        {
            Console.WriteLine("You are a Soldier");
        }
        public void Urchin()
        {
            Console.WriteLine("You are an Urchin");
        }
        public void HauntedOne()
        {
            Console.WriteLine("You are a Haunted One");
        }
        public void CityWatch()
        {
            Console.WriteLine("You are a City Watch");
        }
        public void ClanCrafter()
        {
            Console.WriteLine("You are a Clan Crafter");
        }
        public void CloisteredScholar()
        {
            Console.WriteLine("You are a Cloistered Scholar");
        }
        public void Courtier()
        {
            Console.WriteLine("You are a Courtier");
        }
        public void FactionAgent()
        {
            Console.WriteLine("You are a Faction Agent");
        }
        public void FarTraveler()
        {
            Console.WriteLine("You are a Far Traveler");
        }
        public void Inheritor()
        {
            Console.WriteLine("You are a Inheritor");
        }
        public void KnightOfTheOrder()
        {
            Console.WriteLine("You are a Knight Of The Order");
        }
        public void MercenaryVeteran()
        {
            Console.WriteLine("You are a Mercenary Veteran");
        }
        public void UrbanBountyHunter()
        {
            Console.WriteLine("You are a Urban Bounty Hunter");
        }
        public void UthgardtTrideMember()
        {
            Console.WriteLine("You are a Uthgardt Tride Member");
        }
        public void WaterdhavianNoble()
        {
            Console.WriteLine("You are a Waterdhavian Noble");
        }

    }
}
