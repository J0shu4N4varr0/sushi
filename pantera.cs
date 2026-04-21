using System;
using System.Collections.Generic;

// CLASE CON MALA ARQUITECTURA (Todo es público y desprotegido)
public abstract class Heroe 
{
    private string nombre; // Campo público: Peligroso [cite: 16, 41]
    private int puntosVida; // Campo público: Peligroso [cite: 16, 41]

    public Heroe(string nombre, int puntosVida)
    {
        this.nombre = nombre;
        this.puntosVida = puntosVida;
    }

    public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

    public int PuntosVida 
        {
            get { return puntosVida; }
            set { puntosVida = value >= 0 ? value : 0; }
        }

    public abstract void Atacar();
   
}

public class Guerrero: Heroe 
{
    private int fuerza;
    
    public int Fuerza
        {
            get { return fuerza; }
            set 
            {
                if(value > 0)
                {
                    fuerza = value;
                }
                else {fuerza = 0;}
            }
        }
     public override void Atacar()
    {
        Console.WriteLine("El guerrero ataca con su espada usando " + fuerza + " de poder");
    }

    public Guerrero(string nombre, int puntosVida, int fuerza): base(nombre, puntosVida)
    {
        Fuerza = fuerza;
    }
}

public class Mago : Heroe
{
    public override void Atacar()
    {
        Console.WriteLine("El mago lanza un hechizo de ataque.");
    }

     public Mago(string nombre, int puntosVida): base(nombre, puntosVida)
    {
        
    }
}
class Program 
{
    static void Main() // Punto de entrada obligatorio 
    {
       List<Heroe> party = new List<Heroe>();

       party.Add(new Guerrero("Conan", 100, 20));
       party.Add(new Mago("Gandalf", 80));  
        Console.WriteLine("comienza la batalla!");
        foreach(var heroe in party)
        {
            heroe.Atacar();
        }
        Console.ReadKey();
    }
}