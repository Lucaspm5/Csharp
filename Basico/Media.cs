using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, media;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            media = ((a * 3.5) + (b * 7.5)) / 11.0;
            Console.WriteLine("MEDIA = " + media.ToString("F5"));
        }
    }
   
}
