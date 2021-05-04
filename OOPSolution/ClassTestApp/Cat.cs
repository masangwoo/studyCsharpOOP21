using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTestApp
{
    class Cat : Animal
    {
       
        public string Color { get; set; }
        public int Age { get; set; }

        public Cat() { }

        public Cat(string name, string color, int age)
        {
            //초기화
            this.Name = name;
            this.Color = color;
            this.Age = age;
            this.UniqueID = UniqueID;

        }

        public Cat( string name, string color)
        {
            //초기화
            this.Name=name;
            this.Color=color;
            
        }

        public Cat(int age, string color)
        {
            //초기화
            this.Color = color;
            this.Age = age;

        }


        //public void Meow() { Console.WriteLine("{0,1}, 야옹!", this.Color, this.Name);
        public void Meow() { Console.WriteLine($"{this.Color} 고양이 {this.Name}, 야옹!"); }

        public override void Sleep()
        {
           // base.Sleep(); 부모의 sleep메소드 실행
           //이후 자식 클래스의 sleep내용 실행
            Console.WriteLine($"{this.Color}고양이 {this.Name}이(가) 잡니다!");
        }
    }
}
