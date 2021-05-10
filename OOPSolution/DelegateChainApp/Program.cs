using System;

namespace DelegateChainApp
{
    delegate int Calculate(int a, int b); //계산 대리자를 선언
    class Program
    {
        static void Main(string[] args)
        {
            #region 소방서
            FireStation station = new FireStation();
            ThereIsAFire fireHouse = new ThereIsAFire(station.Call119);
            fireHouse += new ThereIsAFire(station.ShotOut);
            fireHouse += new ThereIsAFire(station.Escape);

            string l = Console.ReadLine();
            //대리자 실행
            fireHouse(l) ;

            Console.WriteLine();

            ThereIsAFire fireWoorim = new ThereIsAFire(station.Call119);
            fireWoorim += new ThereIsAFire(station.ShotOut);
            fireWoorim += new ThereIsAFire(station.Escape);
            fireWoorim("우림라이온스밸리A");
            #endregion

            Calculate calc;
            //무명함수 표현 1 -> 일반식
            /*calc = delegate (int a, int b)
            {
                return a + b;
            };*/

            calc = (a, b) => a + b;
            //무명함수 표현 2 -> 람다식
            Console.WriteLine($"a + b = {calc(3, 5)}");
        }
    }
}
