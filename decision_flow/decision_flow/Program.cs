using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decision_flow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initiating Monty Hall Simulator...");
            Console.Write("Choose door 1, 2, or 3: ");

            string userDoorPick = Console.ReadLine();

            if (userDoorPick == "1")
            {
                string winMessage = "You won a new car!";
                Console.WriteLine(winMessage);
            }

            Console.ReadLine();
        }
    }
}
