﻿using System;

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
            //outcomes - расходы

            //profit - прибыль

            //положительные месяцы

            Console.WriteLine("Месяц Доход, тыс.руб. Расходы, тыс.руб. Прибыль, тыс.руб.");

            for (var month = 0; month < 12; month++)
            {
                Console.WriteLine($"  {month+1}   {incomes[month]}            {outcomes[month]}            {profits[month]}");

            }
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
