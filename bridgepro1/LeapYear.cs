using System;
using System.Collections.Generic;
using System.Text;

namespace bridgepro1
{
    class LeapYear
    {
        public static void year()
        {
            Console.WriteLine("Enter The Yaer");
            int year = int.Parse(Console.ReadLine());
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                Console.WriteLine(" is a Leap Year" +year);
            }
            else
            {
                Console.WriteLine("{0} is not a Leap Year.", year);
                Console.ReadLine();
            }
        }
    }
}
