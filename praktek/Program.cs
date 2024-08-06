using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nama;
            Console.WriteLine("masukan nama panggilan");
            nama = Console.ReadLine();
            if (nama == "rezy")
            {
                Console.WriteLine("nama lengkap: fahrezyshihammuttaki");
                Console.WriteLine("asal:kalimantan");

            }
            else if (nama == "hakim")
            { Console.WriteLine("nama lengkap:abdillah hakim");
                Console.WriteLine("asal:cilacap");
            

            }
            else {
                Console.WriteLine("kamu siapa");
            }
        }
    }
}
