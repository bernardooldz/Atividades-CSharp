using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10Pag72
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] salario = new double[7] {1750, 1950, 2200, 2450, 2600, 2900, 3400 };
            int[] contClasses = new int[7];
            string nome = "";
            int classe, maisF;

            Console.WriteLine($"Bem vindo a sessão de controle de salários!\n*Ps: Para finalizar e ver as estatísticas digite 0 na parte de nome do funcionário\n");
            Console.WriteLine($"----------------------------------------------------------------------");

            while (nome != "0")
            {
                Console.Write("\nDigite o nome do funcionário: ");
                nome = Console.ReadLine();

                if(nome == "0")
                { 
                    break;
                }


                do
                {
                    Console.Write("Digite a classe do funcionário (1 a 7): ");
                    classe = int.Parse(Console.ReadLine());
                }
                while (classe < 1 || classe > 7);

                Console.WriteLine($"\nO funcionário {nome} recebe R${salario[ classe -1 ]},00\n");
                contClasses[classe -1]++;
                Console.WriteLine($"----------------------------------------------------------------------");
            }
            Console.Clear();

            maisF = contClasses[0];
            int classeMaior = 1;
            for(int i=0; i < contClasses.Length; i++)
            {
                if(maisF < contClasses[i])
                {
                    maisF = contClasses[i];
                    classeMaior = i+1;
                }
            }

            Console.WriteLine($"----------------------------------------------------------------------");
            Console.WriteLine($"Existem:\n. {contClasses[0]} funcionários da classe 1;\n. {contClasses[1]} funcionários da classe 2;\n. {contClasses[2]} funcionários da classe 3;\n. {contClasses[3]} funcionários da classe 4;\n. {contClasses[4]} funcionários da classe 5;\n. {contClasses[5]} funcionários da classe 6;\n. {contClasses[6]} funcionários da classe 7;");
            Console.WriteLine($"----------------------------------------------------------------------");
            Console.WriteLine($"A classe {classeMaior} é a classe com mais funcionários");
            Console.WriteLine($"----------------------------------------------------------------------");
            Console.ReadKey();
        }
    }
}
