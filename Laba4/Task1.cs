using System;
using System.Collections.Generic;
using System.Text;
using LibPrint;


namespace Laba4
{
    public class Task1
    {
        public static void First()
        {
            Console.Clear();
            Pt.P("Enter sentense whith dot in the end");//С помощью массива
            string Sent = Console.ReadLine();
            char[] S = Sent.ToCharArray();
            for (int i = 0; i < S.Length; i++)
            {
                int number = 0;
                for (int j = 0; j < S.Length; j++)
                {
                    if (i == j) { continue; }
                    if (S[i] == S[j]) { number++; }
                }
                if (number == 0) { Console.Write($"{S[i]} "); }
            }
            Console.WriteLine();
            for(int i = 0; i < S.Length; i++)//С помощью методов string
            {
                int In1 = Sent.IndexOf(S[i]);
                int In2 = Sent.LastIndexOf(S[i]);
                if (In1 == In2) { Console.Write($"{S[i]} "); }
            }
            Console.ReadKey();
        }  
    }
}
