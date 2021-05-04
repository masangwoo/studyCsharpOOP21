using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTestApp
{
    class FileLogger : iLogger
    {
        public void writeError(string error)
        {
            Debug.WriteLine($"File error : {error}");
        }

        public void writeLog(string message)
        {
            Console.WriteLine($"파일 txt.log에 저장 : {message}");        
        }
    }
}
