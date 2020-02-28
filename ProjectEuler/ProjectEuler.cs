using System;
using ProjectEuler.Methods;
using ProjectEuler.ImplementedMethods;

namespace ProjectEuler
{
    class ProjectEuler
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            PageOne _pageonemethods = new ImplementedPageOne();
            Console.WriteLine("1: "+_pageonemethods.MultiplesOf3and5(1000));
            Console.WriteLine("2: "+_pageonemethods.EvenFibonacci(4000000));

            Console.WriteLine("3: "+_pageonemethods.LargestPrimeFactor(13195));
            Console.WriteLine("3: "+_pageonemethods.LargestPrimeFactor(600851475143));

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Testing");

            var primefac = 992299;
            Console.Write("pf of "+ primefac +" = ");
            foreach(var num in _pageonemethods.PrimeFactorization(primefac))
            {
                Console.Write(num+",");
            }

            Console.WriteLine("");

        }
    }
}
