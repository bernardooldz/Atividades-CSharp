using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medalhas_Olimpiadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] paises = { "BRA", "JAP", "CHN", "EUA", "POR", "ARG", "ISR", "CHL", "EGI", "URU" };
            string paisCampeao = "";
            int[,] medalhas = new int[10, 3];
            int i, j, total, maiorTotal = 0;

            Console.WriteLine("Quadro de Medalhas Olímpicas\n");

            Console.WriteLine("País   Ouro    Prata  Bronze   Total");
            Random m = new Random();

            for (i = 0; i < medalhas.GetLength(0); i++)
            {
                for (j = 0; j < medalhas.GetLength(1); j++)
                {
                    medalhas[i, j] = m.Next(41);
                }
            }

            for (i = 0; i < medalhas.GetLength(0); i++)
            {
                Console.Write(paises[i] + ":\t");
                total = 0;

                for (j = 0; j < medalhas.GetLength(1); j++)
                {
                    Console.Write(medalhas[i, j] + "\t");
                    total += medalhas[i, j];
                    if(total > maiorTotal)
                    {
                        maiorTotal = total;
                        paisCampeao = paises[i];
                    }
                }
                Console.Write($"{total}\n");
            }

            

            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine($"O país campeão foi: {paisCampeao}. Ele obteve um tota de {maiorTotal} medalhas.");            
            Console.ReadKey();
        }
    }
}
