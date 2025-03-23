using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace rock_scissors_paper
{
    class Program
    {
        static void Main(string[] args)
        {
            // Остальное
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WindowHeight = 50;
            Console.WindowWidth = 200;

            // Переменные
            bool isOpenMenu = true;
            string commandMain; // Команда в функции Main

            while(isOpenMenu)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Добро пожаловать в игру: Камень, ножницы и бумага\n");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Доступные команды:");
                Console.Write("╔═════════════════\n" +
                              "╠ Меню - ");
                Console.ResetColor();
                Console.WriteLine("старт/начать игру");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("╠ Информация - ");
                Console.ResetColor();
                Console.WriteLine("информация о игре");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("╠ Выход - ");
                Console.ResetColor();
                Console.WriteLine("выйти из игры");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("╚═════════════════");
                Console.ResetColor();

                Console.Write("Ваша команда: ");
                Console.ForegroundColor = ConsoleColor.Red;
                commandMain = Console.ReadLine().ToLower(); // Комманда
                Console.ResetColor();

                switch (commandMain)
                {
                    case "меню":
                    case "vty.":

                        Menu();

                        break;

                    case "информация":
                    case "byajhvfwbz":

                        Information();


                        break;

                    case "выход":
                    case "ds[jl":

                        Exit();

                        break;

                    default:

                        Error();

                        break;
                }
            }
        }
        static void Menu()
        {
            // Переменные
            string commandMenu; // команды в функции Menu
            bool isOpenMenu = true;
            while (isOpenMenu)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Добро пожаловать в меню!\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Доступные команды:");
                Console.Write("╔═════════════════\n" +
                              "╠ Начать - ");
                Console.ResetColor();
                Console.WriteLine("запустить игру");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("╠ Назад - ");
                Console.ResetColor();
                Console.WriteLine("выйти в главное меню");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("╠ Выход - ");
                Console.ResetColor();
                Console.WriteLine("выйти с игры");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("╚═════════════════");
                Console.ResetColor();

                Console.Write("Ваша команда: ");
                Console.ForegroundColor = ConsoleColor.Red;
                commandMenu = Console.ReadLine().ToLower(); // Комманда
                Console.ResetColor();

                switch (commandMenu)
                {
                    case "начать":
                    case "yfxfnm":

                        Game();
                        isOpenMenu = false;

                        break;

                    case "назад":
                    case "yfpfl":

                        isOpenMenu = false;
                        Console.Clear();

                        break;

                    case "выход":
                    case "ds[jl":

                        Exit();

                        break;

                    default:

                        Error();

                        break;

                }
            }
        }
        static void Game()
        {
            // Переменные
            bool isOpenGame = true;
            int BotRSP; // Bot - rock scissors paper
            string PeopleRPS; // People - rock scissors paper

            string[] definition = {"ножницы", "камень", "бумага"}; // Уже сам, камень, ножницы или бумага


            while (isOpenGame)
            {
                Console.Clear();
                Random rand = new Random();
                BotRSP = rand.Next(0, 3);

                Console.WriteLine(definition[BotRSP]);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Ваш выбор:");
                Console.WriteLine("╔═════════════════\n" +
                                  "╠ Камень");
                Console.WriteLine("╠ Ножницы");
                Console.WriteLine("╠ Бумага");
                Console.WriteLine("╚═════════════════");
                Console.ResetColor();

                Console.Write("Ваш выбор: ");
                Console.ForegroundColor = ConsoleColor.Red;
                PeopleRPS = Console.ReadLine().ToLower(); // Комманда
                Console.ResetColor();

                switch(PeopleRPS)
                {
                    case "камень":

                        Rock(definition[BotRSP], PeopleRPS);

                        break;

                    case "ножницы":

                        Scissors(definition[BotRSP], PeopleRPS);

                        break;

                    case "бумага":

                        Paper(definition[BotRSP], PeopleRPS);

                        break;

                    default:

                        Error();

                        break;
                }
                
            }
        }
        static void Rock(string definition, string PeopleRPS)
        {
            // definition - взято с блока Game
            // PeopleRPS - взято с блока Game | People - rock scissors paper

            if (PeopleRPS == "камень" & definition == "камень") // Камень == камню
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[Упс..] ");
                Console.ResetColor();
                Console.WriteLine("Похоже у вас ничь!");
                Console.Write("У вас: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(PeopleRPS);
                Console.ResetColor();
                Console.Write("У противника: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(definition);

                AddAtt();

            }
            if (PeopleRPS == "камень" & definition == "бумага") // Камень == бумага
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("[Упс..] ");
                Console.ResetColor();
                Console.WriteLine("Похоже вы проиграли!");
                Console.Write("У вас: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(PeopleRPS);
                Console.ResetColor();
                Console.Write("У противника: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(definition);

                AddAtt();

            }
            if (PeopleRPS == "камень" & definition == "ножницы") // Камень == нодницы
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("[УРААА!!] ");
                Console.ResetColor();
                Console.WriteLine("Похоже вы победили, поздравляю!");
                Console.Write("У вас: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(PeopleRPS);
                Console.ResetColor();
                Console.Write("У противника: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(definition);

                AddAtt();
            }
        }
        static void Paper(string definition, string PeopleRPS)
        {
            // definition - взято с блока Game
            // PeopleRPS - взято с блока Game | People - rock scissors paper
            if (PeopleRPS == "бумага" & definition == "бумага") // бумага == бумага
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[Упс..] ");
                Console.ResetColor();
                Console.WriteLine("Похоже у вас ничь!");
                Console.Write("У вас: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(PeopleRPS);
                Console.ResetColor();
                Console.Write("У противника: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(definition);

                AddAtt();

            }
            if (PeopleRPS == "бумага" & definition == "камень") // бумага == камень
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("[УРААА!!] ");
                Console.ResetColor();
                Console.WriteLine("Похоже вы победили, поздравляю!");
                Console.Write("У вас: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(PeopleRPS);
                Console.ResetColor();
                Console.Write("У противника: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(definition);

                AddAtt();

            }
            if (PeopleRPS == "бумага" & definition == "ножницы") // бумага == ножницы
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("[Упс..] ");
                Console.ResetColor();
                Console.WriteLine("Похоже вы проиграли!");
                Console.Write("У вас: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(PeopleRPS);
                Console.ResetColor();
                Console.Write("У противника: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(definition);

                AddAtt();
            }
        }
        static void Scissors(string definition, string PeopleRPS)
        {
            // definition - взято с блока Game
            // PeopleRPS - взято с блока Game | People - rock scissors paper

            if (PeopleRPS == "ножницы" & definition == "бумага") // ножницы == бумага
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("[УРААА!!] ");
                Console.ResetColor();
                Console.WriteLine("Похоже вы победили, поздравляю!");
                Console.Write("У вас: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(PeopleRPS);
                Console.ResetColor();
                Console.Write("У противника: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(definition);

                AddAtt();

            }
            if (PeopleRPS == "ножницы" & definition == "камень") // ножницы == камень
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("[Упс..] ");
                Console.ResetColor();
                Console.WriteLine("Похоже вы проиграли!");
                Console.Write("У вас: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(PeopleRPS);
                Console.ResetColor();
                Console.Write("У противника: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(definition);

                AddAtt();

            }
            if (PeopleRPS == "ножницы" & definition == "ножницы") // ножницы == ножницы
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("[Упс..] ");
                Console.ResetColor();
                Console.WriteLine("Похоже у вас ничь!");
                Console.Write("У вас: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(PeopleRPS);
                Console.ResetColor();
                Console.Write("У противника: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(definition);

                AddAtt();
            }
        }


        static void AddAtt()
        {

            // Переменные
            string cmdAddAtt; // Для ввода команды
            bool AddAttCmd = true; // Для цикла из которого нельзя выйти пока человек не введет то что нужно

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n[Информация] ");
            Console.ResetColor();
            Console.WriteLine("Нажмите любую клавишу, для того что бы продолжить");
            Console.ReadKey();

            while (AddAttCmd)
            {
                Console.Clear();
                Console.WriteLine("Сыграем еще раз?");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Доступные команды:");
                Console.Write("╔═════════════════\n" +
                              "╠ Еще - ");
                Console.ResetColor();
                Console.WriteLine("сыграть еще раз");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("╠ Выход - ");
                Console.ResetColor();
                Console.WriteLine("выйти с игры");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("╚═════════════════");
                Console.ResetColor();

                Console.Write("Ваш выбор: ");
                Console.ForegroundColor = ConsoleColor.Red;
                cmdAddAtt = Console.ReadLine().ToLower(); // Комманда

                switch(cmdAddAtt)
                {
                    case "еще":

                        AddAttCmd = false;
                        Console.Clear();

                        break;

                    case "выход":

                        Exit();

                        break;

                    default:

                        Error();

                        break;
                }
            }

        }
        static void Information()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                              Информация о игре                                   ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nДобро пожаловать в игру 'Камень, ножницы, бумага'!");
            Console.ResetColor();

            Console.WriteLine("\nОписание игры:");
            Console.WriteLine("'Камень, ножницы, бумага' — это классическая игра, в которой два игрока выбирают один из трёх вариантов: камень, ножницы или бумага.");
            Console.WriteLine("Победа определяется по следующим правилам:");
            Console.WriteLine("- Камень побеждает ножницы (камень тупит ножницы).");
            Console.WriteLine("- Ножницы побеждают бумагу (ножницы режут бумагу).");
            Console.WriteLine("- Бумага побеждает камень (бумага накрывает камень).");
            Console.WriteLine("- Если оба игрока выбирают одинаковый вариант, это ничья.");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nКак играть:");
            Console.ResetColor();
            Console.WriteLine("1. В главном меню выберите команду 'Меню', чтобы начать игру.");
            Console.WriteLine("2. В игре вам будет предложено выбрать один из вариантов:");
            Console.WriteLine("   - Камень");
            Console.WriteLine("   - Ножницы");
            Console.WriteLine("   - Бумага");
            Console.WriteLine("3. Компьютер случайным образом выберет свой вариант.");
            Console.WriteLine("4. Результат игры будет показан на экране.");
            Console.WriteLine("5. После завершения раунда вы сможете сыграть ещё раз или выйти из игры.");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nЧто нужно делать в игре:");
            Console.ResetColor();
            Console.WriteLine("- Выберите один из вариантов (камень, ножницы или бумага), чтобы победить компьютер.");
            Console.WriteLine("- Следите за результатами каждого раунда, чтобы понять стратегию компьютера.");
            Console.WriteLine("- Если вы выиграли, попробуйте сыграть ещё раз, чтобы улучшить свои навыки.");
            Console.WriteLine("- Если вы проиграли, не расстраивайтесь! Попробуйте ещё раз, чтобы взять реванш.");
            Console.WriteLine("- В любой момент вы можете выйти из игры, выбрав соответствующую команду.");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nСоветы:");
            Console.ResetColor();
            Console.WriteLine("- Не пытайтесь угадать выбор компьютера — он случайный.");
            Console.WriteLine("- Играйте несколько раундов, чтобы почувствовать стратегию.");
            Console.WriteLine("- Если вы новичок, начните с простых раундов и постепенно улучшайте свои навыки.");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nАвтор игры:");
            Console.ResetColor();
            Console.WriteLine("Разработчик: Stepov");
            Console.WriteLine("Версия: 1.0");
            Console.WriteLine("Дата создания: 24.03.2025");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nСпасибо за игру! Надеюсь, вам понравится!");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nНажмите любую клавишу, чтобы вернуться в главное меню...");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }
        static void Error()
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("[Ошибка] ");
            Console.ResetColor();
            Console.WriteLine("Я вас не понял, проверьте пожалуйста ваш ввод.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("[Ошибка] ");
            Console.ResetColor();
            Console.WriteLine("Нажмите любую клавишу, чтобы вернуться назад.");
            Console.ReadKey();
            Console.Clear();

        }
        static void Exit() // isOpenMainMenu, isOpenMenu
        {
            Console.ResetColor();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Рады были вас видеть у нас в игре!\n" +
                "Надеюсь вы к нам вернетесь!\n" +
                "Я разработчик Stepov, был рад стараться для вас!");
            Console.ResetColor();
            Environment.Exit(0);

        }
    }
}
