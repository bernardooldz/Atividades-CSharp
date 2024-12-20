using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04Pag60
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contAtletas, idade, idadeJovem, mediaIdade, contPeso, somaIdades, numeroAtletas;
            double peso;
            string nome;

            contAtletas = 0; contPeso = 0; idadeJovem = 0; somaIdades = 0;

            Console.WriteLine("================================================================================");
            Console.WriteLine("Bem vindo! Digite as informações de alguns atletas para fazer uma análise.");
            Console.WriteLine("================================================================================\n");

            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("Quantos atletas você deseja analisar?");
            numeroAtletas = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------------------------\n");

            while (contAtletas != numeroAtletas)
            {
                Console.Write("Digite o nome do atleta: ");
                nome = Console.ReadLine();
                Console.Write("Digite a idade do atleta: ");
                idade = int.Parse(Console.ReadLine());
                if(idade >= 20 && idade <= 23)
                {
                    idadeJovem++;
                }
                
                Console.Write("Digite o seu peso: ");
                peso = double.Parse(Console.ReadLine());
                if(peso < 75)
                {
                    contPeso++;
                }
                somaIdades = somaIdades + idade;

                Console.WriteLine("\n-------------------------------------------------------------------\n");
                contAtletas++;                
            }

            mediaIdade = somaIdades / contAtletas;
            Console.Clear();
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("Resultados da análise:");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine($"Quantidade de atletas com peso abaixo de 75kg: {contPeso}");
            Console.WriteLine($"Quantidade de atletas com idade entre 20 e 23 anos: {idadeJovem}");
            Console.WriteLine($"Média de idade dos atletas: {mediaIdade}");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.ReadKey();
        }
    }
}
