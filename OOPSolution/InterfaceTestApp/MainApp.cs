using System;

namespace InterfaceTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("콘솔로거 사용합니다.");


            //ConsoleLogger logger = new ConsoleLogger();
            iLogger logger = new ConsoleLogger();
            logger.writeLog("기본 콘솔 로그입니다.");
            logger.writeError("에러메세지!!!!");

            iLogger clmLogger = new FileLogger();//ver 1.0 climateLogger-->1.2 FileLogger 변경
            clmLogger.writeLog("맑음");
            clmLogger.writeError("문제발생!!");

            iLogger logger2 = new ClimateLogger();
            logger2.writeLog("흐림");
            //logger2.writeError("에러메세지!!!!");//실행오류(예외)발생


        }
    }
}
