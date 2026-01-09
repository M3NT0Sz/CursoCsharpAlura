using ScreenSound.Modelos;
namespace ScreenSound.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica2> musicas)
    {
        var todosOsGenerosMusicais = musicas
            .Select(generos => generos.Genero!)
            .Distinct()
            .ToList();

        Console.WriteLine("Gêneros musicais disponíveis:");
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistaPorGeneroMusical(List<Musica2> musicas, string generoMusical)
    {
        var artistasPorGeneroMusical = musicas
            .Where(musica => musica.Genero!.Contains(generoMusical))
            .Select(musica => musica.Artista)
            .Distinct()
            .ToList();

        Console.WriteLine($"Artistas do gênero {generoMusical}:");
        foreach (var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica2> musicas, string nomeDoArtista)
    {
        var musicasDoArtistaFiltradas = musicas
            .Where(musica => musica.Artista!.Equals(nomeDoArtista))
            .ToList();

        Console.WriteLine($"Músicas do artista {nomeDoArtista}:");
        foreach (var musica in musicasDoArtistaFiltradas)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }

    internal static void FiltrarMusicasEmCSharp(List<Musica2> musicas)
    {
        var musicasEmCSharp = musicas
        .Where(musica => musica.Tonalidade.Equals("C#"))
        .Select(musica => musica.Nome)
        .ToList();
        Console.WriteLine("Músicas em C#:");
        foreach (var musica in musicasEmCSharp)
        {
            Console.WriteLine($"- {musica}");
        }
    }
}