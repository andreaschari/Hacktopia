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
            Console.WriteLine("----------HACKTOPIA---------- \n\n The oldest and strongest emotion of mankind is fear and the oldest and strongest fear is fear of the unknown\n \t\t H.P. Lovecraft\n\n" +
    "Part One: the Horror in Steel\n");
            Console.WriteLine("Deep in the Boyd Orr vault a computer display is waiting for your answer....");
            Console.WriteLine(">>> Who are you?");
            currentPlayer.name = Console.ReadLine();
            Console.WriteLine("Can you help me? (yes/no)");
            string  answer = Console.ReadLine();
            Console.WriteLine(">>> Calculating Response...");
            if(string.Equals(answer, "yes", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Thank You. My Name is Alice");
            }
            else if (string.Equals(answer, "no", StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("I'm Sorry.... Initializing Self-Destruct ");
                System.Threading.Thread.Sleep(1000);
                Console.Write(" 3 ");
                System.Threading.Thread.Sleep(1000);
                Console.Write(" 2 ");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine(" 1 ");

            }
        }
            
        
            
    }
}
