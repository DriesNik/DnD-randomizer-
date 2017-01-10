using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotEveryOneIsAHero
{
    class Traits
    {
        Random random = new Random();
        int firstTrait;
        int secondTrait;
        int thirdTrait;
        int fourthTrait;
        int fifthTrait;
        public void BGChoice(int trait)
        {

        }
        public void BaseTemp()
        {
            firstTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (firstTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            secondTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (secondTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            thirdTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (thirdTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            fourthTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (fourthTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            fifthTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (fifthTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
        }
        public void Acolyte()
        {
            firstTrait = (random.Next(8) + 1);
            Console.WriteLine("Personality Trait");
            switch(firstTrait)
            {
                case 1:
                    Console.WriteLine("You idolize a particular hero of your faith, and constantly refer to that person’s deeds and example.");
                    break;
                case 2:
                    Console.WriteLine("You can find common ground between the fiercest enemies, empathizing with them and always working towards peace.");
                    break;
                case 3:
                    Console.WriteLine("You see omens in every event and action. The gods try to speak to us, we just need to listen");
                    break;
                case 4:
                    Console.WriteLine("Nothing can shake your optimistic attitude.");
                    break;
                case 5:
                    Console.WriteLine("You quote (or misquote) sacred texts and proverbs in almost every situation.");
                    break;
                case 6:
                    Console.WriteLine("You are tolerant (or intolerant) of other faiths and respect (or condemn) the worship of other gods.");
                    break;
                case 7:
                    Console.WriteLine("You've enjoyed fine food, drink, and high society among your temple’s elite. Rough living grates on you.");
                    break;
                case 8:
                    Console.WriteLine("I’ve spent so long in the temple that I have little practical experience dealing with people in the outside world.");
                    break;
            }
            secondTrait = (random.Next(6) + 1);
            Console.WriteLine("Ideals");
            switch(secondTrait)
            {
                case 1:
                    Console.WriteLine("Tradition. The ancient traditions of worship and sacrifice must be preserved and upheld. (Lawful)");
                    break;
                case 2:
                    Console.WriteLine("Charity. You always try to help those in need, no matter what the personal cost. (Good)");
                    break;
                case 3:
                    Console.WriteLine("Change. We must help bring about the changes the gods are constantly working in the world. (Chaotic)");
                    break;
                case 4:
                    Console.WriteLine("Power. You hope to one day rise to the top of your faith’s religious hierarchy. (Lawful)");
                    break;
                case 5:
                    Console.WriteLine("Faith. You trust that your deity will guide your actions, You have faith that if You work hard, things will go well. (Lawful)");
                    break;
                case 6:
                    Console.WriteLine("Aspiration. You seek to prove yourself worthy of your god’s favor by matching your actions against his or her teachings. (Any)");
                    break;
            }
            thirdTrait = (random.Next(6) + 1);
            Console.WriteLine("Bond");
            switch(thirdTrait)
            {
                case 1:
                    Console.WriteLine("You would die to recover an ancient relic of your faith that was lost long ago.");
                    break;
                case 2:
                    Console.WriteLine("You will someday get revenge on the corrupt temple hierarchy who branded you a heretic.");
                    break;
                case 3:
                    Console.WriteLine("You owe your life to the priest who took you in when your parents died.");
                    break;
                case 4:
                    Console.WriteLine("Everything you do is for the common people.");
                    break;
                case 5:
                    Console.WriteLine("You will do anything to protect the temple where you served.");
                    break;
                case 6:
                    Console.WriteLine("You seek to preserve a sacred text that your enemies consider heretical and seek to destroy.");
                    break;
            }
            fourthTrait = (random.Next(6) + 1);
            Console.WriteLine("Flaw");
            switch (fourthTrait)
            {
                case 1:
                    Console.WriteLine("You judge others harshly, and yourself even more severely.");
                    break;
                case 2:
                    Console.WriteLine("You put too much trust in those who wield power within your temple’s hierarchy.");
                    break;
                case 3:
                    Console.WriteLine("My piety sometimes leads me to blindly trust those that profess faith in my god.");
                    break;
                case 4:
                    Console.WriteLine("You are inflexible in your thinking.");
                    break;
                case 5:
                    Console.WriteLine("You are suspicious of strangers and expect the worst of them.");
                    break;
                case 6:
                    Console.WriteLine("Once you pick a goal, you become obsessed with it to the detriment of everything else in your life.");
                    break;
            }

        }
        public void Charlaton()
        {
            firstTrait = (random.Next(6) + 1);
            Console.WriteLine("Scam");
            switch (firstTrait)
            {
                case 1:
                    Console.WriteLine("You cheat at games involving chance.");
                    break;
                case 2:
                    Console.WriteLine("You shave coins or forge documents.");
                    break;
                case 3:
                    Console.WriteLine("You insinuate yourself into people’s lives to prey on their weakness and secure their fortunes.");
                    break;
                case 4:
                    Console.WriteLine("You put on new identities like clothes.");
                    break;
                case 5:
                    Console.WriteLine("You run sleight-of-hand cons on street corners.");
                    break;
                case 6:
                    Console.WriteLine("I convince people that worthless junk is worth their hard-earned money.");
                    break;
            }
            secondTrait = (random.Next(8) + 1);
            Console.WriteLine("Personality Trait");
            switch (secondTrait)
            {
                case 1:
                    Console.WriteLine("You fall in and out of love easily, and are always pursuing someone.");
                    break;
                case 2:
                    Console.WriteLine("You have a joke for every occasion, especially occasions where humor is inappropriate.");
                    break;
                case 3:
                    Console.WriteLine("Flattery is your preferred trick for getting what you want.");
                    break;
                case 4:
                    Console.WriteLine("You are a born gambler who can't resist taking a risk for a potential payoff.");
                    break;
                case 5:
                    Console.WriteLine("You lie about almost everything, even when there’s no good reason to.");
                    break;
                case 6:
                    Console.WriteLine("Sarcasm and insults are your weapons of choice.");
                    break;
                case 7:
                    Console.WriteLine("You keep multiple holy symbols on yourself and invoke whatever deity might come in useful at any given moment.");
                    break;
                case 8:
                    Console.WriteLine("You pocket anything you see that might have some value.");
                    break;
            }
            thirdTrait = (random.Next(6) + 1);
            Console.WriteLine("Ideals");
            switch (thirdTrait)
            {
                case 1:
                    Console.WriteLine("Independence. You are a free spirit— no one tells you what to do. (Chaotic)");
                    break;
                case 2:
                    Console.WriteLine("Fairness. You never target people who can’t afford to lose a few coins. (Lawful)");
                    break;
                case 3:
                    Console.WriteLine("	Charity. You distribute the money you acquire to the people who really need it. (Good)");
                    break;
                case 4:
                    Console.WriteLine("Creativity. You never run the same con twice. (Chaotic)");
                    break;
                case 5:
                    Console.WriteLine("Friendship. Material goods come and go. Bonds of friendship last forever. (Good)");
                    break;
                case 6:
                    Console.WriteLine("Aspiration. You are determined to make something of yourself. (Any)");
                    break;
            }
            fourthTrait = (random.Next(6) + 1);
            Console.WriteLine("Bond");
            switch (fourthTrait)
            {
                case 1:
                    Console.WriteLine("You fleeced the wrong person and must work to ensure that this individual never crosses paths with you or those you care about.");
                    break;
                case 2:
                    Console.WriteLine("You owe everything to your mentor—a horrible person who’s probably rotting in jail somewhere.");
                    break;
                case 3:
                    Console.WriteLine("Somewhere out there, you have a child who doesn’t know you. You are making the world better for him or her.");
                    break;
                case 4:
                    Console.WriteLine("You come from a noble family, and one day you will reclaim your lands and title from those who stole them from you.");
                    break;
                case 5:
                    Console.WriteLine("A powerful person killed someone you love. Some day soon, you will have your revenge.");
                    break;
                case 6:
                    Console.WriteLine("You swindled and ruined a person who didn’t deserve it. You seek to atone for your misdeeds but might never be able to forgive yourself.");
                    break;
            }
            fifthTrait = (random.Next(6) + 1);
            Console.WriteLine("Flaw");
            switch (fifthTrait)
            {
                case 1:
                    Console.WriteLine("You can’t resist a pretty face.");
                    break;
                case 2:
                    Console.WriteLine("You are always in debt. You spend your ill - gotten gains on decadent luxuries faster than you bring them in.");
                    break;
                case 3:
                    Console.WriteLine("You are convinced that no one could ever fool you the way you fool others.");
                    break;
                case 4:
                    Console.WriteLine("You are too greedy for your own good. You can’t resist taking a risk if there’s money involved.");
                    break;
                case 5:
                    Console.WriteLine("You can’t resist swindling people who are more powerful than you.");
                    break;
                case 6:
                    Console.WriteLine("You hate to admit it and will hate yourself for it, but you will run and preserve your own hide if the going gets tough.");
                    break;
            }
        }
        // start here with corrections
        public void Criminal()
        {
            firstTrait = (random.Next(8) + 1);
            Console.WriteLine("Speciality");
            switch (firstTrait)
            {
                case 1:
                    Console.WriteLine("Blackmailer");
                    break;
                case 2:
                    Console.WriteLine("Burglar");
                    break;
                case 3:
                    Console.WriteLine("Enforcer");
                    break;
                case 4:
                    Console.WriteLine("Fence");
                    break;
                case 5:
                    Console.WriteLine("Highway Robber");
                    break;
                case 6:
                    Console.WriteLine("Hired Killer");
                    break;
                case 7:
                    Console.WriteLine("Pickpocket");
                    break;
                case 8:
                    Console.WriteLine("Smuggler");
                    break;
            }
            secondTrait = (random.Next(6) + 1);
            Console.WriteLine("Personality Trait");
            switch (secondTrait)
            {
                case 1:
                    Console.WriteLine("I always have a plan for what to do when things go wrong.");
                    break;
                case 2:
                    Console.WriteLine("I am always calm, no matter what the situation. I never raise my voice or let my emotions control me.");
                    break;
                case 3:
                    Console.WriteLine("The first thing I do in a new place is note the locations of everything valuable-or where such things could be hidden.");
                    break;
                case 4:
                    Console.WriteLine("I would rather make a new friend then a new enemy.");
                    break;
                case 5:
                    Console.WriteLine("I am incredibly slow to trust. Those who seem the fairest often have the most to hide.");
                    break;
                case 6:
                    Console.WriteLine("	I don't pay attention to the risks in a situation. Never tell me the odds.");
                    break;
                case 7:
                    Console.WriteLine("The best way to get me to do something is to tell me I can't do it.");
                    break;
                case 8:
                    Console.WriteLine("	I blow up at the slightest insult.");
                    break;
            }
            thirdTrait = (random.Next(6) + 1);
            Console.WriteLine("Ideals");
            switch (thirdTrait)
            {
                case 1:
                    Console.WriteLine("Honor. I don’t steal from others in the trade. (Lawful)");
                    break;
                case 2:
                    Console.WriteLine("Freedom. Chains are meant to be broken, as are those who would forge them. (Chaotic)");
                    break;
                case 3:
                    Console.WriteLine("Charity. I steal from the wealthy so that I can help people in need. (Good)");
                    break;
                case 4:
                    Console.WriteLine("	Greed. I will do whatever it takes to become wealthy. (Evil)");
                    break;
                case 5:
                    Console.WriteLine("People. I’m loyal to my friends, not to any ideals, and everyone else can take a trip down the Styx for all I care. (Neutral)");
                    break;
                case 6:
                    Console.WriteLine("Redemption. There’s a spark of good in everyone. (Good)");
                    break;
            }
            fourthTrait = (random.Next(6) + 1);
            Console.WriteLine("Bond");
            switch (fourthTrait)
            {
                case 1:
                    Console.WriteLine("	I’m trying to pay off an old debt I owe to a generous benefactor.");
                    break;
                case 2:
                    Console.WriteLine("My ill-gotten gains go to support my family.");
                    break;
                case 3:
                    Console.WriteLine("Something important was taken from me, and I aim to steal it back.");
                    break;
                case 4:
                    Console.WriteLine("I will become the greatest thief that ever lived.");
                    break;
                case 5:
                    Console.WriteLine("I’m guilty of a terrible crime. I hope I can redeem myself for it.");
                    break;
                case 6:
                    Console.WriteLine("Someone I loved died because of a mistake I made. That will never happen again.");
                    break;
            }
            fifthTrait = (random.Next(6) + 1);
            Console.WriteLine("Flaw");
            switch (fifthTrait)
            {
                case 1:
                    Console.WriteLine("When I see something valuable, I can’t think about anything but how to steal it.");
                    break;
                case 2:
                    Console.WriteLine("When faced with a choice between money and my friends, I usually choose the money.");
                    break;
                case 3:
                    Console.WriteLine("If there’s a plan, I’ll forget it. If I don’t forget it, I’ll ignore it.");
                    break;
                case 4:
                    Console.WriteLine("I have a “tell” that reveals when I'm lying.");
                    break;
                case 5:
                    Console.WriteLine("I turn tail and run when things look bad.");
                    break;
                case 6:
                    Console.WriteLine("An innocent person is in prison for a crime that I committed. I’m okay with that.");
                    break;
            }
        }
        public void Entertainer()
        {
            firstTrait = (random.Next(10) + 1);
            Console.WriteLine("Routines");
            switch (firstTrait)
            {
                case 1:
                    Console.WriteLine("Actor");
                    break;
                case 2:
                    Console.WriteLine("Dancer");
                    break;
                case 3:
                    Console.WriteLine("Fire-eater");
                    break;
                case 4:
                    Console.WriteLine("	Jester");
                    break;
                case 5:
                    Console.WriteLine("Juggler");
                    break;
                case 6:
                    Console.WriteLine("Instrumentalist");
                    break;
                case 7:
                    Console.WriteLine("Poet");
                    break;
                case 8:
                    Console.WriteLine("Singer");
                    break;
                case 9:
                    Console.WriteLine("Storyteller");
                    break;
                case 10:
                    Console.WriteLine("Tumbler");
                    break;
            }
            secondTrait = (random.Next(8) + 1);
            Console.WriteLine("Personality Trait");
            switch (secondTrait)
            {
                case 1:
                    Console.WriteLine("I know a story relevant to almost every situation.");
                    break;
                case 2:
                    Console.WriteLine("Whenever I come to a new place, I collect local rumors and spread gossip.");
                    break;
                case 3:
                    Console.WriteLine("I’m a hopeless romantic, always searching for that “special someone.”");
                    break;
                case 4:
                    Console.WriteLine("Nobody stays angry at me or around me for long, since I can defuse any amount of tension.");
                    break;
                case 5:
                    Console.WriteLine("I love a good insult, even one directed at me.");
                    break;
                case 6:
                    Console.WriteLine("I get bitter if I’m not the center of attention.");
                    break;
                case 7:
                    Console.WriteLine("I’ll settle for nothing less than perfection.");
                    break;
                case 8:
                    Console.WriteLine("	I change my mood or my mind as quickly as I change key in a song.");
                    break;
            }
            thirdTrait = (random.Next(6) + 1);
            Console.WriteLine("Ideal");
            switch (thirdTrait)
            {
                case 1:
                    Console.WriteLine("	Beauty. When I perform, I make the world better than it was. (Good)");
                    break;
                case 2:
                    Console.WriteLine("Tradition. The stories, legends, and songs o f the past must never be forgotten, for they teach us who we are. (Lawful)");
                    break;
                case 3:
                    Console.WriteLine("Creativity. The world is in need of new ideas and bold action. (Chaotic)");
                    break;
                case 4:
                    Console.WriteLine("Greed. I’m only in it for the money and fame. (Evil)");
                    break;
                case 5:
                    Console.WriteLine("People. I like seeing the smiles on people’s faces when I perform. That’s all that matters. (Neutral)");
                    break;
                case 6:
                    Console.WriteLine("Honesty. Art should reflect the soul; it should come from within and reveal who we really are. (Any)");
                    break;
            }
            fourthTrait = (random.Next(6) + 1);
            Console.WriteLine("Bond");
            switch (fourthTrait)
            {
                case 1:
                    Console.WriteLine("My instrument is my most treasured possession, and it reminds me of someone I love.");
                    break;
                case 2:
                    Console.WriteLine("Someone stole my precious instrument, and someday I’ll get it back.");
                    break;
                case 3:
                    Console.WriteLine("	I want to be famous, whatever it takes.");
                    break;
                case 4:
                    Console.WriteLine("I idolize a hero of the old tales and measure my deeds against that person’s.");
                    break;
                case 5:
                    Console.WriteLine("	I will do anything to prove myself superior to my hated rival.");
                    break;
                case 6:
                    Console.WriteLine("	I would do anything for the other members of my old troupe.");
                    break;
            }
            fifthTrait = (random.Next(6) + 1);
            Console.WriteLine("Flaw");
            switch (fifthTrait)
            {
                case 1:
                    Console.WriteLine("I’ll do anything to win fame and renown.");
                    break;
                case 2:
                    Console.WriteLine("I’m a sucker for a pretty face.");
                    break;
                case 3:
                    Console.WriteLine("A scandal prevents me from ever going home again. That kind of trouble seems to follow me around.");
                    break;
                case 4:
                    Console.WriteLine("I once satirized a noble who still wants my head. It was a mistake that I will likely repeat.");
                    break;
                case 5:
                    Console.WriteLine("	I have trouble keeping my true feelings hidden. My sharp tongue lands me in trouble.");
                    break;
                case 6:
                    Console.WriteLine("Despite my best efforts, I am unreliable to my friends.");
                    break;
            }
        }
        public void FolkHero()
        {
            firstTrait = (random.Next(10) + 1);
            Console.WriteLine("Defining Event");
            switch (firstTrait)
            {
                case 1:
                    Console.WriteLine("I stood up to a tyrant’s agents.");
                    break;
                case 2:
                    Console.WriteLine("I saved people during a natural disaster.");
                    break;
                case 3:
                    Console.WriteLine("I stood alone against a terrible monster.");
                    break;
                case 4:
                    Console.WriteLine("I stole from a corrupt merchant to help the poor.");
                    break;
                case 5:
                    Console.WriteLine("I led a militia to fight off an invading army.");
                    break;
                case 6:
                    Console.WriteLine("I broke into a tyrant’s castle and stole weapons to arm the people.");
                    break;
                case 7:
                    Console.WriteLine("I trained the peasantry to use farm implements as weapons against a tyrant’s soldiers.");
                    break;
                case 8:
                    Console.WriteLine("A lord rescinded an unpopular decree after I led a symbolic act of protect against it.");
                    break;
                case 9:
                    Console.WriteLine("A celestial, fey, or similar creature gave me a blessing or revealed my secret origin.");
                    break;
                case 10:
                    Console.WriteLine("Recruited into a lord’s army, I rose to leadership and was commended for my heroism.");
                    break;
            }
            secondTrait = (random.Next(8) + 1);
            Console.WriteLine("Personality Trait");
            switch (secondTrait)
            {
                case 1:
                    Console.WriteLine("I judge people by their actions, not their words.");
                    break;
                case 2:
                    Console.WriteLine("If someone is in trouble, I’m always ready to lend help.");
                    break;
                case 3:
                    Console.WriteLine("When I set my mind to something, I follow through no matter what gets in my way.");
                    break;
                case 4:
                    Console.WriteLine("I have a strong sense of fair play and always try to find the most equitable solution to arguments.");
                    break;
                case 5:
                    Console.WriteLine("I’m confident in my own abilities and do what I can to instill confidence in others.");
                    break;
                case 6:
                    Console.WriteLine("Thinking is for other people. I prefer action.");
                    break;
                case 7:
                    Console.WriteLine("I misuse long words in an attempt to sound smarter.");
                    break;
                case 8:
                    Console.WriteLine("I get bored easily. When am I going to get on with my destiny?");
                    break;
            }
            thirdTrait = (random.Next(6) + 1);
            Console.WriteLine("Ideal");
            switch (thirdTrait)
            {
                case 1:
                    Console.WriteLine("Respect. People deserve to be treated with dignity and respect. (Good)");
                    break;
                case 2:
                    Console.WriteLine("Fairness. No one should get preferential treatment before the law, and no one is above the law. (Lawful)");
                    break;
                case 3:
                    Console.WriteLine("Freedom. Tyrants must not be allowed to oppress the people. (Chaotic)");
                    break;
                case 4:
                    Console.WriteLine("Might. If I become strong, I can take what I want—what I deserve. (Evil)");
                    break;
                case 5:
                    Console.WriteLine("Sincerity. There’s no good in pretending to be something I’m not. (Neutral)");
                    break;
                case 6:
                    Console.WriteLine("Destiny. Nothing and no one can steer me away from my higher calling. (Any)");
                    break;
            }
            fourthTrait = (random.Next(6) + 1);
            Console.WriteLine("Bond");
            switch (fourthTrait)
            {
                case 1:
                    Console.WriteLine("I have a family, but I have no idea where they are. One day, I hope to see them again.");
                    break;
                case 2:
                    Console.WriteLine("I worked the land, I love the land, and I will protect the land.");
                    break;
                case 3:
                    Console.WriteLine("A proud noble once gave me a horrible beating, and I will take my revenge on any bully I encounter.");
                    break;
                case 4:
                    Console.WriteLine("My tools are symbols of my past life, and I carry them so that I will never forget my roots.");
                    break;
                case 5:
                    Console.WriteLine("I protect those who cannot protect themselves.");
                    break;
                case 6:
                    Console.WriteLine("I wish my childhood sweetheart had come with me to pursue my destiny.");
                    break;
            }
            fifthTrait = (random.Next(6) + 1);
            Console.WriteLine("Flaw");
            switch (fifthTrait)
            {
                case 1:
                    Console.WriteLine("The tyrant who rules my land will stop at nothing to see me killed.");
                    break;
                case 2:
                    Console.WriteLine("I’m convinced of the significance of my destiny, and blind to my shortcomings and the risk of failure.");
                    break;
                case 3:
                    Console.WriteLine("The people who knew me when I was young know my shameful secret, so I can never go home again.");
                    break;
                case 4:
                    Console.WriteLine("I have a weakness for the vices of the city, especially hard drink.");
                    break;
                case 5:
                    Console.WriteLine("Secretly, I believe that things would be better if I were a tyrant lording over the land.");
                    break;
                case 6:
                    Console.WriteLine("I have trouble trusting in my allies.");
                    break;
            }
        }
        public void GuildArtisan()
        {
            firstTrait = (random.Next(20) + 1);
            Console.WriteLine("Guild Business");
            switch (firstTrait)
            {
                case 1:
                    Console.WriteLine("Alchemists and apothecaries");
                    break;
                case 2:
                    Console.WriteLine("Armorers, locksmiths, and finesmiths");
                    break;
                case 3:
                    Console.WriteLine("Brewers, distillers, and vintners");
                    break;
                case 4:
                    Console.WriteLine("	Calligraphers, scribes, and scriveners");
                    break;
                case 5:
                    Console.WriteLine("Carpenters, roofers, and plasterers");
                    break;
                case 6:
                    Console.WriteLine("Cartographers, surveyors, and chart-makers");
                    break;
                case 7:
                    Console.WriteLine("Cobblers and shoemakers");
                    break;
                case 8:
                    Console.WriteLine("Cooks and bakers");
                    break;
                case 9:
                    Console.WriteLine("	Glassblowers and glaziers");
                    break;
                case 10:
                    Console.WriteLine("Jewelers and gemcutters");
                    break;
                case 11:
                    Console.WriteLine("	Weavers and dyers");
                    break;
                case 12:
                    Console.WriteLine("Leatherworkers, skinners, and tanners");
                    break;
                case 13:
                    Console.WriteLine("Masons and stonecutters");
                    break;
                case 14:
                    Console.WriteLine("Painters, limners, and sign-makers");
                    break;
                case 15:
                    Console.WriteLine("Potters and tile-makers");
                    break;
                case 16:
                    Console.WriteLine("Shipwrights and sailmakers");
                    break;
                case 17:
                    Console.WriteLine("Smiths and metal-forgers");
                    break;
                case 18:
                    Console.WriteLine("Tinkers, pewterers, and casters");
                    break;
                case 19:
                    Console.WriteLine("Wagon-makers and wheelwrights");
                    break;
                case 20:
                    Console.WriteLine("Woodcarvers, coopers, and bowyers");
                    break;
            }
            secondTrait = (random.Next(8) + 1);
            Console.WriteLine("Personality Trait");
            switch (secondTrait)
            {
                case 1:
                    Console.WriteLine("I believe that anything worth doing is worth doing right. I can’t help it— I’m a perfectionist.");
                    break;
                case 2:
                    Console.WriteLine("I’m a snob who looks down on those who can’t appreciate fine art.");
                    break;
                case 3:
                    Console.WriteLine("I always want to know how things work and what makes people tick.");
                    break;
                case 4:
                    Console.WriteLine("I’m full of witty aphorisms and have a proverb for every occasion.");
                    break;
                case 5:
                    Console.WriteLine("I’m rude to people who lack my commitment to hard work and fair play.");
                    break;
                case 6:
                    Console.WriteLine("I like to talk at length about my profession.");
                    break;
                case 7:
                    Console.WriteLine("I don’t part with my money easily and will haggle tirelessly to get the best deal possible.");
                    break;
                case 8:
                    Console.WriteLine("I’m well known for my work, and I want to make sure everyone appreciates it. I'm always taken aback when people haven’t heard of me.");
                    break;
            }
            thirdTrait = (random.Next(6) + 1);
            Console.WriteLine("	Ideal");
            switch (thirdTrait)
            {
                case 1:
                    Console.WriteLine("Community. It is the duty of all civilized people to strengthen the bonds of community and the security of civilization. (Lawful)");
                    break;
                case 2:
                    Console.WriteLine("Generosity. My talents were given to me so that I could use them to benefit the world. (Good)");
                    break;
                case 3:
                    Console.WriteLine("Freedom. Everyone should be free to pursue his or her own livelihood. (Chaotic)");
                    break;
                case 4:
                    Console.WriteLine("	Greed. I’m only in it for the money. (Evil)");
                    break;
                case 5:
                    Console.WriteLine("People. I’m committed to the people I care about, not to ideals. (Neutral)");
                    break;
                case 6:
                    Console.WriteLine("Aspiration. I work hard to be the best there is at my craft.");
                    break;
            }
            fourthTrait = (random.Next(6) + 1);
            Console.WriteLine("Bond");
            switch (fourthTrait)
            {
                case 1:
                    Console.WriteLine("The workshop where I learned my trade is the most important place in the world to me.");
                    break;
                case 2:
                    Console.WriteLine("I created a great work for someone, and then found them unworthy to receive it. I’m still looking for someone worthy.");
                    break;
                case 3:
                    Console.WriteLine("I owe my guild a great debt for forging me into the person I am today.");
                    break;
                case 4:
                    Console.WriteLine("I pursue wealth to secure someone’s love.");
                    break;
                case 5:
                    Console.WriteLine("One day I will return to my guild and prove that I am the greatest artisan of them all.");
                    break;
                case 6:
                    Console.WriteLine("I will get revenge on the evil forces that destroyed my place of business and ruined my livelihood.");
                    break;
            }
            fifthTrait = (random.Next(6) + 1);
            Console.WriteLine("Flaw");
            switch (fifthTrait)
            {
                case 1:
                    Console.WriteLine("I’ll do anything to get my hands on something rare or priceless.");
                    break;
                case 2:
                    Console.WriteLine("	I’m quick to assume that someone is trying to cheat me.");
                    break;
                case 3:
                    Console.WriteLine("	No one must ever learn that I once stole money from guild coffers.");
                    break;
                case 4:
                    Console.WriteLine("I’m never satisfied with what I have— I always want more.");
                    break;
                case 5:
                    Console.WriteLine("I would kill to acquire a noble title.");
                    break;
                case 6:
                    Console.WriteLine("I’m horribly jealous of anyone who can outshine my handiwork. Everywhere I go, I’m surrounded by rivals.");
                    break;
            }
        }
        public void Hermit()
        {
            firstTrait = (random.Next(8) + 1);
            Console.WriteLine("Life of Seclusion");
            switch (firstTrait)
            {
                case 1:
                    Console.WriteLine("I was searching for spiritual enlightenment.");
                    break;
                case 2:
                    Console.WriteLine("I was partaking of communal living in accordance with the dictates of a religious order.");
                    break;
                case 3:
                    Console.WriteLine("I was exiled for a crime I didn’t commit.");
                    break;
                case 4:
                    Console.WriteLine("I retreated from society after a life-altering event.");
                    break;
                case 5:
                    Console.WriteLine("I needed a quiet place to work on my art, literature, music, or manifesto.");
                    break;
                case 6:
                    Console.WriteLine("I needed to commune with nature, far from civilization.");
                    break;
                case 7:
                    Console.WriteLine("I was the caretaker of an ancient ruin or relic.");
                    break;
                case 8:
                    Console.WriteLine("I was a pilgrim in search of a person, place, or relic of spiritual significance.");
                    break;
            }
            secondTrait = (random.Next(8) + 1);
            Console.WriteLine("Personality Trait");
            switch (secondTrait)
            {
                case 1:
                    Console.WriteLine("I’ve been isolated for so long that I rarely speak, preferring gestures and the occasional grunt.");
                    break;
                case 2:
                    Console.WriteLine("I am utterly serene, even in the face of disaster.");
                    break;
                case 3:
                    Console.WriteLine("The leader of my community had something wise to say on every topic, and I am eager to share that wisdom.");
                    break;
                case 4:
                    Console.WriteLine("I feel tremendous empathy for all who suffer.");
                    break;
                case 5:
                    Console.WriteLine("	I’m oblivious to etiquette and social expectations.");
                    break;
                case 6:
                    Console.WriteLine("I connect everything that happens to me to a grand, cosmic plan.");
                    break;
                case 7:
                    Console.WriteLine("I often get lost in my own thoughts and contemplation, becoming oblivious to my surroundings.");
                    break;
                case 8:
                    Console.WriteLine("I am working on a grand philosophical theory and love sharing my ideas.");
                    break;
            }
            thirdTrait = (random.Next(6) + 1);
            Console.WriteLine("Ideal");
            switch (thirdTrait)
            {
                case 1:
                    Console.WriteLine("Greater Good. My gifts are meant to be shared with all, not used for my own benefit. (Good)");
                    break;
                case 2:
                    Console.WriteLine("Logic. Emotions must not cloud our sense of what is right and true, or our logical thinking. (Lawful)");
                    break;
                case 3:
                    Console.WriteLine("Free Thinking. Inquiry and curiosity are the pillars of progress. (Chaotic)");
                    break;
                case 4:
                    Console.WriteLine("Power. Solitude and contemplation are paths toward mystical or magical power. (Evil)");
                    break;
                case 5:
                    Console.WriteLine("Live and Let Live. Meddling in the affairs of others only causes trouble. (Neutral)");
                    break;
                case 6:
                    Console.WriteLine("Self-Knowledge. If you know yourself, there’s nothing left to know. (Any)");
                    break;
            }
            fourthTrait = (random.Next(6) + 1);
            Console.WriteLine("Bond");
            switch (fourthTrait)
            {
                case 1:
                    Console.WriteLine("Nothing is more important than the other members of my hermitage, order, or association.");
                    break;
                case 2:
                    Console.WriteLine("I entered seclusion to hide from the ones who might still be hunting me. I must someday confront them.");
                    break;
                case 3:
                    Console.WriteLine("I’m still seeking the enlightenment I pursued in my seclusion, and it still eludes me.");
                    break;
                case 4:
                    Console.WriteLine("I entered seclusion because I loved someone I could not have.");
                    break;
                case 5:
                    Console.WriteLine("Should my discovery come to light, it could bring ruin to the world.");
                    break;
                case 6:
                    Console.WriteLine("My isolation gave me great insight into a great evil that only I can destroy.");
                    break;
            }
            fifthTrait = (random.Next(6) + 1);
            Console.WriteLine("Flaw");
            switch (fifthTrait)
            {
                case 1:
                    Console.WriteLine("Now that I've returned to the world, I enjoy its delights a little too much.");
                    break;
                case 2:
                    Console.WriteLine("I harbor dark, bloodthirsty thoughts that my isolation and meditation failed to quell.");
                    break;
                case 3:
                    Console.WriteLine("I am dogmatic in my thoughts and philosophy.");
                    break;
                case 4:
                    Console.WriteLine("I let my need to win arguments overshadow friendships and harmony.");
                    break;
                case 5:
                    Console.WriteLine("	I like keeping secrets and won’t share them with anyone.");
                    break;
                case 6:
                    Console.WriteLine("I’d risk too much to uncover a lost bit of knowledge.");
                    break;
            }
        }
        //left off here
        public void Noble()
        {
            firstTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (firstTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            secondTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (secondTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            thirdTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (thirdTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            fourthTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (fourthTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            fifthTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (fifthTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
        }
        public void Outlander()
        {
            firstTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (firstTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            secondTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (secondTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            thirdTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (thirdTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            fourthTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (fourthTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            fifthTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (fifthTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
        }
        public void Sage()
        {
            firstTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (firstTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            secondTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (secondTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            thirdTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (thirdTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            fourthTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (fourthTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            fifthTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (fifthTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
        }
        public void Sailor()
        {
            firstTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (firstTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            secondTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (secondTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            thirdTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (thirdTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            fourthTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (fourthTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            fifthTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (fifthTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
        }
        public void Soldier()
        {
            firstTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (firstTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            secondTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (secondTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            thirdTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (thirdTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            fourthTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (fourthTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            fifthTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (fifthTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
        }
        public void Urchin()
        {
            firstTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (firstTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            secondTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (secondTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            thirdTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (thirdTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            fourthTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (fourthTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            fifthTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (fifthTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
        }
        public void HauntedOne()
        {
            firstTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (firstTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            secondTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (secondTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            thirdTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (thirdTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            fourthTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (fourthTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            fifthTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (fifthTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
        }
        public void CityWatch()
        {
            firstTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (firstTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            secondTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (secondTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            thirdTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (thirdTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            fourthTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (fourthTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            fifthTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (fifthTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
        }
        public void ClanCrafter()
        {
            firstTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (firstTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            secondTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (secondTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            thirdTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (thirdTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            fourthTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (fourthTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            fifthTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (fifthTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
        }
        public void CloisteredScholar()
        {
            firstTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (firstTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            secondTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (secondTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            thirdTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (thirdTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            fourthTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (fourthTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            fifthTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (fifthTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
        }
        public void Courtier()
        {
            firstTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (firstTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            secondTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (secondTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            thirdTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (thirdTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            fourthTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (fourthTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            fifthTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (fifthTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
        }
        public void FactionAgent()
        {
            firstTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (firstTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            secondTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (secondTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            thirdTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (thirdTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            fourthTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (fourthTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            fifthTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (fifthTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
        }
        public void Inheritor()
        {
            firstTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (firstTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            secondTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (secondTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            thirdTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (thirdTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            fourthTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (fourthTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            fifthTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (fifthTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
        }
        public void KnightOfTheOrder()
        {
            firstTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (firstTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            secondTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (secondTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            thirdTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (thirdTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            fourthTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (fourthTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            fifthTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (fifthTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
        }
        public void MercenaryVeteran()
        {
            firstTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (firstTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            secondTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (secondTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            thirdTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (thirdTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            fourthTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (fourthTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            fifthTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (fifthTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
        }
        public void UrbanBountyHunter()
        {
            firstTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (firstTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            secondTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (secondTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            thirdTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (thirdTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            fourthTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (fourthTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            fifthTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (fifthTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
        }
        public void FarTraveler()
        {
            firstTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (firstTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            secondTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (secondTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            thirdTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (thirdTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            fourthTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (fourthTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            fifthTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (fifthTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
        }
        public void UthgardtTribeMember()
        {
            firstTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (firstTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            secondTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (secondTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            thirdTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (thirdTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            fourthTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (fourthTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            fifthTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (fifthTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
        }
        public void WaterdhavianNoble()
        {
            firstTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (firstTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            secondTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (secondTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            thirdTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (thirdTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            fourthTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (fourthTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
            fifthTrait = (random.Next(6) + 1);
            Console.WriteLine("");
            switch (fifthTrait)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("");
                    break;
                case 8:
                    Console.WriteLine("");
                    break;
            }
        }
            }
        } 
    