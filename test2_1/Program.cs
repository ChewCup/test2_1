using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double dia;

            Console.Write("Ange cirkelns diameter: ");

            dia = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("En cirkel med diameter " + dia + " har: ");
            Console.WriteLine();
            Console.Write("... omkretsen: " + dia * Math.PI);
            Console.WriteLine();
            Console.Write("... arean: " + Math.PI * Math.Pow(4, 2));
         
            //stop
            Console.ReadKey();



        }
    }
}
