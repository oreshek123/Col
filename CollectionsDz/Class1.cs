using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDz
{
    public class Class1
    {
        public void Task1Stack()
        {
         FileInfo Task1Stack = new FileInfo("Task1Stack.txt");
         FileInfo Task1Stack2 = new FileInfo("Task1Stack2.txt");
        Stack<char> str = new Stack<char>();

            if (Task1Stack.Exists)
            {
                using (StreamReader sr = new StreamReader(Task1Stack.OpenRead()))
                {
                    //char[] strArray = sr.ReadLine().ToCharArray();

                    foreach (char item in sr.ReadLine().ToCharArray())
                    {
                        str.Push(item);
                    }
                }

                if (!Task1Stack2.Exists)
                {
                    using (StreamWriter sw = new StreamWriter(Task1Stack2.Create()))
                    {
                        string s = "";
                        foreach (char item in str)
                        {
                            s += item;
                        }
                        sw.Write(s);
                    }
                    Console.WriteLine("Посмотрите вашу ф.с");
                }

                
                else
                {
                    using (StreamWriter sw = new StreamWriter(Task1Stack2.OpenWrite()))
                    {
                        string s = "";
                        foreach (char item in str)
                        {
                            s += item;
                        }
                        sw.WriteLine(s);
                    }
                    Console.WriteLine("Посмотрите вашу ф.с");
                }
            }
            else
            {
                Console.WriteLine("Такого файла не существует, создайте новый");

                using (StreamWriter sw = new StreamWriter(Task1Stack.Create()))
                {
                    Console.WriteLine("Введите последовательность чисел");
                    sw.Write(Console.ReadLine());
                }
                Console.WriteLine("Посмотрите вашу ф.с");
            }
        }
        public void Task4Stack()
        {
         FileInfo Task4Stack = new FileInfo("Task4Stack.txt");
         FileInfo Task4Stack2 = new FileInfo("Task4Stack2.txt");

        Stack<char> str = new Stack<char>();
            Stack<char> str2 = new Stack<char>();
            string s1 = "cool";
            string s2 = "popo";


            foreach (char c in s1)
            {
                str.Push(c);
            }

            foreach (char c in s2.Reverse())
            {
                str2.Push(c);
            }

            bool t = str.SequenceEqual(str2);
            Console.WriteLine(t ? "true" : "false");
        }

        public void Task4Queue()
        {
            FileInfo file4 = new FileInfo("Task_4_queue.txt");
            Queue<int> positivequeue = new Queue<int>();
            Queue<int> negativequeue = new Queue<int>();
            if (file4.Exists)
            {
                using (StreamReader sr = file4.OpenText())
                {
                    string[] numbers = sr.ReadToEnd().Split(' ');
                    foreach (string item in numbers)
                    {
                        if (item.StartsWith("-"))
                            negativequeue.Enqueue(int.Parse(item));

                        else if (!item.StartsWith("\n") && item.StartsWith("\r"))
                            positivequeue.Enqueue(int.Parse(item));

                    }
                    positivequeue.ToList().ForEach(f=>{ Console.WriteLine($"Положительные: {f}"); });
                    negativequeue.ToList().ForEach(f => { Console.WriteLine($"Отрицательные: {f}"); });
                }
            }
        }
        public void Task5Queue()
        {
            FileInfo task_5 = new FileInfo("Task_5_queue.txt");
            if (task_5.Exists)
            {

                Queue<string> upperCaseWordsQueue = new Queue<string>();
                Queue<string> lowerCaseWordsQueue = new Queue<string>();
                using (StreamReader sr = task_5.OpenText())
                {


                    string data = sr.ReadToEnd();
                    string[] wordSplit = data.Split(' ');
                    foreach (string s in wordSplit)
                    {

                        if (char.IsUpper(s.ToCharArray()[0]))
                        {
                            upperCaseWordsQueue.Enqueue(s);
                        }
                        else if (s != "\n" || s != "\r")
                        {
                            lowerCaseWordsQueue.Enqueue(s);
                        }
                    }

                    upperCaseWordsQueue.ToList().ForEach(f => { Console.WriteLine($"Слова с прописной буквы : {f}"); });
                    lowerCaseWordsQueue.ToList().ForEach(f => { Console.WriteLine($"Слова с строчной буквы : {f}"); });

                }
            }
        }


    }
}
