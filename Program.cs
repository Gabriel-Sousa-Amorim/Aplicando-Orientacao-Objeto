using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Aplicando Orientação a Objeto");


        Musica SeeYouAgain = new Musica("See you Again", "Tyler the Creator", 240, true );
        Musica Wolf = new Musica("Wolf", "Tyler the Creator", 240, true);
        Album Flowerboy = new Album("Flower Boy");
        Flowerboy.AdicionarMusica(SeeYouAgain);
        Flowerboy.AdicionarMusica(Wolf);
        Flowerboy.ExibirMusica();

        SeeYouAgain.MostrarInfo();

        
        Album WolfAlbum = new Album("Wolf");
        WolfAlbum.AdicionarMusica(Wolf);
        WolfAlbum.ExibirMusica();

        Banda TylertheCreator = new Banda();
        TylertheCreator.NomeBanda = "Tyler The Creator";
        TylertheCreator.AdicionarAlbum(WolfAlbum);
        TylertheCreator.AdicionarAlbum(Flowerboy);
        TylertheCreator.ExibirDiscografia();
    }
}