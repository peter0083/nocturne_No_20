using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] testArray = new int[5];

            testArray[0] = 4;
            testArray[1] = 8;
            testArray[2] = 15;
            testArray[3] = 16;
            testArray[4] = 23;

            Console.WriteLine(testArray[1]);
            Console.WriteLine(testArray.Length);
            Console.ReadLine();
            */

            string[] testArray = new string[] { "James", "Paul", "Chris", "Larry" };

            /*
            for (int i = 0; i < testArray.Length; i++)
            {
                Console.WriteLine(testArray[i]);
            }
            Console.ReadLine();
            */

            foreach (string name in testArray)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

        }
    }
}
