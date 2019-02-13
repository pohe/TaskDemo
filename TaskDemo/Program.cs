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
            Task taskA = new Task(DoUnitOfWorkA);
            //Task taskA = Task.Run(() => DoUnitOfWorkA());
            Task taskB = new Task(DoUnitOfWorkB);
            Object data = new List<int>(){1,3,7,9};
            Task taskC = new Task(DoUnitOfWorkC, data);

            Task taskCalculate = new Task(Calculate);
            taskCalculate.Start();
            taskCalculate.Wait();
            taskA.Start();
            taskB.Start();
            taskC.Start();
            Task taskAD = taskA.ContinueWith(DoUnitOfWorkD);
            //taskAD.Start(); 
            Task.WaitAll(taskA, taskB, taskC, taskAD);
            Console.WriteLine("Done");
            Parallel.For(0, 100, Calculate);
            Console.WriteLine("Done for good");
            Console.ReadLine();
        }

        private static void Calculate(int obj)
        {
            Console.WriteLine($"Calculate {obj}");
        }

        private static void Calculate()
        {
            int milliseconds = 2000;
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
                Console.WriteLine(tal);
            }
        }

        private static void DoUnitOfWorkB()
        {
            System.Console.WriteLine("Hi I am in B");
        }

        private static void DoUnitOfWorkA()
        {
            System.Console.WriteLine("Hi I am in A");
        }
    }
}
