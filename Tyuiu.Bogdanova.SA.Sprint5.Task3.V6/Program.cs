﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.Bogdanova.SA.Sprint5.Task3.V6.Lib;

namespace Tyuiu.Bogdanova.SA.Sprint5.Task3.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            DataService ds = new DataService();
            Console.Title = "Спринт №5 | Выполнила: Богданова С.А. | ИСПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт №5                                                               *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл.                    *");
            Console.WriteLine("* Задание №3                                                              *");
            Console.WriteLine("* Вариант №6                                                              *");
            Console.WriteLine("* Выполнила: Богданова С.А. | ИСПб-23-1                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: Дано выражение вычислить его значение при x = 3, результат     *");
            Console.WriteLine("* сохранить в бинарный файл OutPutFileTask3.bin и вывести на консоль.     *");
            Console.WriteLine("* Округлить до трёх знаков после запятой.                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
        
    

