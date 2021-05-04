namespace InterfaceTestApp
{
    interface iLogger//약속이다. 이 iLogger를 구현(상속)하게 되면 아래의 액션을 무조건(1) 구현해야 한다.
    {
        void writeLog(string message);//하나의 메세지를 받아서 처리할 것

        void writeError(string error);
    }
}
