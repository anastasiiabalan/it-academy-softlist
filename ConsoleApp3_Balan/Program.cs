using System;

namespace ConsoleApp3_Balan
{
    class Program
    {
        static void Main(/*string[] args*/)
        {
            area_1();
        }

        static void area_1()
        {
            int k_rad = 7;
            int k_stovp = 7;
            int type_value_mas = 0;
            Console.Write("Виберiть область масиву вiд 1 до 14\nВаш вибiр :");
            int k_mas = Convert.ToInt32(Console.ReadLine()); ;

            int[,] mas = new int[k_rad, k_stovp];
            char[,] mas_char = new char[k_rad, k_stovp];

            Console.WriteLine("Чим ви хочете заповнювати масив\n1. Псевдовипадковими числами\n2. Парними числави в дiапазонi вiд N до M\n3. Непарними числами в дiапазонi вiд N до M\n4. Будь-якими символами\n5. Будь-якими буквами англiйського алфавiту ");
            Console.Write("Ваш вибiр :");
            int k_sumbol_mas = Convert.ToInt32(Console.ReadLine());

            if (k_sumbol_mas == 1)
            {
                type_value_mas = 1;
                for (int i = 0; i < k_rad; i++)
                {
                    for (int j = 0; j < k_stovp; j++)
                    {
                        if (k_mas == 1)
                        {
                            if (i >= j)
                            {
                                mas[i, j] = Random();
                                Console.Write(mas[i, j]);
                            }
                            else
                            {
                                mas[i, j] = 0;
                                Console.Write(mas[i, j] + " ");
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 2)
                        {
                            if (j >= i)
                            {
                                mas[i, j] = Random();
                                Console.Write(mas[i, j]);
                            }
                            else
                            {
                                mas[i, j] = 0;
                                Console.Write(mas[i, j] + " ");
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 3)
                        {
                            if (i <= j)
                            {
                                mas[i, j] = Random();
                                Console.Write(mas[i, j]);
                            }
                            else
                            {
                                mas[i, j] = 0;
                                Console.Write(mas[i, j] + " ");
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 5)
                        {
                            if ((i >= j & i >= 6 - j) | (i <= j & j <= 6 - i))
                            {
                                mas[i, j] = Random();
                                Console.Write(mas[i, j]);
                            }
                            else
                            {
                                mas[i, j] = 0;
                                Console.Write(mas[i, j] + " ");
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 6)
                        {
                            if ((i <= j & i >= 6 - j) | (i >= j & i <= 6 - j))
                            {
                                mas[i, j] = Random();
                                Console.Write(mas[i, j]);
                            }
                            else
                            {
                                mas[i, j] = 0;
                                Console.Write(mas[i, j] + " ");
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 7)
                        {
                            if ((i >= j & i <= 6 - j))
                            {
                                mas[i, j] = Random();
                                Console.Write(mas[i, j]);
                            }
                            else
                            {
                                mas[i, j] = 0;
                                Console.Write(mas[i, j] + " ");
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 8)
                        {
                            if ((i <= j & i >= 6 - j))
                            {
                                mas[i, j] = Random();
                                Console.Write(mas[i, j]);
                            }
                            else
                            {
                                mas[i, j] = 0;
                                Console.Write(mas[i, j] + " ");
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 9)
                        {
                            if ((i >= j & i >= 6 - j))
                            {
                                mas[i, j] = Random();
                                Console.Write(mas[i, j]);
                            }
                            else
                            {
                                mas[i, j] = 0;
                                Console.Write(mas[i, j] + " ");
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 10)
                        {
                            if ((i <= j & j <= 6 - i))
                            {
                                mas[i, j] = Random();
                                Console.Write(mas[i, j]);
                            }
                            else
                            {
                                mas[i, j] = 0;
                                Console.Write(mas[i, j] + " ");
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 11)
                        {
                            if ((i <= j & i >= 6 - j))
                            {
                                mas[i, j] = 0;
                                Console.Write(mas[i, j] + " ");
                            }
                            else
                            {
                                mas[i, j] = Random();
                                Console.Write(mas[i, j]);
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 12)
                        {
                            if ((i >= j & i <= 6 - j))
                            {
                                mas[i, j] = 0;
                                Console.Write(mas[i, j] + " ");
                            }
                            else
                            {
                                mas[i, j] = Random();
                                Console.Write(mas[i, j]);
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 13)
                        {
                            if ((i >= j & i >= 6 - j))
                            {
                                mas[i, j] = 0;
                                Console.Write(mas[i, j] + " ");
                            }
                            else
                            {
                                mas[i, j] = Random();
                                Console.Write(mas[i, j]);
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 14)
                        {
                            if ((i <= j & j <= 6 - i))
                            {
                                mas[i, j] = 0;
                                Console.Write(mas[i, j] + " ");
                            }
                            else
                            {
                                mas[i, j] = Random();
                                Console.Write(mas[i, j]);
                            }
                            Console.Write("  ");
                        }
                    }
                    for (int j = k_stovp - 1; j >= 0; j--)
                    {
                        if (k_mas == 4)
                        {
                            if (j <= i)
                            {
                                mas[i, j] = Random();
                                Console.Write(mas[i, j]);
                            }
                            else
                            {
                                mas[i, j] = 0;
                                Console.Write(mas[i, j] + " ");
                            }
                            Console.Write("  ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else if (k_sumbol_mas == 2)
            {
                type_value_mas = 1;
                Console.Write("Введіть дiапазон парного числа вiд n до m\nn = ");
                int from = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("m = ");
                int to = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < k_rad; i++)
                {
                    for (int j = 0; j < k_stovp; j++)
                    {
                        if (k_mas == 1)
                        {
                            if (i >= j)
                            {
                                mas[i, j] = Diapason_parnu(ref from, to);
                                Console.Write(mas[i, j]);
                                from++;
                            }
                            else
                            {
                                mas[i, j] = 0;
                                Console.Write(mas[i, j] + " ");
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 2)
                        {
                            if (j >= i)
                            {
                                mas[i, j] = Diapason_parnu(ref from, to);
                                Console.Write(mas[i, j]);
                                from++;
                            }
                            else
                            {
                                mas[i, j] = 0;
                                Console.Write(mas[i, j] + " ");
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 3)
                        {
                            if (i <= j)
                            {
                                mas[i, j] = Diapason_parnu(ref from, to);
                                Console.Write(mas[i, j]);
                                from++;
                            }
                            else
                            {
                                mas[i, j] = 0;
                                Console.Write(mas[i, j] + " ");
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 5)
                        {
                            if ((i >= j & i >= 6 - j) | (i <= j & j <= 6 - i))
                            {
                                mas[i, j] = Diapason_parnu(ref from, to);
                                Console.Write(mas[i, j]);
                                from++;
                            }
                            else
                            {
                                mas[i, j] = 0;
                                Console.Write(mas[i, j] + " ");
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 6)
                        {
                            if ((i <= j & i >= 6 - j) | (i >= j & i <= 6 - j))
                            {
                                mas[i, j] = Diapason_parnu(ref from, to);
                                Console.Write(mas[i, j]);
                                from++;
                            }
                            else
                            {
                                mas[i, j] = 0;
                                Console.Write(mas[i, j] + " ");
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 7)
                        {
                            if ((i >= j & i <= 6 - j))
                            {
                                mas[i, j] = Diapason_parnu(ref from, to);
                                Console.Write(mas[i, j]);
                                from++;
                            }
                            else
                            {
                                mas[i, j] = 0;
                                Console.Write(mas[i, j] + " ");
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 8)
                        {
                            if ((i <= j & i >= 6 - j))
                            {
                                mas[i, j] = Diapason_parnu(ref from, to);
                                Console.Write(mas[i, j]);
                                from++;
                            }
                            else
                            {
                                mas[i, j] = 0;
                                Console.Write(mas[i, j] + " ");
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 9)
                        {
                            if ((i >= j & i >= 6 - j))
                            {
                                mas[i, j] = Diapason_parnu(ref from, to);
                                Console.Write(mas[i, j]);
                                from++;
                            }
                            else
                            {
                                mas[i, j] = 0;
                                Console.Write(mas[i, j] + " ");
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 10)
                        {
                            if ((i <= j & j <= 6 - i))
                            {
                                mas[i, j] = Diapason_parnu(ref from, to);
                                Console.Write(mas[i, j]);
                                from++;
                            }
                            else
                            {
                                mas[i, j] = 0;
                                Console.Write(mas[i, j] + " ");
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 11)
                        {
                            if ((i <= j & i >= 6 - j))
                            {
                                mas[i, j] = 0;
                                Console.Write(mas[i, j] + " ");
                            }
                            else
                            {
                                mas[i, j] = Diapason_parnu(ref from, to);
                                Console.Write(mas[i, j]);
                                from++;
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 12)
                        {
                            if ((i >= j & i <= 6 - j))
                            {
                                mas[i, j] = 0;
                                Console.Write(mas[i, j] + " ");
                            }
                            else
                            {
                                mas[i, j] = Diapason_parnu(ref from, to);
                                Console.Write(mas[i, j]);
                                from++;
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 13)
                        {
                            if ((i >= j & i >= 6 - j))
                            {
                                mas[i, j] = 0;
                                Console.Write(mas[i, j] + " ");
                            }
                            else
                            {
                                mas[i, j] = Diapason_parnu(ref from, to);
                                Console.Write(mas[i, j]);
                                from++;
                            }
                            Console.Write("   ");
                        }
                        else if (k_mas == 14)
                        {
                            if ((i <= j & j <= 6 - i))
                            {
                                mas[i, j] = 0;
                                Console.Write(mas[i, j] + " ");
                            }
                            else
                            {
                                mas[i, j] = Diapason_parnu(ref from, to);
                                Console.Write(mas[i, j]);
                                from++;
                            }
                            Console.Write("  ");
                        }
                    }
                    for (int j = k_stovp - 1; j >= 0; j--)
                    {
                        if (k_mas == 4)
                        {
                            if (j <= i)
                            {
                                mas[i, j] = Diapason_parnu(ref from, to);
                                Console.Write(mas[i, j]);
                            }
                            else
                            {
                                mas[i, j] = 0;
                                Console.Write(mas[i, j] + " ");
                            }
                            Console.Write("  ");
                        }
                    }
                    Console.WriteLine();
                }


            }
            else if (k_sumbol_mas == 3)
            {
                type_value_mas = 1;
                Console.WriteLine("Введіть діапазон непарного числа від n до m\nn = ");
                int from = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("m = ");
                int to = Convert.ToInt32(Console.ReadLine());
                if (from % 2 == 0)
                {
                    from++;
                }

                for (int i = 0; i < k_rad; i++)
                {
                    for (int j = 0; j < k_stovp; j++)
                    {
                        if (k_mas == 1)
                        {
                            if (i >= j)
                            {
                                mas[i, j] = Diapason_no_parnu(ref from, to);
                                Console.Write(mas[i, j]);
                                from++;
                            }
                            else
                            {
                                mas[i, j] = 0;
                                Console.Write(mas[i, j] + " ");
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 2)
                        {
                            if (j >= i)
                            {
                                mas[i, j] = Diapason_no_parnu(ref from, to);
                                Console.Write(mas[i, j]);
                                from++;
                            }
                            else
                            {
                                mas[i, j] = 0;
                                Console.Write(mas[i, j] + " ");
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 3)
                        {
                            if (i <= j)
                            {
                                mas[i, j] = Diapason_no_parnu(ref from, to);
                                Console.Write(mas[i, j]);
                                from++;
                            }
                            else
                            {
                                mas[i, j] = 0;
                                Console.Write(mas[i, j] + " ");
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 5)
                        {
                            if ((i >= j & i >= 6 - j) | (i <= j & j <= 6 - i))
                            {
                                mas[i, j] = Diapason_no_parnu(ref from, to);
                                Console.Write(mas[i, j]);
                                from++;
                            }
                            else
                            {
                                mas[i, j] = 0;
                                Console.Write(mas[i, j] + " ");
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 6)
                        {
                            if ((i <= j & i >= 6 - j) | (i >= j & i <= 6 - j))
                            {
                                mas[i, j] = Diapason_no_parnu(ref from, to);
                                Console.Write(mas[i, j]);
                                from++;
                            }
                            else
                            {
                                mas[i, j] = 0;
                                Console.Write(mas[i, j] + " ");
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 7)
                        {
                            if ((i >= j & i <= 6 - j))
                            {
                                mas[i, j] = Diapason_no_parnu(ref from, to);
                                Console.Write(mas[i, j]);
                                from++;
                            }
                            else
                            {
                                mas[i, j] = 0;
                                Console.Write(mas[i, j] + " ");
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 8)
                        {
                            if ((i <= j & i >= 6 - j))
                            {
                                mas[i, j] = Diapason_no_parnu(ref from, to);
                                Console.Write(mas[i, j]);
                                from++;
                            }
                            else
                            {
                                mas[i, j] = 0;
                                Console.Write(mas[i, j] + " ");
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 9)
                        {
                            if ((i >= j & i >= 6 - j))
                            {
                                mas[i, j] = Diapason_no_parnu(ref from, to);
                                Console.Write(mas[i, j]);
                                from++;
                            }
                            else
                            {
                                mas[i, j] = 0;
                                Console.Write(mas[i, j] + " ");
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 10)
                        {
                            if ((i <= j & j <= 6 - i))
                            {
                                mas[i, j] = Diapason_no_parnu(ref from, to);
                                Console.Write(mas[i, j]);
                                from++;
                            }
                            else
                            {
                                mas[i, j] = 0;
                                Console.Write(mas[i, j] + " ");
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 11)
                        {
                            if ((i <= j & i >= 6 - j))
                            {
                                mas[i, j] = 0;
                                Console.Write(mas[i, j] + " ");
                            }
                            else
                            {
                                mas[i, j] = Diapason_no_parnu(ref from, to);
                                Console.Write(mas[i, j]);
                                from++;
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 12)
                        {
                            if ((i >= j & i <= 6 - j))
                            {
                                mas[i, j] = 0;
                                Console.Write(mas[i, j] + " ");
                            }
                            else
                            {
                                mas[i, j] = Diapason_no_parnu(ref from, to);
                                Console.Write(mas[i, j]);
                                from++;
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 13)
                        {
                            if ((i >= j & i >= 6 - j))
                            {
                                mas[i, j] = 0;
                                Console.Write(mas[i, j] + " ");

                            }
                            else
                            {
                                mas[i, j] = Diapason_no_parnu(ref from, to);
                                Console.Write(mas[i, j]);
                                from++;
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 14)
                        {
                            if ((i <= j & j <= 6 - i))
                            {
                                mas[i, j] = 0;
                                Console.Write(mas[i, j] + " ");
                            }
                            else
                            {
                                mas[i, j] = Diapason_no_parnu(ref from, to);
                                Console.Write(mas[i, j]);
                                from++;
                            }
                            Console.Write("  ");
                        }
                    }
                    for (int j = k_stovp - 1; j >= 0; j--)
                    {
                        if (k_mas == 4)
                        {
                            if (j <= i)
                            {
                                mas[i, j] = Diapason_no_parnu(ref from, to);
                                Console.Write(mas[i, j]);
                            }
                            else
                            {
                                mas[i, j] = 0;
                                Console.Write(mas[i, j] + " ");
                            }
                            Console.Write("  ");
                        }
                    }
                    Console.WriteLine();
                }

            }
            else if (k_sumbol_mas == 4)
            {
                type_value_mas = 2;

                for (int i = 0; i < k_rad; i++)
                {
                    for (int j = 0; j < k_stovp; j++)
                    {
                        if (k_mas == 1)
                        {
                            if (i >= j)
                            {
                                mas_char[i, j] = Random_sumbol();
                                Console.Write(mas_char[i, j]);
                            }
                            else
                            {
                                mas_char[i, j] = '0';
                                Console.Write(mas_char[i, j]);
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 2)
                        {
                            if (j >= i)
                            {
                                mas_char[i, j] = Random_sumbol();
                                Console.Write(mas_char[i, j]);
                            }
                            else
                            {
                                mas_char[i, j] = '0';
                                Console.Write(mas_char[i, j]);
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 3)
                        {
                            if (i <= j)
                            {
                                mas_char[i, j] = Random_sumbol();
                                Console.Write(mas_char[i, j]);
                            }
                            else
                            {
                                mas_char[i, j] = '0';
                                Console.Write(mas_char[i, j]);
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 5)
                        {
                            if ((i >= j & i >= 6 - j) | (i <= j & j <= 6 - i))
                            {
                                mas_char[i, j] = Random_sumbol();
                                Console.Write(mas_char[i, j]);
                            }
                            else
                            {
                                mas_char[i, j] = '0';
                                Console.Write(mas_char[i, j]);
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 6)
                        {
                            if ((i <= j & i >= 6 - j) | (i >= j & i <= 6 - j))
                            {
                                mas_char[i, j] = Random_sumbol();
                                Console.Write(mas[i, j]);
                            }
                            else
                            {
                                mas_char[i, j] = '0';
                                Console.Write(mas[i, j]);
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 7)
                        {
                            if ((i >= j & i <= 6 - j))
                            {
                                mas_char[i, j] = Random_sumbol();
                                Console.Write(mas_char[i, j]);
                            }
                            else
                            {
                                mas_char[i, j] = '0';
                                Console.Write(mas_char[i, j]);
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 8)
                        {
                            if ((i <= j & i >= 6 - j))
                            {
                                mas_char[i, j] = Random_sumbol();
                                Console.Write(mas_char[i, j]);
                            }
                            else
                            {
                                mas_char[i, j] = '0';
                                Console.Write(mas_char[i, j]);
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 9)
                        {
                            if ((i >= j & i >= 6 - j))
                            {
                                mas_char[i, j] = Random_sumbol();
                                Console.Write(mas_char[i, j]);
                            }
                            else
                            {
                                mas_char[i, j] = '0';
                                Console.Write(mas_char[i, j]);
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 10)
                        {
                            if ((i <= j & j <= 6 - i))
                            {
                                mas_char[i, j] = Random_sumbol();
                                Console.Write(mas_char[i, j]);
                            }
                            else
                            {
                                mas_char[i, j] = '0';
                                Console.Write(mas_char[i, j]);
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 11)
                        {
                            if ((i <= j & i >= 6 - j))
                            {
                                mas_char[i, j] = '0';
                                Console.Write(mas_char[i, j]);
                            }
                            else
                            {
                                mas_char[i, j] = Random_sumbol();
                                Console.Write(mas_char[i, j]);
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 12)
                        {
                            if ((i >= j & i <= 6 - j))
                            {
                                mas_char[i, j] = '0';
                                Console.Write(mas_char[i, j]);
                            }
                            else
                            {
                                mas_char[i, j] = Random_sumbol();
                                Console.Write(mas_char[i, j]);
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 13)
                        {
                            if ((i >= j & i >= 6 - j))
                            {
                                mas_char[i, j] = '0';
                                Console.Write(mas_char[i, j]);
                            }
                            else
                            {
                                mas_char[i, j] = Random_sumbol();
                                Console.Write(mas_char[i, j]);
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 14)
                        {
                            if ((i <= j & j <= 6 - i))
                            {
                                mas_char[i, j] = '0';
                                Console.Write(mas_char[i, j]);
                            }
                            else
                            {
                                mas_char[i, j] = Random_sumbol();
                                Console.Write(mas_char[i, j]);
                            }
                            Console.Write("  ");
                        }
                    }
                    for (int j = k_stovp - 1; j >= 0; j--)
                    {
                        if (k_mas == 4)
                        {
                            if (j <= i)
                            {
                                mas_char[i, j] = Random_sumbol();
                                Console.Write(mas_char[i, j]);
                            }
                            else
                            {
                                mas_char[i, j] = '0';
                                Console.Write(mas_char[i, j]);
                            }
                            Console.Write("  ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else if (k_sumbol_mas == 5)
            {
                type_value_mas = 2;
                for (int i = 0; i < k_rad; i++)
                {
                    for (int j = 0; j < k_stovp; j++)
                    {
                        if (k_mas == 1)
                        {
                            if (i >= j)
                            {
                                mas_char[i, j] = Random_english();
                                Console.Write(mas_char[i, j]);
                            }
                            else
                            {
                                mas_char[i, j] = '0';
                                Console.Write(mas_char[i, j]);
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 2)
                        {
                            if (j >= i)
                            {
                                mas_char[i, j] = Random_english();
                                Console.Write(mas_char[i, j]);
                            }
                            else
                            {
                                mas_char[i, j] = '0';
                                Console.Write(mas_char[i, j]);
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 3)
                        {
                            if (i <= j)
                            {
                                mas_char[i, j] = Random_english();
                                Console.Write(mas_char[i, j]);
                            }
                            else
                            {
                                mas_char[i, j] = '0';
                                Console.Write(mas_char[i, j]);
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 5)
                        {
                            if ((i >= j & i >= 6 - j) | (i <= j & j <= 6 - i))
                            {
                                mas_char[i, j] = Random_english();
                                Console.Write(mas_char[i, j]);
                            }
                            else
                            {
                                mas_char[i, j] = '0';
                                Console.Write(mas_char[i, j]);
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 6)
                        {
                            if ((i <= j & i >= 6 - j) | (i >= j & i <= 6 - j))
                            {
                                mas_char[i, j] = Random_english();
                                Console.Write(mas_char[i, j]);
                            }
                            else
                            {
                                mas_char[i, j] = '0';
                                Console.Write(mas_char[i, j]);
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 7)
                        {
                            if ((i >= j & i <= 6 - j))
                            {
                                mas_char[i, j] = Random_english();
                                Console.Write(mas_char[i, j]);
                            }
                            else
                            {
                                mas_char[i, j] = '0';
                                Console.Write(mas_char[i, j]);
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 8)
                        {
                            if ((i <= j & i >= 6 - j))
                            {
                                mas_char[i, j] = Random_english();
                                Console.Write(mas_char[i, j]);
                            }
                            else
                            {
                                mas_char[i, j] = '0';
                                Console.Write(mas_char[i, j]);
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 9)
                        {
                            if ((i >= j & i >= 6 - j))
                            {
                                mas_char[i, j] = Random_english();
                                Console.Write(mas_char[i, j]);
                            }
                            else
                            {
                                mas_char[i, j] = '0';
                                Console.Write(mas_char[i, j]);
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 10)
                        {
                            if ((i <= j & j <= 6 - i))
                            {
                                mas_char[i, j] = Random_english();
                                Console.Write(mas_char[i, j]);
                            }
                            else
                            {
                                mas_char[i, j] = '0';
                                Console.Write(mas_char[i, j]);
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 11)
                        {
                            if ((i <= j & i >= 6 - j))
                            {
                                mas_char[i, j] = '0';
                                Console.Write(mas_char[i, j]);
                            }
                            else
                            {
                                mas_char[i, j] = Random_english();
                                Console.Write(mas_char[i, j]);
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 12)
                        {
                            if ((i >= j & i <= 6 - j))
                            {
                                mas_char[i, j] = '0';
                                Console.Write(mas_char[i, j]);
                            }
                            else
                            {
                                mas_char[i, j] = Random_english();
                                Console.Write(mas_char[i, j]);
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 13)
                        {
                            if ((i >= j & i >= 6 - j))
                            {
                                mas_char[i, j] = '0';
                                Console.Write(mas_char[i, j]);
                            }
                            else
                            {
                                mas_char[i, j] = Random_english();
                                Console.Write(mas_char[i, j]);
                            }
                            Console.Write("  ");
                        }
                        else if (k_mas == 14)
                        {
                            if ((i <= j & j <= 6 - i))
                            {
                                mas_char[i, j] = '0';
                                Console.Write(mas_char[i, j]);
                            }
                            else
                            {
                                mas_char[i, j] = Random_english();
                                Console.Write(mas_char[i, j]);
                            }
                            Console.Write("  ");
                        }
                    }
                    for (int j = k_stovp - 1; j >= 0; j--)
                    {
                        if (k_mas == 4)
                        {
                            if (j <= i)
                            {
                                mas_char[i, j] = Random_english();
                                Console.Write(mas_char[i, j]);
                            }
                            else
                            {
                                mas_char[i, j] = '0';
                                Console.Write(mas_char[i, j]);
                            }
                            Console.Write("  ");
                        }
                    }
                    Console.WriteLine();
                }

            }

            Console.WriteLine("Чи хочете ви виконувати пошук в областi масиву(yes/no) :");
            string action = Console.ReadLine();
            if (action.Equals("yes") == true)
            {
                Console.WriteLine("Пошук в областi масиву\n1. Max(тiльки для чисел)\n2. Min(тiльки для чисел)\n3. Заданого символу(тiльки для символiв)\n4. Транспонувати масив\n5. Переписати елементи з однiєї областi в iншу");
                Console.Write("Ваш вибiр : ");
                int k_search = Convert.ToInt32(Console.ReadLine());
                if (k_search == 1)
                {
                    Console.WriteLine(Max(mas, k_rad, k_stovp));
                    Main();
                }
                else if (k_search == 2)
                {
                    Console.WriteLine(Min(mas, k_rad, k_stovp));
                    Main();
                }
                else if (k_search == 3)
                {
                    Console.WriteLine("Введiть симовл який хочете знайти : ");
                    char sumbol = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine($"Кiлькiсть символу '{sumbol}' в масивi = {Search_sumbol(mas_char, 7, 7, sumbol)}");
                    Main();
                }
                else if (k_search == 4)
                {
                    for (int i = 0; i < k_rad; i++)
                    {
                        for (int j = 0; j < k_stovp; j++)
                        {
                            if (type_value_mas == 1)
                            {
                                Console.Write(transponian(mas, k_rad, k_stovp, i, j) + "  ");
                            }
                            else if (type_value_mas != 1)
                            {
                                Console.Write(transponian(mas_char, k_rad, k_stovp, i, j) + "  ");
                            }

                        }
                        Console.WriteLine();
                    }
                    Main();

                }
                else if (k_search == 5)
                {
                    Console.WriteLine("Введiть область в яку хочете переписати елементи масиву(кожна область вiдповiдає однiй iншiй областi) = ");
                    int k_area = Convert.ToInt32(Console.ReadLine());
                    int[,] mas2 = new int[k_rad, k_stovp];
                    char[,] mas3 = new char[k_rad, k_stovp];

                    if (type_value_mas == 1)
                     {
                        for (int i = 0; i < k_rad; i++)
                        {
                            for (int j = 0; j < k_stovp; j++)
                            {
                                mas2[i, j] = transponian(mas, k_rad, k_stovp, i, j);
                            }
                        }

                        write_other_area(mas2, k_rad, k_stovp, k_area);
                    }
                    else if (type_value_mas == 2)
                    {
                        for (int i = 0; i < k_rad; i++)
                        {
                            for (int j = 0; j < k_stovp; j++)
                            {
                                mas3[i, j] = transponian(mas_char, k_rad, k_stovp, i, j);
                            }
                        }
                        write_other_area(mas3, k_rad, k_stovp, k_area);
                    }
                    else
                    {
                         Main();
                    }
                      
                    


                }
            }
            else
            {
                Main();
            }
        }


        //функції для заповнення масиву 
        static int Random()
        {
            Random rnd = new Random();
            return rnd.Next(1, 100);
        }
        static char Random_sumbol()
        {
            Random rnd = new Random();
            return (char)rnd.Next('A', 'z');
        }
        static char Random_english()
        {
            char letter = ' ';
            Random rnd = new Random();

            if (rnd.Next(0, 100) % 2 != 0)
            {
                letter = (char)rnd.Next('a', 'z');
            }
            else
            {
                letter = (char)rnd.Next('A', 'Z');
            }


            return letter;
        }
        static int Diapason_parnu(ref int from, int to)
        {
            int ch = 0;
            if (from <= to & from % 2 == 0)
            {
                ch = from;
                from++;
            }
            else
            {
                from++;
            }
            return ch;
        }
        static int Diapason_no_parnu(ref int from2, int to2)
        {
            int ch2 = from2;
            if ((from2 % 2) > 0)
            {
                ch2 = from2;
                from2 = from2 + 1;

            }
            else
            {
                from2 = from2 + 1;
            }
            return ch2;
        }
        //функції для пошуку в масиві
        static int Max(int[,] N, int k_radk, int k_stovp)
        {
            int max = N[0, 0];
            for (int i = 0; i < k_radk; i++)
            {
                for (int j = 0; j < k_stovp; j++)
                {
                    if (N[i, j] > max)
                    {
                        max = N[i, j];
                    }
                }
            }
            return max;
        }
        static int Min(int[,] N, int k_radk, int k_stovp)
        {
            int min = N[0, 0];
            for (int i = 0; i < k_radk; i++)
            {
                for (int j = 0; j < k_stovp; j++)
                {
                    if (N[i, j] != 0 & N[i, j] < min)
                    {
                        min = N[i, j];
                    }
                }
            }
            return min;
        }
        static int Search_sumbol(char[,] N, int k_radk, int k_stovp, char sumbol)
        {
            int k_similar = 0;
            for (int i = 0; i < k_radk; i++)
            {
                for (int j = 0; j < k_stovp; j++)
                {
                    if (N[i, j].Equals(sumbol) == true)
                    {
                        k_similar++;
                    }
                }
            }
            return k_similar;
        }
        static int transponian(int[,] N, int k_radk, int k_stovp, int i2, int j2)
        {
            int[,] mas2 = new int[k_radk, k_stovp];
            int temp=0;
            for (int i = 0; i < k_radk; i++)
            {
                for (int j = 0; j < k_stovp; j++)
                {
                    if (i == j)
                    {
                        mas2[i, j] = N[i, j];
                    }
                    else
                    {
                        temp = N[j, i];
                        mas2[i, j] = N[j, i];
                        //N[j, i] = temp;
                    }
                }
            }
            return mas2[i2, j2];
        }
        static char transponian(char[,] N, int k_radk, int k_stovp, int i2, int j2)
        {
            char[,] mas2 = new char[k_radk, k_stovp];
            char temp = ' ';
            for (int i = 0; i < k_radk; i++)
            {
                for (int j = 0; j < k_stovp; j++)
                {
                    if (i == j)
                    {
                        mas2[i, j] = N[i, j];
                    }
                    else
                    {
                        temp = N[j, i];
                        mas2[i, j] = N[j, i];
                        //N[j, i] = temp;
                    }
                }
            }
            return mas2[i2, j2];
        }
        static void write_other_area(char[,] N, int k_radk, int k_stovp, int k_area)
        {
            char[,] mas4 = new char[k_radk, k_stovp];
            if (k_area == 1)
            {
                for (int i = 0; i < k_radk; i++)
                {
                    for (int j = 0; j < k_stovp; j++)
                    {
                        if (N[i,j].Equals('0')==false & j >= i)
                        {
                            mas4[i, j] = N[i, j];
                        }
                        else
                        {
                            mas4[i, j] = '0';
                        }
                    }
                }
            }
            else if (k_area == 2)
            {
                for (int i = 0; i < k_radk; i++)
                {
                    for (int j = 0; j < k_stovp; j++)
                    {
                        if (N[i, j].Equals('0') == false & j >= i)
                        {
                            mas4[i, j] = N[i, j];
                        }
                        else
                        {
                            mas4[i, j] = '0';
                        }
                    }
                }
            }
            else if (k_area == 3)
            {
                for (int i = 0; i < k_radk; i++)
                {
                    for (int j = 0; j < k_stovp; j++)
                    {
                        if (N[i, j].Equals('0') == false & i <= j)
                        {
                            mas4[i, j] = N[i, j];
                        }
                        else
                        {
                            mas4[i, j] = '0';
                        }
                    }
                }
            }
            else if (k_area == 4)
            {
                for (int i = 0; i < k_radk; i++)
                {
                    for (int j = k_stovp - 1; j >= 0; j--)
                    {
                        if (N[i, j].Equals('0') == false & j <= i)
                        {
                            mas4[i, j] = N[i, j];
                        }
                        else
                        {
                            mas4[i, j] = '0';
                        }
                    }
                }
            }
            else if (k_area == 5)
            {
                for (int i = 0; i < k_radk; i++)
                {
                    for (int j = 0; j < k_stovp; j++)
                    {
                        if ((N[i, j].Equals('0') == false & i >= j & i >= 6 - j) | (N[i, j].Equals('0') == false & i <= j & j <= 6 - i))
                        {
                            mas4[i, j] = N[i, j];
                        }
                        else
                        {
                            mas4[i, j] = '0';
                        }
                    }
                }
            }
            else if (k_area == 6)
            {
                for (int i = 0; i < k_radk; i++)
                {
                    for (int j = 0; j < k_stovp; j++)
                    {
                        if ((N[i, j].Equals('0') == false & i <= j & i >= 6 - j) | (N[i, j].Equals('0') == false & i >= j & i <= 6 - j))
                        {
                            mas4[i, j] = N[i, j];
                        }
                        else
                        {
                            mas4[i, j] = '0';
                        }
                    }
                }
            }
            else if (k_area == 7)
            {
                for (int i = 0; i < k_radk; i++)
                {
                    for (int j = 0; j < k_stovp; j++)
                    {
                        if ((N[i, j].Equals('0') == false & i >= j & i <= 6 - j))
                        {
                            mas4[i, j] = N[i, j];
                        }
                        else
                        {
                            mas4[i, j] = '0';
                        }
                    }
                }
            }
            else if (k_area == 8)
            {
                for (int i = 0; i < k_radk; i++)
                {
                    for (int j = 0; j < k_stovp; j++)
                    {
                        if ((N[i, j].Equals('0') == false & i <= j & i >= 6 - j))
                        {
                            mas4[i, j] = N[i, j];
                        }
                        else
                        {
                            mas4[i, j] = '0';
                        }
                    }
                }
            }
            else if (k_area == 9)
            {
                for (int i = 0; i < k_radk; i++)
                {
                    for (int j = 0; j < k_stovp; j++)
                    {
                        if ((N[i, j].Equals('0') == false & i >= j & i >= 6 - j))
                        {
                            mas4[i, j] = N[i, j];
                        }
                        else
                        {
                            mas4[i, j] = '0';
                        }
                    }
                }
            }
            else if (k_area == 10)
            {
                for (int i = 0; i < k_radk; i++)
                {
                    for (int j = 0; j < k_stovp; j++)
                    {
                        if ((N[i, j].Equals('0') == false & i <= j & j <= 6 - i))
                        {
                            mas4[i, j] = N[i, j];
                        }
                        else
                        {
                            mas4[i, j] = '0';
                        }
                    }
                }
            }
            else if (k_area == 11)
            {
                for (int i = 0; i < k_radk; i++)
                {
                    for (int j = 0; j < k_stovp; j++)
                    {
                        if ((N[i, j].Equals('0') == true & i <= j & i >= 6 - j))
                        {
                            mas4[i, j] = '0';
                        }
                        else
                        {
                            mas4[i, j] = N[i, j];
                        }
                    }
                }
            }
            else if (k_area == 12)
            {
                for (int i = 0; i < k_radk; i++)
                {
                    for (int j = 0; j < k_stovp; j++)
                    {
                        if ((N[i, j].Equals('0') & i >= j & i <= 6 - j))
                        {
                            mas4[i, j] = '0';
                        }
                        else
                        {
                            mas4[i, j] = N[i, j];
                        }
                    }
                }
            }
            else if (k_area == 13)
            {
                for (int i = 0; i < k_radk; i++)
                {
                    for (int j = 0; j < k_stovp; j++)
                    {
                        if ((N[i, j].Equals('0') == true & i >= j & i >= 6 - j))
                        {
                            mas4[i, j] = '0';
                        }
                        else
                        {
                            mas4[i, j] = N[i, j];
                        }
                    }
                }
            }
            else if (k_area == 14)
            {
                for (int i = 0; i < k_radk; i++)
                {
                    for (int j = 0; j < k_stovp; j++)
                    {
                        if ((N[i, j].Equals('0') == true & i <= j & j <= 6 - i))
                        {
                            mas4[i, j] = '0';
                        }
                        else
                        {
                            mas4[i, j] = N[i, j];
                        }
                    }
                }
            }

            for (int i2 = 0; i2 < k_radk; i2++)
            {
                for (int j2 = 0; j2 < k_stovp; j2++)
                {
                    //Console.Write(transponian(mas4, k_radk, k_stovp, i2, j2));
                    Console.Write(mas4[i2, j2] + "   ");
                }
                Console.WriteLine();
            }

        }
        static void write_other_area(int[,] N, int k_radk, int k_stovp, int k_area)
        {
            int[,] mas3 = new int[k_radk, k_stovp];
            
            if (k_area == 1)
            {
                for (int i = 0; i < k_radk; i++)
                {
                    for (int j = 0; j < k_stovp; j++)
                    {
                        if (N[i,j]!=0 & j >= i)
                        {
                            mas3[i, j] = N[i, j];
                        }
                        else
                        {
                            mas3[i, j] = 0;
                        }
                    }
                }
            }
            else if (k_area == 2)
            {
                for (int i = 0; i < k_radk; i++)
                {
                    for (int j = 0; j < k_stovp; j++)
                    {
                        if (N[i, j] != 0 & j >= i)
                        {
                            mas3[i, j] = N[i, j];
                        }
                        else
                        {
                            mas3[i, j] = 0;
                        }
                    }
                }
            }
            else if (k_area == 3)
            {
                for (int i = 0; i < k_radk; i++)
                {
                    for (int j = 0; j < k_stovp; j++)
                    {
                        if (N[i, j] != 0 & i <= j)
                        {
                            mas3[i, j] = N[i, j];
                        }
                        else
                        {
                            mas3[i, j] = 0;
                        }
                    }
                }
            }
            else if (k_area == 4)
            {
                for (int i = 0; i < k_radk; i++)
                {
                    for (int j = k_stovp - 1; j >= 0; j--)
                    {
                        if (N[i, j] != 0 & j <= i)
                        {
                            mas3[i, j] = N[i, j];
                        }
                        else
                        {
                            mas3[i, j] = 0;
                        }
                    }
                }
            }
            else if (k_area == 5)
            {
                for (int i = 0; i < k_radk; i++)
                {
                    for (int j = 0; j < k_stovp; j++)
                    {
                        if ((N[i, j] != 0 & i >= j & i >= 6 - j) | (N[i, j] != 0 & i <= j & j <= 6 - i))
                        {
                            mas3[i, j] = N[i, j];
                        }
                        else
                        {
                            mas3[i, j] = 0;
                        }
                    }
                }
            }
            else if (k_area == 6)
            {
                for (int i = 0; i < k_radk; i++)
                {
                    for (int j = 0; j < k_stovp; j++)
                    {
                        if ((N[i, j] != 0 & i <= j & i >= 6 - j) | (N[i, j] != 0 & i >= j & i <= 6 - j))
                        {
                            mas3[i, j] = N[i, j];
                        }
                        else
                        {
                            mas3[i, j] = 0;
                        }
                    }
                }
            }
            else if (k_area == 7)
            {
                for (int i = 0; i < k_radk; i++)
                {
                    for (int j = 0; j < k_stovp; j++)
                    {
                        if ((N[i, j] != 0 & i >= j & i <= 6 - j))
                        {
                            mas3[i, j] = N[i, j];
                        }
                        else
                        {
                            mas3[i, j] = 0;
                        }
                    }
                }
            }
            else if (k_area == 8)
            {
                for (int i = 0; i < k_radk; i++)
                {
                    for (int j = 0; j < k_stovp; j++)
                    {
                        if ((N[i, j] != 0 & i <= j & i >= 6 - j))
                        {
                            mas3[i, j] = N[i, j];
                        }
                        else
                        {
                            mas3[i, j] = 0;
                        }
                    }
                }
            }
            else if (k_area == 9)
            {
                for (int i = 0; i < k_radk; i++)
                {
                    for (int j = 0; j < k_stovp; j++)
                    {
                        if ((N[i, j] != 0 & i >= j & i >= 6 - j))
                        {
                            mas3[i, j] = N[i, j];
                        }
                        else
                        {
                            mas3[i, j] = 0;
                        }
                    }
                }
            }
            else if (k_area == 10)
            {
                for (int i = 0; i < k_radk; i++)
                {
                    for (int j = 0; j < k_stovp; j++)
                    {
                        if ((N[i, j] == 0 & i <= j & j <= 6 - i))
                        {
                            mas3[i, j] = N[i, j];
                        }
                        else
                        {
                            mas3[i, j] = 0;
                        }
                    }
                }
            }
            else if (k_area == 11)
            {
                for (int i = 0; i < k_radk; i++)
                {
                    for (int j = 0; j < k_stovp; j++)
                    {
                        if ((N[i, j] == 0 & i <= j & i >= 6 - j))
                        {
                            mas3[i, j] = 0;
                        }
                        else
                        {
                            mas3[i, j] = N[i, j];
                        }
                    }
                }
            }
            else if (k_area == 12)
            {
                for (int i = 0; i < k_radk; i++)
                {
                    for (int j = 0; j < k_stovp; j++)
                    {
                        if ((N[i, j] == 0 & i >= j & i <= 6 - j))
                        {
                            mas3[i, j] = 0;

                        }
                        else
                        {
                            mas3[i, j] = N[i, j];
                        }
                    }
                }
            }
            else if (k_area == 13)
            {
                for (int i = 0; i < k_radk; i++)
                {
                    for (int j = 0; j < k_stovp; j++)
                    {
                        if ((N[i, j] == 0 & i >= j & i >= 6 - j))
                        {
                            mas3[i, j] = 0;
                        }
                        else
                        {
                            mas3[i, j] = N[i, j];
                        }
                    }
                }
            }
            else if (k_area == 14)
            {
                for (int i = 0; i < k_radk; i++)
                {
                    for (int j = 0; j < k_stovp; j++)
                    {
                        if ((N[i, j] == 0 & i <= j & j <= 6 - i))
                        {
                            mas3[i, j] = 0;
                        }
                        else
                        {
                            mas3[i, j] = N[i, j];
                        }
                    }
                }
            }

            for (int i2 = 0; i2 < k_radk; i2++)
            {
                for (int j2 = 0; j2 < k_stovp; j2++)
                {
                   //mas3[i2,j2]= transponian(mas3, k_radk, k_stovp,i2,j2);
                   Console.Write(mas3[i2, j2] + "   ");

                }
                Console.WriteLine();
            }
            

        }

    }
}

