﻿using System;

namespace ExceptionTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("프로그램 시작");
            int[] array = new int[5];
            /* for (int i = 0; i <=5 ; i++)
             {
                 try
                 {
                     array[i] = (i + 1);//1,2,3,4,5
                 }
                 catch (Exception ex)
                 {
                     Console.WriteLine($"{ex.Message} 관리자에게 문의하세요 : Main(16~)");
                 }
             }*/
            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    array[i] = (i + 1);//1,2,3,4,5
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message} 관리자에게 문의하세요 : Main(16~)");
            }
           

            Console.WriteLine("다른로직 수행");
            //...
            int[] list = { 107, 108, 109 };
            try
            {
                string message = null;
                Console.WriteLine(message.Length);

                var result = list[1] / 0;

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(list[i]);
                }


            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
                //IndexOutOfRange예외시 다른 일 처리
                Console.WriteLine("IndexOutOfRangeException 이후 처리!");
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
                //DivideByZeroException예외시 다른 일 처리
                Console.WriteLine("DivideByZeroException 이후 처리!");
            }

            catch (NullReferenceException ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
                //NullReferenceException예외시 다른 일 처리
                Console.WriteLine("입력좀 제발 제대로좀 ");
            }

            catch (Exception ex)//퉁치기
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
                Console.WriteLine("입력좀 제발 제대로좀 ");
            }

            finally 
            {
                
            }


            Console.WriteLine("프로그램 종료!");//
        }
    }
}
