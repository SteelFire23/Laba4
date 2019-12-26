using System;
using System.Collections.Generic;
using System.Text;
using LibPrint;

namespace Laba4
{
   public class Task3
   {
       public static void Third()
       {
            Console.Clear();
            Pt.P("Enter some words whith dot in the end");
            String Words = Console.ReadLine();
            Words = Words.Remove(Words.Length - 1, 1);
            String[] S = Words.Split();
            for (int i = S.Length-1; i >=0; i--)//С помощью массива и цикла
            {
                Console.Write($"{S[i]} ");
            }
            Console.Write(".");
            StringBuilder Rev = new StringBuilder();
            foreach (string c in S){
                Rev.Insert(0, c);
                Rev.Insert(S.Length - 3, " ");
            }
            Words = Rev.ToString();
            Console.WriteLine(Words+".");
            Console.ReadKey();
        }
   }
}
