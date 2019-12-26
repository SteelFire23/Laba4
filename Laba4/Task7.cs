using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using LibPrint;

namespace Laba4
{
    public class Task7
    {
        public static void Seventh()
        {
            int Sum = 0, Min, Max;            
            String[] Text = new string[10];
            Text = new string[]
            { ( "Gentle Giant – Free Hand [6:15]" ),
              ( "Supertramp – Child Of Vision [07:27]" ),
              ( "Camel – Lawrence [10:46]" ),
              ( "Yes – Don’t Kill The Whale [3:55]" ),
              ( "10CC – Notell Hotel [04:58]" ),
              ( "Nektar – King Of Twilight [4:16]" ),
              ( "The Flower Kings – Monsters & Men [21:19]" ),
              ( "Focus – Le Clochard [1:59]" ),
              ( "Pendragon – Fallen Dream And Angel [5:23]" ),
              ( "Kaipa – Remains Of The Day [08:02]" ) };
            int[] Time = new int[Text.Length];
            for (int i = 0; i < Text.Length; i++)
            {
                Sum += SplitLine(Text[i]);
                Time[i] = SplitLine(Text[i]);             
            }
            Min = minIterative(Time);
            Max = maxIterative(Time);
            for (int i = 0; i < Time.Length; i++)
            {
                if (Time[i] == Min) { Pt.P($"Song with minimal playing time: {Text[i]}"); }
                else if (Time[i] == Max) { Pt.P($"Song with maximal playing time: {Text[i]}"); }
            }
            Pt.P($"\nPlaying time of all songs: {Sum} sec\n");
            for (int i = 0; i < Time.Length; i++)
            {
                for (int j = 0; j < Time.Length; j++)
                {                    
                    if (Math.Abs(Time[i] - Time[j]) == Dif(Time) && Time[i] != Time[j]) 
                    { Pt.P($"Songs with minimal different in playing time: {Text[i]} and {Text[j]}");break; }
                }
            }
            static int Dif(int[]Time)
            {
                int minD = Math.Abs(Time[0] - Time[1]);
                for (int i = 0; i < Time.Length; i++)
                {
                    for (int j = 0; j < Time.Length; j++)
                    {
                        if (Time[i] != Time[j])
                        {
                            if (Math.Abs(Time[i] - Time[j]) < minD)
                            { minD = Math.Abs(Time[i] - Time[j]); }
                        }
                    }
                }
                return minD;
            }
            static int maxIterative(int[] mI)
            {
                int max = mI[0];
                for(int i = 0; i < mI.Length; i++)
                {
                    if (mI[i] > max) { max = mI[i]; }
                }
                return max;
            }
            static int minIterative(int[] mI)
            {
                int min = mI[0];
                for (int i = 0; i < mI.Length; i++)
                {
                    if (mI[i] < min) { min = mI[i]; }
                }
                return min;
            }
            Console.ReadKey();
        }
            static int SplitLine(string S)
            {
                int k = 0, temp;
                int[] Temp = new int[10];
                Regex reg = new Regex(@"\b\d+(:)\d+\b");               
                String[] Str = S.Split();
                for (int i = 0; i < Str.Length; i++)
                {                   
                    if (reg.IsMatch(Str[i])) 
                    {
                        temp=Seconds(Str[i]);
                        Temp[k] = temp;
                        ++k;
                        return temp;                                                
                    }
                }
                return 0;
            }  
            static int Seconds(string S)
            {             
                S = S.Trim('[', ']');
                string[] Temp = S.Split(':');
                int[] Num = new int[2];               
                for (int i = 0; i < Temp.Length; i++)
                {
                    Num[i] = int.Parse(Temp[i]);                                     
                }
                int Number = (Num[0]*60) + Num[1];
                return Number;                               
            }                    
        }
    }


