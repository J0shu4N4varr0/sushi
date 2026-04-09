using System;

// CLASE CON MALA ARQUITECTURA (Todo es público y desprotegido)
public class Heroe 
{
    private string nombre; // Campo público: Peligroso [cite: 16, 41]
    private int puntosVida; // Campo público: Peligroso [cite: 16, 41]

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
}

class Program 
{
    static void Main() // Punto de entrada obligatorio 
    {
        Heroe miHeroe = new Heroe(); // Instanciación [cite: 10]
        
        miHeroe.Nombre = "Arturo";
        miHeroe.PuntosVida = -500; // ¡ERROR LÓGICO! La salud no debería ser negativa.

        Console.WriteLine("Héroe: "+miHeroe.Nombre+", Vida: "+miHeroe.PuntosVida);
        Console.ReadKey();
    }
}