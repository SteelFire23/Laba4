using System;
using System.Collections.Generic;
using System.Text;
using LibPrint;
using System.Text.RegularExpressions;

namespace Laba4
{
    public class IndTask3
    {
        public static void Ind3()
        {
            Pt.P("Please, enter some text");
            string Text = Console.ReadLine();
            string[] T = Text.Split();
            Regex reg = new Regex(@"\w*([< > != == >= <=])\w*");
            for(int i = 0; i < T.Length; i++)
            {
                if (reg.IsMatch(T[i]))
                {
                    Console.WriteLine(T[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
