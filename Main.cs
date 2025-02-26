class Program
{
    static void Main()
    {
        // Crear personajes
        Personaje soldado = new Soldado();
        Personaje mago = new Mago();
        Personaje luchador = new Luchador();
        Console.WriteLine();
        Console.WriteLine("-------Mago-------");
        // Simulación de combate
        mago.RecibirDaño(15);
        mago.RecibirDaño(10);
        mago.RecibirDaño(40);
        mago.RecibirDaño(60);
        Console.WriteLine();
        Console.WriteLine("-------Soldado-------");
        soldado.RecibirDaño(5);
        soldado.RecibirDaño(30);
        soldado.RecibirDaño(20);
        Console.WriteLine();
        Console.WriteLine("-------Luchador-------");
        luchador.RecibirDaño(2); 
        luchador.RecibirDaño(10);

        Console.WriteLine();
        Console.WriteLine($"¿El mago sigue en juego? {mago.EstaEnJuego()}");
        Console.WriteLine($"¿El soldado sigue en juego? {soldado.EstaEnJuego()}");
        Console.WriteLine($"¿El luchador sigue en juego? {luchador.EstaEnJuego()}");
    }
}
