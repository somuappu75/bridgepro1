using System;
using System.Collections.Generic;
using System.Text;

namespace bridgepro1
{
    class PowerofTwo
    {
        public static void power2()
        {
            Console.WriteLine("Enter the Number");
            int powerOfTwo(int n)
            {
                if (n == 0) 
                {
                    return 0;
                }
                while (n != 1)
                {
                    n = n / 2;
                    if (n % 2 != 0 && n != 1) 
                    {
                        return 0;
                        Console.ReadLine(PowerofTwo);
                    }
                }
                return 1;
            }
        }
    }
}
