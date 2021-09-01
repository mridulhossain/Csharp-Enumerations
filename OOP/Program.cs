using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine((int)Status.paid); // get status value of enum
            Console.WriteLine((Status)2); // get status by value


            Status a;
            Enum.TryParse("something", out a);
            Console.WriteLine(a);  // if not found it return by default 0 


            Status b;
            Enum.TryParse("paid",out b);
            Console.WriteLine(b); // if found it's show this value 

        }


       public enum Status
        {
            nostatus = 0,
            paid     = 1,
            unpaid   = 2
        }

    }
}


