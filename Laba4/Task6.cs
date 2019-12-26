using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using LibPrint;
using System.Text.RegularExpressions;

namespace Laba4
{
    public class Task6
    {
        public static void Sixth()
        {
            Pt.P("Enter some expression like this: 15 + 36 = 51");
            String Expr = Console.ReadLine();
            if (Expr.Contains("+")) Expr = Expr.Replace("+", " ");
            Expr = Expr.Replace("=", " ");
            int First = 0, Second = 0, Sum = 0;         
            Regex reg = new Regex(@"(\s||'-')\d*");                                 
            String[] S = Expr.Split(" ",StringSplitOptions.RemoveEmptyEntries) ;               
            for (int i = 0; i < S.Length; i++)
            {
                if (reg.IsMatch(S[i]))
                {                    
                    if (First == 0) { First = int.Parse(S[i]); }
                    if (First != 0 && Second == 0 ) { Second = int.Parse(S[i]); }
                    if (First != 0 && Second != int.Parse(S[i])) { Sum = int.Parse(S[i]); }
                }
            }                         
            Console.Write($"First number: {First}, Second number: {Second} and a sum of this numbers: {Sum}");
            Console.ReadKey();
        }
    }
}
