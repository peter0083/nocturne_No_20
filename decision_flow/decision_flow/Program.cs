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
            /*
            Console.WriteLine("Initiating Monty Hall Simulator...");
            Console.Write("Choose door 1, 2, or 3: ");

            string userDoorPick = Console.ReadLine();

            if (userDoorPick == "1")
            {
                string winMessage = "You won a new car!";
                Console.WriteLine(winMessage);
            }

            else if (userDoorPick == "2" || userDoorPick == "3")
            {
                string goatMessage = "You got a goat! You lose :(";
                Console.WriteLine(goatMessage);
            }
            else
            {
                string inputErrorMessage = "Only input 1, 2, or 3 can be accepted";
                Console.WriteLine(inputErrorMessage);
            }

            Console.ReadLine();
            */

            Console.WriteLine("Initiating Monty Hall Simulator...");
            Console.Write("Choose door 1, 2, or 3: ");
            
            string userDoorPick = Console.ReadLine();

            string message = (userDoorPick == "1") ? "You won a new car!" : "You got a goat! You lose.";

            Console.Write("You picked door {0}" + Environment.NewLine + "... {1}", userDoorPick, message);
            Console.ReadLine();
        }
    }
}
