using System;
using System.Collections.Generic;


// Classe Abstrata
public abstract class Professor
{   
    // Atributos 
    protected String nome;
    protected int matricula;

    protected int cargaHoraria;
    
    protected double beneficio;

    public Professor(string nome, int matricula, int cargaHoraria)
    {
        this.nome = nome;
        this.matricula = matricula;
        this.cargaHoraria = cargaHoraria;
    }
    // Calculo de benefício
    public abstract void calcularBeneficio();

    public double getBeneficio()
    {
        return beneficio;
    }

    public string getNome()
    {
        return this.nome;
    }
}


// Classe filha
public class ProfDe : Professor
{
    public ProfDe(string nome, int matricula, int cargaHoraria) : base(nome, matricula, cargaHoraria) {}
   

    public override void calcularBeneficio()
    {
        this.beneficio = this.cargaHoraria * 100;
    }

   
}

public class ProfHorista : Professor
{
    private double ValorHora;
    public ProfHorista(string nome, int matricula, int cargaHoraria, double ValorHora) : base(nome, matricula, cargaHoraria)
    {
        this.ValorHora = ValorHora;
    }

    public override void calcularBeneficio()
    {
        this.beneficio = this.cargaHoraria * this.ValorHora;
    }
}



class Program
{
    static void Main()
    {
        ProfDe p1 = new ProfDe("Vinicius", 200, 12);
        ProfHorista p2 = new ProfHorista("Rosallen", 101, 12, 70);

        p1.calcularBeneficio();
        p2.calcularBeneficio();

        Console.WriteLine($"O valor do beneficio do professor {p1.getNome()} é {p1.getBeneficio()}");
        Console.WriteLine($"O valor do beneficio do professor {p2.getNome()} é {p2.getBeneficio()}");
    }

}
