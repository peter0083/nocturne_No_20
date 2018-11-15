using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x;
            int y;

            x = 7;
            y = x + 3;

            Console.WriteLine(y);
            Console.ReadLine();
            */

            Console.WriteLine("Enter user ID and pin...");
            Console.Write("Type your user ID here: ");

            string myUserID;
            myUserID = Console.ReadLine();

            Console.Write("Type your user pin here: ");

            //string myUserPin;
            //myUserPin = Console.ReadLine();

            string myUserPin = Console.ReadLine();

            Console.WriteLine("User ID " + myUserID + " is now paired with " + myUserPin);
            Console.ReadLine();
        }
    }
}
