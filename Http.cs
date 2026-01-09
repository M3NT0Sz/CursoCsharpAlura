using System.Text.Json;
using ScreenSound.Filtros;
using ScreenSound.Modelos;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica2>>(resposta)!;

        LinqFilter.FiltrarMusicasEmCSharp(musicas);

        // musicas[0].ExibirDetalhesDaMusica();
        // LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        // LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        // LinqFilter.FiltrarArtistaPorGeneroMusical(musicas, "Rock");
        // LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Post Malone");

        // var MusicasPreferidasDoMatheus = new MusicasPreferidas("Matheus");
        // MusicasPreferidasDoMatheus.AdicionarMusicasFavoritas(musicas[1]);
        // MusicasPreferidasDoMatheus.AdicionarMusicasFavoritas(musicas[15]);
        // MusicasPreferidasDoMatheus.AdicionarMusicasFavoritas(musicas[1000]);
        // MusicasPreferidasDoMatheus.AdicionarMusicasFavoritas(musicas[1955]);
        // MusicasPreferidasDoMatheus.AdicionarMusicasFavoritas(musicas[400]);

        // MusicasPreferidasDoMatheus.ExibirMusicasFavoritas();
        // MusicasPreferidasDoMatheus.GerarArquivoJson();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ocorreu um erro ao buscar as músicas: {ex.Message}");
    }
}
