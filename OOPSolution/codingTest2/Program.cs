using System;
using System.Globalization;

namespace codingTest2
{
    class Program
    {
        static void Main1(string[] args)
        {
            Boiler kitturami = new Boiler ();
            kitturami.printAll();
        }

        static void Main2(string[] args)
        {
            Boiler boiler = new Boiler();
            boiler.Brand = Console.ReadLine();
            boiler.Voltage = byte.Parse(Console.ReadLine());
            boiler.Temperature = int.Parse(Console.ReadLine());

            Console.WriteLine($"{boiler.Brand} {boiler.Voltage} {boiler.Temperature}");

        }

        static void Main3    (string[] args)
        {
            HybridCar ioniq = new HybridCar();
            ioniq.Name = "아이오닉";
            ioniq.Maker = "현대자동차";
            ioniq.Color = "white";
            ioniq.YearModel = 2018;
            ioniq.MaxSpeed = 220;
            ioniq.UniqueNumber = "54라 3346";

            ioniq.Start();
            ioniq.Accelerate();
            ioniq.Recharge();
            ioniq.TurnRight();
            ioniq.Brake();
        }

        static void Main4(string[] args)
        {

        }

        static void Main(string[] args)
        {
            Dog bak = new Dog();
            bak.name = "백구";
            bak.age = 5;

            bak.Name();
            bak.Age();
            bak.Eat();
            bak.Sleep();
            bak.Sound();
        }
    }
}
