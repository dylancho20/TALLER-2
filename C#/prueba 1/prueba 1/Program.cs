using System;

public abstract class Figura
{
    public abstract double CalcularArea();
    public abstract double CalcularDiametro();
}

public class Cuadrado : Figura
{
    public double Lado { get; set; }

    public override double CalcularArea()
    {
        return Lado * Lado;
    }

    public override double CalcularDiametro()
    {
        return Math.Sqrt(2) * Lado;
    }
}

public class Triangulo : Figura
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public override double CalcularArea()
    {
        return (Base * Altura) / 2;
    }

    public override double CalcularDiametro()
    {
   
        return 0;
    }
}

public class Circulo : Figura
{
    public double Radio { get; set; }

    public override double CalcularArea()
    {
        return Math.PI * Radio * Radio;
    }

    public override double CalcularDiametro()
    {
        return 2 * Radio;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Figura figura = null;
        string tipoFigura;

        Console.WriteLine("Ingrese el tipo de figura (cuadrado, triangulo o circulo):");
        tipoFigura = Console.ReadLine().ToLower();

        switch (tipoFigura)
        {
            case "cuadrado":
                figura = new Cuadrado();
                Console.WriteLine("Ingrese el valor del lado:");
                ((Cuadrado)figura).Lado = double.Parse(Console.ReadLine());
                break;
            case "triangulo":
                figura = new Triangulo();
                Console.WriteLine("Ingrese el valor de la base:");
                ((Triangulo)figura).Base = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el valor de la altura:");
                ((Triangulo)figura).Altura = double.Parse(Console.ReadLine());
                break;
            case "circulo":
                figura = new Circulo();
                Console.WriteLine("Ingrese el valor del radio:");
                ((Circulo)figura).Radio = double.Parse(Console.ReadLine());
                break;
            default:
                Console.WriteLine("Tipo de figura no válido.");
                return;
        }

        Console.WriteLine("Área calculada: " + figura.CalcularArea());
        Console.WriteLine("Diámetro calculado: " + figura.CalcularDiametro());
    }
}
