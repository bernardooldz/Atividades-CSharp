using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12Pag61
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char simnao;

            do
            {
                int contTemp = 0, contDiasTempPadra = 0, PorcentAbaix, contDiasAbaixo = 0, contDias;
                double tempHoje, tempMedia = 0, MaiorTemp = 0, tempSomaMedia = 0;

                Console.Write("Quantos dias você pretende analisar? ");
                contDias = int.Parse(Console.ReadLine()); 
                Console.Clear();
                Console.WriteLine("Ok. Vamos lá!");

                do
                {                    
                    Console.WriteLine("--------------------------------------------------------------------------------");
                    do
                    {
                        Console.Write($"Digite a temperatura do dia {contTemp + 1}: ");
                        tempHoje = double.Parse(Console.ReadLine());
                    }
                    while (tempHoje < 0);

                    if (tempHoje > MaiorTemp)
                    {
                        MaiorTemp = tempHoje;
                    }
                    if (tempHoje >= 20 && tempHoje <= 23)
                    {
                        contDiasTempPadra++;
                    }
                    if (tempHoje < 20)
                    {
                        contDiasAbaixo++;
                    }

                    tempSomaMedia += tempHoje;
                    contTemp++;
                }
                while (contTemp != contDias);

                PorcentAbaix = (contDiasAbaixo * 100) / contTemp;
                tempMedia = tempSomaMedia / contTemp;

                Console.Clear();
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.WriteLine("Resultados da análise:");
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.WriteLine($"1. A temperatura esteve entre 20 e 23 graus em: {contDiasTempPadra} dia(s).");
                Console.WriteLine($"2. A temperatura média deste período foi de: {tempMedia.ToString("0.0")} graus");
                Console.WriteLine($"3. A porcentagem de dias em que a temperatura esteve abaixo de 20 graus foi de: {PorcentAbaix}%");
                Console.WriteLine($"4. A maior temperatura registrada neste período foi de: {MaiorTemp} graus");
                Console.ReadKey();

                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.WriteLine("Deseja executar novamente? <S/N>" );

                simnao = char.Parse(Console.ReadLine().ToUpper());
                Console.Clear();
            }
            while (simnao == 'S');

            

        }
    }
}
