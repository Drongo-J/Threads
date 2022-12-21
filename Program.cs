using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ThreadStart ts = new ThreadStart(Something);
            //Thread thread= new Thread(ts);
            //thread.Start();

            //for (int x = 0; x < 10000; x++)
            //{
            //    Console.WriteLine($"\t\t\t Hi from new Thread {x}");
            //    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            //}

            //Thread t = new Thread(() =>
            //{
            //    Something();
            //});
            //t.Start();

            //Thread th = new Thread(Something);
            //th.Start();

            //Thread t1 = new Thread(() => 
            //{
            //    for (int i = 0; i < 1000; i++)
            //    {
            //        Console.WriteLine("111111111");
            //    }
            //});
            //t1.Start();

            //Thread t2 = new Thread(() =>
            //{
            //    for (int i = 0; i < 1000; i++)
            //    {
            //        Console.WriteLine("222222");
            //    }
            //});
            //t2.Start();

            //Thread t1 = new Thread(() =>
            //{
            //    for (int i = 0; i < 100; i++)
            //    {
            //        Console.WriteLine($"A : {i}");
            //    }
            //});
            //t1.Start();
            //t1.IsBackground= true;

            //Thread t2 = new Thread(() =>
            //{
            //    for (int i = 0; i < 50; i++)
            //    {
            //        Console.WriteLine($"B : {i}");
            //    }
            //});
            //t2.Start();


            //Thread t1 = new Thread(() =>
            //{
            //    for (int i = 0; i < 100; i++)
            //    {
            //        Thread.Sleep(1000);
            //        Console.WriteLine($"A : {i}");
            //    }
            //});
            //t1.Start();
            //t1.IsBackground = true;

            //// t1 background thread oldugu ucun main threadi read key ederek 
            //// sonlandirdiqda o da bitir
            //Console.ReadKey(); 

            //Thread t = new Thread(() =>
            //{
            //    Something("Elvin");
            //});
            //t.Start();
            ////Console.ReadKey();
            ////t.Abort();

            //Thread t2 = new Thread(() =>
            //{
            //    while (true)
            //    {
            //        if (Console.ReadKey().Key == ConsoleKey.P)
            //        {
            //            Console.WriteLine("Paused");
            //            t.Suspend(); // will pause
            //        }
            //        if (Console.ReadKey().Key == ConsoleKey.R)
            //        {
            //            t.Resume();
            //        }
            //    }
            //});
            //t2.Start();


            //var t = new Thread(() =>
            //{
            //    for (int i = 0; i < 10000; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //});

            //var t2 = new Thread(() =>
            //{
            //    t.Join();
            //    for (int i = 0; i < 10000; i++)
            //    {
            //        Console.WriteLine("Thread 2");
            //    }
            //});

            //t2.Start();

            //t.Start();

            //t.Join();

            //t2.Join();

            //for (int i = 0; i < 10000; i++)
            //{
            //    Console.WriteLine("Main");
            //}

            int sum = 0;

            var t1 = new Thread(() =>
            {
                for (int i = 0; i < 2500; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\tT1");
                    sum += i;
                }

            });
            t1.Start();
            var t2 = new Thread(() =>
            {
                for (int i = 2500; i < 5000; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\tT2");
                    sum += i;
                }

            });
            t2.Start();
            var t3 = new Thread(() =>
            {
                for (int i = 5000; i < 7500; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\t\t\tT3");
                    sum += i;
                }

            });
            t3.Start();
            var t4 = new Thread(() =>
            {
                for (int i = 7500; i < 10000; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\t\t\t\tT4");
                    sum += i;
                }

            });
            t4.Start();

            var t5 = new Thread(() =>
            {
                t1.Join();
                t2.Join();
                t3.Join();
                t4.Join();
                Console.WriteLine(sum);
            });
            t5.Start();

        }

        private static void Something()
        {
            for (int x = 0; x < 10000; x++)
            {
                Console.WriteLine($"\t\t\t Hi from new Thread {x}");
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            }
        }

        private static void Something(string sender)
        {
            for (int x = 0; x < 10000; x++)
            {
                Console.WriteLine($"\t\t\t Hi from new {sender} Thread {x}");
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            }
        }
    }
}
