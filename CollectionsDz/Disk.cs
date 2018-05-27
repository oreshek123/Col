using System;
using System.Collections;

namespace CollectionsDz
{
    public class Disk
    {
        public Hashtable Disks = new Hashtable();
        public Hashtable Songs = new Hashtable();

        public void AddDisk()
        {
            Console.WriteLine("Введите название диска");
            string name = Console.ReadLine();
            Console.WriteLine("Введите исполнителя");
            string singer = Console.ReadLine();
            if (!string.IsNullOrEmpty(name))
                Disks.Add(name, singer);

        }

        public void DeleteDisk()
        {
            Console.WriteLine("Введите название диска");
            string name = Console.ReadLine();
            if (!string.IsNullOrEmpty(name))
                Disks.Remove(name);
        }
        public void AddSongToDisk()
        {
            Console.WriteLine("Введите название диска");
            string d = Console.ReadLine();
            Console.WriteLine("Введите название песни");
            string name = Console.ReadLine();

            if (!string.IsNullOrEmpty(name))
                Songs.Add(name, d);
            else Console.WriteLine("Неправильный ввод");
        }
        public void DeleteSong()
        {
            Console.WriteLine("Введите название песни");
            string name = Console.ReadLine();
            if (!string.IsNullOrEmpty(name))
                Songs.Remove(name);
            else Console.WriteLine("Неправильный ввод");
        }

        public void PrintAllKatalog()
        {
            foreach (DictionaryEntry disk in Disks)
            {
                Console.WriteLine($"Название {disk.Key} Исполнитель {disk.Value}");
                foreach (DictionaryEntry song in Songs)
                {
                    if (song.Value.ToString() == disk.Key.ToString())
                        Console.WriteLine(song.Key);
                }
            }
        }

        public void PrintDisk()
        {
            Console.WriteLine("Введите название диска");
            string name = Console.ReadLine();
            if (!string.IsNullOrEmpty(name))
            {
                foreach (DictionaryEntry disk in Disks)
                {
                    if (disk.Key.ToString() == name)
                        foreach (DictionaryEntry song in Songs)
                        {
                            if (song.Value.ToString() == disk.Key.ToString())
                                Console.WriteLine(song.Key.ToString());
                        }
                    break;
                }
            }
            else Console.WriteLine("Неправильный ввод");
        }

        public void SearchDisksBySinger()
        {
            Console.WriteLine("Введите исполнителя");
            string singer = Console.ReadLine();
            if (!string.IsNullOrEmpty(singer))
            {
                foreach (DictionaryEntry disk in Disks)
                {
                    if (disk.Value.ToString() == singer)
                        Console.WriteLine(disk.Key);
                }
            }
            else Console.WriteLine("Неправильный ввод");
        }
    }
}