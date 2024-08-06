using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rollercoaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tinggi = 160;
            int umur = 15;

          if(umur > 14 && tinggi >= 150)
            {
                Console.WriteLine("boleh naik roller coaster");
            }
            else
            {
                Console.WriteLine("tidak boleh");
            }
        }
    }
}
