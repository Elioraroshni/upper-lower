using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give lower limit");
            int lower = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give upper limit");
            int upper = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numbers between Upper and Lower limits are");

            for (int i = lower; i <= upper; i++)
            {

                Console.WriteLine(i);

            }
            Console.ReadKey();
        }
    }
}
