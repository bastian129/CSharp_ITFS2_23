using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_ITFS2_23
{
    internal class Aufgaben_Methoden_4
    {
        public static void Start()
        {
            while (true)
            {
                long i;
                Console.WriteLine("Bitte geben Sie eine Zahl ein:");
                while (!long.TryParse(Console.ReadLine(), out i)) ;
                if (Meth(i))
                    Console.WriteLine("Jap, ist eine Primzahl");
                else
                    Console.WriteLine("Nope, ist keine Primzahl");
            }
        }
        static bool Meth(long i)
        {
            for (long k = 2; k < i; k++)
                if (i % k == 0) return false;

            return true;
        }
    }
}
