using System;


class Produto
{
    // Atriibutos
    private string nome;
    private double preco;
    private int estoque;

    // Construtor
    public Produto(string nome, double preco, int estoque)
    {
        this.nome = nome;
        this.preco = preco;
        this.estoque = estoque;
    }

    // Getters e Setters 
    
    public string getNome()
    {
        return this.nome;
    }

    public void setNome(string newName)
    {
        this.nome = newName;
    }

    public double getPreco()
    {
        return this.preco;
    }

    public void setPreco(double newPrice)
    {
        this.preco = newPrice;
    }
    public int getEstoque()
    {
        return this.estoque;
    }

    public void setEstoque(int newEstoque)
    {
        this.estoque = newEstoque;
    }


    public double valorTotal()
    {
        return estoque * preco;
    }

    public void exibirDados()
    {
        Console.WriteLine($"Produto: {nome}");
        Console.WriteLine($"Preço: {preco:f2}");
        Console.WriteLine($"Qtd(Em estoque): {estoque} unidades");
        Console.WriteLine($"Valor total do estoque do produto R${valorTotal()}\n");
    }
}



class Loja
{   
    static void Main()
    {
        // Instanciando
        Produto p1 = new Produto("Macbook", 6000, 5);
        Produto p2 = new Produto("Dell G15", 6000, 9);
        Produto p3 = new Produto("Alienware", 13000, 4);

       p1.exibirDados();
       p1.valorTotal();

       p2.exibirDados();
       p2.valorTotal();

       p3.exibirDados();
       p3.valorTotal();

       double valorTotalEst = p1.valorTotal() + p2.valorTotal() + p3.valorTotal();
       Console.WriteLine($"Valor total do estoque: R${valorTotalEst:f2}");
    }
}
