using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTestApp
{
    class Dog
    {
        private int age;
        private string name;
        public string color { get; set; }
        public int Age 
        {

            get
            { return age; }
            set 
            {
                if (value < 0) { this.age = 1; }
                else if (value > 15) { this.age = 15; }
                else age = value;
            }
        }

        public string Name { get; set; } = "댕댕";
            /*get { return name; }
            set { name = value; }*/

        /*public string GetName() { return this.name; }

        //값을 설정
        public void SetName(string name) { this.name = name; }

        //값을 사용
*//*        public int GetAge() { return this.age; }
*//*        public string GetAge() { return $"{this.age}세"; }


        //값을 설정
        public void SetAge(int age) 
        {
            if (age < 0) { this.age = 1; }
            else if (age > 15) { this.age = 15; }
            else { this.age = age; } 
        }

        //Eat, Sleep, Bark() 생략...*/
    }
}
