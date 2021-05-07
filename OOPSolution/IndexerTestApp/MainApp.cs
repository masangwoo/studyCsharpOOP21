using System;

namespace IndexerTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MyList 예제");

            MyList list = new MyList();
            for (int i = 0; i < 5; i++)
            {
                list[i] = (i + 1);//1~5 this[index]
            }


            Console.WriteLine("foreach 실행");

            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.WriteLine("foreach 실행");
            foreach (var item in list)
            {
                
            }
        }
    }
}
