using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labal1
{
    internal class Program
    {
        class Firma
        {
            public Firma(string name, string street, int year) {
                this.name = name; 
                this.street = street; 
                this.year = year; 
            }
            private string name;
            private string street;
            private int year;

            public string Name {
                get { return name; }
                set { name = value; }
            }
            public string Street {
                get { return street; }
                set { street = value; }
            }
            public int Year {
                get { return year; }
                set { year = value; }
            }
            public void Vivod() => Console.WriteLine("Название: {0}\nАдрес: {1}\nГод основание: {2}", name, street, year);
        }
        static void Main(string[] args) {
            Firma firma = new Firma("123123", "ул123123 32 корпус 4", 128);
            firma.Vivod();
            Console.ReadKey();
        }
    }
}
