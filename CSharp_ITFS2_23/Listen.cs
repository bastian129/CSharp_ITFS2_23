using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_ITFS2_23
{
    internal class Listen
    {
        public static void Start()
        {
            int[] intArray = new int[] { 12, 34, 45, 56 };
            List<int> intList = new List<int>(intArray);

            intList.Add(15);
            intList.Add(34);
            intList.Add(123);

            Console.WriteLine(intList[2]);
            intList.Insert(0, 12);
            Console.WriteLine(intList[2]);
            intList.RemoveAt(2);
            intList.Contains(15);
            int i = intList.Count;
            intList.Clear();
            intList.IndexOf(34);

            intList.Sort();
            intList.Remove(123);

            foreach (var element in intList)
                Console.WriteLine(element);

        }
    }
}
