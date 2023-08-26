using System;
public class Musica
{
    public Musica(string nome, string artista, int duracao, bool disponibilidade)
    {
        this.Nome = nome;
        this.Artista = artista;
        this.Duracao = duracao;
        this.Disponibilidade = disponibilidade;
    } 

    public string Nome { get;set;}
    public string Artista { get;set;}
    public int Duracao { get;set;}
    public bool Disponibilidade { get;set;}
    public string NomeCompleto => 
    $"{Nome} - {Artista}";

    public void MostrarInfo()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao/60} minutos");
        Console.Write("Disponibilidade: ");
        if (Disponibilidade) 
        {
            Console.Write("Disponível\n");
        } 
        else 
        {
            Console.Write("Indisponível\n");
        };
    }
}
