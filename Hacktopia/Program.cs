using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacktopia
{
    class Program
    {
         private static void prelude()
        {
            Console.WriteLine("----HACKTOPIA: CHAPTER 1----\n"+
                "12 Months ago the world ended... 6 brave scientists " +
                "travelled deep into the ruins of the Boyd Orr building \n to find the last working" +
                "electronic devices on earth. \n All expect one were running MyCampus and were useless.\n One was still operational, display a single question");
        }

        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            prelude();
            Console.WriteLine("Enter Player Name: ");
            string playerName = Console.ReadLine();

        }
            
        
            
    }
}
