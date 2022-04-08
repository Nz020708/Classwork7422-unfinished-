using System;
using System.Collections.Generic;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintFileGen<PDF> a = new PrintFileGen<PDF>();

            PrintFileGen<Excel>.Print();



        }
    }
}   



