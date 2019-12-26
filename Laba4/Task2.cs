using System;
using System.Collections.Generic;
using System.Text;
using LibPrint;

namespace Laba4
{
    public class Task2
    {
        public static void Second()
        {
            Console.Clear();
            Pt.P("Enter sentense whith dot in the end");
            string Sent = Console.ReadLine();
            int count = 1;
            char[] P_tion = new char[] { '.', ',', ':', ';'};
            String[] S = Sent.Split();
            for(int i=0;i<S.Length;i++)//Через массив
            {
                if (S[i] != "." && S[i] != "," && S[i] != "!" && S[i] != "?" && S[i] != "-" && S[i] != ":" && S[i]!=" ") 
                { Console.Write($"{S[i]}({count}) ");count++; }
                else { Console.Write($"{S[i]} "); }               
            }
            Console.WriteLine();
            int index = 0;
            count=1;
            for(int i = 0; i < S.Length; i++)//Через методы string
            {

                if (S[i] == "!" || S[i] == "?" || S[i] == "-") { Console.Write(S[i]); }
                else if(IsP(S[i], ref P_tion, ref index) == 0 )
                {                    
                    Console.Write($"{S[i]}({count}) "); 
                    count++;
                }
                else
                {
                    S[i] = S[i].TrimEnd(P_tion[index]);
                    Console.Write($"{S[i]}({count}){P_tion[index]} ");
                    count++;
                }                
            }
            static int IsP(string S,ref char[]P,ref int index)
            {              
                for (int i = 0; i < P.Length; i++)
                {
                   if (S.EndsWith(P[i])) { index = i;return 1; }                 
                }
                return 0;
            }           
            Console.ReadKey();
        }
    }
}
