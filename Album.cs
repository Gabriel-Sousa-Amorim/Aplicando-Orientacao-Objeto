using System;
class Album
{
    public Album(string nomeAlbum) 
    {
        this.NomeAlbum = nomeAlbum;
    }
    public List<Musica> musicas = new List<Musica>();
    public string NomeAlbum {get; set;}
    public int DuracaoTotal => musicas.Sum(i => DuracaoTotal + i.Duracao);
    public void AdicionarMusica(Musica x)
    {
        musicas.Add(x);
    }
    public void ExibirMusica()
    {
        Console.WriteLine("\n--");
        Console.WriteLine("Nome do Album: {0}", this.NomeAlbum);
        foreach (var i in musicas)
        {
            Console.Write(i.NomeCompleto, '-' );
            Console.WriteLine("- {0} minutos", i.Duracao/60);
        }
        Console.WriteLine(this.DuracaoTotal);
        Console.WriteLine("---\n");
    }
}