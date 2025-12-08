using System;

// Esta clase representa un círculo muy simple.
// Guarda el radio y permite calcular el área y el perímetro.
public class Circulo
{
    // Aquí guardamos el radio del círculo
    public double radio;

    // Esta función calcula el área del círculo usando la fórmula: área = pi * radio^2
    public double CalcularArea()
    {
        return Math.PI * radio * radio;
    }

    // Esta función calcula el perímetro: perímetro = 2 * pi * radio
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}
