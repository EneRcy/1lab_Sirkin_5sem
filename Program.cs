using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите задание: \n1. Посчитать факториал числа n.\n2. Составить процедуру для расчетов функции согласно своему варианту (5), значения задается пользователем. \n3. Составить последовательность чисел Фибоначчи от 0 до n. \n4. Разложить функцию в ряд Тейлора согласно своему вариант. \n5. Выход из программы.");
                int a = Convert.ToInt32(Console.ReadLine());

                switch (a)
                {
                    case 1:
                        Console.WriteLine("Введите n");
                        ulong n = Convert.ToUInt64(Console.ReadLine());
                        Console.WriteLine(Fact(n));
                        break;

                    case 2:
                        Console.WriteLine("Введите x {ОДЗ: (0 ; 4] }");
                        double x = Convert.ToDouble(Console.ReadLine());
                        double A = Math.Sqrt(Math.Log(4 / x)) - (1 / x) - (Math.Exp(Math.Sin(x)));
                        Console.WriteLine(A);
                        Console.WriteLine("\n");

                        break;

                    case 3:
                        Console.WriteLine("Введите n");
                        int N = Convert.ToInt32(Console.ReadLine());
                        int Numb1 = 1;
                        int Numb2 = 0;
                        int SummNumb = 0;
                        while (SummNumb < N)
                        {
                            SummNumb = Numb1 + Numb2;
                            if (SummNumb > N)
                            {
                                break;
                            }
                            Numb1 = Numb2;
                            Numb2 = SummNumb;
                            Console.Write(" " +SummNumb);
                        }
                        Console.WriteLine("\n");
                        break;

                    case 4:
                        Console.WriteLine("Введите число повторений после запятой");
                        int Povt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите x");
                        int X = Convert.ToInt32(Console.ReadLine());

                        double result = 1;
                        ulong k = 0;
                        int Perm = 0;
                        int alterPerm = 0;

                        while (true)
                        {
                            result = Math.Pow(X, k) / Fact(k);
                            Perm = (int)(result * Math.Pow(10, Povt)/1);
                            if (Perm == alterPerm) 
                                break;
                            Console.WriteLine($"{result} || {Perm}");
                            k++;
                        }

                        Console.WriteLine($"- {result} -"); 
                        Console.WriteLine($"Первые {Povt} цифр после запятой начинают повторяться на числе {result}");
                        Console.WriteLine("\n");
                        break;

                    case 5:
                        return;
                        break;

                    default:
                        Console.WriteLine("Введите корректное значение");
                        break;
                }
            }
        }
        static ulong Fact(ulong n)
        {
            ulong fact = 1;
            ulong i = 1;
            for (i = 1; i < n; i++)
            {
                fact = fact * i;
            }
            fact = fact * i;
            Console.WriteLine("\n");
            return fact;
        }
    }
}
