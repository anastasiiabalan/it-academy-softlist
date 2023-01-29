using System;

namespace Balan_lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input text 1: ");
            string text1 = Console.ReadLine()+'\n';

            Console.Write("Input text 2: ");
            string text2 = Console.ReadLine()+'\n';

            Console.Write($"text1 = {text1}");
            Console.Write($"text2 = {text2}");
            int lenght1 = text_Lenght(text1);
            int lenght2 = text_Lenght(text2);

            Console.WriteLine($"text1 equals text2 = {K_equals(text1, text2,lenght1,lenght2)}");
            Console.WriteLine($"text1 equals text2 replace '#' = {text_Replace(text1, text2, lenght1, lenght2)}");
            Console.WriteLine($"text1 equals text2 count = {K_similar(text1, text2, lenght1, lenght2)}");
        }
        static int text_Lenght(string text)
        {
            int lenght = 0;
            while (text[lenght] != '\n')
            {
                lenght++;
            }
            return lenght;

        }
        static bool K_equals(string text1, string text2, int lenght1, int lenght2)
        {
            bool result=false;
            int k_false=0;
            int[] mas = new int[lenght1];
            for (int i = 0; i < lenght1; i++)
            {
                for (int j = 0; j < lenght2; j++)
                {
                    if (text1[i]== text2[j])
                    {
                        mas[i] = 1;
                    }  
                }
            }
            for(int i = 0; i < lenght1; i++)
            {
                if (mas[i] == 1)
                {
                    k_false++;
                }
            }
            if (k_false != 0)
            {
                result = false;
            }
            else
            {
                result = true;
            }
            return result;
        }
        static string text_Replace(string text1, string text2, int lenght1, int lenght2)
        {
            string text3="";
            string sumbol = "#";
            int[] mas = new int[lenght1];
            for (int i = 0; i < lenght1; i++)
            {
                for (int j = 0; j < lenght2; j++)
                {
                    if (text1[i] == text2[j])
                    {
                        mas[i] = 1;
                    }
                }
            }
            for (int i = 0; i < lenght1; i++)
            {
                if (mas[i] == 1)
                {
                    text3 = text3 + sumbol;
                }
                else
                {
                    text3 = text3 + text1[i];
                }
            }
            return text3;
        }
        static int K_similar(string text1, string text2, int lenght1, int lenght2)
        {
            int k_similar = 0;
            for (int i = 0; i < lenght1; i++)
            {
                for (int j = 0; j < lenght2; j++)
                {
                    if (text1[i] == text2[j])
                    {
                    k_similar++;
                    }
                }
            }
            return k_similar;
        }
     }
}

