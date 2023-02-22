using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_ITFS2_23
{
    internal class Listen_Aufgabe_1
    {
        public static void Start()
        {
            List<string> stringList = new List<string>();
            while(true)
            {
                Console.WriteLine("Bitte geben Sie was ein:");
                stringList.Add(Console.ReadLine());
                Console.WriteLine("Weiter machen? (J = JA, ich will!)");
                if (Console.ReadLine() != "J")
                    break;
            }
            int sum = 0;
            foreach(var element in stringList)
            {
                int i;
                if (int.TryParse(element, out i)) { }
                else
                    i = element.Length;

                sum += i;
                Console.WriteLine("Wert: {0} - Zahl: {1}", element, i);
            }
            Console.WriteLine("Summe: " + sum);
        }
    }
}
