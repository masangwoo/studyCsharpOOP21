using System;
using System.Threading;

namespace BasicThreadTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DoSomething();
            Thread th1 = new Thread(new ThreadStart(DoSomething));
            th1.Start();
            //th1.Join();

            DoOtherthing();
            //th1.Abort();//더이상 사용 안함
            //th1.Interrupt();//스레드를 WaitJoinSleep상태일때 중단메서드. 더 안씀
        }

        private static void DoSomething()
        {
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine($"DoSomething : {i}");
                Thread.Sleep(10);//10ms 대기
            }
        }

        private static void DoOtherthing()
        {
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine($"DoOtherthing : {i}");
                Thread.Sleep(10);//10ms
            }
        }
    }
}
