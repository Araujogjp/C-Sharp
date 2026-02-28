using System;

class Gestao
{
    static void Main()
    {
        // Variáveis
        double preco = 0;
        double total = 0;
        double totalLimp = 0;
        double totalAli = 0;
        double totalHig = 0;
        string mer;
        int n = 0;
        
        // Lógica de repetição
        while(n < 5)
        {
            Console.WriteLine("---------------Gestão de Recursos-----------------");
            Console.WriteLine("Digite (l) ou (L) para produtos de ramo da limpeza\n");
            Console.WriteLine("Digite (a) ou (A) para produtos de ramo da alimetação\n");
            Console.WriteLine("Digite (h) ou (H) para produtos de ramo da higiene\n");
            Console.WriteLine("Digite a letra do ramo do produto: ");
            mer = Console.ReadLine();

            if(mer == "l" || mer == "L" || mer == "a" || mer == "A" || mer == "h" || mer == "H")
            {
                Console.WriteLine("Digite o valor da mercadoria: ");
                preco = double.Parse(Console.ReadLine());
                if(preco > 0)
                {
                     if( mer == "l" || mer == "L")
                    {
                        totalLimp += preco;
                    }
                    else if( mer == "a" || mer == "A")
                    {
                        totalAli += preco;
                    }
                    else
                    {
                        totalHig += preco;
                    }
                    n++;
                }
                else
                {
                    Console.WriteLine("O preço deve ser maior que 0");
                }
            }
            else
            {
                Console.WriteLine("Essa ramo não está cadastrado");
            }
        }
        total = totalAli + totalHig + totalLimp;
        Console.WriteLine($"Valor Total dos produtos de limpeza: {totalLimp:F2}");
        Console.WriteLine($"Valor Total dos produtos de Alimentação: {totalAli:F2}");
        Console.WriteLine($"Valor Total dos produtos de Higiene: {totalHig:F2}");
        Console.WriteLine($"Valor Total da cesta: {total:F2}");
    }
}
