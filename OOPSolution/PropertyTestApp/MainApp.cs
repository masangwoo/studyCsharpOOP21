using System;

namespace PropertyTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("강아지객체 생성!");
            Dog baekgoo = new Dog();
            /*baekgoo.SetAge(18);
            baekgoo.SetName("백구");
            Console.WriteLine($"{baekgoo.GetName()}의 나이는 {baekgoo.GetAge()}입니다.");*/

            baekgoo.Age = 25000;
            baekgoo.Name = "백구";
            baekgoo.color = "하양";
            Console.WriteLine($"{baekgoo.Name}의 나이는 {baekgoo.Age}이고, 색은 {baekgoo.color}입니다.");

            Dog streetDog = new Dog();
            Console.WriteLine($"{streetDog.Name}의 나이는 {streetDog.Age}이고, 색은 {streetDog.color}입니다.");

            Dog dog1 = new Dog();
            dog1.Name = "땡구";
            dog1.color = "노랑";
            dog1.Age = 10;

            Dog dog2 = new ()
            {
                Name = "깜댕이",
                Age = 5,
                color = "깜장"
            };

            var myInstance = new { Name = "마상우" , Age=27};
            Console.WriteLine(myInstance.Name);
            Console.WriteLine(myInstance.Age);


        }
    }
}
