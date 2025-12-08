using System;

// Esta clase representa un cuadrado simple.
// Guarda el dato del lado y calcula área y perímetro.
public class Cuadrado
{
    // Aquí guardamos cuánto mide un lado del cuadrado
    public double lado;

    // Esta función calcula el área del cuadrado: área = lado * lado
    public double CalcularArea()
    {
        return lado * lado;
    }

    // Esta función calcula el perímetro del cuadrado: perímetro = 4 * lado
    public double CalcularPerimetro()
    {
        return 4 * lado;
    }
}
