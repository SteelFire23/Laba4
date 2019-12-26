using System;
using LibPrint;

namespace Laba4
{
    class Program
    {
        static void Main(string[] args)
        {
            A:
            try
            {
                Console.Clear();
                Pt.P("Please enter the number of task which you want to see");
                int number = int.Parse(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        Task1.First(); break;
                    case 2:
                        Task2.Second(); break;
                    case 3:
                        Task3.Third(); break;
                    case 4:
                        Task4.Fourth(); break;
                    case 5:
                        Task5.Fifth();break;
                    case 6:
                        Task6.Sixth();break;
                    case 7:
                        Task7.Seventh();break;
                    case 8:
                        IndTask1.Ind1();break;
                    case 9:
                        IndTask2.Ind2();break;
                    case 10:
                        IndTask3.Ind3();break;
                }
                goto A;
            }
            catch { Pt.P("What are you doing?"); Console.ReadKey(); Console.Clear(); goto A; }
        }
    }
}
