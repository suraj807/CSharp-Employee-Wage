using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpemployeewage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ispresent = 1;
            Random random = new Random();
            int empInput = random.Next(0, 2);

            if (ispresent == empInput)
            {
                Console.WriteLine("employee is present");
            }
            else
            {
                Console.WriteLine("employee is absent");
            }
        }
    }
}
