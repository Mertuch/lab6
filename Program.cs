using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {

            Silnia s = new Silnia(4);

            Console.WriteLine("Stworzyłem obiekt silnia");
            Console.WriteLine(s.Oblicz());
            Console.WriteLine("PRES ENY KII TU KONTINIU\n");
            Console.ReadKey();

        }
    }
}
