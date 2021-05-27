using System;

namespace Task2.Pascal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк в треугольнике Паскаля: ");
            var N = Convert.ToInt32(Console.ReadLine());
            var pascal = new int[N, N];


            for (var y = 0; y < N; y++)
            {
                pascal[0, y] = 1;
            }

            for (var x = 0; x < N; x++)
            {
                pascal[x, 0] = 1;
            }
            for (var row = 1; row < N; row++)
            {
                for (var column = 1; column < row; column++)
                {
                    var x = row - column;
                    var y = column;
                    pascal[x, y] = pascal[x, y - 1] + pascal[x - 1, y]; 
                }
            }
            for (var row = 0; row < N; row++)
            {
                for (var i = 0; i < (N - row) * 4; i++)
                {
                    Console.Write(" ");
                }
                for (var column = 0; column < row + 1; column++)
                {
                    var x = row - column;
                    var y = column;
                    Console.Write($"{pascal[x, y],8} ");
                }
                Console.WriteLine();
            }












            // * Задание 2
            // Заказчику требуется приложение строящее первых N строк треугольника паскаля. N < 25
            // 
            // При N = 9. Треугольник выглядит следующим образом:
            //                                 1
            //                             1       1
            //                         1       2       1
            //                     1       3       3       1
            //                 1       4       6       4       1
            //             1       5      10      10       5       1
            //         1       6      15      20      15       6       1
            //     1       7      21      35      35       21      7       1
            //                                                              
            //                                                              
            // Простое решение:                                                             
            // 1
            // 1       1
            // 1       2       1
            // 1       3       3       1
            // 1       4       6       4       1
            // 1       5      10      10       5       1
            // 1       6      15      20      15       6       1
            // 1       7      21      35      35       21      7       1
            // 
            // Справка: https://ru.wikipedia.org/wiki/Треугольник_Паскаля

        }
    }
}
