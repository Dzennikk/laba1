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
            public Firma(string name, string adress, int year) {
                this.name = name; 
                this.adress = adress; 
                this.year = year; 
            }
            private string name;
            private string adress;
            private int year;

            public string Name {
                get { return name; }
                set { name = value; }
            }
            public string Adress {
                get { return adress; }
                set { adress = value; }
            }
            public int Year {
                get { return year; }
                set { year = value; }
            }
            public void Vivod() => Console.WriteLine("Название: {0}\nАдрес: {1}\nГод основание: {2}", name, adress, year);
        }
        static void Main(string[] args) {
            Firma firma = new Firma("123123", "ул123123 32 корпус 4", 128);
            firma.Vivod();
            Console.ReadKey();
        }
    }
}
