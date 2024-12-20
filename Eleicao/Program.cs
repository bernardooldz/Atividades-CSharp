using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int voto, contCandA = 0, contCandB = 0, contCandC = 0, contCandD = 0, ganhador1, ganhador2, ganhador3 = 0;
            string candiA = "Cadidato A", candiB = "Cadidato B", candiC = "Cadidato C", candiD = "Cadidato D", canditadoVencedor = "";

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Escolha em quem deseja votar: ");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("1 - Candidato A");
            Console.WriteLine("2 - Candidato B");
            Console.WriteLine("3 - Candidato C");
            Console.WriteLine("4 - Candidato D");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Vote digitando 1, 2, 3 ou 4 ou digite 0 para encerrar");
            Console.Write("Digite seu voto: ");

        voto = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------------");
            
            while (voto != 0) 
            { 
               switch (voto)
               {
                case 1: contCandA++; break;
                case 2: contCandB++; break;
                case 3: contCandC++; break;
                case 4: contCandD++; break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Não foi informado um voto válido. ");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
               }
                Console.Write("Digite seu novo voto: ");
                voto = int.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------------------------------------");
            }

            ganhador1 = Math.Max(contCandA, contCandB);
            ganhador2 = Math.Max(contCandC, contCandD);
            ganhador3 = Math.Max(ganhador1, ganhador2);

            if (ganhador3 == contCandA)
            {
                canditadoVencedor = candiA;
            }
            else if (ganhador3 == contCandB)
            {
                canditadoVencedor = candiB;
            }
            else if (ganhador3 == contCandC)
            {
                canditadoVencedor = candiC;
            }
            else if (ganhador3 == contCandD)
            {
                canditadoVencedor = candiD;
            }
                      

            Console.Clear();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("  Quandidade final de votos: \n");
            Console.WriteLine("O Candidato A recebeu " + contCandA + " votos.");
            Console.WriteLine("O Candidato B recebeu " + contCandB + " votos.");
            Console.WriteLine("O Candidato C recebeu " + contCandC + " votos.");
            Console.WriteLine("O Candidato D recebeu " + contCandD + " votos.");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine($"O candidato com mais votos foi {canditadoVencedor}. Ele obteve {ganhador3} votos.");
            Console.WriteLine("-------------------------------------------------------");
            Console.ReadKey();
        }
    }
}

