namespace ScreenSound.Menus;

internal class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Modelos.Banda> bandasRegistradas)
    {
        Console.Clear();
        Console.WriteLine("Obrigado por utilizar o Screen Sound! Até a próxima!");
        Thread.Sleep(3000);
        Environment.Exit(0);
    }
}