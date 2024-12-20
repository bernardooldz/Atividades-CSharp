using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15Pag62
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, maiorSalario, menorSalario, totalSalarios = 0, mediaSalrio;
            int contFuncionarios, codFuncionario, codFuncionarioMenorSal = 9999999, codFuncionarioMaiorSal = 0, numFuncAnalisar;

            Console.Write("Quantos funcionários você pretende analisar? ");
            numFuncAnalisar = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Ok, vamos começar!");
            Console.WriteLine("----------------------------------------------------------------------");


            maiorSalario = 12; menorSalario = 999999;

            for (contFuncionarios = 0; contFuncionarios != numFuncAnalisar; contFuncionarios++)
            {
                Console.Write($"Digite o código do funcionário número {contFuncionarios + 1} da análise: ");
                codFuncionario = int.Parse(Console.ReadLine());

                Console.Write("Digite o sálario deste funcionário: ");
                salario = double.Parse(Console.ReadLine());
                Console.WriteLine("----------------------------------------------------------------------");


                if (salario > maiorSalario)
                {
                    maiorSalario = salario;
                    codFuncionarioMaiorSal = codFuncionario;
                }
                if (salario < menorSalario)
                {
                    menorSalario = salario;
                    codFuncionarioMenorSal = codFuncionario;
                }

                totalSalarios = totalSalarios + salario;
            }

            mediaSalrio = totalSalarios / contFuncionarios;
            Console.Clear();
            Console.WriteLine("Resultados da análise:");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine($"1. Maior salário da empresa: {maiorSalario.ToString("C")} e ele pertece ao funcionário: {codFuncionarioMaiorSal}");
            Console.WriteLine($"2. Menor salário da empresa: {menorSalario.ToString("C")} e ele pertece ao funcionário: {codFuncionarioMenorSal}");
            Console.WriteLine($"3. O valor total da folha de pagamentos da empresa é: {totalSalarios.ToString("C")}");
            Console.WriteLine($"4. A méida salarial da empresa é: {mediaSalrio.ToString("C")}");
            Console.ReadKey();
        }
    }
}
