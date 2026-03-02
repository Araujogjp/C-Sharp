using System;
using System.Collections.Generic;


class Moeda
{
    // Atributos
    private double valor;
    private string nome; 

    // Construtor
    public Moeda(double valor, string nome)
    {
        this.valor = valor;
        this.nome = nome;
    }

    // Getters
    public double getValor()
    {
        return this.valor;
    }

    public string getNome()
    {
        return this.nome;
    }
}

class Cofrinho
{
    // Atributos
    private List<Moeda> moedas;

    public Cofrinho()
    {
        moedas = new List<Moeda>();
    }

    public void adicionar(Moeda m)
    {
        moedas.Add(m);
        Console.WriteLine($"Moeda adicionada: {m.getNome()} | R${m.getValor()}");
    }

    public double calcularTotal()
    {
        double total = 0;
        foreach(Moeda m in moedas)
        {
            total += m.getValor();
        }
        return total;
    }

   public int qtdMoedas()
    {
        return moedas.Count;
    } 

    public int qtdMoedasIguais(double valor)
    {
        int n = 0;
        foreach(Moeda m in moedas)
        {
            if(m.getValor() == valor)
            {
                n++;
            }
        }
        return n;
    }

    public Moeda maiorMoeda()
    {
        Moeda maior = moedas[0];
        foreach(Moeda m in moedas)
        {
            if(m.getValor() > maior.getValor())
            {
                maior = m;
            }
        }
        return maior;
    }
}

class Teste
{   
    static void Main()
    {
       Cofrinho cofri = new Cofrinho();

       Moeda m1 = new Moeda(0.05, "5 centavos");
       Moeda m2 = new Moeda(0.10, "10 centavos");
       Moeda m3 = new Moeda(0.25, "25 centavos");
       Moeda m4 = new Moeda(0.50, "50 centavos");
       Moeda m5 = new Moeda(1.00, "1 real");
       Moeda m6 = new Moeda(2.00, "2 reais");

       
       cofri.adicionar(m1);
       cofri.adicionar(m2);
       cofri.adicionar(m3);
       cofri.adicionar(m4);
       cofri.adicionar(m5);
       cofri.adicionar(m6);
       
       Console.WriteLine($"Valor total do cofrinho: {cofri.calcularTotal():f2}");
       Console.WriteLine($"Qtd total de moedas no cofrinho: {cofri.qtdMoedas()}");
       Console.WriteLine($"Qtd de moedas iguais: {cofri.qtdMoedasIguais(0.50)}");
       Console.WriteLine($"Moeda de maior valor: {cofri.maiorMoeda().getValor()}");
    }
}
