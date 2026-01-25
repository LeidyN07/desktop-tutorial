using System;
using System.Collections.Generic;

class TorresDeHanoi
{
    private Stack<int> torreA = new Stack<int>();
    private Stack<int> torreB = new Stack<int>();
    private Stack<int> torreC = new Stack<int>();
    private int numDiscos;

    public TorresDeHanoi(int discos)
    {
        numDiscos = discos;
        for (int i = discos; i >= 1; i--)
        {
            torreA.Push(i);
        }
    }

    public void Resolver()
    {
        MoverDiscos(numDiscos, torreA, torreC, torreB, "A", "C", "B");
    }

    private void MoverDiscos(int n, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar,
                             string nombreOrigen, string nombreDestino, string nombreAuxiliar)
    {
        if (n == 1)
        {
            destino.Push(origen.Pop());
            Console.WriteLine($"Mover disco de {nombreOrigen} a {nombreDestino}");
            MostrarTorres();
        }
        else
        {
            MoverDiscos(n - 1, origen, auxiliar, destino, nombreOrigen, nombreAuxiliar, nombreDestino);
            destino.Push(origen.Pop());
            Console.WriteLine($"Mover disco de {nombreOrigen} a {nombreDestino}");
            MostrarTorres();
            MoverDiscos(n - 1, auxiliar, destino, origen, nombreAuxiliar, nombreDestino, nombreOrigen);
        }
    }

    private void MostrarTorres()
    {
        Console.WriteLine($"Torre A: [{string.Join(",", torreA)}]");
        Console.WriteLine($"Torre B: [{string.Join(",", torreB)}]");
        Console.WriteLine($"Torre C: [{string.Join(",", torreC)}]");
        Console.WriteLine("-----------------------------");
    }

    static void Main()
    {
        Console.WriteLine("Ingrese el número de discos para las Torres de Hanoi:");
        int discos = int.Parse(Console.ReadLine());

        TorresDeHanoi hanoi = new TorresDeHanoi(discos);
        Console.WriteLine("Resolviendo Torres de Hanoi...");
        hanoi.Resolver();
    }
}