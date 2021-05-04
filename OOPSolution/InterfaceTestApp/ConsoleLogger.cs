using System;
using System.Diagnostics;

namespace InterfaceTestApp
{
    class ConsoleLogger : iLogger
    {
        public void writeError(string error)
        {
            Debug.WriteLine($"에러 : {error}");
        }
        
        public void writeLog(string message)
        {
            /*throw new NotImplementedException();*/
            Console.WriteLine($"로그{DateTime.Now} : {message}");
        }
    }
}
