using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_ITFS2_23
{
    internal class Aufgabe_Methoden_3
    {
        public static void Start()
        {
            while(true)
            {
                Console.WriteLine("String eingeben:");
                string s = Console.ReadLine();
                Console.WriteLine("Integer eingeben:");
                int i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Meth(s, i));
            }
        }

        static string Meth(string s, int i)
        {
            //Zuerst überprüfen, ob die Eingabe bereits kleiner oder gleich der zweiten Eingabe ist
            if (s.Length <= i)
                return s;
            //Liste aller Buchstaben
            string[] abc = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            //Durchlaufen aller einzelnen Buchstaben im Alphabet
            foreach(var element in abc)
            {
                //Sollte der Buchstabe öfter vorkommen
                while (true)
                {
                    //Ist der Buchstabe überhaupt (noch) drinnen? Dann rausspringen
                    if (!s.ToLower().Contains(element))
                        break;
                    //Buchstabe rausnehmen
                    s = s.Remove(s.ToLower().IndexOf(element), 1);
                    //Ist die Ziellänge erreicht?
                    if (s.Length <= i)
                        return s;
                }
            }
            return s;
        }

    }
}
