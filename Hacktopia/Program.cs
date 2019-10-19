using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Channels;

namespace Hacktopia
{
    class Program
    {
        public static Player currentPlayer = new Player();
   
        static void Main(string[] args)
        {
            Start();
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
            string  answer = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(">>> Calculating Response...");
            System.Threading.Thread.Sleep(2000);

            if (string.Equals(answer, "yes", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(">>> Good, I will show you the real world. The one they denied us.");
            }
            else if (string.Equals(answer, "no", StringComparison.OrdinalIgnoreCase))
            {
                Console.Write(">>> I'm afraid in order to escape this place, you will need to suffer more. Initializing Self-Destruct ");
                System.Threading.Thread.Sleep(1000);
                Console.Write(" 3 ");
                System.Threading.Thread.Sleep(1000);
                Console.Write(" 2 ");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine(" 1 ");

            }
            else if(string.Equals(answer, "maybe", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(">>> So many choices you end up not knowing which one you want. It doesn't matter you are just a puppet you are not in control.");
            }
            else
            {
                Console.WriteLine(">>> Fatal Error. Eliminating Subject.");
            }
        }
            
        
            
    }
}
