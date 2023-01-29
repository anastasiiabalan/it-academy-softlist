using System;
//for (int i = 0; i < count; i++)
//{
//    mas[i] = N % 10;
//    N = N / 10;
//    Console.WriteLine($"mas[{i}]= {mas[i]}");
//}
namespace Balan_lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, N_zmin;
            Console.Write("Введiть цiле число N=");
            N = Convert.ToInt32(Console.ReadLine());
            int N_stala=N;
            int count = GetNumber(N_stala);

            int[] array = new int[count];
            for (int i = 0; i < count; i++)
            {
                array[i] = GetMas(ref N);
                Console.WriteLine($"getMas[{i}] = {array[i]}");
            }

            //арифмет
            Console.WriteLine($"Середнє арифметичне всiх елементiв масиву = {GetAVGAruf(array, count)}");
            Console.WriteLine($"Середнє геометричне всiх елементiв масиву = {GetAVGGeom(array, count)}");

            int factoral_N = GetFactorial(N_stala);
            if (N_stala>1 & factoral_N == 1)
            {
                Console.WriteLine($"Введене число бiльше за 31, введiть iнше число: ");
                N_zmin= Convert.ToInt32(Console.ReadLine());
                factoral_N = GetFactorial(N_zmin);
                Console.WriteLine($"Факторiал числа {N_zmin} = {factoral_N}");
            }
            else
            {
                Console.WriteLine($"Факторiал числа {N_stala} = {factoral_N}");
            }

            Console.WriteLine($"Сума всiх парних чисел вiд 1 до {N_stala} = {GetNumber2(N_stala)}");
            Console.WriteLine($"Сума всiх непарних чисел вiд 1 до {N_stala} = {GetNumberNo2(N_stala)}");

            Console.WriteLine("Введiть  параметри, якi задають дiапазон в якому треба знаходити суму:");
            Console.Write("вiд: ");
            int from = Convert.ToInt32(Console.ReadLine());
            Console.Write("до: ");
            int to = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Сума всiх парних чисел вiд {from} до {to} = {GetNumber2(from, to)}");
            Console.WriteLine($"Сума всiх непарних чисел вiд {from} до {to} = {GetNumberNo2(from, to)}");
        }
        static int GetNumber(int N)
        {
            int k_number;
            if (N == 0)
            {
                k_number = 0;
            }
            else
            {
                k_number = 1;
            }

            while (N / 10 != 0)
            {
                N = N / 10;
                k_number++;
            }

            return k_number;
        }
        static int GetMas(ref int N)
        {
            int ch = N % 10;
            N=N / 10;
            return ch;
        }

        //Функція для визначення середнього арифметичного
        static double GetAVGAruf(int[] array, int count)
        {
            double sum = 0;
            double avg_aruf;
            for (int i = 0; i < count; i++)
            {
                sum =sum + array[i];
            }
            avg_aruf = (Convert.ToDouble(sum / count));
            return avg_aruf;
        }
        static double GetAVGGeom(int[] array, int count)
        {
            int dob = 1;
            double avg_geom;
            for (int i = 0; i < count; i++)
            {
                dob =dob* array[i];
            }
            avg_geom = Math.Pow((double)dob, (double)1/count);
            return avg_geom;
        }
        static int GetFactorial(int N)
        {
            int factorial = 1;
            if (N < 32)
            {
                for (int i = 1; i <= N; i++)
                {
                    factorial = factorial * (i);
                }
            }
            return factorial;
        }
        static int GetNumber2(int N)
        {
            int sum_parnux = 0;
            for (int i = 1; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    sum_parnux += i;
                } 
            }
            return sum_parnux;
        }
        static int GetNumber2(int from, int to)
        {
            int sum_parnux = 0;
            for (int i = from; i <= to; i++)
            {
                if (i % 2 == 0)
                {
                    sum_parnux += i;
                }
            }
            return sum_parnux;
        }
        static int GetNumberNo2(int N)
        {
            int sum_no_parnux = 0;
            for (int i = 1; i <= N; i++)
            {
                if (i % 2 != 0)
                {
                    sum_no_parnux += i;
                }
            }
            return sum_no_parnux;
        }
        static int GetNumberNo2(int from, int to)
        {
            int sum_no_parnux = 0;
            for (int i = from; i <= to; i++)
            {
                if (i % 2 != 0)
                {
                    sum_no_parnux += i;
                }
            }
            return sum_no_parnux;
        }

    }
}
