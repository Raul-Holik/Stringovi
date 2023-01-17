using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringovi5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string brojevi;
            int x;
            double y;

            Console.WriteLine("Unesite jedan cijeli i jedan decimalni broj odvojeni s razmakom: ");
            brojevi = Console.ReadLine();
            
            string[] broj = brojevi.Split(' ');
            x = Convert.ToInt32(broj[0]);
            y = Convert.ToDouble(broj[1]);

            Console.WriteLine("Prvi broj: " + x + ", drugi broj: " + y);

            Console.ReadKey();
        }
    }
}
