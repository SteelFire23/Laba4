using System;
using System.Collections.Generic;
using System.Text;
using LibPrint;
using System.Text.RegularExpressions;

namespace Laba4
{
    public class IndTask2
    {
        public static void Ind2()
        {
            Pt.P("Please enter some text");
            string Text = Console.ReadLine();
            string S = "";           
            char[] T = Text.ToCharArray();
            string[] Ts = Text.Split();
            string[] SomeNum = new string[] { "One", "Two", "Three", "Four", "Five" };
            char[] Numbers = new char[] { '1', '2', '3', '4', '5' };
            for (int i = 0; i < T.Length; i++)
            {
                if(Test(T[i],ref Numbers) == -1)
                {
                    S += T[i];
                }
                else { S += SomeNum[Test(T[i], ref Numbers)]; }
            }
            Pt.P(S);
            static int Test(char S,ref char[] N)
            {
                for (int i = 0; i < N.Length; i ++)
                {
                    if (N[i] == S) { return i; }
                }
                return -1;
            }
            //Через методы string//
            for (int i = 0; i < Ts.Length; i++)
            {
                for (int j = 0; j < Numbers.Length; j++)
                {
                    if (Ts[i].Contains(Numbers[j]))
                    {
                        int Index = Ts[i].IndexOf(Numbers[j]);
                        Ts[i]=Ts[i].Remove(Index).Insert(Index, SomeNum[j]);
                        Console.Write(Ts[i] + " ");
                    }
                }
            }                             
            Console.ReadKey();
        }
    }
}
