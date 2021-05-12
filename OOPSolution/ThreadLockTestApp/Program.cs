using System;
using System.Threading;

namespace ThreadLockTestApp
{

    class Counter
    {
        /* private int count = 0;
         public int Count { get => count; }
         public void Increment()
         {
             count++;
             Thread.Sleep(1);//1ms대기
         }

         public void Decrement()
         {
             count--;
             Thread.Sleep(1);//1ms대기

         }*/

        private int counter = 1000;

        private object thislock = new object();

        public void Run()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread th = new Thread(UnsafeCalc);
                th.Start();
            }
        }

        public void UnsafeCalc()
        {
            lock (thislock)//lock을 통해서 동기화(다른 스레드가 접근 못하도록 막는다)
            {
                counter++;

                Thread.Sleep(5);

                Console.WriteLine(counter);
            }
           
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();
            counter.Run();

        }
    }
}
