using System;
using System.Collections.Generic;
using System.Text;
using LibPrint;

namespace Laba4
{
    public class Task4
    {
        public static void Fourth()
        {
            Pt.P("Enter the seven sentences");
            String[][] Sent = new string[7][];
            for (int i = 0; i < 7; i++)
            {               
               Sent[i] = new string[] { Console.ReadLine() };                
            }
            int count = 0, number = 0, min = 9999, minString = 9999, numberString = 0, countString = 0;
            //Console.Clear();
            Pt.P("Lines with .com in the end");
            for (int i = 0; i < Sent.Length; i++)//С помощью массива
            {
                for (int j = 0; j < Sent[i].Length; j++)
                {
                    if (Test(Sent[i][j]) == 1) 
                    { Pt.P(Sent[i][j]); }
                    if (TestTime(Sent[i][j]) == 1)
                    {
                        count++; if (count < min) { min = count; number = i + 1; count = 0; }
                    }
                    if (Sent[i][j].EndsWith(".com") || Sent[i][j].EndsWith(".com."))
                    { Pt.P(Sent[i][j]); }//метод string
                    int N = Sent[i][j].IndexOf(" ");
                    if (N != 0)
                    {
                       countString++;
                        if (countString < minString) { minString = countString; numberString = i + 1; countString = 0; }
                    }                
                }
            }                              
            if (number == 0) { Pt.P("There is no lines with space"); } 
            else { Pt.P($"\nLowest number of spase in: {number} line"); }
            if (numberString == 0) { Pt.P("There is no lines with space"); }
            else { Pt.P($"\nLowest number of spase in: {numberString} line"); }
            static int Test(string S)
            {
                Char[] C = S.ToCharArray();
                if (C[C.Length - 1] == 'm' && C[C.Length - 2] == 'o' && C[C.Length - 3] == 'c' && C[C.Length - 4] == '.') { return 1; }
                else if (C[C.Length - 1] == '.' && C[C.Length - 2] == 'm' && C[C.Length - 3] == 'o' && C[C.Length - 4] == 'c' && C[C.Length - 5] == '.') { return 1; }
                return 0;
            }
            static int TestTime(string S)
            {
                char[] C = S.ToCharArray();
                for(int i = 0; i < C.Length; i++)
                {
                    if(C[i]==' ')
                    {
                        return 1;
                    }
                }
                return 0;
            }
                Console.ReadKey();          
        }
    }
}
