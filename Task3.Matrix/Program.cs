using System;

namespace Task3.Matrix
{
    class Program
    {
        static void DisplayMatrix(int N, int M, int[,] matrix)
        {
            for (var x = 0; x < N; x++)
            {
                for (var y = 0; y < M; y++)
                {
                    Console.Write($"{matrix[x, y],4}");

                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        private static int[,] GenerateMatrix(int N, int M)
        {
            var inMatrix = new int[N, M];
            var randomize = new Random();
            for (var x = 0; x < N; x++)
            {
                for (var y = 0; y < M; y++)
                {
                    inMatrix[x, y] = randomize.Next(0, 10);
                }
            }

            return inMatrix;
        }
        private static int[,] MultiplyK(int N, int M, int[,] inMatrix, int k)
        {
            var outMatrix = new int[N, M];
            for (var x = 0; x < N; x++)
            {
                for (var y = 0; y < M; y++)
                {
                    outMatrix[x, y] = inMatrix[x, y] * k;
                }
            }

            return outMatrix;
        }
        private static int[,] Add(int N, int M, int[,] inMatrix1, int[,] inMatrix2)
        {
            var outMatrix = new int[N, M];
            for (var x = 0; x < N; x++)
            {
                for (var y = 0; y < M; y++)
                {
                    outMatrix[x, y] = inMatrix1[x, y] + inMatrix2[x, y];
                }
            }

            return outMatrix;
        }

        private static int[,] Subtract(int N, int M, int[,] inMatrix1, int[,] inMatrix2)
        {
            var outMatrix = new int[N, M];
            for (var x = 0; x < N; x++)
            {
                for (var y = 0; y < M; y++)
                {
                    outMatrix[x, y] = inMatrix1[x, y] - inMatrix2[x, y];
                }
            }

            return outMatrix;
        }

        static void Main(string[] args)
        {
            var N = 3;
            var M = 4;

            var inMatrix = GenerateMatrix(N, M);
            var outMatrix = MultiplyK(N, M, inMatrix, 5);

            DisplayMatrix(N, M, inMatrix);
            DisplayMatrix(N, M, outMatrix);

            var inMatrix1 = GenerateMatrix(N, M);
            var inMatrix2 = GenerateMatrix(N, M);
            var outMatrix2 = Add(N, M, inMatrix1, inMatrix2);
            var subtractMatrix = Subtract(N, M, inMatrix1, inMatrix2);

            DisplayMatrix(N, M, inMatrix1);
            DisplayMatrix(N, M, inMatrix2);
            DisplayMatrix(N, M, outMatrix2);
            DisplayMatrix(N, M, subtractMatrix);
           


            // * Задание 3.1
            // Заказчику требуется приложение позволяющщее умножать математическую матрицу на число
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Умножение_матрицы_на_число
            // Добавить возможность ввода количество строк и столцов матрицы и число,
            // на которое будет производиться умножение.
            // Матрицы заполняются автоматически. 
            // Если по введённым пользователем данным действие произвести невозможно - сообщить об этом
            //
            // Пример
            //
            //      |  1  3  5  |   |  5  15  25  |
            //  5 х |  4  5  7  | = | 20  25  35  |
            //      |  5  3  1  |   | 25  15   5  |
            //
            //
            // ** Задание 3.2
            // Заказчику требуется приложение позволяющщее складывать и вычитать математические матрицы
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Сложение_матриц
            // Добавить возможность ввода количество строк и столцов матрицы.
            // Матрицы заполняются автоматически
            // Если по введённым пользователем данным действие произвести невозможно - сообщить об этом
            //
            // Пример
            //  |  1  3  5  |   |  1  3  4  |   |  2   6   9  |
            //  |  4  5  7  | + |  2  5  6  | = |  6  10  13  |
            //  |  5  3  1  |   |  3  6  7  |   |  8   9   8  |
            //  
            //  
            //  |  1  3  5  |   |  1  3  4  |   |  0   0   1  |
            //  |  4  5  7  | - |  2  5  6  | = |  2   0   1  |
            //  |  5  3  1  |   |  3  6  7  |   |  2  -3  -6  |
            //
            // *** Задание 3.3
            // Заказчику требуется приложение позволяющщее перемножать математические матрицы
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Умножение_матриц
            // Добавить возможность ввода количество строк и столцов матрицы.
            // Матрицы заполняются автоматически
            // Если по введённым пользователем данным действие произвести нельзя - сообщить об этом
            //  
            //  |  1  3  5  |   |  1  3  4  |   | 22  48  57  |
            //  |  4  5  7  | х |  2  5  6  | = | 35  79  95  |
            //  |  5  3  1  |   |  3  6  7  |   | 14  36  45  |
            //
            //  
            //                  | 4 |   
            //  |  1  2  3  | х | 5 | = | 32 |
            //                  | 6 |  
            //
        }


    }
}
