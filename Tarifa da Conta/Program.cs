using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExResolvidoPag40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, classe;
            int numConta;
            double saldoSemestre, saldoMedio, tarifa;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite o número da sua conta: ");
            numConta = int.Parse(Console.ReadLine());
            Console.Write("Digite o seu saldo total no semestre: ");
            saldoSemestre = int.Parse(Console.ReadLine());
                        
            saldoMedio = saldoSemestre / 6;

            if (saldoMedio <= 1000)
            {
                tarifa = 25;
                classe = "Basica";
            }
            else if (saldoMedio >= 1000.01 && saldoMedio <= 2000)
            {
                tarifa = 20;
                classe = "Prata";
            } 
            else if(saldoMedio >= 2000.01 && saldoMedio <= 3500)
            {
                tarifa = 13;
                classe = "Ouro";
            }
            else
            {
                tarifa = 0;
                classe = "Prêmio";
            }

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Tarifa para sua conta: " + tarifa);
            Console.WriteLine("Classe conta: " + classe);
            Console.ReadKey();
        }     
    }
}
