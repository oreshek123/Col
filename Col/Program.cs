using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CollectionsDz;

namespace Col
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 clas = new Class1();
            Disk disk = new Disk();
            mainMenu:
            Console.WriteLine("1 - Stack\n2 - Queue\n3 - HashTable");
            int.TryParse(Console.ReadLine(), out int c);
            switch (c)
            {
                case 1:
                    {
                        stack:
                        Console.WriteLine("1 - задание 1 (Stack)\n" +
                                          "4 - задание 4 (Stack)");
                        int.TryParse(Console.ReadLine(), out int b);
                        switch (b)
                        {
                            case 1:
                                {
                                    clas.Task1Stack();
                                    Console.WriteLine("Enter to go back to menu");
                                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                                        goto stack;
                                    break;
                                }
                            case 4:
                                {
                                    clas.Task4Stack();
                                    Console.WriteLine("Enter to go back to menu");
                                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                                        goto stack;
                                    break;
                                }
                        }

                        Console.WriteLine("Enter to go back to main menu");
                        if (Console.ReadKey().Key == ConsoleKey.Enter)
                            goto mainMenu;
                        break;
                    }
                case 2:
                    {
                        queue:
                        Console.WriteLine("4 - задание 1 (Stack)\n" +
                                          "5 - задание 4 (Stack)");
                        int.TryParse(Console.ReadLine(), out int b);
                        switch (b)
                        {
                            case 4:
                                {
                                    clas.Task4Queue();
                                    Console.WriteLine("Enter to go back to menu");
                                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                                        goto queue;
                                    break;
                                }
                            case 5:
                                {
                                    clas.Task5Queue();
                                    Console.WriteLine("Enter to go back to menu");
                                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                                        goto queue;
                                    break;
                                }
                        }

                        Console.WriteLine("Enter to go back to main menu");
                        if (Console.ReadKey().Key == ConsoleKey.Enter)
                            goto mainMenu;
                        break;
                    }
                case 3:
                    {

                        start:
                        Console.WriteLine("1 - добвить диск\n" +
                                          "2 - удалить диск\n" +
                                          "3 - добавить песню\n" +
                                          "4 - удалить песню\n" +
                                          "5 - просмотреть весь каталог\n" +
                                          "6 - просмотреть отдельный диск\n" +
                                          "7 - поиск по заданному исполнителю\n");
                        int.TryParse(Console.ReadLine(), out int choice);
                        switch (choice)
                        {
                            case 1:
                                {
                                    disk.AddDisk();
                                    Console.WriteLine("Для выхода в меню нажмите ENTER");
                                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                                        goto start;
                                    break;
                                }
                            case 2:
                                {
                                    disk.DeleteSong();
                                    Console.WriteLine("Для выхода в меню нажмите ENTER");
                                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                                        goto start;
                                    break;

                                }
                            case 3:
                                {
                                    disk.AddSongToDisk();
                                    Console.WriteLine("Для выхода в меню нажмите ENTER");
                                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                                        goto start;
                                    break;
                                }
                            case 4:
                                {
                                    disk.DeleteSong();
                                    Console.WriteLine("Для выхода в меню нажмите ENTER");
                                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                                        goto start;
                                    break;
                                }
                            case 5:
                                {
                                    disk.PrintAllKatalog();
                                    Console.WriteLine("Для выхода в меню нажмите ENTER");
                                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                                        goto start;
                                    break;
                                }
                            case 6:
                                {
                                    disk.PrintDisk();
                                    Console.WriteLine("Для выхода в меню нажмите ENTER");
                                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                                        goto start;
                                    break;
                                }
                            case 7:
                                {
                                    disk.SearchDisksBySinger();
                                    Console.WriteLine("Для выхода в меню нажмите ENTER");
                                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                                        goto start;
                                    break;
                                }
                        }
                        Console.WriteLine("Enter to go back to main menu");
                        if (Console.ReadKey().Key == ConsoleKey.Enter)
                            goto mainMenu;
                        break;
                    }
            }


            Console.ReadLine();
        }
    }
}
