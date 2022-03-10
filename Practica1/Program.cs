using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Firma
    {
        public string name; //Название
        public string adress; //Адресс
        public int year; //Год основания
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
    }
 
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
