using System;

namespace War
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Platoon platoon1 = new Platoon();
            Platoon platoon2 = new Platoon();
            Random random = new Random();
            string putUser;
            int damage1, damage2, i = 1;
            bool isAlive = true, isAlive1 = true, isAlive2 = true, check = true;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Есть 3 класса:\n1. Стрелки.");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("У них повышенный урон, но меньше броня.");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("2. Конница.");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Повышеная броня, но меньше здоровье (так как их может придавить конь).");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("3. Войско на своих двоих (не могу подобрать для них слова).");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Все значения усреднены.\n\n");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Сформируйте первый взвод.");
            Console.Write("Укажите количество войнов на коне: ");
            while (check)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                putUser = Console.ReadLine().Replace(" ", "");

                if (!String.IsNullOrEmpty(putUser))
                {
                    if (Int32.TryParse(putUser, out int count) && count >=0)
                    {
                        platoon1.AddCavalries(count, random);
                        check = false;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Вы ввели что-то не то.");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы ничего не ввели.");
                    Console.ResetColor();
                }
            }
            check = true;
            Console.Write("Укажите количество стрелков: ");
            while (check)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                putUser = Console.ReadLine().Replace(" ", "");

                if (!String.IsNullOrEmpty(putUser))
                {
                    if (Int32.TryParse(putUser, out int count) && count >= 0)
                    {
                        platoon1.AddArchers(count, random);
                        check = false;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Вы ввели что-то не то.");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы ничего не ввели.");
                    Console.ResetColor();
                }
            }
            check = true;
            Console.Write("Укажите количество последних: ");
            while (check)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                putUser = Console.ReadLine().Replace(" ", "");

                if (!String.IsNullOrEmpty(putUser))
                {
                    if (Int32.TryParse(putUser, out int count) && count >= 0)
                    {
                        platoon1.AddUnknowns(count, random);
                        check = false;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Вы ввели что-то не то.");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы ничего не ввели.");
                    Console.ResetColor();
                }
            }
            check = true;
            Console.ResetColor();

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Сформируйте второй взвод.");
            Console.Write("Укажите количество войнов на коне: ");
            while (check)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                putUser = Console.ReadLine().Replace(" ", "");

                if (!String.IsNullOrEmpty(putUser))
                {
                    if (Int32.TryParse(putUser, out int count) && count >= 0)
                    {
                        platoon2.AddCavalries(count, random);
                        check = false;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Вы ввели что-то не то.");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы ничего не ввели.");
                    Console.ResetColor();
                }
            }
            check = true;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Укажите количество стрелков: ");
            while (check)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                putUser = Console.ReadLine().Replace(" ", "");

                if (!String.IsNullOrEmpty(putUser))
                {
                    if (Int32.TryParse(putUser, out int count) && count >= 0)
                    {
                        platoon2.AddArchers(count, random);
                        check = false;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Вы ввели что-то не то.");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы ничего не ввели.");
                    Console.ResetColor();
                }
            }
            check = true;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Укажите количество последних: ");
            while (check)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                putUser = Console.ReadLine().Replace(" ", "");

                if (!String.IsNullOrEmpty(putUser))
                {
                    if (Int32.TryParse(putUser, out int count) && count >= 0)
                    {
                        platoon2.AddUnknowns(count, random);
                        check = false;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Вы ввели что-то не то.");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы ничего не ввели.");
                    Console.ResetColor();
                }
            }
            check = true;
            Console.ResetColor();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Первый взвод состоит из:");
            platoon1.ShowInfo();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Второй взвод состоит из:");
            platoon2.ShowInfo();

            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Да начнётся бой!");
            Console.WriteLine();

            while (isAlive)
            {
                Console.WriteLine();
                Console.ResetColor();
                Console.WriteLine($"Раунд {i}.");
                Console.WriteLine();
                damage1 = platoon1.BackDamage();
                damage2 = platoon2.BackDamage();
                isAlive1 = platoon1.TakeDamage(damage2);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                platoon1.ShowInfo();
                Console.ResetColor();

                Console.WriteLine();

                isAlive2 = platoon2.TakeDamage(damage1);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                platoon2.ShowInfo();
                Console.ResetColor();

                if (!isAlive1 || !isAlive2)
                {
                    isAlive = false;
                }

                ++i;
            }

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            if (!isAlive1)
            {
                Console.WriteLine("Второй взвод выиграл");
            }

            else if (!isAlive2)
            {
                Console.WriteLine("Первый взвод выиграл");
            }

            Console.ResetColor();
        }

    }
}
