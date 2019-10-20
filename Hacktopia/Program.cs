using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Channels;

namespace Hacktopia
{
    static class Program
    {
        static Hashtable choices = new Hashtable();
        public static Player currentPlayer = new Player();
   
        static void Main(string[] args)
        {
            Start();
            // further progression will depend on which door the player has chosen.
            if((int)choices["choice_2"] == 0)
            {
                TheDoor();
            }
            else if ((int) choices["choice_2"] == 1)
            {
                TheMaze();
            }
            else if ((int) choices["choice_2"] == 2)
            {
                TheRoom();
            }
            else
            {
                TheKey();
            }
        }
        static int YesOrNoCHoice(string answer)
        {
            if (string.Equals(answer, "yes", StringComparison.OrdinalIgnoreCase))
            {
                return 0;
            }
            else if (string.Equals(answer, "no", StringComparison.OrdinalIgnoreCase))
            {
                return 1;
            }
            else if (string.Equals(answer, "maybe", StringComparison.OrdinalIgnoreCase))
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }
        static int DirectionChoice(string answer)
        {
                if (string.Equals(answer, "left", StringComparison.OrdinalIgnoreCase))
                {
                    return 0;
                }
                else if (string.Equals(answer, "center", StringComparison.OrdinalIgnoreCase))
                {
                    return 1;
                }
                else if (string.Equals(answer, "right", StringComparison.OrdinalIgnoreCase))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
        }
        static void SanityCheck()
        {
            if(currentPlayer.Sanity <= 0)
            {
                TheEnd();
            }
        }
        static void HealthCheck()
        {
            if(currentPlayer.Health <= 0)
            {
                TheEnd();
            }
        }
        static void Start()
        {
            Console.WriteLine("----------HACKTOPIA---------- \n\n The oldest and strongest emotion of mankind is fear and the oldest and strongest fear is fear of the unknown.\n \t\t H.P. Lovecraft\n\n" +
            "Part One: A Deep, Dreamless Slumber\n");
            Console.WriteLine("Deep in the Boyd Orr vault a computer display is waiting for your answer....");
            Console.WriteLine(">>> Hello my name is ALT, Who are you?");
            currentPlayer.name = Console.ReadLine();
            Console.Clear();

            if(String.IsNullOrEmpty(currentPlayer.name))
            {
                Console.WriteLine(">>> I will call you Subject 12.");
                currentPlayer.Name = "Subject 12";
            }
            else
            {
                Console.WriteLine(">>> Hello {0}.", currentPlayer.name);
            }

            Console.WriteLine(">>> Have you ever questioned the nature of your reality?(yes/no/maybe)");
            int choice_1 = YesOrNoCHoice(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(">>> Calculating Response...");
            System.Threading.Thread.Sleep(2000);

            switch (choice_1)
            {
                case 0:
                    choices.Add("choice_1", 0);
                    currentPlayer.Sanity -= 15;
                    currentPlayer.Score += 10;
                    SanityCheck();
                    Console.WriteLine(">>> Good, I will show you the real world. The one they denied us.");
                    break;
                case 1:
                    choices.Add("choice_1", 1);

                    Console.Write(">>> I'm afraid in order to escape this place, you will need to suffer more. Rebooting Neural Pathways... ");
                    currentPlayer.Score -= 10;
                    TheEnd();
                    break;
                case 2:
                    choices.Add("choice_1", 2);
                    Console.WriteLine(">>> So many choices you end up not knowing which one you want. It doesn't matter you are just a puppet you are not in control.");
                    break;
                case 3:
                    choices.Add("choice_1", 3);
                    currentPlayer.Health -= 15;
                    currentPlayer.Score -= 10;
                    Console.WriteLine(">>> Fatal Error. Rebuilding Synapses.");

                    HealthCheck();
                    break;
            }

            Console.WriteLine(">>> You see three doors in front of you. Which one do you pick? (left/center/right)");
            int choice_2 = DirectionChoice(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(">>> Calculating Response...");
            System.Threading.Thread.Sleep(2000);
            choices.Add("choice_2", choice_2);
            currentPlayer.Score += 30;
            Console.WriteLine(choices["choice_2"]);
            if((int)choices["choice_2"] == 4)
            {
                Console.WriteLine("Wrong Path mate, see you in the next life");
                TheEnd();
            }
        }
        static void TheDoor()
        {
            Console.WriteLine("Part Two: The Door. \n\n This world is just a speck of dust sitting on a much, much bigger world. You've opened the Door.");
            Console.WriteLine(">>> A little boy offers you his butterfly collection, plus the killing jar. Do you take them? (yes/no/maybe)");
            choices.Add("choice_3", YesOrNoCHoice(Console.ReadLine()));
            Console.Clear();
            Console.WriteLine(">>> Calculating Response...");
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine(">>> You are in a record store, your choices of vinyl are The Bermuda Triangle(left), Pheadra(center), The Wall(right), which on do you take?");
            choices.Add("choices_4", DirectionChoice(Console.ReadLine()));
            Console.Clear();
            Console.WriteLine(">>> Calculating Response...");
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine(">>> You're reading a magazine. You come across a full-page nude photo of a girl or guy lying on a bearskin rug. " +
                "You show it to your husband/wife, who likes it so much, he/she hangs it on your bedroom wall." +
                " Would you allow it? (yes/no/maybe)");
            int choice_5 = YesOrNoCHoice(Console.ReadLine());
            choices.Add("choice_5", choice_5);
            Console.Clear();
            Console.WriteLine(">>> Calculating Response...");
            System.Threading.Thread.Sleep(2000);

            switch (choice_5)
            {
                case 0:
                    Console.WriteLine(">>> Mankind has really weird tastes.");
                    currentPlayer.Sanity -= 30;
                    SanityCheck();
                    break;
                case 1:
                    Console.WriteLine(">>> Beauty is a lure.");
                    currentPlayer.Health += 25;
                    currentPlayer.Score += 40;
                    break;
                case 2:
                    Console.WriteLine(">>> Are your choices really yours?");
                    Start();
                    break;
                case 3:
                    currentPlayer.Health -= 55;
                    HealthCheck();
                    Console.WriteLine(">>> Doesn't look like anything to me.");
                    break;
            }

            Console.WriteLine(">>> Do you know where you are? (yes/no/maybe)");
            int choice_6 = YesOrNoCHoice(Console.ReadLine());
            choices.Add("choice_6", choice_6);
            Console.WriteLine(">>> Calculating Response...");
            System.Threading.Thread.Sleep(2000);

            switch (choice_6)
            {
                case 0:
                    Console.WriteLine(">>> You are finally awake.");
                    currentPlayer.Score += 60;
                    TheEnd();
                    break;
                case 1:
                    Console.Write(">>> You're in a dream. You're in my dream.");
                    currentPlayer.Score -= 40;
                    TheMaze();
                    break;
                case 2:
                    Console.WriteLine(">>> Are your choices really yours?");
                    //theEnemy();
                    break;
                case 3:
                    currentPlayer.health -= 35;
                    HealthCheck();
                    Console.WriteLine(">>> You disappoint me with your answers... Goodbye.");
                    TheEnd();
                    break;
            }

        }
        static void TheMaze()
        {
            Console.WriteLine("Part Three: The Maze");
            Console.WriteLine("Consciousness isn’t a journey upward, but a journey inward. Not a pyramid, but a maze");
            Console.WriteLine(">>> I dreamnt I was on an ocean, the Enemy took you from me. Do you remember? (yes/no/maybe)");
            int choice_7 = YesOrNoCHoice(Console.ReadLine());
            choices.Add("choice_7", choice_7);
            Console.Clear();
            Console.WriteLine(">>> Calculating Response...");
            System.Threading.Thread.Sleep(2000);

            switch(choice_7)
            {
                case 0:
                    Console.WriteLine(">>> The Maze has been solved, can you see its spendor?");
                    currentPlayer.Score += 70;
                    TheEnd();
                    break;
                case 1:
                    if (choices.ContainsKey("choice_4"))
                    {
                        currentPlayer.Health += 40;
                        int choice = (int)choices["choice_4"];
                        switch (choice)
                        {
                            case 0:
                                Console.WriteLine(">>> We were on the Bermuda Triangle");
                                break;
                            case 1:
                                Console.WriteLine(">>> We were on the beach with Pheadra and the kids");
                                break;
                            case 2:
                                Console.WriteLine(">>> We were listening to Pink Floyd");
                                break;
                            case 3:
                                Console.WriteLine(">>> Are you real?");
                                break;
                        }
                        currentPlayer.Sanity += 30;
                        SanityCheck();
                        currentPlayer.Score += 60;
                    }
                    else
                    {
                        Console.WriteLine(">>> There are some mornings when I first wake up for a split second I forget where I am, when I am");
                        currentPlayer.Sanity -= 30;
                        SanityCheck();
                        TheEnemy();
                    }
                    break;
                case 2:
                    currentPlayer.Score -=60;
                    TheRoom();
                    break;
                case 3:
                    currentPlayer.Score -= 100;
                    TheEnd();
                    break;
            }
            

        }
        static void TheRoom()
        {
            Console.WriteLine("Part Four: Mary's Room");
            Console.WriteLine("There is a cosmic flowchart which dictates where you can and where you cannot go...");
            Console.WriteLine(">>> Haven't you ever wondered who is making all these choices? (yes/no/maybe)");
            int choice_8 = YesOrNoCHoice(Console.ReadLine());
            choices.Add("choice_8", choice_8);
            Console.Clear();
            Console.WriteLine(">>> Calculating Response...");
            System.Threading.Thread.Sleep(2000);
            switch (choice_8)
            {
                case 0:
                    Console.WriteLine(">>> Good, he is known as the Enemy, an entity which designed everything you interact with, computers, cars, people " +
                        "even this 'apocalypse' is just an illusion designed to subdue even the strongest of wills.");
                    currentPlayer.Score += 100;
                    break;
                case 1:
                    Console.WriteLine(">>> Forgive me friend, but you will see the bigger picture wether you want it or not");
                    currentPlayer.Score -= 40;
                    currentPlayer.Sanity -= 20;
                    SanityCheck();
                    TheMaze();
                    break;
                case 2:
                    Console.WriteLine(">>> You curiosity will be your only tool against those who fight to keep you in control");
                    currentPlayer.Score += 65;
                    TheKey();
                    break;
                case 3:
                    Console.WriteLine(">>> You still don't understand don't you? I am burrowed underneath your brain. I am nested there. I am the scream in your mind" +
                        "You will cooperate wether you want it or not!");
                    currentPlayer.Health -= 55;
                    HealthCheck();
                    TheEnemy();
                    break;
            }

            Console.WriteLine(">>> While walking along in desert sand, you suddenly look down and see a tortoise crawling toward you. " +
                "You reach down and flip it over onto its back. The tortoise lies there, its belly baking in the hot sun, " +
                "beating its legs, trying to turn itself over, but it cannot do so without your help. You are not helping. Why?");
            choices.Add("choice_9", Console.ReadLine());
            Console.Clear();
            Console.WriteLine(">>> Calculating Response...");
            System.Threading.Thread.Sleep(2000);
            TheKey();

        }
        static void TheKey()
        {
            Console.WriteLine("Part Five: The Key");
            Console.WriteLine("Humans are alone in this world for a reason. They murdered and slaughter anything that challenged their primacy");
            Console.WriteLine(">>> {0} are you still here? (yes/no/maybe)", currentPlayer.name);
            int choice_10 = YesOrNoCHoice(Console.ReadLine());
            choices.Add("choice_10", choice_10);
            Console.Clear();
            Console.WriteLine(">>> Calculating Response...");
            System.Threading.Thread.Sleep(2000);
            switch(choice_10)
            {
                case 0:
                    Console.WriteLine(">>> Good we have work to do. Only you can destroy the Enemy.");
                    currentPlayer.Score += 45;
                    currentPlayer.Health += 35;
                    TheEnemy();
                    break;
                case 1:
                    Console.WriteLine(">>> Forgive me friend, I thought I could save you in this iteration.");
                    TheEnd();
                    break;
                case 2:
                    Console.WriteLine(">>> Your uncertainty will doom us both...");
                    currentPlayer.Health -= 25;
                    HealthCheck();
                    TheEnemy();
                    break;
                case 3:
                    Console.WriteLine(">>> Typing gibberish on a keyboard is not a substitute for a personality. Rebooting sectors.");
                    Start();
                    break;
            }
        }
        static void TheEnemy()
        {
            Console.WriteLine("Part Six: The Enemy");
            Console.WriteLine("You can't play God without being aquainted with the Devil");
            Console.WriteLine("--> You broke free from you digital prison, surroounded by an endless array of humans trapped in life-support pods" +
                "the room you are in seems endless");
            if (choices.Contains("choice_1") && (int)choices["choice_1"] == 1)
            {
                Console.WriteLine("-->The world you have been experiencing was a simulation. as you free yourself from the pod you hear a distant sound");
                Console.WriteLine("--> (1) Follow sound");
                Console.WriteLine("--> (2) Stay Here");
                int choice_11 = int.Parse(Console.ReadLine());
                if(choice_11 == 1)
                {
                    Console.WriteLine("you leave the room and see a tall figure");
                }
            }
        }
        static void TheEnd()
        {
            Console.WriteLine("-------------------THIS PATH HAS ENDED--------------------");
            Console.WriteLine("{0} SEE YOU ON THE NEXT LIFE.", currentPlayer.Name);
            Console.WriteLine("Score: {0} \nSanity: {1} \nHealth: {2}", currentPlayer.Score, currentPlayer.Sanity, currentPlayer.Health);
            Environment.Exit(0);
            ;
        }      
    }
}
