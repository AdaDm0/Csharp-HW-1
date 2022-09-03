using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_01._09._22
{
    internal class Program
    {
        enum season { Зима = 1, Весна, Лето, Осень };
        static void Main(string[] args)
        {
            //Домашнее задание реализовано в виде меню. Введите номер задания для выполнения кода.
            int taskNumber;
            char controlSymbol; // управление меню
            do
            {
                Console.WriteLine("Task number - ");
                taskNumber = Convert.ToInt32(Console.ReadLine());
                switch (taskNumber)
                {
                    case 1:
                        Console.WriteLine("Задание 1. \nПользователь вводит с клавиатуры число в диапазоне от 1 до 100. \n " +
                            "Если число кратно 3 (делится на 3 без остатка) нужно вывести слово Fizz. \n" +
                            "Если число кратно 5 нужно вывести слово Buzz. \n" +
                            "Если число кратно 3 и 5 нужно вывести Fizz Buzz. /n" +
                            "Если число не кратно не 3 и 5 нужно вывести само число. \n" +
                            "Если пользователь ввел значение не в диапазоне от 1 до 100 требуется вывести сообщение об ошибке.");
                        do
                        {
                            Console.WriteLine("Enter number 1-100: ");
                            int number = Convert.ToInt32(Console.ReadLine());

                            if (number >= 1 && number <= 100)
                            {
                                if (number % 3 == 0 && number % 5 == 0)
                                {
                                    Console.WriteLine("Fizz Buzz");
                                }
                                else if (number % 3 == 0)
                                {
                                    Console.WriteLine("Fizz");
                                }
                                else if (number % 5 == 0)
                                {
                                    Console.WriteLine("Buzz");
                                }
                                else
                                {
                                    Console.WriteLine(number);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Input error");
                            }
                            Console.WriteLine("Press enter to run the task_1 again or another any key to escape...");
                            controlSymbol = Console.ReadKey().KeyChar;
                        }
                        while (controlSymbol == 13);
                        break;

                    case 2:
                        Console.WriteLine("Задание 2. \nПользователь вводит с клавиатуры два числа. \n" +
                            "Первое число — это значение, второе число процент, который необходимо посчитать.\n" +
                            "Например, мы ввели с клавиатуры 90 и 10.Требуется вывести на экран 10 процентов от 90. Результат: 9.");
                        do
                        {
                            Console.WriteLine("num1 = ");
                            int num1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("num2 = ");
                            int num2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("= " + (num1 * num2 / 100));

                            Console.WriteLine("Press enter to run the task_2 again or another any key to escape...");
                            controlSymbol = Console.ReadKey().KeyChar;
                        }
                        while (controlSymbol == 13);
                        break;

                    case 3:
                        Console.WriteLine("Задание 3. Пользователь вводит с клавиатуры четыре цифры. Необходимо создать число, содержащее эти цифры. \n" +
                            "Например, если с клавиатуры введено 1, 5, 7, 8 тогда нужно сформировать число 1578.");
                        do
                        {
                            int[] arr = new int[4];
                            int res;
                            for (int i = 0; i < 4; i++)
                            {
                                Console.WriteLine("num" + i);
                                arr[i] = Convert.ToInt32(Console.ReadLine());
                            }
                            res = arr[0] * 1000 + arr[1] * 100 + arr[2] * 10 + arr[3];
                            Console.WriteLine("Res = " + res);

                            Console.WriteLine("Press enter to run the task_3 again or another any key to escape...");
                            controlSymbol = Console.ReadKey().KeyChar;
                        }
                        while (controlSymbol == 13);
                        break;

                    case 4:
                        Console.WriteLine("Задание 4. Пользователь вводит шестизначное число. После чего пользователь вводит номера разрядов для обмена цифр. \n" +
                            "Например, если пользователь ввёл один и шесть — это значит, что надо обменять местами первую и шестую цифры. \n" +
                            "Число 723895 должно превратиться в 523897. Если пользователь ввел не шестизначное число требуется вывести сообщение об ошибке.");
                        do
                        {
                            Console.WriteLine("Enter a six-digit number");
                            string arr = Console.ReadLine();
                            // если длина введенных символов = 6 и все символы - цифры
                            if (arr.Length == 6 && arr.All(char.IsNumber))
                            {
                                int num1, num2;
                                char[] res = new char[6];
                                Console.Write("Enter num1 = ");
                                num1 = Convert.ToInt32(Console.ReadLine());
                                num1--;
                                Console.Write("Enter num2 = ");
                                num2 = Convert.ToInt32(Console.ReadLine());
                                num2--;

                                res = arr.ToCharArray();
                                (res[num1], res[num2]) = (res[num2], res[num1]);
                                arr = res.ToString();
                                Console.Write("Res = ");
                                for (int i = 0; i < 6; i++)
                                {
                                    Console.Write(res[i]);
                                }
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine("Entry error");
                            }

                            Console.WriteLine("Press enter to run the task_4 again or another any key to escape...");
                            controlSymbol = Console.ReadKey().KeyChar;
                        }
                        while (controlSymbol == 13);
                        break;

                    case 5:
                        Console.WriteLine("Задание 5. Пользователь вводит с клавиатуры дату. Приложение должно отобразить название сезона и дня недели." +
                            "Например, если введено 22.12.2021, приложение должно отобразить Winter Wednesday.");
                        // enum season { Зима = 1, Весна, Лето, Осень };  -- объявлено до main
                        do
                        {
                            var сulture = new System.Globalization.CultureInfo("ru");
                            Console.WriteLine("Enter the date. Format: " + сulture.DateTimeFormat.ShortDatePattern);
                            string dateString = Console.ReadLine();

                            DateTime userDate;
                            if (DateTime.TryParse(dateString, сulture.DateTimeFormat, System.Globalization.DateTimeStyles.None, out userDate))
                            {
                                Console.Write(userDate.ToLongDateString() + " " + userDate.DayOfWeek + " ");
                                if (userDate.Month >=1 && userDate.Month<=2 | userDate.Month ==12)
                                    Console.WriteLine(season.Зима);
                                else if (userDate.Month >= 3 && userDate.Month<=6)
                                    Console.WriteLine(season.Весна);
                                else if (userDate.Month >= 6 && userDate.Month <= 8)
                                    Console.WriteLine(season.Лето);
                                else if (userDate.Month >= 9 && userDate.Month <= 11)
                                    Console.WriteLine(season.Осень);
                            }
                            else
                                Console.WriteLine("Invalid date!");

                            Console.WriteLine("Press enter to run the task_4 again or another any key to escape to main menu...");
                            controlSymbol = Console.ReadKey().KeyChar;
                        }
                        while (controlSymbol == 13);
                        break;

                    case 6:
                        Console.WriteLine("Задание 6. Пользователь вводит с клавиатуры показания температуры. " +
                            "В зависимости от выбора пользователя программа переводит температуру из Фаренгейта в Цельсий или наоборот");
                        //Цельсий (°C) = K − 273,15 = C = (F − 32) / 1,8.
                        //Фаренгейт (°F) = K · 1,8 − 459,67 = C · 1,8 + 32 = F
                        do
                        {
                            Console.Write("Введите температуру: ");
                            float t = float.Parse(Console.ReadLine());
                            Console.WriteLine("Перевести: \n 1. °C --> °F  \n 2. °F --> °C?");
                            ConsoleKey key = Console.ReadKey().Key;
                            if (key == ConsoleKey.NumPad1 | key == ConsoleKey.D1)
                            {
                                Console.WriteLine("\n" + t + "°C  --> " + (t * 1.8 +32) + "°F");
                            }
                            else if (key == ConsoleKey.NumPad2 | key == ConsoleKey.D2)
                            {
                                Console.WriteLine("\n" + t + "°F  --> " + ((t-32)/1.8 ) + "°F");
                            }
                            else
                            {
                                Console.WriteLine("Ошибка ввода!");
                            }

                            Console.WriteLine("Press enter to run the task_4 again or another any key to escape to main menu...");
                            controlSymbol = Console.ReadKey().KeyChar;
                        }
                        while (controlSymbol == 13);
                        break;

                    case 7:
                        Console.WriteLine("Задание 7. Пользователь вводит с клавиатуры два числа. Нужно показать все четные числа в указанном диапазоне." +
                            "Если границы диапазона указаны неправильно, требуется произвести нормализацию границ." +
                            "Например, пользователь ввел 20 и 11, требуется нормализация, после которой начало диапазона станет равно 11, а конец 20.");
                        do
                        {
                            Console.Write("Enter num 1 = ");
                            int num1 = int.Parse(Console.ReadLine());
                            Console.Write("Enter num 2 =");
                            int num2 = int.Parse(Console.ReadLine());
                            //нормализация границ
                            if (num1>num2)
                            {
                                int temp = num1;
                                num1 = num2;
                                num2 = temp;
                            }
                            //вывод значений
                            for (int i = num1; i<num2; i++)
                            {
                                if (i%2 == 0)
                                {
                                    Console.WriteLine(i);
                                }
                            }

                            Console.WriteLine("Press enter to run the task_4 again or another any key to escape to main menu...");
                            controlSymbol = Console.ReadKey().KeyChar;
                        }
                        while (controlSymbol == 13);
                        break;

                }
                // продолжение/выход
                Console.WriteLine();
                Console.WriteLine("Press enter to select ANOTHER TASK or another any key to escape...");
                controlSymbol = Console.ReadKey().KeyChar;
            }
            while (controlSymbol == 13);
        }
    }
}
