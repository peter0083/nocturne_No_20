using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int index = 0; index < 10; index++)
            {
                //Console.WriteLine(index);
                if (index == 7)
                {
                    Console.WriteLine("Now the index is equal to 7!");
                    break;
                }
            }

            for (int index = 0; index < 15; index++)
            {
                Console.WriteLine("Hello world" + index);
            }

            Console.ReadLine();
        }
    }
}
