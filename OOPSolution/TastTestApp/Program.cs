﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace TastTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var myTask = Task.Factory.StartNew(()=> {
                //Task로 비동기 처리할 내용
                Thread.Sleep(1000);//1초동안 작업이 처리됨(대규모 일) 8500만개,,
                Console.WriteLine("비동기 처리 완료!");
            });

            var sum = 0;
            for (int i = 0; i < 100; i++)
            {
                sum += i;
            }
            Console.WriteLine($"메인스레드 동기처리 : {sum}");
            myTask.Wait();//비동기 호출이 완료될 때 까지 대기
        }
    }
}
