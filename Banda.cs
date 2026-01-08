class Banda
{
    public Banda(string nome)
    {
        Nome = nome;
    }

    private List<Album> albums = new List<Album>();
    public string Nome { get; }

    public void adicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void exibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}:\n");
        foreach (var album in albums)
        {
            Console.WriteLine($"Álbum: {album.Nome} - Duração Total: {album.DuracaoTotal} segundos");
        }
    }
}