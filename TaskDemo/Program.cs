using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task taskA = new Task(DoUnitOfWorkA);
            //Task taskB = new Task(DoUnitOfWorkB);
            //taskA.Start();
            //taskB.Start();

            //Task taskA = Task.Run(() => DoUnitOfWorkA());

            //Object data = new List<int>() { 1, 3, 7, 9 };
            //Task taskC = new Task(DoUnitOfWorkC, data);
            //taskC.Start();
            

            //taskA.Start();
            
            //taskB.Start();

            //Task taskAd = taskA.ContinueWith(DoUnitOfWorkD);
            //Task taskAd = taskA.ContinueWith(DoUnitOfWorkD, TaskContinuationOptions.OnlyOnRanToCompletion);
            
            //taskA.Wait();
            //taskAd.Start();

            //Task taskCalculate = new Task(Calculate);
            //taskCalculate.Start();
            //taskCalculate.Wait();







            //Task.WaitAll(taskA, taskB, taskC, taskAd);
            Console.WriteLine("Done");

            //Parallel.For(0, 100, Calculate);
            //Console.WriteLine("Done for good");
            Console.ReadLine();
        }

        private static void Calculate(int obj)
        {
            Console.WriteLine($"Calculate {obj}");
        }

        private static void Calculate()
        {
            int milliseconds = 20;
            Thread.Sleep(milliseconds);
            System.Console.WriteLine("Hi I am in Calculate");
        }

        private static void DoUnitOfWorkD(Task obj)
        {
            System.Console.WriteLine("Hi I am in D");
        }

        private static void DoUnitOfWorkC(Object data)
        {
            foreach (int tal in (List<int>)data)
            {
                Thread.Sleep(10);
                Console.WriteLine("Hi I am in C " + tal);
            }
        }

        private static void DoUnitOfWorkB()
        {
            int milliseconds = 10;
            Thread.Sleep(milliseconds);
            System.Console.WriteLine("Hi I am in B");
        }

        private static void DoUnitOfWorkA()
        {
            int milliseconds = 10;
            Thread.Sleep(milliseconds);
            System.Console.WriteLine("Hi I am in A");
        }
    }
}
