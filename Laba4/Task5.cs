using System;
using System.Collections.Generic;
using System.Text;
using LibPrint;
using System.Text.RegularExpressions;

namespace Laba4
{
    public class Task5
    {
        public static void Fifth()
        {
            Pt.P("Enter some text");
            string Text = Console.ReadLine();
            string NewString = "";
            string[] Tstring = Text.Split();
            for(int i = 0; i < Tstring.Length; i++)
            {
                if (Test(Tstring[i], i) != -1) { NewString += Tstring[i]+ " "; }
                else if (i == Tstring.Length - 1 && NewString == "") { Pt.P("You don't write any words according to condition!"); }
            }
            Pt.P("Words with numbers in the end: "+NewString);
            static int Test(string S,int number)//С помощью массива
            {
                char[] C = S.ToCharArray();                
                    if (char.IsLetter(C[0]))
                    {
                        if (char.IsUpper(C[0]))
                        {
                            if (char.IsNumber(C[C.Length - 1]) && char.IsNumber(C[C.Length - 2]))
                            {
                             return number;
                            }
                        }
                    }                   
                return -1;
            }
            Console.Write("Words with numbers in the end: ");            
            Regex reg = new Regex(@"\b[A-Z](\w*|| )\d[10-99](\s||[, . ; : ! ?])\b");            
            MatchCollection M = reg.Matches(Text);
            if (M.Count > 0)
            {
                foreach (Match word in M) Console.Write(word.Value+" ");               
            }
            else { Pt.P("The entered words don't meet the condition!"); }
            Console.ReadKey();
        }
    }
}
