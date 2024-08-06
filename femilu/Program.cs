using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace femilu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int umur;
            Console.WriteLine("silahkan masukan umur");
            umur = int.Parse (Console.ReadLine());
            if (umur > 100
                )
                
            {
                Console.WriteLine("SUDAH BOLEH MENCOBLOS");
            } else
            {
                Console.WriteLine("jangan ya dek ya");
            }
        }
    }
}
