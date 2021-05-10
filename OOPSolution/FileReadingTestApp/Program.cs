using System;
using System.IO;

namespace FileReadingTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string fullPath = @"C:\Test1\Help\PFRO.log";
            StreamReader sr = new StreamReader(new FileStream(fullPath, FileMode.Open));

            while (sr.EndOfStream==false)
            {
                Console.WriteLine(sr.ReadLine());
            }

            sr.Close();
            //텍스트파일 읽어오는 부분
*/
            string writePath = @"C:\Test1\Help\SMG.txt";
            StreamWriter sw = new StreamWriter(new FileStream(writePath, FileMode.Create));

            sw.Write("hello, world!");
            sw.Write("안녕하세요");
            sw.Write("3.141592f");
            sw.Close();//필수


            Console.WriteLine("파일 작성을 완료했습니다");
        }
    }
}
