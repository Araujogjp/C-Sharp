using System;
using System.Security.Principal;

class Ibge
{
    static void Main()
    {
        int[] faixa = new int[5];
        int total = 0;
        int idade;

        Console.WriteLine("Gestão de pessoas Ibge");
        Console.WriteLine("Digite um número igual ou menor que 0 para encerrar o programa\n");

        while (true)
        {
            Console.WriteLine("Digite a idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade <= 0)
            {
                break;
            }

            total++;

            if (idade <= 15)
            {
                faixa[0]++;
            }
            else if (idade <= 30)
            {
                faixa[1]++;
            }
            else if (idade <= 45)
            {
                faixa[2]++;
            }
            else if (idade <= 60)
            {
                faixa[3]++;
            }
            else
            {
                faixa[4]++;
            }

            if (total == 0)
            {
                Console.WriteLine("Nenhuma idade foi informada");
                return;
            }

            string [] nomes = {"A (01 - 15 anos)", "B (16 - 30 anos)", "C (31 - 45 anos)", "D (46 - 60 anos)", "E (>= 61 anos)"};

            Console.WriteLine("\nResultado");
            Console.WriteLine($"Total de Pessoas: {total}\n");
            
            for(int i = 0; i < 5; i++)
            {
                double porcentagem = (double)faixa[i]/ total * 100;
                Console.WriteLine($"Faixa {nomes[i]}: {faixa[i]} pessoa(s) -> {porcentagem:F2}%");
            }

        }
    }
}
