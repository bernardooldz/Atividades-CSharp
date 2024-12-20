using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12Pag38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, hh, mm, ss;

            Console.Write("Digite um número: ");
            n = int.Parse(Console.ReadLine());

            hh = n / 3600;
            Console.WriteLine($"{hh} horas");
            mm = (n % 3600) / 60;
            Console.WriteLine($"{mm} minutos");
            ss = (n % 3600) % 60;
            Console.WriteLine($"{ss} segundos");

            Console.ReadKey();
        }
    }
}
