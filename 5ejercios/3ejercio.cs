using System;

class Programa
{
    static void Main()
    {
        // Yo voy a poner los números de la lotería
        int[] numeros = new int[6];

        Console.WriteLine("Introduce 6 números de lotería:");
        for (int i = 0; i < 6; i++)
        {
            Console.Write("Número " + (i + 1) + ": ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        // Ordenar los números (burbuja simple)
        for (int i = 0; i < numeros.Length - 1; i++)
        {
            for (int j = i + 1; j < numeros.Length; j++)
            {
                if (numeros[i] > numeros[j])
                {
                    int temp = numeros[i];
                    numeros[i] = numeros[j];
                    numeros[j] = temp;
                }
            }
        }

        Console.WriteLine("Números ordenados:");
        foreach (var n in numeros)
        {
            Console.Write(n + " ");
        }
    }
}
