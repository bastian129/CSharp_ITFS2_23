using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_ITFS2_23
{
    internal class Aufgabe_Methoden_1
    {
        public static void Start()
        {
            while (true)
            {
                Console.WriteLine("Bitte geben Sie eine Anweisung ein:");
                switch (Console.ReadLine().ToLower())
                {
                    case "hello":
                        Hello();
                        break;
                    case "quadrat":
                        Quadrat();
                        break;
                    case "buchstaben":
                        Buchstaben();
                        break;
                    case "exit":
                        return;
                }
            }
        }
        public static void Hello()
        {
            Console.WriteLine("+------------------+");
            Console.WriteLine("|    Hello World!  |");
            Console.WriteLine("+------------------+");
        }
        public static void Quadrat()
        {
            Console.WriteLine("Bitte geben Sie eine Zahl ein:");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ihr Ergebnis ist: " + (i * i));
        }
        public static void Buchstaben()
        {
            Console.WriteLine("Bitte geben Sie einen String ein:");
            foreach(var element in Console.ReadLine())
                Console.Write(element + " ");

            Console.WriteLine();
        }

    }
}
