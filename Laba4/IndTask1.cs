using System;
using System.Collections.Generic;
using System.Text;
using LibPrint;

namespace Laba4
{
    public class IndTask1
    {
        public static void Ind1()
        {
            //Шифр Гронсфельда//
            Pt.P("Enter message wich you want to code");
            string G = Console.ReadLine();
            Pt.P("\nAnd now enter sequence of numbers");
            string N = Console.ReadLine() ;
            string Alphabet = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЬЫЪЭЮЯ ,.";
            string NewLine = "", OldLine = "";
            Encode(G, N,ref Alphabet,ref NewLine);
            Pt.P($"\nCoded message is <{NewLine}>");
            Console.ReadKey();
            Decod(ref NewLine, N, ref Alphabet, ref OldLine);
            Pt.P($"\nDecoded message is <{OldLine}>");
            Console.ReadKey();
            Console.Clear();
            static void Encode(string S,string N,ref string  A,ref string New)
            {
                char[] Num = N.ToCharArray();
                char[] C = S.ToUpper().ToCharArray();
                for(int i = 0; i < C.Length; i++)
                {                                                            
                    C[i] = Convert.ToChar(A[IndexEncode(ref A, C[i]) + int.Parse(Num[i].ToString())]);
                    New += C[i].ToString();                   
                }
            }
            static int IndexEncode(ref string A,char C)
            {                  
                    int index = A.IndexOf(C);
                    if (index == A.Length - 1) { return -1; }
                    return index;                    
            }
            static void Decod(ref string New, string N, ref string A, ref string Old)
            {
                char[] C = New.ToCharArray();
                char[] Num = N.ToCharArray();
                for(int i = 0; i < C.Length; i++)
                {
                    C[i] = Convert.ToChar(A[IndexDecode(ref A, C[i]) - int.Parse(Num[i].ToString())]);
                    Old += C[i].ToString();
                }
            }
            static int IndexDecode(ref string A,char C)
            {              
                    int index = A.IndexOf(C);
                    if (index == A.IndexOf(A[0])) { return A.Length; }
                    return index;              
            }
            //Тритемиуса//           
            Pt.P("\nEnter the number of steps");
            int Number = int.Parse(Console.ReadLine());
            string Alphabet1 = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЬЫЪЭЮЯ ,.";
            string NewLine1 = "", OldLine1 = "";
            EncodeT(G, Number, ref Alphabet1, ref NewLine1);
            Pt.P($"\nCoded message is <{NewLine1}>");
            Console.ReadKey();
            DecodT(ref NewLine1, Number, ref Alphabet1, ref OldLine1);
            Pt.P($"\nDecoded message is <{OldLine1}>");
            Console.ReadKey();
            Console.Clear();
            static void EncodeT(string S, int N, ref string A, ref string New)
            {             
                char[] C = S.ToUpper().ToCharArray();
                for (int i = 0; i < C.Length; i++)
                {
                    C[i] = Convert.ToChar(A[IndexEncodeT(ref A, C[i]) + N]);
                    New += C[i].ToString();
                }
            }
            static int IndexEncodeT(ref string A, char C)
            {
                int index = A.IndexOf(C);
                if (index == A.Length - 1) { return -1; }
                return index;
            }
            static void DecodT(ref string New, int N, ref string A, ref string Old)
            {
                char[] C = New.ToCharArray();               
                for (int i = 0; i < C.Length; i++)
                {
                    C[i] = Convert.ToChar(A[IndexDecodeT(ref A, C[i]) - N]);
                    Old += C[i].ToString();
                }
            }
            static int IndexDecodeT(ref string A, char C)
            {
                int index = A.IndexOf(C);
                if (index == A.IndexOf(A[0])) { return A.Length; }
                return index;
            }
            //Книжный шифр//
            Pt.P("Books code\nKey: poem A song about the Prophetic Oleg the first four verses\nPlease, enter message which you want to code");
            string Res = "";
            string[] Song = new string[24];
            Song=new string[]
            {"Как ныне сбирается вещий Олег",
             "Отмстить неразумным хозарам",
             "Их селы и нивы за буйный набег",
             "Обрек он мечам и пожарам",
             "С дружиной своей, в цареградской броне,",
             "Князь по полю едет на верном коне.",
             "Из темного леса навстречу ему",
             "Идет вдохновенный кудесник,",
             "Покорный Перуну старик одному,",
             "Заветов грядущего вестник,",
             "В мольбах и гаданьях проведший весь век.",
             "И к мудрому старцу подъехал Олег.",
             "Скажи мне, кудесник, любимец богов,",
             "Что сбудется в жизни со мною?",
             "И скоро ль, на радость соседей-врагов,",
             "Могильной засыплюсь землею?",
             "Открой мне всю правду, не бойся меня:",
             "В награду любого возьмешь ты коня».",
             "«Волхвы не боятся могучих владык,",
             "А княжеский дар им не нужен;",
             "Правдив и свободен их вещий язык",
             "И с волей небесною дружен.",
             "Грядущие годы таятся во мгле;",
             "Но вижу твой жребий на светлом челе."};

            for (int i = 0; i < Song.Length; i++)
            {               
                if(EncodeBook(Song[i], G) != -1)Res+=$"{i+1}:{EncodeBook(Song[i], G)+1} ";
               
            }
            Pt.P(Res);
            static int EncodeBook(string S,string M)
            {
                M = M.Replace(" ", "").ToUpper();
                char[] Cm = M.ToCharArray();
                S = S.ToUpper();
                char[] C = S.ToCharArray();
                for (int i = 0; i < Cm.Length; i++)
                {
                    for (int j = 0; j < C.Length; j++)
                    {
                        if (Cm[i] == C[j])
                        {
                            return j;
                        }

                    }
                }
                return -1;
            }
            static void Decode(ref string Line,string S,int k)
            {               
                Line = Line.Trim(':');
                char[] LC = Line.ToCharArray();
                char[] C = S.ToCharArray();
                string Old = "";
                Old+= C[LC[k + 1] - 1].ToString();
                Console.Write(Old);
            }
            Console.ReadKey();
        }
    }
}
