using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03Pag66
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contP = 0;
            string nome, sexo, continuar="";
            double peso, altura, somaAlturaH = 0, mediaAlturaH, pesopadrao=0, porcPesopadrao;

            for(continuar = "S" ;continuar == "S"; contP++)
            {
                Console.WriteLine("-----------------------------------------------");
                Console.Write("Digite seu nome: ");
                nome = Console.ReadLine();

                Console.Write("Digite seu sexo (use M ou F): ");
                sexo = Console.ReadLine().ToUpper();
                while(sexo != "F" && sexo != "M")
                {
                    Console.Write("Utilize apenas M ou F. Digite seu sexo (use M ou F): ");
                    sexo = Console.ReadLine().ToUpper();
                }

                Console.Write("Digite seu peso: ");
                peso = int.Parse(Console.ReadLine());
                if(peso >= 70 && peso <= 80)
                {
                    pesopadrao++;
                }

                Console.Write("Digite sua altura: ");
                altura = int.Parse(Console.ReadLine());
                
                if(sexo == "M")
                {
                    somaAlturaH += altura;
                }

                Console.WriteLine("Deseja continuar? (S para sim ou insira qualquer outra letra para encerrar)");
                continuar = Console.ReadLine().ToUpper();                               
            }

            mediaAlturaH = somaAlturaH / contP;
            porcPesopadrao = mediaAlturaH * 100;

            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Resultados:");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine($"a) O numéro de pessoas do grupo foi de: {contP}");
            Console.WriteLine($"b) A quantidade de pessoas que pesam entre 70Kg e 80kg é de: {mediaAlturaH}, e o percentual disse é de; {porcPesopadrao}");
            Console.WriteLine($"c) O numéro de pessoas do grupo foi de: {contP}");
            Console.ReadKey();
        }
    }
}
