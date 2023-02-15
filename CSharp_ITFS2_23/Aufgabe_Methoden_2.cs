using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_ITFS2_23
{
    internal class Aufgabe_Methoden_2
    {
        public static void Start()
        {
            while (true)
            {
                Console.WriteLine("Ihr Ergebnis: " + Meth());
                Console.WriteLine("Wollen Sie weiter machen? (J = Ja, weiter geht's)");
                if (Console.ReadLine().ToUpper() != "J")
                    break;
            }
        }
        static int Meth()
        {
            Console.WriteLine("Gebe String ein.... SOFORT!");
            return Console.ReadLine().Length;
        }
    }
}
