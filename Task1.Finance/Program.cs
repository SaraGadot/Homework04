using System;

namespace Task1.Finance
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomize = new Random();

            var incomes = new int[12];
            for (var month = 0; month < 12; month++)
            {
                incomes[month] = randomize.Next(7, 20) * 10_000;

            }

            var outcomes = new int[12];
            for (var month = 0; month < 12; month++)
            {
                outcomes[month] = randomize.Next(7, 20) * 10_000;
            }

            var profits = new int[12];
            for (var month = 0; month < 12; month++)
            {
                profits[month] = incomes[month] - outcomes[month];

            }

            var positiveProfitCount = 0;
            foreach (var profit in profits)
            {
                if (profit > 0)
                {
                    positiveProfitCount = positiveProfitCount + 1;
                }
            }



            var minProfit1 = int.MaxValue;
            foreach (var profit in profits)
            {
                if (profit < minProfit1)
                {
                    minProfit1 = profit;
                }
            }

            var minProfit2 = int.MaxValue;
            foreach (var profit in profits)
            {
                if (minProfit1 < profit && profit < minProfit2)
                {
                    minProfit2 = profit;
                }
            }

            var minProfit3 = int.MaxValue;
            foreach (var profit in profits)
            {
                if (minProfit2 < profit && profit < minProfit3)
                {
                    minProfit3 = profit;
                }
            }

            Console.WriteLine("Месяц Доход, тыс.руб. Расходы, тыс.руб. Прибыль, тыс.руб.");

            for (var month = 0; month < 12; month++)
            {
                Console.WriteLine($"  {month+1}   {incomes[month]}            {outcomes[month]}            {profits[month]}");

            }

            Console.Write("Худшая прибыль в месяцах:");

            var isFirst = true;
            for (var month = 0; month < 12; month++)
            {
                if (minProfit1 == profits[month] || minProfit2 == profits[month] || minProfit3 == profits[month])
                {
                    if (!isFirst)
                        Console.Write(",");
                    Console.Write($" {month + 1}");
                    if (isFirst)
                        isFirst = false;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Месяцев с положительной прибылью: {positiveProfitCount}");
























            // Задание 1.
            // Заказчик просит вас написать приложение по учёту финансов
            // и продемонстрировать его работу.
            // Суть задачи в следующем: 
            // Руководство фирмы по 12 месяцам ведет учет расходов и поступлений средств. 
            // За год получены два массива – расходов и поступлений.
            // Определить прибыли по месяцам
            // Количество месяцев с положительной прибылью.
            // Добавить возможность вывода трех худших показателей по месяцам, с худшей прибылью, 
            // если есть несколько месяцев, в некоторых худшая прибыль совпала - вывести их все.
            // Организовать дружелюбный интерфейс взаимодействия и вывода данных на экран

            // Пример
            //       
            // Месяц      Доход, тыс. руб.  Расход, тыс. руб.     Прибыль, тыс. руб.
            //     1              100 000             80 000                 20 000
            //     2              120 000             90 000                 30 000
            //     3               80 000             70 000                 10 000
            //     4               70 000             70 000                      0
            //     5              100 000             80 000                 20 000
            //     6              200 000            120 000                 80 000
            //     7              130 000            140 000                -10 000
            //     8              150 000             65 000                 85 000
            //     9              190 000             90 000                100 000
            //    10              110 000             70 000                 40 000
            //    11              150 000            120 000                 30 000
            //    12              100 000             80 000                 20 000
            // 
            // Худшая прибыль в месяцах: 7, 4, 1, 5, 12
            // Месяцев с положительной прибылью: 10
        }
    }
}
