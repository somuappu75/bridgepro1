using System;
using System.Collections.Generic;
using System.Text;

namespace bridgepro1
{
    class user
    {
        public static void userinput()
        {
            Console.WriteLine("plase enter the name");
            string name = Console.ReadLine();
            int namelength = name.Length;
            if(namelength>=3)
            {
                Console.WriteLine("The length of the string is:" + namelength);
                Console.WriteLine("Hello " + name + " How are you");
                Console.WriteLine("Hello {0} how are you", name);
            }
            else
            {
                Console.WriteLine("please enter  Minimum 3 chars");
            }


        }

    }
}

