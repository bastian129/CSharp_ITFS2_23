using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_ITFS2_23
{
    internal class Aufgabe_X
    {
        public static void Start()
        {
            int i = Meth1();
            Console.WriteLine("Ihre Zahl: " + i);
        }
        //Keinen Übergabewert - Keinen Rückgabewert
        public static void Meth()
        {
            Console.WriteLine("+------------------+");
            Console.WriteLine("|        🤔        |");
            Console.WriteLine("+------------------+");
        }

        public static int Meth1()
        {
            while(true)
            {
                Console.WriteLine("Lieber Nutzer, bitte gebe eine Zahl ein :)");
                if (int.TryParse(Console.ReadLine(), out int i))
                    return i;
                Console.WriteLine("Leider ist die Eingabe keine Zahl oder die Zahl ist zu groß oder zu klein...");
            }
        }
    }
}
