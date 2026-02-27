using System;
using System.Net.Http.Headers;
using System.Security.Principal;

class VeraoCapixasNew
{
    static void Main()
    {
        Console.WriteLine("Temperatura média do verão Capixaba\n");
        int n = 1;
        double soma = 0;
        double temp;
        double media;
        while(n <= 15)
        {
            Console.WriteLine($"Digite a temperatura do dia: {n}\n");
            temp = double.Parse(Console.ReadLine());
            if (temp >= 28)
            {
                soma += temp;
                n++;
            }
            else
            {
                Console.WriteLine("Temperatura inválida!\n");
            }
            
        }

        media = soma / (n - 1);
        Console.WriteLine($"A média de temperatura dos 15 dias foi de: {media:F2}");
    }
}
