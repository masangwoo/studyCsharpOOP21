using System;
using System.Threading;

namespace UsingInterfaceTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //이전생략 3000라인
            var monitor1 = new ExtendedMonitor(new ConsoleLogger(DateTime.Now));
            monitor1.PrintLog("콘솔로그입니다");//=>콘솔에 찍힘

            var monitor = new ExtendedMonitor(new FileLogger("210504.log"));
            monitor.PrintLog("로그내용입니다");//로그파일이 생성됨

            Thread.Sleep(5000);

            //이하생략 1400라인
            monitor.PrintLog("이하 오류가 발생했습니다");
        }
    }
}
