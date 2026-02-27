using System;
using System.Security.Principal;

class VeraoCapixas
{
    static void Main()
    {
        // Variáveis
        double resultado;
        double temp;
        int escolha;

        // Lógica de repetição
        while (true)
        {
            Console.WriteLine("Software de Conversão de Temperaturas\n");
            Console.WriteLine("[0] Para encerrar o programa\n");
            Console.WriteLine("[1] para Celsius -> Fahrenheit\n");
            Console.WriteLine("[2] para Fahrenheit -> Celsius\n");
            Console.WriteLine("[3] para Celsius -> Kelvin\n");
            Console.WriteLine("[4] para Celsius -> Fahrenheit\n");
            escolha = int.Parse(Console.ReadLine());

            // Verificação de escolhas 
            if (escolha == 0)
            {
                Console.WriteLine("Programa encerrado");
                break;
            }   

            Console.WriteLine("Digite a temperatura: ");
            temp = double.Parse(Console.ReadLine());

            if(escolha == 1)
            {
                resultado = temp * 1.8 + 32;
                Console.WriteLine($"A temperatura é de: {resultado:F2} Fº");
            }
            else if(escolha == 2)
            {
                resultado = (temp - 32) / 1.8;
                Console.WriteLine($"A temperatura é de: {resultado:F2} Cº");
            }
            else if(escolha == 3)
            {
                resultado = temp + 273.15;
                Console.WriteLine($"A temperatura é de: {resultado:F2} Kº");
            }
            else
            {
                resultado = temp - 273.15;
                Console.WriteLine($"A temperatura é de: {resultado:F2} Cº");
            }
            
        }
    }
}
