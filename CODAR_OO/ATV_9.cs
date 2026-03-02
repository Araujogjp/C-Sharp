using System;
using System.Collections.Generic;

class Significado
{
    public string texto;
    public Palavra palavra;

    public Significado(string texto, Palavra palavra)
    {
        this.texto = texto;
        this.palavra = palavra;
    }
}

class Palavra
{
    public string nome;
    public List<Significado> significados;

    public Palavra(string nome)
    {
        this.nome = nome;
        this.significados = new List<Significado>();
    }

    public void adicionarSignificado(Significado texto)
    {
        significados.Add(texto);
        Console.WriteLine($"Significado '{texto.texto}' adicionado à palavra '{nome}'");
    }

    public List<Significado> recuperarSignificado()
    {
        return significados;
    }

    public void removerSignificado(Significado texto)
    {
        if (significados.Remove(texto))
            Console.WriteLine($"Significado '{texto.texto}' removido da palavra '{nome}'");
        else
            Console.WriteLine($"Significado não encontrado!");
    }

    public bool pesquisarSignificado(Significado texto)
    {
        return significados.Contains(texto);
    }
}

class Dicionario
{
    static void Main()
    {
        
        Palavra p1 = new Palavra("Banco");
        Palavra p2 = new Palavra("Manga");

        // Criando significados
        Significado s1 = new Significado("Instituição financeira", p1);
        Significado s2 = new Significado("Assento para sentar", p1);
        Significado s3 = new Significado("Fruta tropical", p2);
        Significado s4 = new Significado("Parte da roupa que cobre o braço", p2);

        Console.WriteLine("======== Dicionário ========\n");

        
        p1.adicionarSignificado(s1);
        p1.adicionarSignificado(s2);
        p2.adicionarSignificado(s3);
        p2.adicionarSignificado(s4);

        
        Console.WriteLine($"\nSignificados de '{p1.nome}':");
        foreach (Significado s in p1.recuperarSignificado())
            Console.WriteLine($"  - {s.texto}");

        Console.WriteLine($"\nSignificados de '{p2.nome}':");
        foreach (Significado s in p2.recuperarSignificado())
            Console.WriteLine($"  - {s.texto}");

        
        Console.WriteLine($"\nPesquisando '{s1.texto}' em '{p1.nome}': {p1.pesquisarSignificado(s1)}");
        Console.WriteLine($"Pesquisando '{s3.texto}' em '{p1.nome}': {p1.pesquisarSignificado(s3)}");

        
        Console.WriteLine();
        p1.removerSignificado(s2);

        Console.WriteLine($"\nSignificados de '{p1.nome}' após remoção:");
        foreach (Significado s in p1.recuperarSignificado())
            Console.WriteLine($"  - {s.texto}");
    }
}
