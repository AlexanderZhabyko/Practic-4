using System;
using System.Collections.Generic;
namespace practic_4
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<string> two = new List<string> { "  1. сходить в магазин", "  2. написать другу" };
            
            
            day1();
        }
        static void day1()
        {
            List<string> one = new List<string> { "  1.разбудить брата после нового года", "  2.сходить убраться на улице после праздника" };
            Console.WriteLine("\tЗаметки 01.01.2023");
            Console.WriteLine(one[0]);
            Console.WriteLine(one[1]);
            string F = "Время создания";

            int position = 1;
            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");
            ConsoleKeyInfo clavisha = Console.ReadKey();
            
            while (clavisha.Key != ConsoleKey.Enter)
            {
                if (clavisha.Key == ConsoleKey.UpArrow)
                {
                    position--;
                    Console.Clear();
                    Console.WriteLine("\tЗаметки 01.01.2023");
                    Console.WriteLine(one[0]);
                    Console.WriteLine(one[1]);
                }
                else if (clavisha.Key == ConsoleKey.DownArrow)
                {
                    position++;
                    Console.Clear();
                    Console.WriteLine("\tЗаметки 01.01.2023");
                    Console.WriteLine(one[0]);
                    Console.WriteLine(one[1]);
                }
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                clavisha = Console.ReadKey();

                if (clavisha.Key == ConsoleKey.RightArrow) { Console.Clear(); day2(); }
                else if (clavisha.Key == ConsoleKey.LeftArrow) { Console.Clear(); day3(); }
            }
            if (position == 1)
            {
                Console.Clear();
                Console.WriteLine(one[0] + " ---- подняться в 12 дня на второй этаж и разбудить брата");
                Console.WriteLine();
                Console.WriteLine(F + ": 31.12.2022 - 12:54:99");
            }
            else if (position == 2)
            {
                Console.Clear();
                Console.WriteLine(one[1] + " ---- убрать мангал с улицы, убрать со стола ");
                Console.WriteLine();
                Console.WriteLine(F + ": 31.12.2022 - 18:14:99");
            }
            Console.ReadKey();
            Console.Clear();
            day1();

            static void day2()
            {
                
                List<string> two = new List<string> { "  1. сходить в магазин", "  2. написать другу" };

                Console.WriteLine("\tЗаметки 04.01.2023");
                Console.WriteLine(two[0]);
                Console.WriteLine(two[1]);
                string F = "Время создания";

                int position = 1;
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                ConsoleKeyInfo clavisha = Console.ReadKey();
                
                while (clavisha.Key != ConsoleKey.Enter)
                {
                    if (clavisha.Key == ConsoleKey.UpArrow)
                    {
                        position--;
                        Console.Clear();
                        Console.WriteLine("\tЗаметки 04.01.2023");
                        Console.WriteLine(two[0]);
                        Console.WriteLine(two[1]);
                    }
                    else if (clavisha.Key == ConsoleKey.DownArrow)
                    {
                        position++;
                        Console.Clear();
                        Console.WriteLine("\tЗаметки 04.01.2023");
                        Console.WriteLine(two[0]);
                        Console.WriteLine(two[1]);
                    }
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");
                    clavisha = Console.ReadKey();

                    if (clavisha.Key == ConsoleKey.RightArrow) { Console.Clear(); day3(); }
                    else if (clavisha.Key == ConsoleKey.LeftArrow) { Console.Clear(); day1(); }
                }
                if (position == 1)
                {
                    Console.Clear();
                    Console.WriteLine(two[0] + " ---- купить хлеб, 8 десятков яиц, 4 поросенка,\n  18 рулонов тулаетной бумаги и кетчуп");
                    Console.WriteLine();
                    Console.WriteLine(F + ": 31.12.2022 - 12:54:99");
                }
                else if (position == 2)
                {
                    Console.Clear();
                    Console.WriteLine(two[1] + " ----  напомнить другу о долге");
                    Console.WriteLine();
                    Console.WriteLine(F + ": 31.12.2022 - 18:14:99");
                }
                Console.ReadKey();
                Console.Clear();
                day2();
            }
            static void day3()
            {
                List<string> three = new List<string> { "  1. сходить на концерт май литл пони" };
                Console.WriteLine("\tЗаметки 21.05.2023");
                Console.WriteLine(three[0]);
                string F = "Время создания";

                int position = 1;
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                ConsoleKeyInfo clavisha = Console.ReadKey();

                while (clavisha.Key != ConsoleKey.Enter)
                {
                    if (clavisha.Key == ConsoleKey.UpArrow)
                    {
                        position--;
                        Console.Clear();
                        Console.WriteLine("\tЗаметки 21.05.2023");
                        Console.WriteLine(three[0]);
                       
                    }
                    else if (clavisha.Key == ConsoleKey.DownArrow)
                    {
                        position++;
                        Console.Clear();
                        Console.WriteLine("\tЗаметки 21.05.2023");
                        Console.WriteLine(three[0]);
                        
                    }
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");
                    clavisha = Console.ReadKey();

                    if (clavisha.Key == ConsoleKey.RightArrow) { Console.Clear(); Console.WriteLine("Дни закночились переход к первой записи..."); day1(); }
                    else if (clavisha.Key == ConsoleKey.LeftArrow) { Console.Clear(); day2(); }
                }
                Console.Clear();
                Console.WriteLine(three[0] + "  ---- пойти на концерт май литл пони в дубае,\n   не забыать купить билет. время начала концерта в 24:30");
                Console.WriteLine();
                Console.WriteLine(F + ": 23.11.2022 - 23:54:99");
                
            }
        }

    }
}