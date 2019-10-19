﻿using System;
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
                //TheKey();
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
            if(currentPlayer.sanity <= 0)
            {
                TheEnd();
            }
        }
        static void HealthCheck()
        {
            if(currentPlayer.health <= 0)
            {
                TheEnd();
            }
        }
        static void Start()
        {
            Console.WriteLine("----------HACKTOPIA---------- \n\n The oldest and strongest emotion of mankind is fear and the oldest and strongest fear is fear of the unknown.\n \t\t H.P. Lovecraft\n\n" +
            "Part One: Deep, Dreamless Slumber\n");
            Console.WriteLine("Deep in the Boyd Orr vault a computer display is waiting for your answer....");
            Console.WriteLine(">>> Hello my name is ALT, Who are you?");
            currentPlayer.name = Console.ReadLine();
            Console.Clear();

            if(String.IsNullOrEmpty(currentPlayer.name))
            {
                Console.WriteLine(">>> I will call you Subject 12.");
                currentPlayer.name = "Subject 12";
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
                    currentPlayer.sanity -= 5;
                    currentPlayer.score += 10;
                    SanityCheck();
                    Console.WriteLine(">>> Good, I will show you the real world. The one they denied us.");
                    break;
                case 1:
                    choices.Add("choice_1", 1);

                    Console.Write(">>> I'm afraid in order to escape this place, you will need to suffer more. Initializing Self-Destruct ");
                    System.Threading.Thread.Sleep(1000);
                    Console.Write(" 3 ");
                    System.Threading.Thread.Sleep(1000);
                    Console.Write(" 2 ");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine(" 1 ");
                    currentPlayer.score -= 10;
                    TheEnd();
                    break;
                case 2:
                    choices.Add("choice_1", 2);
                    Console.WriteLine(">>> So many choices you end up not knowing which one you want. It doesn't matter you are just a puppet you are not in control.");
                    break;
                case 3:
                    choices.Add("choice_1", 3);
                    currentPlayer.health -= 5;
                    currentPlayer.score -= 10;
                    Console.WriteLine(">>> Fatal Error. Eliminating Subject.");

                    HealthCheck();
                    break;
            }

            Console.WriteLine(">>> You see three doors in front of you. Which one do you pick? (left/center/right)");
            int choice_2 = DirectionChoice(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(">>> Calculating Response...");
            System.Threading.Thread.Sleep(2000);
            choices.Add("choice_2", choice_2);
            currentPlayer.score += 20;
        }
        static void TheDoor()
        {
            Console.WriteLine(">>> Part Two: The Door. \n\n This world is just a speck of dust sitting on a much, much bigger world. You've opened the Door.");
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
                    currentPlayer.sanity -= 10;
                    SanityCheck();
                    break;
                case 1:
                    Console.WriteLine(">>> Beauty is a lure.");
                    currentPlayer.score += 10;
                    break;
                case 2:
                    Console.WriteLine(">>> Are your choices really yours?");
                    break;
                case 3:
                    currentPlayer.health -= 5;
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
                    currentPlayer.score += 30;
                    TheEnd();
                    break;
                case 1:
                    Console.Write(">>> You're in a dream. You're in my dream.");
                    currentPlayer.score -= 20;
                    TheMaze();
                    break;
                case 2:
                    Console.WriteLine(">>> Are your choices really yours?");
                    //theEnemy();
                    break;
                case 3:
                    currentPlayer.health -= 5;
                    HealthCheck();
                    Console.WriteLine(">>> You disappoint me with your answers... Goodbye.");
                    TheEnd();
                    break;
            }

        }
        static void TheMaze()
        {
            Console.WriteLine(">>> Part Three: The Maze");
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
                    currentPlayer.score += 50;
                    TheEnd();
                    break;
                case 1:
                    if (choices.ContainsKey("choice_4"))
                    {
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
                        currentPlayer.sanity += 10;
                        SanityCheck();
                        currentPlayer.score += 10;
                    }
                    else
                    {
                        Console.WriteLine(">>> There are some mornings when I first wake up for a split second I forget where I am, when I am");
                        currentPlayer.sanity -= 3;
                        SanityCheck();
                        //TheEnemy();
                    }
                    break;
                case 2:
                    currentPlayer.score -= 10;
                    TheRoom();
                    break;
                case 3:
                    currentPlayer.score -= 100;
                    TheEnd();
                    break;
            }
            

        }

        static void TheRoom()
        {
            Console.WriteLine("Part Four: Mary's Room");
            Console.WriteLine("You start realising that your control is an illusion");
            Console.WriteLine("Haven't you ever wondered who is making all these choices? (yes/no/maybe)");
            int choice_8 = YesOrNoCHoice(Console.ReadLine());
            choices.Add("choice_8", choice_8);
            Console.Clear();
            Console.WriteLine(">>> Calculating Response...");
            System.Threading.Thread.Sleep(2000);
            switch(choice_8)
            {
                case 0:
                    Console.WriteLine("Good, he is known as the Enemy, an entity which design everything you interact with, computers, cars, people" +
                        "even this 'apocalypse' is just an illusion designed to subdue even the strongest of wills.");
                    break;
                case 1:
                    Console.WriteLine("Forgive me friend, but you will see the bigger picture wether you want it or not");
                    //TheKey();
                    break;
                case 2:
                    Console.WriteLine("You curiosity will be your only tool against those who fight to keep you in control");
                    break;
                case 3:
                    Console.WriteLine("You still don't understand don't you? I am burrowed underneath your brain. I am nested there. I am the scream in your mind" +
                        "You will cooperate wether you want it or not!");
                    //TheEnemy();
                    break;
            }
        }
        static void TheEnd()
        {
            Console.WriteLine("-------------------THIS PATH HAS ENDED--------------------");
            Console.WriteLine("{0} SEE YOU ON THE NEXT LIFE.", currentPlayer.name);
            Console.WriteLine("Score: {0} \nSanity: {1} \nHealth: {2}", currentPlayer.score, currentPlayer.sanity, currentPlayer.health);
            Environment.Exit(0);
            ;
        }
            
        
            
    }
}
