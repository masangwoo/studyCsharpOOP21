using System;

namespace ArrayTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("대성마이맥 수학점수");
            //초기화
            /*            int[] scores = new int[10] { 80, 74, 81, 94, 100, 40, 55, 96, 70, 88};
            */
            // int[] scores = { 80, 74, 81, 94, 100, 40, 55, 96, 70, 88 };//가장짧은 초기화방법

            int[] scores = new int[10];
            /*scores[0] = 80;
            scores[1] = 74;
            scores[2] = 81;
            scores[3] = 94;
            scores[4] = 100; 
            scores[5] = 40;
            scores[6] = 55;
            scores[7] = 96;
            scores[8] = 70;
            scores[9] = 88;*/



            //학생 수학점수 총합
            int sum = 0;

            foreach (var item in scores)
            {
                Console.Write($"{item}\t");
            }

            Console.WriteLine($"");


            for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
            }
            //평균
            float average = (float) sum / scores.Length;

            Console.WriteLine($"수학점수 총합 : {sum}, 평균 : {average}");
        }
    }
}
