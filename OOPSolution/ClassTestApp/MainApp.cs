﻿using System;
using System.Xml;

namespace ClassTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("고양이 객체 생성");
            Cat kitty = new Cat();
            kitty.Name = "키티";
            kitty.Age = 3;
            kitty.Color = "하얀";
            kitty.Meow();*/

            Console.WriteLine("고양이 객체 생성");
            Cat kitty = new Cat();
            kitty.Name = "키티";
            kitty.Age = 3;
            kitty.Color = "하얀";
            kitty.Meow();

            Cat nero = new Cat
            {
                Name = "네로",
                Age = 12,
                Color = "검은"
            };
            nero.Meow(); 
        

            Cat mimi = new Cat("미미", "노랑", 30);
            mimi.Meow();

            Cat coco = new Cat("코코", "얼룩");
            coco.Age = 2;
            coco.Meow();

            Cat noname = new Cat(12, "은색");
            noname.Name = "야옹이";
            noname.Meow();
            noname.Sleep();

        }
    }
}
