// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// int Numbers(int num1)
// {
//     PrintNaturalNumbers(num1);
//     return num1;
// }

// void PrintNaturalNumbers(int n)
// {
//     if (n <= 0)
//         return;

//     Console.WriteLine(n);
//     PrintNaturalNumbers(n - 1);
// }

// Console.Write("Введите значение N: ");
// int res = Convert.ToInt32(Console.ReadLine());
// Numbers(res);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
// Console.Write("Введите M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите N: ");
// int N = Convert.ToInt32(Console.ReadLine());
//     int Summ1()
//     {
//            int sum = 0;
//             for (int i = M; i <= N; i++)
//             {
//                 sum += i;
//             }
//              Console.WriteLine("Сумма натуральных чисел от {0} до {1} равна {2}", M, N,sum);
//             return sum; 
//     }
//     int Summ2()
//     {
//          int sum = 0;
//             for (int i = N; i <= M; i++)
//             {
//                 sum += i;
//             }
//          Console.WriteLine("Сумма натуральных чисел от {0} до {1} равна {2}", M, N,sum);
//         return sum; 
//     }
//     void General(int M, int N)
//     {
//         if (M < N)
//         {
//             Summ1();
      
//         } else if (M > N)
//         {
//            Summ2();
//         }
//     }
// General(M, N);
