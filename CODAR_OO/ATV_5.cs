using System;


class Funcionario
{
    
    // Atributos 
    private int matricula;
    private string nome;
    private string cargoAtual;
    private double salarioAtual;

    // Construtor
    public Funcionario(int matricula, string nome, string cargoAtual, double salarioAtual)
    {
        this.matricula = matricula;
        this.nome = nome;
        this.cargoAtual = cargoAtual;
        this.salarioAtual = salarioAtual;
    }
    public void cadastar()
    {
        Console.WriteLine("Funcionário cadastrado!!\n");
    }

    public void consultar()
    {
        Console.WriteLine("Consultado dados do Funcionário\n");
        Console.WriteLine($"Nome: {nome} | Matrícula: {matricula} | Cargo Atual: {cargoAtual} | Salário Atual: {salarioAtual:F2}");
    }

    public void atualizarSalario(double novoSalario)
    {
        salarioAtual = novoSalario;
        Console.WriteLine("Salário Atualizado\n");
    }

    public void listarDepedentes()
    {
        Console.WriteLine("Listando dependentes\n");
    }
}



class Program
{
    static void Main()
    {
        Funcionario func = new Funcionario(2026, "JP", "Programador", 1000);

        func.cadastar();
        func.listarDepedentes();
        func.atualizarSalario(1500);
        func.consultar();
        func.listarDepedentes();
    }
}
