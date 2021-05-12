using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codingTest2
{
    class Boiler
    {
        public string Brand { get; set; }
        public byte voltage;
        public int temperature;
        public void printAll()
        {
            Console.WriteLine($"{this.Brand}  {Voltage}  {Temperature}");
        }

        public byte Voltage
        {
            get { return this.voltage; }
            set 
            {
                if (value == 110) { this.voltage = value; }
                else if (value == 220) { this.voltage = value; }
                else Console.WriteLine("다시 입력해주세요");
            }
        }
        public int Temperature
        {
            get { return this.temperature; }
            set 
            {
                if (value < 5) { this.temperature = 5; }
                else if (value > 70) { this.temperature = 70; }
                else temperature = value;
            }
        }
    }

    static void Main(string[] args)
    {
        Boiler boiler = new Boiler();
        boiler.Brand = Console.ReadLine();
        boiler.Voltage = byte.Parse(Console.ReadLine());
        boiler.Temperature = int.Parse(Console.ReadLine());

        Console.WriteLine($"{boiler.Brand} {boiler.Voltage} {boiler.Temperature}");

    }
}
