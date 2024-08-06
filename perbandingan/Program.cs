using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perbandingan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int angka1, angka2;
            Console.WriteLine("masukan angka pertama");
            angka1 = int.Parse(Console.ReadLine());
            Console.WriteLine("masukan angka ke 2");
            angka2 = int.Parse(Console.ReadLine());

            if (angka1 < angka2)
            {
                Console.WriteLine("benar");
            } else {
                Console.WriteLine("salah");
            }
        } 
    }
}
