﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10_sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startCycle = 5;
            int endCycle = 96;
            int stepCycle = 7;
            /*
             * Лучшим выбором для вывода последовательности 5 12 19 26 33 40 47 54 61 68 75 82 89 96, является цикл for потому как:
             * 1) Нам четко известен диапазон значений заранее поэтому проверку удобно проводить прям в заголовке\условии цикла
             * 2) Как мы можем заметить каждый шаг кратен 7 и поэтому увеличение шага легко делать опять же в заголовке\условии цикла
             * 3) Нет необходимости создавать переменную с продолжительным сроком жизни, которая будет использованна только внутри цикла
             * 4) И благодаря первым трем пунктам у нас получается написать максимально короткий, лаконичный и как следствие аккуратный и красивый код. 
            */
            for (int i = startCycle; i <= endCycle; i += stepCycle)
                Console.WriteLine(i);
        }
    }
}
