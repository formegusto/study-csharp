using System;
using System.Collections.Generic;

namespace study_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize
            int[] intArray = new int[5];
            int[] intArray_2 = new int[5] { 1, 2, 3, 4, 5 };

            List<int> listInt = new List<int>() { 1, 2, 3, 4 };

            foreach(int i in intArray_2)
            {
                Console.WriteLine(i);
            }

            for(int i = 0; i < listInt.Count; i++)
            {
                Console.WriteLine(listInt[i]);
            }
        }
    }
}
