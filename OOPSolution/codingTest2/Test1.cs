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
        public byte Voltage { get; set; }
        public int Temperature { get; set; }

        public void printAll()
        {
            Console.WriteLine($"{this.Brand}  {Voltage}  {Temperature}");
        }
    }


    static void Main1(string[] args)
    {
        Boiler kitturami = new Boiler();
        kitturami.printAll();
    }
}