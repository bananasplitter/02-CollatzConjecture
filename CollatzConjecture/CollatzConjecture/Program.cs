using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollatzConjecture
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter number here greater than 1");

            string input = Console.ReadLine();

            int yourNumber = int.Parse(input);

            int currentStep = 0;

            int largestStep = 0;

            int largestNumber = yourNumber;

            while (yourNumber != 1)

            {
                currentStep++;

                if (yourNumber > largestNumber);
                {
                    yourNumber = largestNumber
                    Console.WriteLine(yourNumber);
                }
                    if (yourNumber % 2 == 0)
                    {
                        yourNumber = yourNumber / 2;

                        Console.WriteLine(yourNumber);
                    }

                    else


                    {
                        yourNumber = yourNumber * 3 + 1;

                        Console.WriteLine(yourNumber);
                    }

            }
            Console.ReadLine();
        }
    }
}
