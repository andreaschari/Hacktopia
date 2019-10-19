using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Channels;

namespace Hacktopia
{
    class Program
    {
        static Hashtable choices = new Hashtable();
        public static Player currentPlayer = new Player();
   
        static void Main(string[] args)
        {
            Start();
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

        static void Start()
        {
            Console.WriteLine("----------HACKTOPIA---------- \n\n The oldest and strongest emotion of mankind is fear and the oldest and strongest fear is fear of the unknown.\n \t\t H.P. Lovecraft\n\n" +
            "Part One: the Horror in Steel\n");
            Console.WriteLine("Deep in the Boyd Orr vault a computer display is waiting for your answer....");
            Console.WriteLine(">>> Who are you?");
            currentPlayer.name = Console.ReadLine();
            Console.Clear();
            if(currentPlayer.name == "")
            {
                Console.WriteLine(">>> I will call you Subject 12.");
                currentPlayer.name = "Subject 12";
            }
            else
            {
                Console.WriteLine(">>> Hello {0}.", currentPlayer.name);
            }

            Console.WriteLine(">>> Have you ever questioned the nature of your reality?");
            string  answer_1 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(">>> Calculating Response...");
            int choice_1 = YesOrNoCHoice(answer_1);
            System.Threading.Thread.Sleep(2000);

            switch (choice_1)
            {
                case 0:
                    choices.Add("choice_1", 0);
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
                    break;
                case 2:
                    choices.Add("choice_1", 2);
                    Console.WriteLine(">>> So many choices you end up not knowing which one you want. It doesn't matter you are just a puppet you are not in control.");
                    break;
                case 3:
                    choices.Add("choice_1", 3);
                    Console.WriteLine(">>> Fatal Error. Eliminating Subject.");
                    break;
            }

            Console.WriteLine(">>> You see three doors in front of you. A white on the left, a black on the centre and a grey on the right\n Which one do you pick?");
            string answer_2 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(">>> Calculating Response...");
            int choice_2 = DirectionChoice(answer_1);
            System.Threading.Thread.Sleep(2000);
        }
            
        
            
    }
}
