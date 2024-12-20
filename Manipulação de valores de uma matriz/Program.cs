using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Ex04Pag72
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valor = new int[200];
            int i, maior = -100000, menor = 100000, somaGeral = 0, contZeros=0, contI=0, contNegativo=0, posicaoMenor=0;
            string posicoesNumGrandes = "";
            double media, percZero=0;

            Random n = new Random();

            for (i = 0; i < 200; i++)
            {
                valor[i] = n.Next(-100, 500);
                Console.Write(valor[i] + "\t");
            }

            for (i = 0; i < 200; i++)
            {
                if (valor[i] > maior)
                {
                    maior = valor[i];
                    posicaoMenor = i;
                }

                if (valor[i] < menor)
                {
                    menor = valor[i];

                }

                somaGeral += valor[i];
                
                if (valor[i] == 0)
                {
                    contZeros++;
                }

                if (valor[i] < 0)
                {
                    contNegativo++;
                }

                contI++;
            }

            for (i = 0; i < 200; i++) 
            { 
                if (valor[i] >= 100 && valor[i] <= 200)
                { 
                posicoesNumGrandes = posicoesNumGrandes + "," + i;
                }
            }
            
            media = (double)somaGeral / contI;
            percZero = (double)(contZeros * 100) / contI;

            Console.WriteLine($"\n--------------------------------------------------------------------\n");
            Console.WriteLine($"1. A soma total dos valores digitados foi: {somaGeral}.");
            Console.WriteLine($"2. O maior valor digitado foi: {maior}.");
            Console.WriteLine($"3. O menor valor digitado foi: {menor} na posição: {posicaoMenor}.");
            Console.WriteLine($"4. A média dos valores digitado foi: {media}.");
            Console.WriteLine($"5. O valor zero digitado {contZeros} vezes.");
            Console.WriteLine($"6. O percentual do valor zero sendo digitado foi: {percZero}%");
            Console.WriteLine($"7. Foram digitado valores negativos {contNegativo} vezes.");
            Console.WriteLine($"8. Os valores negativos foram digitado nas posições: {posicoesNumGrandes}");
            Console.ReadKey();
        }
    }
}
