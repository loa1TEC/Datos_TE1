using System;

abstract class Personaje
{
    // Atributos encapsulados
    private int corazones;
    private int vidaPorCorazon = 20; 
    private int vidaRestante; 

    //Constructor
    public Personaje(int corazonesIniciales, int daño)
    {
        this.corazones = corazonesIniciales;
        this.Daño = daño;
        this.vidaRestante = vidaPorCorazon; 
    }

    public int Daño { get; protected set; }

    public int Corazones
    {

    get { return corazones; }
    
    private set
        {
            if (value <= 0)
            {
                corazones = 0;
                Console.WriteLine($"{this.GetType().Name} ha perdido todos sus corazones y está fuera del juego.");
            }
            else
            {
                corazones = value;
            }
        }
    }

    // Método abstracto para polimorfismo
    public abstract void Atacar();

    // Método para recibir daño
    public void RecibirDaño(int cantidad)
    {

        while (cantidad > 0 && corazones > 0)
        {
            if (cantidad >= vidaRestante)
            {
                Console.WriteLine($"{this.GetType().Name} recibe {cantidad} de daño.");
                cantidad -= vidaRestante;
                vidaRestante = 0;
                Corazones--; 
                Console.WriteLine($"{this.GetType().Name} ha perdido un corazón. Corazones restantes: {corazones}");

                if (corazones > 0)
                {
                    vidaRestante = vidaPorCorazon; // Nuevo corazón activo
                }
            }
            else
            {
                vidaRestante -= cantidad;
                Console.WriteLine($"{this.GetType().Name} recibe {cantidad} de daño.Vida restante = {vidaRestante}");
                cantidad = 0;
            }
        }
    }

    // Método para verificar si el personaje sigue en juego
    public bool EstaEnJuego()
    {
        return corazones > 0;
    }
}

class Soldado : Personaje
{
    //Constructor
    public Soldado() : base(3, 15) { }

    public override void Atacar()
    {
        Console.WriteLine("Soldado ataca con su espada causando " + Daño + " de daño.");
    }
}

class Mago : Personaje
{
    public Mago() : base(5, 25) { }

    public override void Atacar()
    {
        Console.WriteLine("Mago lanza un hechizo causando " + Daño + " de daño.");
    }
}

class Luchador : Personaje
{
    public Luchador() : base(4, 10) { }

    public override void Atacar()
    {
        Console.WriteLine("Luchador golpea con sus puños causando " + Daño + " de daño.");
    }
}
