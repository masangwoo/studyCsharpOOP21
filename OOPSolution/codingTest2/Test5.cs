using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codingTest2
{
    interface IAnimal
    {
        public string name { get; set; }
        public int age { get; set; }
        public virtual void Name() { Console.WriteLine(value: $"강아지의 이름은 {this.name} 입니다."); }

        public virtual void Age() { Console.WriteLine(value: $"강아지는 {this.age}살 입니다."); }
    }

    class Dog : IAnimal
    {
        public string name { get; set; }
        public int age { get; set; }

        public Dog() { }

        public Dog(string name, string color, int age)
        {
            this.name = name;
            this.age = age;
        }
        public virtual void Name() { Console.WriteLine(value: $"강아지의 이름은 {this.name} 입니다."); }

        public virtual void Age() { Console.WriteLine(value: $"강아지는 {this.age}살 입니다."); }


        public void Eat() { Console.WriteLine(value: $"{this.name}가 밥을 먹습니다."); }
        public void Sleep() { Console.WriteLine(value: $"{this.name}가 잠을 잡니다."); }
        public void Sound() { Console.WriteLine(value: $"{this.name}가 소리를 냅니다."); }

    }
    class Cat : IAnimal
    {
        public string name { get; set; }
        public int age { get; set; }

        public Cat() { }

        public Cat(string name, string color, int age)
        {
            this.name = name;
            this.age = age;
        }
        public virtual void Name() { Console.WriteLine(value: $"고양이의 이름은 {this.name} 입니다."); }

        public virtual void Age() { Console.WriteLine(value: $"고양이는 {this.age}살 입니다."); }


        public void Eat() { Console.WriteLine(value: $"{this.name}가 밥을 먹습니다."); }
        public void Sleep() { Console.WriteLine(value: $"{this.name}가 잠을 잡니다."); }
        public void Sound() { Console.WriteLine(value: $"{this.name}가 소리를 냅니다."); }

    }
    class Horse : IAnimal
    {
        public string name { get; set; }
        public int age { get; set; }

        public Horse() { }

        public Horse(string name, string color, int age)
        {
            this.name = name;
            this.age = age;
        }
        public virtual void Name() { Console.WriteLine(value: $"말의 이름은 {this.name} 입니다."); }

        public virtual void Age() { Console.WriteLine(value: $"말은 {this.age}살 입니다."); }


        public void Eat() { Console.WriteLine(value: $"{this.name}가 밥을 먹습니다."); }
        public void Sleep() { Console.WriteLine(value: $"{this.name}가 잠을 잡니다."); }
        public void Sound() { Console.WriteLine(value: $"{this.name}가 소리를 냅니다."); }

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
