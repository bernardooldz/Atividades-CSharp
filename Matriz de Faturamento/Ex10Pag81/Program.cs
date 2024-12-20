using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ex10Pag81
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, total, ano = 2005;
            string texto="";
            string[] anos = { "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014" };
            int[,] mat = new int[10,12];
            Random obj = new Random();

            for (i = 0; i < mat.GetLength(0); i++)
            {
                for (j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = obj.Next(1000, 5000);
                    texto += mat[i, j] + "\t";
                }
                texto += "\n";
            }


            for (i = 0; i < mat.GetLength(0); i++)
            {
                Console.Write(anos[i] + ":\t");
                total = 0;

                for (j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i, j] + "\t");
                    total += mat[i, j];
                }
                Console.WriteLine($"\nFaturmento do ano de {ano+i} foi: R${total},00\n");
            }

            Console.ReadKey();

        }
    }
}
