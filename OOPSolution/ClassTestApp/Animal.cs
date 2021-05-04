using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTestApp
{
    class Animal
    {
        protected int UniqueID { get; set; }
        public string Name { get; set; }

        public void Eat(string meal)
        {
            Console.WriteLine($"{this.Name}이 {meal}을 먹습니다.");
        }

        //public void Sleep() { Console.WriteLine($"{this.Name}이 잠을 잡니다."); }
        public virtual void Sleep() { Console.WriteLine($"{this.Name}이(가) 잠을 잡니다."); }
    }
}
