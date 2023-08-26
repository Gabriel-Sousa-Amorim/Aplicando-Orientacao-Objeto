using System;
class Banda 
{
    private List<Album> ListaDeAlbuns = new List<Album>();
    public string NomeBanda { get; set;}
    public void AdicionarAlbum(Album x)
    {
        ListaDeAlbuns.Add(x);
    }
    public void ExibirDiscografia()
    {
        Console.WriteLine("Discografia de {0}", this.NomeBanda);
        foreach (var i in ListaDeAlbuns)
        {
            Console.WriteLine(i.NomeAlbum);
        }
    }
}