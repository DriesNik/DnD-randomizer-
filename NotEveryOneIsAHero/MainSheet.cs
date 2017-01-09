using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotEveryOneIsAHero
{
    class MainSheet
    {
        Stats stats = new Stats();
        Classes classes = new Classes();
        Races races = new Races();
        BackGround background = new BackGround();

        public void StartSheet()
        {
            //Console.ReadLine();
            stats.GetStats();
            classes.SelectClass();
            races.SelectRace();
            background.SelectBackground();
        }
    }
}
